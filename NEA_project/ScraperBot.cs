using HtmlAgilityPack;
using System.Collections.Generic;

namespace NEA_project
{
    class ScraperBot
    {
        private static List<string> getTriggers(List<Row> titles) // extract trigger words from article titles
        {   
            string userID = user.getUserID();
            List<string> triggers = SQLOperations.sqlSelect("select triggers.triggerWord from triggers inner join financial on triggers.financialID = financial.financialID inner join selections on financial.financialID = selections.financialID where selections.userID = \"" + userID + "\"");
            List<string> names = SQLOperations.sqlSelect("select name from Selections where userID = \"" + userID + "\""); // would make this one query but i need names and triggers separately
            List<string> detectedTriggers = new List<string>();

            for (int x = 0; x <= titles.Count; x++)
            {
                for (int y = 0; y <= triggers.Count; y++)
                {
                    System.Windows.Forms.MessageBox.Show(x.ToString() + " " + y.ToString());
                    string title = titles[x].ToString();
                    string trigger = triggers[y].ToString();
                    if (title.Contains(trigger)) // if the title contains a trigger word
                    {
                        detectedTriggers[y] = triggers[y].ToString();
                    }
                }
            }

            List<string> predicts = new List<string>();

            for (int i = 0; i <= names.Count; i++)
            {
                if (detectedTriggers[i] != null)
                {
                    predicts.Add(Predictions.getPredicts(names[i].ToString(), detectedTriggers[i].ToString())); // generate predictions for each item and trigger
                }
            }
            return predicts;
        }

        public static (List<string>, List<string>) runScraper()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://uk.finance.yahoo.com"); // data source
            var headerNames = doc.DocumentNode.SelectNodes("//h2[@class='Mt(0) Td(u):h Mb(13px) Fz(24px)!--miw1100 Fz(18px) LineClamp(4,5.3em) Lh(1.15)']"); // HTML class that holds article titles

            var titles = new List<Row>();
            List<string> uiTitles = new List<string>();
            foreach (var item in headerNames)
            {
                titles.Add(new Row { title = item.InnerText });
                uiTitles.Add(item.InnerText);
            }

            List<string> predicts = getTriggers(titles);
            return (predicts, uiTitles);
        }

        public class Row
        {
            public string title { get; set; }
        }
    }
}