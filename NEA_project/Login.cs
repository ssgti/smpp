using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
                string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();

                    string sql = "select userID from Users where username = " + username + " and password = " + password;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        MessageBox.Show(rdr[0] + " -- " + rdr[1]);
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }



            /*
            if(username == "test" && password == "1234")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user details entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
