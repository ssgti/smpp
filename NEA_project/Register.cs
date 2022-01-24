using System;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            // boring validation stuff for account creation

            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string rePassword = rePasswordBox.Text;

            if (username == "" || password == "" || rePassword == "") // was data entered?
            {
                MessageBox.Show("Please fill in user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (username.Length > 20) // is username short enough?
            {
                MessageBox.Show("Username must be 20 characters or under", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            int specialCharCounter = 0;
            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    specialCharCounter++;
                }
            }
            if (specialCharCounter < 2 || password.Length < 8) // is password under 8 characters and does it include special chars?
            {
                MessageBox.Show("Password must be at least 8 characters and include at least 2 special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (password != rePassword) // do passwords match?
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // connect to database
            SQLOperations.sqlInsert("insert into Users(username, password) values(" + username + ", " + password + ")");

        }
    }
}
