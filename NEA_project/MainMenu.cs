using System;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            // displayPredictions();
            initList();
        }

        private void initList()
        {
            predictBox.BeginUpdate();
            for (int i = 0; i < 50; i++)
            {
                predictBox.Items.Add("Item " + (i + 1));
            }
            predictBox.EndUpdate();
        }

        private void displayPredictions()
        {
            // List<string> selections = SQLOperations.sqlSelect("select name from Selections where userID = ");
            predictBox.BeginUpdate();
            /*
            for (int i = 0; i < selections.Count; i++)
            {
                predictBox.Items.Add(Predictions.getPredicts(selections[i]));
            }
            */
            ScraperBot.runScraper();
            predictBox.EndUpdate();
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
