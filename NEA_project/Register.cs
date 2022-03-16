using System;
using System.Linq;
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

        private bool accountExists(string username) // check if details already exist in db
        {
            List<string> usrList = SQLOperations.sqlSelect("select username from Users where username = \"" + username + "\"");
            bool isEmpty = !usrList.Any();
            if (isEmpty)
            {
                return false; // account with this username does not already exist, all good
            }
            else
            {
                MessageBox.Show("Username " + username + " is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // account exists
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            // get data from UI
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string rePassword = rePasswordBox.Text;

            // run validation checks
            bool hasData = dataEntered(username, password, rePassword);
            bool usernameValid = validateUsername(username);
            bool passwordValid = validatePassword(password);
            bool passMatch = passwordMatch(password, rePassword);
            bool exists = accountExists(username);

            // get new userID
            int ID = SQLOperations.autoIncrementID("userID", "users"); // get an automatically incremented ID

            // create account if conditions are met
            if(hasData && usernameValid && passwordValid && passMatch && !exists)
            {
                SQLOperations.sqlExecute("insert into Users values(" + ID + ", \"" + username + "\", \"" + password + "\")");
                MessageBox.Show("Account created successfully\nYou may now log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
