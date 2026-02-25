using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using DTRMSimpleAdaptor;
using System.Diagnostics;

namespace DTRMAdaptorFileCopier {
    public partial class frmProcess : Form {

        private DirectorySetter setter;
        
        public frmProcess() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            

        }

        private bool FindDTRMDirectory() {
            bool blnSuccess = false;
            string AppDirectory = "";

            //try 32 bit location
            if (Directory.Exists(@"C:\Program Files\DTRM")) {
                AppDirectory = @"C:\Program Files\DTRM";                
                blnSuccess = true;
            } else {
                //try 64 bit location
                if (Directory.Exists(@"C:\Program Files (x86)\DTRM")) {
                    AppDirectory = @"C:\Program Files (x86)\DTRM";
                    blnSuccess = true;
                } else {
                    FolderBrowserDialog dlg = new FolderBrowserDialog();
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                        AppDirectory = dlg.SelectedPath;
                        blnSuccess = true;
                    } 
                }
            }

            if (blnSuccess) {
                setter = new DirectorySetter(AppDirectory);
                return XmlSerialize("AdaptorSettings.xml", setter, typeof(DirectorySetter));
            } else
                return false;            
        }

        private void CopyFiles() {
            if (FindDTRMDirectory()) {
                var ext = new string[] { ".XML", ".DLL",".PNG" };
                FileInfo[] finfoList = (from fi in new DirectoryInfo(setter.AppDirectory).GetFiles()
                                        where ext.Contains(fi.Extension.ToUpper())
                                        select fi)
                         .ToArray();

                int increment = 100 / finfoList.Length;
                pBar.Value = 0;
                for (int i = 0; i < finfoList.Length; i++) {
                    finfoList[i].CopyTo(finfoList[i].Name, true);
                    pBar.Value = increment * i;
                    Application.DoEvents();
                }

                Process myProcess = new Process();

                try {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "DTRMSimpleAdaptor.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself.  
                    // Given that is is started without a window so you cannot terminate it  
                    // on the desktop, it must terminate itself or you can do it programmatically 
                    // from this application using the Kill method.

                    Application.Exit();
                } catch  {
                }
            } else
                Application.Exit();
        }

        private void btnCopyFiles_Click(object sender, EventArgs e) {
            CopyFiles();
        }

        public  bool XmlSerialize(string filename, object obj, Type typ) {
            try {
                System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
                TextWriter writer = null;
                writer = new StreamWriter(filename);
                xser.Serialize(writer, obj);
                writer.Close();
                return true;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static object XmlDeSerialize(string filename, Type typ) {
            try {
                System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
                FileStream fs = null;
                fs = new FileStream(filename, FileMode.Open);
                System.Xml.XmlReader reader = new System.Xml.XmlTextReader(fs);

                object obj = xser.Deserialize(reader);
                fs.Close();
                return obj;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
