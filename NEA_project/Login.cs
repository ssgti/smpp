﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (username == "debug" && password == "") // for the super secret debug menu
            {
                DebugMenu debug = new DebugMenu();
                debug.Show();
            }
            else
            {
                // database connection

                List<string> ID = SQLOperations.sqlSelect("select userID from Users where username = \"" + username + "\" and password = \"" + password + "\"");
                string userID = ID[0].ToString();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                mainMenu.displayPredictions(userID);
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
