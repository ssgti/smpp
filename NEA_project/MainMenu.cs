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
        }

        public void displayPredictions() // run the web scraper
        {
            predictBox.BeginUpdate();
            ScraperBot.runScraper(user.getUserID());
            predictBox.EndUpdate();
        }

        public void initNewsFeed(List<string> titles) // fill the news feed with articles used by web scraper
        {
            // this is not called anywhere yet
            articleBox.BeginUpdate();
            for (int i = 0; i < titles.Count; i++)
            {
                articleBox.Items.Add(titles[i]);
            }
            articleBox.EndUpdate();
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
