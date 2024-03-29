﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NEA_project
{
    static class SQLOperations 
    {
        private const string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321"; // only change this here

           // keeping all SQL code in one place to save me having to retype it all every time it's needed
          //  these functions are called from other parts of the program passing the queries as parameters
         //   the select function returns data in a list
        //    errors are displayed in message boxes

        public static List<string> sqlSelect(string query) // perform select operation on database
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
                    items.Add(rdr.GetString(0)); // read data and add each item to a string
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            return items; // returns the string to where it was called from
        }

        public static void sqlExecute(string query) // perform insert operation on database
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

        public static int autoIncrementID(string row, string table) // auto increment user IDs because MySQL workbench is being annoying and won't let me
        {
            List<string> ids = SQLOperations.sqlSelect("select " + row + " from " + table); // row and table passed as args
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

    }
}