﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<string> selections = SQLOperations.sqlSelect("select name from Selections where userID = ");
            predictBox.BeginUpdate();
            for (int i = 0; i < selections.Count; i++)
            {
                predictBox.Items.Add(Predictions.getPredicts(selections[i]));
            }
            predictBox.EndUpdate();
        }

        private void settBtn_Click(object sender, EventArgs e)
        {
            SettingsMenu settings = new SettingsMenu();
            settings.Show();
        }

        private void persBtn_Click(object sender, EventArgs e)
        {
            PersonaliseMenu personalise = new PersonaliseMenu();
            personalise.Show();
        }
    }
}
