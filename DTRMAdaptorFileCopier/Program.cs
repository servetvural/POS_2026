using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DTRMAdaptorFileCopier {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            //if (args.Length > 0) {
            //    if (args[0].ToString().ToUpper() == "DELETEFILES") {
            //        var ext = new string[] { ".XML", ".DLL" };
            //        FileInfo[] finfoList = (from fi in new DirectoryInfo(".").GetFiles()
            //                                where ext.Contains(fi.Extension.ToUpper())
            //                                select fi)
            //                 .ToArray();

            //        for (int i = 0; i < finfoList.Length; i++) {
            //            if (finfoList[i].Name != "AdaptorSettings.xml")
            //                File.Delete(finfoList[i].Name);
            //        }
            //        Application.Exit();
            //    }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0 && args[0].ToUpper() == "DELETEFILES")
                Application.Run(new frmDeleteFiles());
            else 
                Application.Run(new frmProcess());
        }
    }
}
