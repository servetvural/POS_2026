using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinLayer;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary;
using PosLibrary.Forms;
using WinLayer.Library;

namespace WinOffice {
    public partial class frmSessionReports : Form {
        PosConfig config;
        IRepository<Session> repoSession;
        IRepository<Order> repoOrder;

        double cardTotal = 0;
        double cashTotal = 0;

        private BindingSource _sessionSource = new BindingSource();
        private BindingSource _orderSource = new BindingSource();
        private BindingSource _orderitemSource = new BindingSource();
        private BindingSource _allitemSource = new BindingSource();
        public frmSessionReports() {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
        }
        private void frmSessionReports_Load(object sender, EventArgs e) {
            ShowHideButtons(false);
            expArchivedSessions.Expanded = false;
            pnlArchivedSessions.Width = 500;
            expSessions.Expanded = false;
            pnlSessions.Width = 500;
            expOrders.Expanded = true;
            pnlOrders.Width = 400;
            expOrderItems.Expanded = true;
            expItemsGrouped.Expanded = true;

            LoadDBSessions();
         //   LoadArchivedSessionsLocal();

        }

        private async void LoadDBSessions() {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadDBSessions), null);
            else
            {

                BindingList<Session> sessionList = new BindingList<Session>(await repoSession.GetAllAsync("Orders,Orders.Items"));

                dgvDatabase.AutoGenerateColumns = false;
                dgvOrders.AutoGenerateColumns = false;
                dgvOrderItems.AutoGenerateColumns = false;
                dgvSessionAllOrderItems.AutoGenerateColumns = false;

                _sessionSource.DataSource = sessionList;
                _sessionSource.Sort = "StartDate DESC";
                dgvDatabase.DataSource = _sessionSource;


                _orderSource.DataSource = _sessionSource;
                _orderSource.DataMember = "Orders";
                _orderSource.Sort = "OrderDate ASC";
                dgvOrders.DataSource = _orderSource;


                _orderitemSource.DataSource = _orderSource;
                _orderitemSource.DataMember = "Items";
                _orderitemSource.Sort = "DOrder ASC";
                dgvOrderItems.DataSource = _orderitemSource;

                if (!sessionList.IsNullOrEmpty())
                    lblAllSessionTotal.Text = sessionList.Sum(x => x.Total).ToString("N2");
                else
                    lblAllSessionTotal.Text = "?";
            
            }
        }
        private void LoadArchivedSessionsLocal() {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadArchivedSessionsLocal), null);
            else {
                dgvArchive.DataSource = BSLayer.Instance.GetArchivedSessionDataTable(DRFile.GetApplicationPath() + POSLayer.Library.UF.SessionDirName);
            }
        }

        #region TAX REPORT
        private void btnGenerateTaxReport_Click(object sender, EventArgs e) {
           
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

                frmTaxReport frm = ActivatorUtilities.CreateInstance<frmTaxReport>(ServiceHelper.Services,  FirstStartDate, LastEndDate); // bslayer.GetTaxSummaryReport(FirstStartDate, LastEndDate));
                frm.Show();


            }

        }
        private void btnEmailTaxReport_Click(object sender, EventArgs e) {
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

                frmInputForm frm = new frmInputForm("Email Address of the recepient of this report");
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    MemoryStream stream = new MemoryStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(BSLayer.Instance.GetTaxSummaryReportAsCSVString(FirstStartDate, LastEndDate));
                    writer.Flush();
                    stream.Position = 0;
                    BSLayer.Instance.SendEmailToCustomRecepient(frm.InputValue, "Tax Report", "", new System.Net.Mail.Attachment(stream, FirstStartDate.ToShortDateString() + "_" + LastEndDate.ToShortDateString() + "_report.csv", "text/csv"));
             

                }

            }
        }
        #endregion
                          



        private void dgvDatabase_SelectionChanged(object sender, EventArgs e) {

            if (dgvDatabase.SelectedRows.Count > 0)
            {
                cmbRange.DataSource = null;

                if (pnl3661.Visible)
                {
                    LoadSRangeList();
                }

                Session session = dgvDatabase.SelectedRows[0].DataBoundItem as Session;
                _allitemSource.DataSource = session.Orders.SelectMany(x => x.Items )
                    .GroupBy(i => i.OrderItemText).Select(g => new
                    {
                        OrderItemText = g.Key,
                        Quantity = g.Sum(x => x.Quantity),
                        TaxPercent= g.First().TaxPercent,
                        TotalVat = g.Sum(x => x.TotalVat),
                        Price = g.First().Price,
                        Total = g.Sum(x => x.Quantity * x.Price)
                    }).OrderByDescending(x => x.Quantity).ToList();
                //_allitemSource.Sort = "Quantity DESC";
                dgvSessionAllOrderItems.DataSource = _allitemSource;
            }
        }



#region LOAD SESSION FROM SESSIONS DIRECTORY

private void btnLoadSessions_Click(object sender, EventArgs e) {
            if (dgvArchive.SelectedRows.Count > 0) {
                List<SessionDataShort> theList = new List<SessionDataShort>();
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");
                for (int i = 0; i < dgvArchive.SelectedRows.Count; i++) {
                    SessionDataShort session = new SessionDataShort();
                    session.IID = dgvArchive.SelectedRows[i].Cells["colArcIID"].Value.ToString();
                    session.StartDate = Convert.ToDateTime(dgvArchive.SelectedRows[i].Cells["colArcStartDate"].Value.ToString(), culture);
                    session.EndDate = Convert.ToDateTime(dgvArchive.SelectedRows[i].Cells["colArcEndDate"].Value.ToString(), culture);
                    theList.Add(session);
                }


                //To call this function you must implement Delegate_BackGroundWork function
                //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                //args parameter must have an object array which will match with the second parameter
                //of this function call.
                frmProgress frm = new frmProgress(
                    new Delegate_BackGroundWork(LoadSessionsInToDatabaseAsync),
                    theList.ToArray(), true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView,false, btnLoadSessions.Image);
                frm.Text = "Loading Sessions into Database";
                frm.Message = "Loading, Please DO NOT Cancel.";
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;

            }

        }

        private void LoadSessionsInToDatabaseAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            SessionDataShort[] sessionList = (SessionDataShort[])args;
            for (int i = 0; i < sessionList.Length; i++) {
                BSLayer.Instance.ReloadSessionFromDirectory(sessionList[i].StartDate, sessionList[i].EndDate);
                //bslayer.ReloadSessionFromFile(fileList[i]);
                int percent = (100 / sessionList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Loading " + sessionList[i].StartDate.ToString() + " To " + sessionList[i].EndDate.ToString());
            }
            LoadArchivedSessionsLocal();
            LoadDBSessions();
        }
        #endregion

        #region LOAD SESSIONS FROM CUSTOM DIRECTORY
        private void btnLoadSessionsFromDirectory_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Session Files |*.xml";
            dlg.InitialDirectory = Application.ExecutablePath;
            dlg.Multiselect = true;
            //string[] fileList = null;
            if (dlg.ShowDialog() == DialogResult.OK) {
                
                //To call this function you must implement Delegate_BackGroundWork function
                //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                //args parameter must have an object array which will match with the second parameter
                //of this function call.
                frmProgress frm = new frmProgress(
                    new Delegate_BackGroundWork(LoadSessionsInToDatabaseFromDirectoryAsync),
                    dlg.FileNames, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView,false, btnLoadSessionsFromDirectory.Image);
                frm.Text = "Loading Sessions into Database";
                frm.Message = "Loading, Please DO NOT Cancel.";
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;
            }
        }

        private void LoadSessionsInToDatabaseFromDirectoryAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            string[] fileList = (string[])args;
            for (int i = 0; i < fileList.Length; i++) {
                BSLayer.Instance.ReloadSessionFromFile(fileList[i]);
                int percent = (100 / fileList.Length) * (i+1);
                bgWorker.ReportProgress(percent, "Loading " + fileList[i]);
            }
            LoadDBSessions();
            //MessageBox.Show("Load Completed");
        }
        #endregion

        #region ARCHIVE SESSIONS TO SPECIAL DIRECTORY
        private void btnArchiveSessionToSpecialDirectory_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                FolderBrowserDialog dlg = new FolderBrowserDialog();               
                dlg.ShowNewFolderButton = true;                
                if (dlg.ShowDialog() == DialogResult.OK) {
                    string directoryPath = dlg.SelectedPath;

                    string[] SessionIIDList = new string[dgvDatabase.SelectedRows.Count];
                    for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                       SessionIIDList[i] = dgvDatabase.SelectedRows[i].Cells["dbIID"].Value.ToString();
                    }
                    object[] args = new object[] { directoryPath, SessionIIDList };


                    //To call this function you must implement Delegate_BackGroundWork function
                    //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                    //args parameter must have an object array which will match with the second parameter
                    //of this function call.
                    frmProgress frm = new frmProgress(
                        new Delegate_BackGroundWork(ArchiveSessionsInToDirectoryAsync),
                        args, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView,false, btnArchiveSessionToSpecialDirectory.Image);
                    frm.Text = "Archiving Sessions into Directory";
                    frm.Message = "Archiving, Please DO NOT Cancel.";
                    frm.ShowDialog();

                    //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                    object result = frm.AsyncResult;
                   
                }
            }
        }

        private void ArchiveSessionsInToDirectoryAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            object[] arguments = (object[])args;
            string directoryPath = (string)arguments[0];
            string[] SessionIIDList = (string[])arguments[1];

            for (int i = 0; i < SessionIIDList.Length; i++) {
                BSLayer.Instance.ArchiveSessionToDirectory(directoryPath, SessionIIDList[i], true);
                int percent = (100 / SessionIIDList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Archiving " + SessionIIDList[i]);
            }
            LoadDBSessions();
            LoadArchivedSessionsLocal();
            //MessageBox.Show("Archive Completed");
        }
        #endregion

        #region ARCHIVE SESSIONS TO SESSIONS DIRECTORY
        private void btnArchiveSessions_Click(object sender, EventArgs e) {

            string directoryPath = DRFile.GetApplicationPath() + POSLayer.Library.UF.SessionDirName;

            string[] SessionIIDList = new string[dgvDatabase.SelectedRows.Count];
            for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                SessionIIDList[i] = dgvDatabase.SelectedRows[i].Cells["dbIID"].Value.ToString();
            }
            object[] args = new object[] { directoryPath, SessionIIDList };


            //To call this function you must implement Delegate_BackGroundWork function
            //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
            //args parameter must have an object array which will match with the second parameter
            //of this function call.
            frmProgress frm = new frmProgress(
                new Delegate_BackGroundWork(ArchiveSessionsInToDirectoryAsync),
                args, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView,false, btnArchiveSessions.Image);
            frm.Text = "Archiving Sessions into Directory";
            frm.Message = "Archiving, Please DO NOT Cancel.";
            frm.ShowDialog();

            //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
            object result = frm.AsyncResult;

        }
        #endregion


        #region PRINT SESSIONS FROM DATABASE
        private void btnPrintReport_Click(object sender, EventArgs e) {
            if (dgvDatabase.SelectedRows.Count > 0) {
                Report report = BSLayer.Instance.GetReport(ReportFormatTypes.ZReport);


                if (report.ReportType == ReportFormatTypes.ZReport) {
                    if (MessageBox.Show("Z Report will archive the sessions after print.\nAre you want to continue to ARCHIVE THE SESSION(S)?",
                        "SESSION(S) WILL BE ARCHIVED", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                        return;
                }

                if (MessageBox.Show("You have selected " + dgvDatabase.SelectedRows.Count.ToString() +
                   " sessions!\nThis will take several minutes!\nDo you want to continue?\r\n\r\n" + 
                   "\r\nThe print process will continue running in the background.",
                   "REPORT CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    frmAppPrinterDialog fsp =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                    if (fsp.ShowDialog() == DialogResult.OK) {
                        List<CustomReportPrintJob> jobList = new List<CustomReportPrintJob>();
                        for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++) {
                            jobList.Add(new CustomReportPrintJob(report.ReportType, 
                                fsp.SelectedPrinterIID, 
                                dgvDatabase.SelectedRows[i].Cells["dbIID"].Value.ToString(),
                                DateTime.Parse(dgvDatabase.SelectedRows[i].Cells["colDBStartDate"].Value.ToString()), true));
                       }

                        //To call this function you must implement Delegate_BackGroundWork function
                        //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                        //args parameter must have an object array which will match with the second parameter
                        //of this function call.
                        frmProgress frm = new frmProgress(
                            new Delegate_BackGroundWork(PrintSessionsAsync),
                            new object[]{ jobList}, true, ProgressDetailTypes.FullDetails,false);
                        frm.Text = "Printing Sessions";
                        frm.Message = "Printing, Please DO NOT Cancel.";
                        frm.ShowDialog();

                        //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                        object result = frm.AsyncResult;
                    }
                }
            }
        }

        private void PrintSessionsAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e) {
            object[] arguments = (object[])args;
            List<CustomReportPrintJob> jobList = (List<CustomReportPrintJob>)arguments[0];

            for (int i = 0; i < jobList.Count; i++) {
                CustomReportPrintJob job = jobList[i];
                BSLayer.Instance.PrintReport(job.ReportType, job.SessionIID, job.PrinterIID, job.LatePrinting);
                int percent = (100 / jobList.Count) * (i + 1);
                bgWorker.ReportProgress(percent, "Printing Session : " + job.SessionStartDate.ToString());
            }
            MessageBox.Show("Print Completed");
            LoadDBSessions();
        }
        #endregion

        private void btnReload_Click(object sender, EventArgs e) {
           // LoadArchivedSessionsLocal();
            LoadDBSessions();
        }


        
        private void btnGroupExport_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvSessionAllOrderItems);
            if (exporter.Generate(true, true))
                exporter.ExportToFile();
        }

        private void btnGroupEmail_Click(object sender, EventArgs e) {
            frmInputForm frm = new frmInputForm("Recepient email address");
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvSessionAllOrderItems);
                if (exporter.Generate(true, true)) {
                    BSLayer.Instance.SendEmailToCustomRecepient(frm.InputValue, "Report Session All Items", "", exporter.GetAsAttachment());
                }
            }
        }

        private void btnGroupPrint_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvSessionAllOrderItems);
            if (exporter.GenerateAsTabular(true, true,new int[]{-4,-21,5,8})) {
                frmAppPrinterDialog frm =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    PrintHandler printer = new PrintHandler(config,exporter.csvText, frm.SelectedPrinterNetworkName );
                    printer.PrintNow();
                }
            }
        }

        private void btnSessionDBExport_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDatabase);
            if (exporter.Generate(true, true))
                exporter.ExportToFile();
        }

        private void btnSessionDBEmail_Click(object sender, EventArgs e) {
            frmInputForm frm = new frmInputForm("Recepient email address");
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDatabase);
                if (exporter.Generate(true, true)) {
                    BSLayer.Instance.SendEmailToCustomRecepient(frm.InputValue, "Report Database Sessions", "", exporter.GetAsAttachment());
                }
            }
        }

        private void btnSessionDBPrint_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDatabase);
            if (exporter.GenerateAsTabular(true, true, new int[] { -15, -15, 10 })) {
                frmAppPrinterDialog frm =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    PrintHandler printer = ActivatorUtilities.CreateInstance < PrintHandler>(ServiceHelper.Services,exporter.csvText, frm.SelectedPrinterNetworkName);
                    printer.PrintNow();

                    
                }
            }
        }

        private void btnSessionARCExport_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvArchive);
            if (exporter.Generate(true, true))
                exporter.ExportToFile();
        }

        private void btnSessionARCEmail_Click(object sender, EventArgs e) {
            frmInputForm frm = new frmInputForm("Recepient email address");
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvArchive);
                if (exporter.Generate(true, true)) {
                    BSLayer.Instance.SendEmailToCustomRecepient(frm.InputValue, "Report Archived Sessions", "", exporter.GetAsAttachment());
                }
            }
        }

        private void btnSessionARCPrint_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvArchive);
            if (exporter.GenerateAsTabular(true, true, new int[] { -15, -15, 10 })) {
                frmAppPrinterDialog frm =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    PrintHandler printer = ActivatorUtilities.CreateInstance < PrintHandler>(ServiceHelper.Services,exporter.csvText, frm.SelectedPrinterNetworkName);
                    printer.PrintNow();
                }
            }
        }

        private void btnSessionARCReload_Click(object sender, EventArgs e) {
            LoadArchivedSessionsLocal();
        }

        private void btnSessionDBReload_Click(object sender, EventArgs e) {
            LoadDBSessions();
        }

        private async void btnDuplicateOrders_Click(object sender, EventArgs e)
        {
            //Random rand = new Random();            
            //for (int i=0; i < dgvOrders.SelectedRows.Count;i++)
            //{
            //    string orderIID = dgvOrders.SelectedRows[i].Cells["colOrderIID"].Value.ToString();
            //    await BSLayer.Instance.SaveOrder(BSLayer.Instance.GetOrder(orderIID).Result.Duplicate(rand.Next(300, 1800)));
            //}
            //LoadOrders();
        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrders.SelectedRows)
                {                                                              
                    Order order = row.DataBoundItem as Order;
                    if (order.Payment == PaymentMethods.Cash)
                    {
                       if ( await repoOrder.Delete(order) > 0)
                        {
                            (_sessionSource.Current as Session).Orders.Remove(order);
                            //Deleted successfully
                        }
                    }
                }
            }

            //for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
            //{
            //    string orderIID = dgvOrders.SelectedRows[i].Cells["colOrderIID"].Value.ToString();
            //    string Payment = dgvOrders.SelectedRows[i].Cells["colPaymentMethod"].Value.ToString();
            //    if (Payment == "1")
            //        await BSLayer.Instance.DeleteOrder(orderIID);
            //}
            //LoadOrders();
        }

        private void dgvArchive_SelectionChanged(object sender, EventArgs e)
        {
            
            float total = 0;
            for (int i=0; i < dgvArchive.SelectedRows.Count;i++)
            {
                try
                {
                    total += float.Parse(dgvArchive.SelectedRows[i].Cells["cellArchivedGrossTotal"].Value.ToString());
                } catch
                {

                }
            }
            lblArchivedSelectedTotal.Text = total.ToString("N2");
        }

        private void chkLoadAllItems_CheckedChanged(object sender, EventArgs e) {
            //if (chkLoadAllItems.Checked) {
            //    chkLoadAllItems.Image = Properties.Resources.Checked;
            //    LoadOrderItemsForSession();
            //}
            //else {
            //    chkLoadAllItems.Image = Properties.Resources.Unchecked;
            //    dgvSessionAllOrderItems.DataSource = null;
            //}
        }

        private void chkLoadOrders_CheckedChanged(object sender, EventArgs e) {
            //if (chkLoadOrders.Checked) {
            //    chkLoadOrders.Image = Properties.Resources.Checked;
            //    LoadOrders();
            //}
            //else {
            //    chkLoadOrders.Image = Properties.Resources.Unchecked;
            //    dgvOrders.DataSource = null;
            //    UnloadOrderItems();
            //}
        }

        private async void btnAddOrderItem_Click(object sender, EventArgs e) {
            //if (dgvOrders.SelectedRows.Count > 0) {
            //    string orderIID = dgvOrders.SelectedRows[0].Cells["colOrderIID"].Value.ToString();
            //    frmCategoryItemSelector frm = new frmCategoryItemSelector(BSLayer.Instance.ActiveMenu.IID);
            //    if (frm.ShowDialog() == DialogResult.OK) {
            //        Order order = await BSLayer.Instance.GetOrder(orderIID);
            //        for (int i = 0; i < frm.SelectedEntiyButtonIIDList.Count; i++) {
            //            BSLayer.Instance.DirectCreateTopOrderItemForOrder(order, frm.SelectedEntiyButtonIIDList[i] , true);
            //        }
            //        LoadOrderItems();
            //    }
            //}
        }

        private void btnIncrementOrderItem_Click(object sender, EventArgs e) {
            //if (dgvOrders.SelectedRows.Count > 0) {
            //    string orderIID = dgvOrders.SelectedRows[0].Cells["colOrderIID"].Value.ToString();

            //    for (int i = 0; i < dgvOrderItems.SelectedRows.Count; i++) {
            //        string itemIID = dgvOrderItems.SelectedRows[i].Cells["colItemIID"].Value.ToString();
            //        BSLayer.Instance.DirectIncrementOrderItem(itemIID);
            //    }
            //    LoadOrderItems();
            //}
        }

        private void btnDecrementOrderItem_Click(object sender, EventArgs e) {
            //if (dgvOrders.SelectedRows.Count > 0) {
            //    string orderIID = dgvOrders.SelectedRows[0].Cells["colOrderIID"].Value.ToString();

            //    for (int i = 0; i < dgvOrderItems.SelectedRows.Count; i++) {
            //        string itemIID = dgvOrderItems.SelectedRows[i].Cells["colItemIID"].Value.ToString();
            //        BSLayer.Instance.DirectDecrementOrderItem(itemIID);
            //    }
            //    LoadOrderItems();
            //}
        }

        private void btnDeleteItem_Click(object sender, EventArgs e) {
            //if (dgvOrders.SelectedRows.Count > 0) {
            //    string orderIID = dgvOrders.SelectedRows[0].Cells["colOrderIID"].Value.ToString();

            //    for (int i = 0; i < dgvOrderItems.SelectedRows.Count; i++) {
            //        string itemIID = dgvOrderItems.SelectedRows[i].Cells["colItemIID"].Value.ToString();
            //        BSLayer.Instance.DirectDeleteOrderItem(itemIID);
            //    }
            //    LoadOrderItems();
            //}
        }

        //private void LoadOrderItems() {
        //    if (dgvOrders.SelectedRows.Count > 0) {
                
                
        //        string orderIID = dgvOrders.SelectedRows[0].Cells["colOrderIID"].Value.ToString();
        //        lblOrderTotal.Text = BSLayer.Instance.GetOrderTotal(orderIID).ToString("f2");
        //        dgvOrderItems.DataSource = GetOrderItemsForOrderCustom(orderIID);
        //    }
        //}
        //private void UnloadOrderItems() {
        //    lblOrderTotal.Text = "0";
        //    dgvOrderItems.DataSource = null;
        //}

        private void toolStripButton1_Click(object sender, EventArgs e) {
          
        }

        private void btnDelZeros_Click(object sender, EventArgs e) {
            DataTable dt = BSLayer.Instance.GetDataTable("select IID from OrdersView Where CalculatedValue is null");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string IID = dt.Rows[i]["IID"].ToString();
                BSLayer.Instance.DeleteOrder(IID);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            if (pnl3661.Visible) {
                ShowHideButtons(false);
                return;
            } 
            frmNo frm = new frmNo(true);
            if (frm.ShowDialog() == DialogResult.OK) { 
                if (frm.val == 6252) {
                    ShowHideButtons(true);
                    expArchivedSessions.Expanded = false;
                    //pnlOrders.Width = 600;
                    expOrderItems.Expanded = true;
                    pnlOrderItems.Width = 470;

                } else {
                    ShowHideButtons(false);
                }

            } else {
                ShowHideButtons(false);
            }
        }

        private void ShowHideButtons(bool blnShowHide) {
                btnAddOrderItem.Visible = btnIncrementOrderItem.Visible = btnDecrementOrderItem.Visible = 
                btnDeleteItem.Visible = pnl3661.Visible = blnShowHide;
        }

        private async void btnChangePaymentMethodForOrder_Click(object sender, EventArgs e) {
            //if (dgvOrders.SelectedRows.Count > 0) {
            //    frmPaymentType frm = new frmPaymentType();
            //    if (frm.ShowDialog() == DialogResult.OK) {
            //        for (int i = 0; i < dgvOrders.SelectedRows.Count; i++) {
            //            string orderIID = dgvOrders.SelectedRows[i].Cells["colOrderIID"].Value.ToString();
            //            Order order = await BSLayer.Instance.GetOrder(orderIID);
            //            order.Payment = frm.SelectedPaymentMethod;
            //            BSLayer.Instance.SaveOrder(order);
            //        }
            //        LoadOrders();
            //    }
                
            //}
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e) {
           
        }



        private void tsSil_Click(object sender, EventArgs e) {
            if (pnl3661.Visible)
            {
                //for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
                //{
                //    string orderIID = dgvOrders.SelectedRows[i].Cells["colOrderIID"].Value.ToString();
                //    BSLayer.Instance.DeleteOrder(orderIID);
                //}
                //LoadOrders();
            }
        }



        private void btnLoadSelectables_Click(object sender, EventArgs e)
        {
            if (pnl3661.Visible)
            {
                LoadSRangeList();
            }
        }
                      
        void LoadSRangeList()
        {
            double total = 0;
            List<SRange> srList = new List<SRange>();

            total = double.Parse(lblTotal.Text);

            for (int k = 2; k < 10; k++)
            {
                double pickTotal = 0;
                int count = 0;
                for (int i = 1; i < dgvOrders.Rows.Count - 2; i = i + k)
                {
                    Order order = dgvOrders.Rows[i].DataBoundItem as Order;
                    if (order.Payment == PaymentMethods.Cash || order.Payment == PaymentMethods.NotPaid)
                    {
                        pickTotal += order.Total;
                        count++;
                    }
                    //if (int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) < 2)
                    //{
                    //    pickTotal += float.Parse(dgvOrders.Rows[i].Cells["colCalculatedValue"].Value.ToString());
                    //    count++;
                    //}
                }



                SRange sr = new SRange()
                {
                    ItemGap = k,
                    Secilen = pickTotal,
                    NakitSonuc = cashTotal - pickTotal ,
                    TotalSonuc = total - pickTotal,
                    Adet = count
                };
                srList.Add(sr);
            }
            cmbRange.DataSource = srList;
            cmbRange.DisplayMember = "DisplayValue";
            cmbRange.ValueMember = "ItemGap";
        }
        private void cmbRange_SelectedValueChanged(object sender, EventArgs e)
        {
            if (pnl3661.Visible)
            {
                try
                {
                    SRange sr = (SRange)cmbRange.SelectedItem;

                    if (sr != null)
                    {
                        dgvOrders.ClearSelection();
                        for (int i = 1; i < dgvOrders.Rows.Count - 2; i = i + sr.ItemGap)
                        {
                            Order order = dgvOrders.Rows[i].DataBoundItem as Order;
                            if (order.Payment == PaymentMethods.Cash || order.Payment == PaymentMethods.NotPaid)
                            {
                                dgvOrders.Rows[i].Selected = true;
                            }
                            //if (int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) < 2)
                            //{
                            //    dgvOrders.Rows[i].Selected = true;
                            //}
                        }
                    }
                } catch 
                {
                    return;
                }
            }
        }


    }
}
