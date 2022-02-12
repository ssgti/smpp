using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA_project
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    public static class user // initialising the user as an object
    {
        public static string userID;

        public static void setUserID(string id)
        {
            userID = id;
        }

        public static string getUserID()
        {
            return userID;
        }
    }
}
