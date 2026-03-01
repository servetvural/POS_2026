using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTRMNS;
using System.Threading;

namespace DTRMSimpleBackOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            //args = new string[] { "User" };
            //args = new string[] { "Accountant" };
            //args = new string[] { "MenuEditor" };
            args = new string[] { "Owner" };

            Application.Run(new frmOffice(args));
        }
    }
}
