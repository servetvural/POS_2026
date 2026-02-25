using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTRMNS;
using System.Threading;

namespace DTRMSimpleBackOffice {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                DTRMConfig config = UF.GetConfig();


                switch (config.Terminal_UserInterface_Culture) {
                    case LanguageTypes.English:
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                        break;
                    case LanguageTypes.Türkçe:
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
                        
                        break;
                    default:
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                        break;
                }
  
            } catch {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            Application.Run(new frmOffice());
           // Application.Run(new Form1());
        }
    }
}
