using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            displayPredictions();
        }

        public void displayPredictions() // run the web scraper
        {
            var data = ScraperBot.runScraper();
            List<string> predicts = data.Item1;
            List<string> titles = data.Item2;
            predictBox.BeginUpdate();
            for (int i = 0; i < predicts.Count; i++)
            {
                predictBox.Items.Add(predicts[i].ToString());
            }
            predictBox.EndUpdate();
            initNewsFeed(titles);
        }

        private void initNewsFeed(List<string> titles) // fill the news feed with articles used by web scraper
        {
            for (int i = 0; i < titles.Count; i++)
            {
                articleBox.AppendText(titles[i] + " \n\n"); // each article separated by an empty line
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutMenu about = new AboutMenu();
            about.Show();
        }

        private void persBtn_Click(object sender, EventArgs e)
        {
            PersonaliseMenu personalise = new PersonaliseMenu();
            personalise.Show();
        }
    }
}
