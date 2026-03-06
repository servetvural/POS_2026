using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTRMNS;
using System.Threading;

namespace DTRMSimpleBackOffice
{
    static class Program
    {
        public static int Profile { get; set; } = 123456789;
        public static string UserType { get; set; } = "User";
        public static string RemoteBackUpDirectory { get; set; }  = ".\\Backup";

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
            // args = new string[] { "Owner" };


            if (args.Length >= 1 )
                UserType = args[0].Trim();
            else
                UserType = "User";

            Random random = new Random();
            Profile = random.Next(1234,int.MaxValue);

            if (args.Length >= 2)
            {
                try
                {
                    Profile = int.Parse(args[1].Trim());
                } catch (Exception ex)
                {
                    Profile = random.Next(1234, int.MaxValue);
                    MessageBox.Show("Invalid profile number.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                         
                }
            }

            if (args.Length >= 3)
            {
                try
                {
                    //string theFolder = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    //RemoteBackUpDirectory = args[2] + "\\" + theFolder ;

                    RemoteBackUpDirectory = args[2];
                } catch (Exception ex)
                {
                    RemoteBackUpDirectory = ".\\Backup";
                    MessageBox.Show("Invalid Backup Location\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   else
            {
                RemoteBackUpDirectory = ".\\Backup";
            }

            Application.Run(new frmOffice());
        }
    }
}
