using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DTRMAdaptorFileCleaner {
    public partial class frmDeleteFiles : Form {
        public frmDeleteFiles() {
            InitializeComponent();
        }

        private void frmDeleteFiles_Load(object sender, EventArgs e) {
            DeleteFiles();
        }

        private void DeleteFiles() {
            
            var ext = new string[] { ".XML", ".DLL" };
            FileInfo[] finfoList = (from fi in new DirectoryInfo(".").GetFiles()
                                    where ext.Contains(fi.Extension.ToUpper())
                                    select fi)
                     .ToArray();

            for (int i = 0; i < finfoList.Length; i++) {
                if (finfoList[i].Name != "AdaptorSettings.xml")
                    File.Delete(finfoList[i].Name);
            }
            Application.Exit();

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
