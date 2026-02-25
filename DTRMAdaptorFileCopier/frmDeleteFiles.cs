using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DTRMAdaptorFileCopier {
    public partial class frmDeleteFiles : Form {
        public frmDeleteFiles() {
            InitializeComponent();
        }

        private void frmDeleteFiles_Load(object sender, EventArgs e) {

        }


        private void DeleteFiles() {
            var ext = new string[] { ".XML", ".DLL",".PNG" };
            FileInfo[] finfoList = (from fi in new DirectoryInfo(".").GetFiles()
                                    where ext.Contains(fi.Extension.ToUpper())
                                    select fi)
                     .ToArray();

            for (int i = 0; i < finfoList.Length; i++) {
                if (finfoList[i].Name != "AdaptorSettings.xml") {
                    lblStatus.Text = "Deleting " + finfoList[i].Name;
                    File.Delete(finfoList[i].Name);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(50);
                }
            }
            Application.Exit();

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnCleaning_Click(object sender, EventArgs e) {
            DeleteFiles();
        }
    }
}
