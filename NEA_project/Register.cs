using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            string query = "insert into Users(username, password) values(" + username + ", " + password + ")";
            SQLOperations.sqlInsert(query);

            /*
            string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                
                string sql = "insert into Users(username, password) values(" + username + ", " + password + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insert into Users(username, password) values(?username, ?password)";
                comm.Parameters.Add("?username", MySqlDbType.VarChar).Value = username;
                comm.Parameters.Add("?password", MySqlDbType.VarChar).Value = password;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            */
        }
    }
}
