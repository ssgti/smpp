﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private bool dataEntered(string username, string password, string rePassword) // was data entered?
        {
            if (username == "" || password == "" || rePassword == "")
            {
                MessageBox.Show("Please fill in user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateUsername(string username) // is username short enough?
        {
            if (username.Length > 20)
            {
                MessageBox.Show("Username must be 20 characters or under", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validatePassword(string password) // is password under 8 characters and does it include special chars?
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            int specialCharCounter = 0;
            
            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    specialCharCounter++;
                }
            }

            if (specialCharCounter < 2 || password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters and include at least 2 special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool passwordMatch(string password, string rePassword) // do passwords match?
        {
            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private int autoIncrementID() // auto increment user IDs because MySQL workbench is being annoying and won't let me
        {
            List<string> ids = SQLOperations.sqlSelect("select userID from users");
            int newID = 1;
            try
            {
                for (int i = 0; i <= ids.Count; i++)
                {
                    if (ids[i] == "") // in case of a deleted entry
                    {
                        newID = i;
                    }
                }
            }
            catch
            {
                newID = ids.Count + 1;
            }

            return newID;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string rePassword = rePasswordBox.Text;

            bool hasData = dataEntered(username, password, rePassword);
            bool usernameValid = validateUsername(username);
            bool passwordValid = validatePassword(password);
            bool passMatch = passwordMatch(password, rePassword);

            int ID = autoIncrementID();

            if((hasData == true) && (usernameValid == true) && (passwordValid == true) && (passMatch == true))
            {
                // connect to database
                SQLOperations.sqlExecute("insert into Users values(" + ID + ", \"" + username + "\", \"" + password + "\")");
            }
        }
    }
}
