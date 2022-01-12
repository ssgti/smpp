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
    static class SQLOperations
    {
        private const string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321";

        public static List<string> sqlSelect(string query)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<string> items = new List<string>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    items.Add(rdr.ToString());
                }
                rdr.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            return items;
        }

        public static void sqlInsert(string query)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

    }
}