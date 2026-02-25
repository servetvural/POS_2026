using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;
using System.IO;
using DronaxLibrary;
using DronaxLibrary.DBSpace;

namespace DTRMNS {
    public partial class frmMain : Form{
        private DTRMSimpleBusiness bslayer;
        private int dbVersion;

        private string localdburl = "\"https://www.microsoft.com/en-us/download/details.aspx?id=42299\"";
        private string sqlexpressurl = "\"https://www.microsoft.com/en-us/download/details.aspx?id=42299\"";
        private string dotneturl = "\"https://www.microsoft.com/en-us/download/details.aspx?id=53344\"";
        private string dronaxurl = "http://www.dronax.com";

        private string str = "";

        private bool blnNeedToPrint;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            try {
                bslayer = new DTRMSimpleBusiness();
            } catch {
                //MessageBox.Show("Business Layer DLL is missing or corrupt!");
            }
            //LoadAll();
            wb.Navigate("about:blank");
        }

        private void LoadAll() {
            LoadComputerDetails();
        }

        public string GetApplicationPath() {
            FileInfo finfo = new FileInfo(Application.ExecutablePath);
            return finfo.Directory.ToString() + "\\";
        }
        private string GetRegistryValue(string path, string SubKeyName) {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + path);
            if (key == null)
                return "";
            else 
                return key.GetValue(SubKeyName).ToString();
        }

        

        private void LoadComputerDetails() {

            str = "";
            str += "Machine Name<br/><hr/>" + Environment.MachineName + "<br/><br/>";
            str += "Operating System<br/><hr/>" + Environment.OSVersion.Platform.ToString() + ", " +
                    GetRegistryValue(@"Microsoft\Windows NT\CurrentVersion", "ProductName") + "<br/><br/>";
            str += "IP Address<br/><hr/> " + DRUF.GetIPAddresses(AddressFamily.InterNetwork) + "<br/><br/>";

            if (bslayer == null) {
                str += GetText(bslayer ==null, "Business Layer DLL is missing or corrupt!","");
                str += "<br/>";
                mnuConnectDatabase.Enabled = false;
            } else {
                str += "ApplicationVersion <br/><hr/>" + bslayer.ApplicationVersion + "<br/><br/>";
                str += "RequiredLocalDbVersion <br/><hr/>" + bslayer.RequiredLocalDbVersion + "<br/><br/>";
                str += "RequiredSqlExpressVersion <br/><hr/>" + bslayer.RequiredSqlExpressVersion + "<br/><br/>";
                str += "RequiredMdfFileVersion <br/><hr/>" + bslayer.RequiredMdfFileVersion + "<br/><br/>";
                str += "RequiredDotNetVersion <br/><hr/>" + bslayer.RequiredDotNetVersion + "<br/><br/>";
                str += "DatabaseFilesRootName <br/><hr/>" + bslayer.DatabaseFilesRootName + "<br/><br/>";
                mnuConnectDatabase.Enabled = true;
            }


            //Check Directories and required files

            str += "Application Directory<br/><hr/>" + GetApplicationPath() + "<br/><br/>";
            //List of files in application folder
            str += "Sessions Directory<br/><hr/>" + GetText(Directory.Exists(GetApplicationPath() + "Sessions")) + "  /  ";
            if (Directory.Exists(GetApplicationPath() + "Sessions"))
                str += Directory.GetFiles("Sessions").Length + " Files.<br/><br/>";
            else
                str += "<br/><br/>";

            str += "Reports Directory<br/><hr/>" + GetText(Directory.Exists(GetApplicationPath() + "Reports")) + "  /  ";
            if (Directory.Exists(GetApplicationPath() + "Reports"))
                str += Directory.GetFiles("Reports").Length + " Files.<br/><br/>";
            else
                str += "<br/><br/>";

            str += "Database Directory <br/><hr/>" + GetText(Directory.Exists(GetApplicationPath() + "Db")) + "  /  ";
            //List of files in Database Directory
            if (Directory.Exists(GetApplicationPath() + "Db")) {
                string[] dbfiles = Directory.GetFiles("Db");
                str += dbfiles.Length + " Files.<br/>";
                for (int i = 0; i < dbfiles.Length; i++)
                    str += dbfiles[i] + "<br/>";
            } 
            str += "<br/><br/>";

            str += "Scripts Directory <br/><hr/>" + GetText(Directory.Exists(GetApplicationPath() + "Scripts")) + "  /  <br/>";
            //List of files in Scripts Directory
            if (Directory.Exists(GetApplicationPath() + "Scripts")) {
                string[] scripts = Directory.GetFiles("Scripts");
                str += scripts.Length + " Files.<br/>";
                for (int i = 0; i < scripts.Length; i++)
                    str += scripts[i] + "<br/>";
            }
            str += "<br/><br/>";


            float dotnetversion = 0f;
            str += "Installed .NET Framework<br/><hr/> " + DRUF.GetInstalledDotNetVersion(ref dotnetversion,true) + "<br/>";
            str += "<a href=" + dotneturl + "  target=\"_blank\">Microsoft</a><br/><br/>";
            

            DTRMConfig configLocal = null;
            if (UF.IsConfigFileExist()) {
                configLocal = UF.GetConfig();
                mnuDisplayConfiguration.Enabled = true;
            }
            else {
                mnuConnectDatabase.Enabled = false;
                mnuDisplayConfiguration.Enabled = false;
            }
            
            
            str += "Configuration File<br/><hr/>" + GetText(configLocal != null) + "<br/><br/>";

            str += "Config Application Type<br/><hr/>";
            if (configLocal == null)
                str += GetFalseText("No Configuration File");
            
            str += "<br/><br/>";

            string latestlocaldb = "";
            string localdbversion = DRUF.GetInstalledLocalDbVersion(ref latestlocaldb);
            str += "Installed LocalDB Version <br/><hr/>" + GetText(localdbversion != "",localdbversion, "No LocalDB Installed") + "<br/>";
            str += "<a href=" + localdburl + " target=\"_blank\">Microsoft</a><br/><br/>";

            List<SqlExpressDesc> serverList = DRUF.GetEasyInstalledSqlExpressList();
            str += "Installed SQL Express Version<br/><hr/>";
            for (int i = 0; i < serverList.Count; i++) {
                str += serverList[i].ToString() + "<br/>";
            }
            if (serverList.Count == 0)
                str += GetFalseText("No SQL Express Installed") + "<br/>";

            //string currentsqlversion = "";
            //string sqlversion = UF.GetInstalledSqlExpressVersion(ref currentsqlversion);
            //str += "Installed SQL Express Version<br/><hr/>" + GetText(sqlversion!= "",sqlversion,"No SQL Express Installed") + "<br/>";

            str += "<a href=" + sqlexpressurl + "  target=\"_blank\">Microsoft</a><br/><br/>";
            wb.DocumentText = str;
        }


        private string GetFalseText(string str) {
            return "<span style= \"color:red\">" + str + "</span>";
        }

        private string GetText(bool val) {
            if (val)
                return val.ToString();
            else
                return "<span style= \"color:red\">" + val.ToString() + "</span>";
        }
        private string GetText(bool val, string truetext, string falsetext) {
            if (val)
                return truetext;
            else
                return "<span style= \"color:red\">" + falsetext + "</span>";
        }


        private void mnuLoadDetails_Click(object sender, EventArgs e) {
            LoadComputerDetails();
        }

        private void mnuConnectDatabase_Click(object sender, EventArgs e) {
            
            try {
                bslayer = new DTRMSimpleBusiness(UF.GetConfig());
                dbVersion = bslayer.GetDbVersion();
                MessageBox.Show("Connected to db and File Version = " + dbVersion.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to connect : " + ex.Message);
            }
        }

        private void mnuDisplayConfiguration_Click(object sender, EventArgs e) {
            frmConfig frm = new frmConfig(null);
            frm.ShowDialog();
        }

        private void mnuDronaxWebsite_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(dronaxurl);
        }

        private void mnuDownloadDotNet_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(dotneturl);
        }

        private void mnuDownloadLocalDB_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(localdburl);
        }

        private void mnuDownloadSQLExpress_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(sqlexpressurl);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            frmLocalPrinterSelector frm = new frmLocalPrinterSelector();
            if (frm.ShowDialog() == DialogResult.OK) {
                PrintHandler printer = new PrintHandler(bslayer,wb.Document.Body.OuterText, frm.SelectedPrinterNetworkName); 
                printer.PrintNow();
            }
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (blnNeedToPrint) {
                blnNeedToPrint = false;
                btnPrint_Click(null, null);
            }
        }

        private void printDirect_Click(object sender, EventArgs e) {
            blnNeedToPrint = true;
            LoadComputerDetails();
        }
    }
}
