using HtmlAgilityPack;
using System.Collections.Generic;

namespace NEA_project
{
    class ScraperBot
    {
        private static void getTriggers(List<Row> titles) // extract trigger words from article titles
        {
            string userID = user.getUserID();
            List<string> triggers = SQLOperations.sqlSelect("select triggerWord from Triggers");  // make multi-dimensional, include selections
            List<string> names = SQLOperations.sqlSelect("select name from Selections where userID = \"" + userID + "\"");
            List<string> detectedTriggers = new List<string>();
            triggers.ToArray();
            names.ToArray();
            detectedTriggers.ToArray();

            for (int x = 0; x < titles.Count; x++)
            {
                for (int y = 0; y < triggers.Count; y++)
                {
                    if (titles[x].ToString().Contains(triggers[y].ToString())) // if the title contains a trigger word
                    {
                        detectedTriggers[y] = triggers[y];
                    }
                }
            }

            for (int i = 1; i < names.Count; i++)
            {
                if (detectedTriggers[i] != "")
                {
                    Predictions.getPredicts(names[i].ToString());
                }
            }
        }

        public static List<string> runScraper()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://uk.finance.yahoo.com"); // data source
            var headerNames = doc.DocumentNode.SelectNodes("//h3[@class='Mb(5px)']"); // HTML class that holds article titles

            var titles = new List<Row>();
            List<string> uiTitles = new List<string>();
            foreach (var item in headerNames)
            {
                titles.Add(new Row { title = item.InnerText });
                uiTitles.Add(item.InnerText);
            }

            getTriggers(titles);
            return uiTitles; // for articleBox
        }

        public class Row
        {
            public string title { get; set; }
        }
    }
}