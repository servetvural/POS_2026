using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;

using PosLibrary;
using PosLibrary.Forms;

namespace WinLayer.Forms
{
    public partial class frmReportArchive : Form
    {
       

        public frmReportArchive()
        {
            InitializeComponent();
        }
        private void frmReportArchive_Load(object sender, EventArgs e)
        {
            LoadDBSessions();
            LoadArchivedSessionsLocal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnReloadArchive_Click(object sender, EventArgs e)
        {
            LoadArchivedSessionsLocal();
        }
        private void LoadArchivedSessionsLocal()
        {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadArchivedSessionsLocal), null);
            else
            {
                dgvArchive.DataSource =  DTRMSimpleBusiness.Instance.GetArchivedSessionDataTable(DRFile.GetApplicationPath() + UF.SessionDirName);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvDatabase.SelectedRows.Count > 0)
            {
                Report report =  DTRMSimpleBusiness.Instance.GetReport(ReportFormatTypes.ZReport);


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
                    frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                    if (fsp.ShowDialog() == DialogResult.OK)
                    {
                        List<CustomReportPrintJob> jobList = new List<CustomReportPrintJob>();
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
                        object result = frm.AsyncResult;
                    }
                }
            }
        }

        private async void PrintSessionsAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            object[] arguments = (object[])args;
            List<CustomReportPrintJob> jobList = (List<CustomReportPrintJob>)arguments[0];

            for (int i = 0; i < jobList.Count; i++)
            {
                CustomReportPrintJob job = jobList[i];
                await DTRMSimpleBusiness.Instance.PrintReport(job.ReportType, job.SessionIID, job.PrinterIID, job.LatePrinting);
                int percent = (100 / jobList.Count) * (i + 1);
                bgWorker.ReportProgress(percent, "Printing Session : " + job.SessionStartDate.ToString());
            }                 
           // MessageBox.Show("Print Completed");              
            LoadDBSessions();
            LoadArchivedSessionsLocal();
            
        }

        private void btnReloadDatabase_Click(object sender, EventArgs e)
        {
            LoadDBSessions();
        }

        private void LoadDBSessions()
        {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadDBSessions), null);
            else
            {
                try
                {
                    string sessionTableName = "Sessions";
                    dgvDatabase.DataSource =  DTRMSimpleBusiness.Instance.GetDataTable("Select * from " + sessionTableName + " where IID <> '" +  DTRMSimpleBusiness.Instance.shop.CurrentSessionIID + "' order by StartDate desc");

                   // lblAllSessionTotal.Text = float.Parse( DTRMSimpleBusiness.Instance.GetDataTable("Select SUM(GrossSessionTotal) AS Total from " + sessionTableName + "  where IID <> '" +  DTRMSimpleBusiness.Instance.GetCurrentSessionIID() + "'").Rows[0]["Total"].ToString()).ToString("N2");
                } catch { }
            }
        }

        private void btnLoadSessions_Click(object sender, EventArgs e)
        {
            if (dgvArchive.SelectedRows.Count > 0)
            {
                List<SessionDataShort> theList = new List<SessionDataShort>();
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
                // DTRMSimpleBusiness.Instance.ReloadSessionFromFile(fileList[i]);
                int percent = (100 / sessionList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Loading " + sessionList[i].StartDate.ToString() + " To " + sessionList[i].EndDate.ToString());
            }
            LoadArchivedSessionsLocal();
            LoadDBSessions();
        }

        private void btnArchiveSessions_Click(object sender, EventArgs e)
        {
            string directoryPath = DRFile.GetApplicationPath() + UF.SessionDirName;

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

        private async void ArchiveSessionsInToDirectoryAsync(object args, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            object[] arguments = (object[])args;
            string directoryPath = (string)arguments[0];
            string[] SessionIIDList = (string[])arguments[1];

            for (int i = 0; i < SessionIIDList.Length; i++)
            {
               await DTRMSimpleBusiness.Instance.ArchiveSessionToDirectory(directoryPath, SessionIIDList[i], true);
                int percent = (100 / SessionIIDList.Length) * (i + 1);
                bgWorker.ReportProgress(percent, "Archiving " + SessionIIDList[i]);
            }
            LoadDBSessions();
            LoadArchivedSessionsLocal();
            //MessageBox.Show("Archive Completed");
        }
    }
}
