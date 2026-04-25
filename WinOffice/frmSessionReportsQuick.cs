using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinLayer;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary;
using PosLibrary.Forms;

namespace WinOffice
{
    public partial class frmSessionReportsQuick : Form
    {
        PosConfig config;
        IRepository<Session> repoSession;
        IRepository<Order> repoOrder;


        double cardTotal = 0;
        double cashTotal = 0;


        double sessionMin;
        double minBarrierAlt = 2000;
        double minBarrierUst = 3000;


        private BindingSource _sessionSource = new BindingSource();
        private BindingSource _orderSource = new BindingSource();


        private bool blnBackUpCompleted;
        bool IsBackupValid
        {
            get
            {
                if (string.IsNullOrEmpty(Program.RemoteBackUpDirectory))
                    return false;
                return blnBackUpCompleted;
            }
        }

        public frmSessionReportsQuick()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
        }
        private void frmSessionReportsQuick_Load(object sender, EventArgs e)
        {
            ShowHideButtons(false);
            LoadDBSessions();
           // LoadArchivedSessionsLocal();
        }


        private async void LoadDBSessions()
        {
            if (blnDgvDatabaseBusy)
                return;

            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadDBSessions), null);
            else
            {
                BindingList<Session> sessionList = new BindingList<Session>(await repoSession.GetAllAsync("Orders,Orders.Items"));

                dgvDatabase.AutoGenerateColumns = false;
                dgvOrders.AutoGenerateColumns = false;

                _sessionSource.DataSource = sessionList;
                _sessionSource.Sort = "StartDate DESC";
                dgvDatabase.DataSource = _sessionSource;


                _orderSource.DataSource = _sessionSource;
                _orderSource.DataMember = "Orders";
                _orderSource.Sort = "OrderDate ASC";
                dgvOrders.DataSource = _orderSource;


                //if (!sessionList.IsNullOrEmpty())
                   
                //    lblAllSessionTotal.Text = sessionList.Sum(x => x.Total).ToString("N2");
                //else
                //    lblAllSessionTotal.Text = "?";
            }
        }
        private void LoadArchivedSessionsLocal()
        {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadArchivedSessionsLocal), null);
            else
            {
                dgvArchive.DataSource = DTRMSimpleBusiness.Instance.GetArchivedSessionDataTable(DRFile.GetApplicationPath() + POSLayer.Library.UF.SessionDirName);
            }
        }


       
        //private void LoadOrders()
        //{
        //    if (dgvDatabase.SelectedRows.Count > 0)
        //    {
        //        string SessionIID = dgvDatabase.SelectedRows[0].Cells["dbIID"].Value.ToString();
        //        //IID, OrderDate, CalculatedValue
        //        dgvOrders.DataSource = DTRMSimpleBusiness.Instance.GetDataTable("Select IID, OrderDate, Payment, CalculatedValue from OrdersView where SessionIID = '" + SessionIID + "' Order by OrderDate asc");
        //        dgvOrders_SelectionChanged(null, null);

        //        // LoadSRangeList();
        //        try
        //        {

        //            cardTotal = 0;
        //            cashTotal = 0;


        //            for (int i = 0; i < dgvOrders.Rows.Count; i++)
        //            {

        //                if ((PaymentMethods)int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) == PaymentMethods.Cash)
        //                {
        //                    cashTotal += float.Parse(dgvOrders.Rows[i].Cells["colCalculatedValue"].Value.ToString());
        //                }
        //                if ((PaymentMethods)int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) == PaymentMethods.Card)
        //                {
        //                    cardTotal += float.Parse(dgvOrders.Rows[i].Cells["colCalculatedValue"].Value.ToString());
        //                }
        //            }
        //            cardTotal = (float)(Math.Truncate(cardTotal * 100) / 100);
        //            cashTotal = (float)(Math.Truncate(cashTotal * 100) / 100);

        //            lblCard.Text = cardTotal.ToString("0.00");
        //            lblCash.Text = cashTotal.ToString("0.00");

        //            Random rand = new();
        //            float minBarrier = (float)(rand.NextDouble() * (minBarrierUst - minBarrierAlt) + minBarrierAlt);
        //            float carpan = (float)(rand.NextDouble() * (2.1 - 1.5) + 1.5);

        //            sessionMin = cardTotal * carpan;
        //            if (sessionMin < minBarrier)
        //                sessionMin = minBarrier;
        //            if (cardTotal > sessionMin)
        //            {
        //                sessionMin = cardTotal * carpan;
        //            }

        //            lblInfo.Text = "Min : " + sessionMin.ToString("N2");

        //            //SessionData sessionData = bslayer.GetSessionDataDynamic(SessionIID);                      
        //            // lblTotal.Text = sessionData.GrossSessionTotal.ToString("f2");
        //            lblTotal.Text = (cardTotal + cashTotal).ToString("0.00");
        //        } catch
        //        {
        //        }
        //    } else
        //    {
        //        dgvOrders.DataSource = null;
        //        // lblTotal.Text = "TOTAL";
        //        lblCard.Text = "";
        //        lblCash.Text = "";
        //    }

        //}
        //private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvOrders.SelectedRows.Count > 0)
        //    {
        //        string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();


        //        float total = 0;
        //        for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
        //        {
        //            try
        //            {
        //                total += float.Parse(dgvOrders.SelectedRows[i].Cells["colCalculatedValue"].Value.ToString());
        //            } catch
        //            {

        //            }
        //        }
        //        lblSelectedOrdersTotal.Text = total.ToString("N2");

        //    } else
        //    {
        //        cmbRange.DataSource = null;
        //        lblInfo.Text = "";
        //        lblSelectedOrdersTotal.Text = "";
        //    }
        //}


        bool blnDgvDatabaseBusy = false;
        private void dgvDatabase_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatabase.SelectedRows.Count > 0)
            {
                blnDgvDatabaseBusy = true;
                cmbRange.DataSource = null;

                if (pnl3661.Visible)
                {
                    LoadSRangeList();
                }
                blnDgvDatabaseBusy = false;

            }

            double total = 0;
            for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++)
            {
                Session session= (Session)dgvDatabase.SelectedRows[i].DataBoundItem;
                total += session.Total;
            }
            lblDatabaseSelectedTotal.Text = total.ToString("N2");
        }


        #region LOAD SESSION FROM SESSIONS DIRECTORY

        private void btnLoadSessions_Click(object sender, EventArgs e)
        {
            if (dgvArchive.SelectedRows.Count > 0)
            {
                List<SessionDataShort> theList = new();
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");
                for (int i = 0; i < dgvArchive.SelectedRows.Count; i++)
                {
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
                    theList.ToArray(), true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView, false, btnLoadSessions.Image);
                frm.Text = "Loading Sessions into Database";
                frm.Message = "Loading, Please DO NOT Cancel.";
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;

            }

        }

        private async void LoadSessionsInToDatabaseAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            SessionDataShort[] sessionList = (SessionDataShort[])args;
            for (int i = 0; i < sessionList.Length; i++)
            {
                await  DTRMSimpleBusiness.Instance.ReloadSessionFromDirectory(sessionList[i].StartDate, sessionList[i].EndDate);
 
                int percent = (100 / sessionList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Loading " + sessionList[i].StartDate.ToString() + " To " + sessionList[i].EndDate.ToString());
            }
            LoadArchivedSessionsLocal();
            LoadDBSessions();
        }
        #endregion

        #region LOAD SESSIONS FROM CUSTOM DIRECTORY
        private void btnLoadSessionsFromDirectory_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new()
            {
                Filter = "XML Session Files |*.xml",
                InitialDirectory = Application.ExecutablePath,
                Multiselect = true
            };
            //string[] fileList = null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                //To call this function you must implement Delegate_BackGroundWork function
                //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
                //args parameter must have an object array which will match with the second parameter
                //of this function call.
                frmProgress frm = new frmProgress(
                    new Delegate_BackGroundWork(LoadSessionsInToDatabaseFromDirectoryAsync),
                    dlg.FileNames, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView, false, btnLoadSessionsFromDirectory.Image);
                frm.Text = "Loading Sessions into Database";
                frm.Message = "Loading, Please DO NOT Cancel.";
                frm.ShowDialog();

                //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                object result = frm.AsyncResult;
            }
        }

        private void LoadSessionsInToDatabaseFromDirectoryAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            string[] fileList = (string[])args;
            for (int i = 0; i < fileList.Length; i++)
            {
                DTRMSimpleBusiness.Instance.ReloadSessionFromFile(fileList[i]);
                int percent = (100 / fileList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Loading " + fileList[i]);
            }
            LoadDBSessions();
            //MessageBox.Show("Load Completed");
        }
        #endregion

        #region ARCHIVE SESSIONS TO SPECIAL DIRECTORY
        private void ArchiveSessionsInToDirectoryAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            object[] arguments = (object[])args;
            string directoryPath = (string)arguments[0];
            string[] SessionIIDList = (string[])arguments[1];

            for (int i = 0; i < SessionIIDList.Length; i++)
            {
                DTRMSimpleBusiness.Instance.ArchiveSessionToDirectory(directoryPath, SessionIIDList[i], true);
                int percent = (100 / SessionIIDList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Archiving " + SessionIIDList[i]);
            }
            LoadDBSessions();
            LoadArchivedSessionsLocal();
        }

        private async Task<bool> BackupDBSessions(string directoryPath, bool blnRemoveFromDatabase = false)
        {
            try
            {
                string[] SessionIIDList = new string[dgvDatabase.Rows.Count];
                for (int i = 0; i < dgvDatabase.Rows.Count; i++)
                {
                    SessionIIDList[i] = dgvDatabase.Rows[i].Cells["dbIID"].Value.ToString();
                }
                if (SessionIIDList.Length == 0)
                {
                    MessageBox.Show("No sessions available for backup.");
                    return false;
                }
                for (int i = 0; i < SessionIIDList.Length; i++)
                {
                    await Task.Run(() => DTRMSimpleBusiness.Instance.ArchiveSessionToDirectory(directoryPath, SessionIIDList[i], blnRemoveFromDatabase));
                    //await Task.Run(() => bslayer.ArchiveSessionToDirectoryAsJson(directoryPath, SessionIIDList[i], blnRemoveFromDatabase));

                }
                if (Directory.GetFiles(directoryPath).Length == SessionIIDList.Length)
                {
                    // MessageBox.Show("Archiving Completed to " + directoryPath + " with success.");
                    return true;
                } else
                {
                    // MessageBox.Show("Archiving Completed with some errors. Please check the directory and database.");
                    return false;
                }
                //return true;
            } catch
            {
                return false;
            }
        }
        #endregion

        #region ARCHIVE SESSIONS TO SESSIONS DIRECTORY
        private void btnArchiveSessions_Click(object sender, EventArgs e)
        {

            string directoryPath = DRFile.GetApplicationPath() + POSLayer.Library.UF.SessionDirName;

            string[] SessionIIDList = new string[dgvDatabase.SelectedRows.Count];
            for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++)
            {
                SessionIIDList[i] = dgvDatabase.SelectedRows[i].Cells["dbIID"].Value.ToString();
            }
            object[] args = new object[] { directoryPath, SessionIIDList };


            //To call this function you must implement Delegate_BackGroundWork function
            //with parameters (object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
            //args parameter must have an object array which will match with the second parameter
            //of this function call.
            frmProgress frm = new frmProgress(
                new Delegate_BackGroundWork(ArchiveSessionsInToDirectoryAsync),
                args, true, ProgressDetailTypes.FullDetails, ProgressDialogViewTypes.CompactView, false, btnArchiveSessions.Image);
            frm.Text = "Archiving Sessions into Directory";
            frm.Message = "Archiving, Please DO NOT Cancel.";
            frm.ShowDialog();

            //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
            object result = frm.AsyncResult;

        }
        #endregion


        #region PRINT SESSIONS FROM DATABASE
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (dgvDatabase.SelectedRows.Count > 0)
            {
                Report report = DTRMSimpleBusiness.Instance.GetReport(ReportFormatTypes.ZReport);


                if (report.ReportType == ReportFormatTypes.ZReport)
                {
                    if (MessageBox.Show("Z Report will archive the sessions after print.\nAre you want to continue to ARCHIVE THE SESSION(S)?",
                        "SESSION(S) WILL BE ARCHIVED", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                        return;
                }

                if (MessageBox.Show("You have selected " + dgvDatabase.SelectedRows.Count.ToString() +
                   " sessions!\nThis will take several minutes!\nDo you want to continue?\r\n\r\n" +
                   "\r\nThe print process will continue running in the background.",
                   "REPORT CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAppPrinterDialog fsp =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                    if (fsp.ShowDialog() == DialogResult.OK)
                    {
                        List<CustomReportPrintJob> jobList = new();
                        for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++)
                        {
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
                            new object[] { jobList }, true, ProgressDetailTypes.FullDetails, false);
                        frm.Text = "Printing Sessions";
                        frm.Message = "Printing, Please DO NOT Cancel.";
                        frm.ShowDialog();

                        //Remove this line if you don't want result back, the result can be AsyncWorkResultTypes or bool or anything
                        // object result = frm.AsyncResult;
                    }
                }
            }
        }

        private void PrintSessionsAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            object[] arguments = (object[])args;
            List<CustomReportPrintJob> jobList = (List<CustomReportPrintJob>)arguments[0];

            for (int i = 0; i < jobList.Count; i++)
            {
                CustomReportPrintJob job = jobList[i];
                DTRMSimpleBusiness.Instance.PrintReport(job.ReportType, job.SessionIID, job.PrinterIID, job.LatePrinting);
                int percent = (100 / jobList.Count) * (i + 1);
                bgWorker.ReportProgress(percent, "Printing Session : " + job.SessionStartDate.ToString());
            }

            LoadDBSessions();
        }
        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadArchivedSessionsLocal();
            LoadDBSessions();
        }


        private void btnSessionARCReload_Click(object sender, EventArgs e)
        {
            LoadArchivedSessionsLocal();
        }

        private void btnSessionDBReload_Click(object sender, EventArgs e)
        {
            LoadDBSessions();
        }

        private void dgvArchive_SelectionChanged(object sender, EventArgs e)
        {

            float total = 0;
            for (int i = 0; i < dgvArchive.SelectedRows.Count; i++)
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

        private void btnDelZeros_Click(object sender, EventArgs e)
        {
            DataTable dt = DTRMSimpleBusiness.Instance.GetDataTable("select IID from OrdersView Where CalculatedValue is null");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string IID = dt.Rows[i]["IID"].ToString();
                DTRMSimpleBusiness.Instance.DeleteOrder(IID);
            }
        }


        private void ShowHideButtons(bool blnShowHide)
        {
            pnl3661.Visible = btnWizard.Visible = lblInfo.Visible = blnShowHide;
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void DeleteSelected()
        {
            //if (pnl3661.Visible)
            //{
            //    for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
            //    {
            //        string orderIID = dgvOrders.SelectedRows[i].Cells["colOrderIID"].Value.ToString();
            //        DTRMSimpleBusiness.Instance.DeleteOrder(orderIID);
            //    }
            //    LoadOrders();
            //}
        }

        private void btnLoadSelectables_Click(object sender, EventArgs e)
        {
            if (pnl3661.Visible)
            {
                LoadSRangeList();
            }
        }

        List<SRange> srList;

        void LoadSRangeList()
        {
            float total = 0;
            srList = new List<SRange>();

            total = float.Parse(lblTotal.Text);

            for (int k = 2; k < 10; k++)
            {
                float pickTotal = 0;
                int count = 0;
                for (int i = 1; i < dgvOrders.Rows.Count - 2; i = i + k)
                {
                    if (int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) < 2)
                    {
                        pickTotal += float.Parse(dgvOrders.Rows[i].Cells["colCalculatedValue"].Value.ToString());
                        count++;
                    }
                }

                SRange sr = new()
                {
                    ItemGap = k,
                    Secilen = pickTotal,
                    NakitSonuc = cashTotal - pickTotal,
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
                            if (int.Parse(dgvOrders.Rows[i].Cells["colPaymentMethod"].Value.ToString()) < 2)
                            {
                                dgvOrders.Rows[i].Selected = true;
                            }
                        }
                    }
                } catch
                {
                    return;
                }
            }
        }

        private void btnShowHideArchive_Click(object sender, EventArgs e)
        {
            pnlArchivedSessions.Visible = !pnlArchivedSessions.Visible;
        }

        private void btnAllSessionTotal_Click(object sender, EventArgs e)
        {
            btnAllSessionTotal.Enabled = false;
            LoadDBSessions();
            btnAllSessionTotal.Enabled = true;
        }

        private async void btnWizard_Click(object sender, EventArgs e)
        {
            SingleDayMagic();
        }

        private async void SingleDayMagic()
        {
            LoadSRangeList();

            if (srList != null && srList.Count > 0)
            {
                SRange closest = srList.OrderBy(sr => Math.Abs(sr.TotalSonuc - sessionMin)).FirstOrDefault();

                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (srList[i].TotalSonuc > sessionMin)
                        {
                            closest = srList[i];
                            break;
                        }
                    }
                } catch
                {
                }

                if (closest == null)
                {
                    return;
                }
                if (closest.TotalSonuc < (sessionMin * 0.97))
                {
                    return;
                } else
                {
                    cmbRange.SelectedIndex = closest.ItemGap - 2;
                    DeleteSelected();
                    int index = 0;
                    try
                    {
                        index = dgvDatabase.SelectedRows[0].Index;
                    } catch
                    {

                    }
                    LoadDBSessions();
                    try
                    {
                        dgvDatabase.Rows[0].Selected = false;
                        dgvDatabase.Rows[index].Selected = true;
                    } catch
                    {

                    }
                }
            }
        }

        private async void btnRefreshDatabase_Click(object sender, EventArgs e)
        {
           await DTRMSimpleBusiness.Instance.RefreshDatabase();
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            if (await DoCheck())
            {
                string theFolder = Program.RemoteBackUpDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                if (Directory.Exists(theFolder))
                {
                    MessageBox.Show("A backup folder with the same name already exists. A random number will be added to the folder name to avoid overwriting.");
                    //theFolder += "_" + new Random().Next(1000, 9999).ToString();
                    return;
                }  else
                {
                    Directory.CreateDirectory(theFolder);
                }
                if (Directory.Exists(theFolder))
                {
                    blnBackUpCompleted = await BackupDBSessions(theFolder, false);
                    if (blnBackUpCompleted)
                    {
                        ShowHideButtons(true);
                    }   else
                    {
                        ShowHideButtons(false);
                    }
                } else
                {
                    MessageBox.Show("Failed to create backup directory. Please check the path and permissions.");
                }
            }
        }

        async Task<bool> DoCheck()
        {
            if (pnl3661.Visible)
            {
                ShowHideButtons(false);
                return false;
            }
            frmNo frm = new frmNo(true);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (frm.val == Program.Profile)
                {                     
                    return true;
                } else
                {
                    ShowHideButtons(false);                      
                }

            } else
            {
                ShowHideButtons(false);
            }
            return false;
        }
    }
}
