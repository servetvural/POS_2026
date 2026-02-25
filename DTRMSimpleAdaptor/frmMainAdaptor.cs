using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using PosLibrary;
using DTRMNS;
using PosLibrary.Forms;
using System.IO;
using System.Diagnostics;

namespace DTRMSimpleAdaptor {
    public partial class FrmMainAdaptor : Form {
        private DTRMSimpleBusiness bslayer;
        private DirectorySetter setter;
        private bool blnAbort;

        public FrmMainAdaptor() {
            InitializeComponent();

            if (File.Exists("AdaptorSettings.xml")) {

                setter = (DirectorySetter)XmlDeSerialize("AdaptorSettings.xml", typeof(DirectorySetter));
                if (setter != null) {

                    if (CreateBusinessLayer()) {
                        
                    } else {
                        blnAbort = true;
                        Application.Exit();
                    }
                } else
                    Application.Exit();
            } else
                Application.Exit();
        }



        #region UTILITY
        public bool XmlSerialize(string filename, object obj, Type typ) {
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

        #endregion

        private void FrmMainAdaptor_Load(object sender, EventArgs e) {
            EnsureDirectoryStructure();

            DisplayArchivedSessions();
            LoadDatabaseSessions();
           
        }

        private void EnsureDirectoryStructure() {
            //Create Session Directory Locally
            if (!Directory.Exists("SessionsBackup"))
                Directory.CreateDirectory("SessionsBackup");

            //if (!Directory.Exists("MenuBackup"))
            //    Directory.CreateDirectory("MenuBackup");

            //if (!Directory.Exists("DatabaseBackup"))
            //    Directory.CreateDirectory("DatabaseBackup");

            //if (!Directory.Exists("ReportsBackup"))
            //    Directory.CreateDirectory("ReportsBackup");

            //if (!Directory.Exists("CustomReports"))
            //    Directory.CreateDirectory("CustomReports");

        }

        private void EnsureSessionBackup(BackgroundWorker bgWorker) {
            string[] sessionFilesFullName =  Directory.GetFiles(setter.SessionDirectory);
            int counter = 0;
            for (int i = 0; i < sessionFilesFullName.Length; i++) {
                FileInfo finfo = new FileInfo(sessionFilesFullName[i]);
                //if (File.Exists(Path.Combine("SessionsBackup\\",finfo.Name)))
                //    File.Delete(Path.Combine("SessionsBackup\\",finfo.Name));

                if (bgWorker != null) {
                    if (counter==100)
                        counter = 0;
                    counter++;
                    bgWorker.ReportProgress(counter);
                }

                File.Copy(finfo.FullName, Path.Combine("SessionsBackup" , finfo.Name),true);
            }
        }
        private void EnsureMenuBackup() {
            DataTable dtMenus = bslayer.GetMenuList();
            for (int i = 0; i < dtMenus.Rows.Count; i++) {


                FMenu menu = bslayer.GetMenuDB(dtMenus.Rows[i]["IID"].ToString());
                XmlSerialize(Path.Combine("MenuBackup\\", menu.MenuName + "_" + DateTime.Now.ToString("dd MMM yyyy HH mm") + ".xml"),menu, typeof(FMenu));
            }
        }
        private void EnsureDatabaseBackup() {
            DatabaseBackup backup = new DatabaseBackup();
            DatabaseBackupOptions options = new DatabaseBackupOptions();
            options.blnCustomers = options.blnImages = options.blnPrinters = options.blnStock =
                options.blnTables = options.blnUsers = true;

            if (bslayer.GetDatabaseBackup(ref backup, options)) {
                DRFile.XmlSerialize(Path.Combine("DatabaseBackup\\", "Database Backup on " +
                    DateTime.Now.ToString("dd MMM yyyy HH mm") + ".xml"), backup, typeof(DatabaseBackup), true);
            }
        }
        //private void EnsureDatabaseTableBackup() {
        //    //TABLE_CATALOG, TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE
        //    //DTRMSimple, dbo, Orders, BASE TABLE
        //    DataTable dt = bslayer.db.GetDataTable("SELECT * FROM information_schema.TABLES where TABLE_TYPE = 'BASE TABLE'");

        //    for (int i = 0; i < dt.Rows.Count; i++) {
        //        string tablename = dt.Rows[i]["TABLE_NAME"].ToString();
        //        //xml_guid........ [Column0]
        //        DataTable dtxml = bslayer.db.GetDataTable("select * from " + tablename + " FOR XML AUTO");
        //        if (dtxml.Rows.Count > 0) {
        //            string xmlText = dtxml.Rows[0][0].ToString();
        //            string filename = Path.Combine("DatabaseTableBackup", tablename + ".xml");
        //            if (File.Exists(filename))
        //                File.Delete(filename);
        //            StreamWriter stream = File.CreateText(filename);
        //            stream.Write(xmlText);
        //            stream.Flush();
        //            stream.Close();
        //        }
        //    }

        //}
        private void EnsureReportsBackup() {
            if (Directory.Exists(setter.ReportDirectory)) {
                string[] reportFilesFullName = Directory.GetFiles(setter.ReportDirectory);

                for (int i = 0; i < reportFilesFullName.Length; i++) {
                    //get fileinfo for report file in app report directory
                    FileInfo finfo = new FileInfo(reportFilesFullName[i]);

                    if (!File.Exists(Path.Combine("ReportsBackup\\", finfo.Name)))
                        // File.Delete(Path.Combine("ReportsBackup\\", finfo.Name));
                        File.Copy(finfo.FullName, Path.Combine("ReportsBackup" , finfo.Name));

                }
            }
        }
        

        

        

        private bool CreateBusinessLayer() {
            frmInput frm = new frmInput();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                try {
                    bslayer = new DTRMSimpleBusiness(UF.GetConfig());
                    bslayer.LoggedUser = bslayer.GetUserByPassword(frm.ReturnValue);
                    if (bslayer.LoggedUser == null)
                        return false;
                    return true;
                } catch {
                    return false;

                }
            }
            return false;

        }

        private float CalculateArchivedSelectedRows() {
            float total = 0;
            for (int i = 0; i < dgvArchive.SelectedRows.Count; i++) {
                total += float.Parse(dgvArchive.SelectedRows[i].Cells["colArcTotal"].Value.ToString());
            }
            return total;
        }

        private float CalculateLoadedSelectedRows() {
            float total = 0;

            for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                total += float.Parse(dgvDatabase.SelectedRows[i].Cells["colDBTotal"].Value.ToString());
            }
            return total;
        }

        private void DisplayArchivedSessions() {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(DisplayArchivedSessions), null);
            else {
                
                dgvArchive.DataSource = bslayer.GetArchivedSessionDataTable(setter.SessionDirectory);
                dgvArchive.Sort(dgvArchive.Columns["colArcStartDate"], ListSortDirection.Descending);
                float total = 0;
                for (int i = 0; i < dgvArchive.Rows.Count; i++) {
                    total += float.Parse(dgvArchive.Rows[i].Cells["colArcTotal"].Value.ToString());
                }
                lblArcTotal.Text = total.ToString("c2");
            }
        }

        private void LoadDatabaseSessions() {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadDatabaseSessions), null);
            else {
                dgvDatabase.DataSource = bslayer.GetDataTable("Select * from Sessions where IID <> '" + bslayer.GetCurrentSessionIID() + "' order by StartDate desc");
                float total = 0;
                for (int i = 0; i < dgvDatabase.Rows.Count; i++) {
                    total += float.Parse(dgvDatabase.Rows[i].Cells["colDBTotal"].Value.ToString());
                    bslayer.SaveSessionData(dgvDatabase.Rows[i].Cells[0].Value.ToString());                 
                }
                lblDBTotal.Text = total.ToString("c2");
            }
        }

        private void BtnLoadSelectedIntoDatabase_Click(object sender, EventArgs e) {

            if (dgvArchive.SelectedRows.Count > 0) {
                List<SessionDataShort> theList = new List<SessionDataShort>();
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");
                for (int i = 0; i < dgvArchive.SelectedRows.Count; i++) {
                    SessionDataShort session = new SessionDataShort {
                        IID = dgvArchive.SelectedRows[i].Cells["colArcIID"].Value.ToString(),
                        StartDate = Convert.ToDateTime(dgvArchive.SelectedRows[i].Cells["colArcStartDate"].Value.ToString(), culture),
                        EndDate = Convert.ToDateTime(dgvArchive.SelectedRows[i].Cells["colArcEndDate"].Value.ToString(), culture)
                    };
                    theList.Add(session);
                }


                //To call this function you must implement Delegate_BackGroundWork function
                //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                //args parameter must have an object array which will match with the second parameter
                //of this function call.
                frmProgress frm = new frmProgress(
                    new Delegate_BackGroundWork(LoadSessionsInToDatabaseAsync),
                    theList.ToArray(), true, ProgressDetailTypes.FullDetails, false) {
                    Text = "Loading Sessions into Database",
                    Message = "Loading, Please DO NOT Cancel."
                };
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;

            }

        }

        private void LoadSessionsInToDatabaseAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            SessionDataShort[] sessionList = (SessionDataShort[])args;
            for (int i = 0; i < sessionList.Length; i++) {
                bslayer.ReloadSessionFromCustomDirectory(setter.SessionDirectory,sessionList[i].StartDate, sessionList[i].EndDate);

                int percent = (100 / sessionList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Loading " + sessionList[i].StartDate.ToString() + " To " + sessionList[i].EndDate.ToString());
            }
            LoadDatabaseSessions();
            DisplayArchivedSessions();
        }

        private void BtnProcessSessions_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                frmInput frm = new frmInput("Process Amount 0-100",false);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    int percentToDelete = 0;
                    try {
                        percentToDelete = int.Parse(frm.ReturnValue);
                    } catch {
                        return;
                    }

                    List<string> sessionIIDList = new List<string>();
                    for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                        sessionIIDList.Add(dgvDatabase.SelectedRows[i].Cells[0].Value.ToString());
                    }

                    if (sessionIIDList.Count > 0) {
                        trmPrinterSelector fsp = new trmPrinterSelector(bslayer, PrinterTypes.Receipt);
                        if (fsp.ShowDialog() == DialogResult.OK) {
                            ProcessAllSessions(percentToDelete, sessionIIDList, chkPrintWhenProcessed.Checked, fsp.SelectedPrinter.IID);
                            LoadDatabaseSessions();
                            DisplayArchivedSessions();
                        }
                    }
                }
            }
        }

        private void BtnArchiveSessions_Click(object sender, EventArgs e) {
            string[] SessionIIDList = new string[dgvDatabase.SelectedRows.Count];
            for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                SessionIIDList[i] = dgvDatabase.SelectedRows[i].Cells["colDBIID"].Value.ToString();
            }
            string SessionDir = "";
            if (Directory.Exists(setter.SessionDirectory))
                SessionDir = setter.SessionDirectory;
            else {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    SessionDir = dlg.SelectedPath;
                else
                    return;
            }

            

            object[] args = new object[] { SessionDir, SessionIIDList };


            //To call this function you must implement Delegate_BackGroundWork function
            //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
            //args parameter must have an object array which will match with the second parameter
            //of this function call.
            frmProgress frm = new frmProgress(
                new Delegate_BackGroundWork(ArchiveSessionsInToDatabaseAsync),
                args, true, ProgressDetailTypes.FullDetails, false) {
                Text = "Archiving Sessions into Directory",
                Message = "Archiving, Please DO NOT Cancel."
            };
            frm.ShowDialog();

            //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
            object result = frm.AsyncResult;
        }

        private void ArchiveSessionsInToDatabaseAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            object[] arguments = (object[])args;
            string directoryPath = (string)arguments[0];
            string[] SessionIIDList = (string[])arguments[1];

            for (int i = 0; i < SessionIIDList.Length; i++) {
                SessionData sesData = bslayer.GetSessionDataDynamic(SessionIIDList[i]);
                bslayer.ArchiveSessionToDirectory(directoryPath, SessionIIDList[i], true);
                int percent = (100 / SessionIIDList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Archiving " + sesData.SessionStartDateTime.ToString() + " to " + sesData.SessionEndDateTime.ToString());
            }
            LoadDatabaseSessions();
            DisplayArchivedSessions();
            //MessageBox.Show("Archive Completed");
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            LoadDatabaseSessions();
            DisplayArchivedSessions();
        }



        public bool ProcessAllSessions(int delPercent, List<string> sessionIIDList, bool blnPrint, string printerIID) {
            for (int i = 0; i < sessionIIDList.Count; i++) {
                ProcessSingleSession(delPercent, sessionIIDList[i], blnPrint, printerIID);
            }
            return true;
        }

        public bool ProcessSingleSession(int delPercent, string SessionIID, bool blnPrint, string printerIID) {
            //Get number of which item to delete
            DataTable dt = bslayer.db.GetDataTable("select floor(sum(quantity/100*" + delPercent + ")) as requiredamount,   OrderItemText from orderitem where ParentOrderIID in (select IID from orders where sessioniid = '" +
                SessionIID + "' and Payment < 2) group by  OrderItemText");

            string deletesql = "";
            for (int i = 0; i < dt.Rows.Count; i++) {
                int requiredamount = int.Parse(dt.Rows[i]["requiredamount"].ToString());
                if (requiredamount == 0)
                    continue;
                string OrderItemText = dt.Rows[i]["OrderItemText"].ToString();

                //delete required amount from order item
                deletesql += "delete from OrderItem where IID in (Select top " + requiredamount + " IID from OrderItemView where OrderItemText = '" + OrderItemText + "' and SessionIID = '" + SessionIID + "' order by NewID());";

            }
            bslayer.db.RunQuery(deletesql);
            //delete orders which has total of 0
            bslayer.db.RunQuery("delete from Orders where IID in (Select IID from OrdersView where CalculatedValue = 0 and sessionIID = '" + SessionIID + "' and Payment = 1) ");
            SessionData session = bslayer.GetSessionDataDynamic(SessionIID);
            bslayer.SaveSessionData(session);
            if (blnPrint) {
                bslayer.PrintReport(setter.SessionDirectory, ReportFormatTypes.ZReport, SessionIID, printerIID, true);
            }
            return true;
        }

        private void BtnArcExportToCsv_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvArchive);
            if (exporter.Generate(true, true)) {
                string filename = "ArchiveList_on_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                if (exporter.Export(Path.Combine("CustomReports" , filename)))
                    MessageBox.Show("File saved CustomReports directory on memory stick as " + filename);
                else
                    MessageBox.Show("Failed to save report");
            }
        }

        private void BtnDBExportToCsv_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDatabase);
            if (exporter.Generate(true, true)) {
                string filename = "DatabaseList_on_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                if (exporter.Export(Path.Combine("CustomReports", filename)))
                    MessageBox.Show("File saved CustomReports directory on memory stick as " + filename);
                else
                    MessageBox.Show("Failed to save report");
            }

        }

        private void BtnPrint_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                trmPrinterSelector fsp = new trmPrinterSelector(bslayer, PrinterTypes.Receipt);
                if (fsp.ShowDialog() == DialogResult.OK) {
                    for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++)
                        bslayer.PrintReport(setter.SessionDirectory, ReportFormatTypes.ZReport, dgvDatabase.SelectedRows[i].Cells[0].Value.ToString(), fsp.SelectedPrinter.IID, true);
                    LoadDatabaseSessions();
                    DisplayArchivedSessions();
                }

            }
        }

        private void BtnViewOrders_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                frmOrderView frm = new frmOrderView(bslayer, dgvDatabase.SelectedRows[0].Cells[0].Value.ToString());
                frm.ShowDialog();
                BtnRefresh_Click(null, null);
            }
        }

        private void BtnArcEmailAsCsv_Click(object sender, EventArgs e) {
            Luv luv = bslayer.GetLuv();
            if (luv.NotificationEmail == "") {
                MessageBox.Show("There is no valid email address to send");
                return;
            }
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvArchive);
            if (exporter.Generate(true, true)) {
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(exporter.csvText);
                writer.Flush();
                stream.Position = 0;
                if (bslayer.SendEmailToCustomRecepient(luv.NotificationEmail, "Report Archive", "", new System.Net.Mail.Attachment(stream, "report.csv", "text/csv")))
                    MessageBox.Show("Email Sent");
            }
        }

        private void BtnDBEmailAsCsv_Click(object sender, EventArgs e) {
            Luv luv= bslayer.GetLuv();
            if (luv.NotificationEmail == "") {
                MessageBox.Show("There is no valid email address to send");
                return;
            }
            
                DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDatabase);
                if (exporter.Generate(true, true)) {
                    MemoryStream stream = new MemoryStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(exporter.csvText);
                    writer.Flush();
                    stream.Position = 0;
                    if (bslayer.SendEmailToCustomRecepient(luv.NotificationEmail, "Report Archive", "", new System.Net.Mail.Attachment(stream, "report.csv", "text/csv")))
                        MessageBox.Show("Email Sent");
                }
        }


        

        private void BtnViewTaxReport_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                DateTime FirstStartDate = DateTime.Parse(dgvDatabase.SelectedRows[0].Cells["colDBStartDate"].Value.ToString());
                DateTime LastEndDate = DateTime.Parse(dgvDatabase.SelectedRows[0].Cells["colDBStartDate"].Value.ToString());

                for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                    DateTime startDate = DateTime.Parse(dgvDatabase.SelectedRows[i].Cells["colDBStartDate"].Value.ToString());
                    DateTime endDate = DateTime.Parse(dgvDatabase.SelectedRows[i].Cells["colDBEndDate"].Value.ToString());
                    if (startDate < FirstStartDate)
                        FirstStartDate = startDate;
                    if (endDate > LastEndDate)
                        LastEndDate = endDate;
                }

                frmTaxReport frm = new frmTaxReport(bslayer, FirstStartDate, LastEndDate); // bslayer.GetTaxSummaryReport(FirstStartDate, LastEndDate));
                frm.ShowDialog();


            }
        }

        private void FrmMainAdaptor_FormClosing(object sender, FormClosingEventArgs e) {
            if (!blnAbort) {

                //To call this function you must implement Delegate_BackGroundWork function
                //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                //args parameter must have an object array which will match with the second parameter
                //of this function call.
                frmProgress frm = new frmProgress(
                    new Delegate_BackGroundWork(DoBackup),
                    null, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView, false, this.BackgroundImage) {
                    Text = "Backing up System Files",
                    Message = "Backing up, Please DO NOT Cancel."
                };
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;
            }
        }

        private void DoBackup(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            try {
                bgWorker.ReportProgress(10, "Checking Directory Structure ");
                EnsureDirectoryStructure();
                bgWorker.ReportProgress(30, "Backing up Session Files");
                EnsureSessionBackup(bgWorker);
                //bgWorker.ReportProgress(50, "Backing up Menu Files");
                //EnsureMenuBackup();
                //bgWorker.ReportProgress(70, "Backing up Database");
                //EnsureDatabaseBackup();
                //bgWorker.ReportProgress(100, "Backing up Report Files");
                //EnsureReportsBackup();
            } catch {
                MessageBox.Show("Failed to backup certain files");
            }
        }

        private void FrmMainAdaptor_FormClosed(object sender, FormClosedEventArgs e) {
            Process myProcess = new Process();

            try {
                myProcess.StartInfo.UseShellExecute = false;
                // You can start any process, HelloWorld is a do-nothing example.
                myProcess.StartInfo.FileName = "Starter.exe";
                myProcess.StartInfo.Arguments = "DELETEFILES";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                // This code assumes the process you are starting will terminate itself.  
                // Given that is is started without a window so you cannot terminate it  
                // on the desktop, it must terminate itself or you can do it programmatically 
                // from this application using the Kill method.

                Application.Exit();
            } catch {
            }

            
        }

        private void BtnShowTotalArchived_Click(object sender, EventArgs e) {
            float total = CalculateArchivedSelectedRows();
            if (total > 0) {
                MessageBox.Show(total.ToString("c2"));
            }
        }

        private void BtnShowTotalDatabase_Click(object sender, EventArgs e) {
            float total = CalculateLoadedSelectedRows();
            if (total > 0) {
                MessageBox.Show(total.ToString("c2"));
            }
        }
        



        
    }
}
