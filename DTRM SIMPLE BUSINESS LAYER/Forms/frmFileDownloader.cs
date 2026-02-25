using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace DTRMNS {
    public partial class frmFileDownloader : Form {
        private WebClient webClient;

        //private BackgroundWorker bgWorker;

        private string tempFile;

        internal string TempFilePath { get { return this.tempFile; } }

        //public frmFileDownloader() {
        //    InitializeComponent();
        //}

        private string localFileName;

        public frmFileDownloader(string localFileName, Uri sourceFileUrl) {
            InitializeComponent();

            tempFile = Path.GetTempFileName();
            this.localFileName = localFileName;

            webClient = new WebClient();
            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;

            //bgWorker = new BackgroundWorker();
            //bgWorker.DoWork += bgWorker_DoWork;
            //bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;

            try {
                webClient.DownloadFileAsync(sourceFileUrl, this.tempFile);
            } catch {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                this.Close();
            }
        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = String.Format("Downloaded {0} of {1}", FormatBytes(e.BytesReceived, 1, true), FormatBytes(e.TotalBytesToReceive, 1, true));
        }

        private string FormatBytes(long bytes, int decimalPlaces, bool showByteType) {
            double newBytes = bytes;
            string formatString = "{0";
            string byteType = "B";

            if (newBytes > 1024 && newBytes < 1048576) {
                newBytes /= 1024;
                byteType = "KB";
            } else if (newBytes > 1048576 && newBytes < 1073741824) {
                newBytes /= 1048576;
                byteType = "MB";
            } else {
                newBytes /= 1073741824;
                byteType = "GB";
            }

            if (decimalPlaces > 0)
                formatString += ":0.";

            for (int i = 0; i < decimalPlaces; i++)
                formatString += "0";

            formatString += "}";

            if (showByteType)
                formatString += byteType;

            return string.Format(formatString, newBytes);


        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                this.Close();
            } else if (e.Cancelled) {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                this.Close();
            } else {
                lblProgress.Text = "Download Completing...";
                //progressBar.Style = ProgressBarStyle.Marquee;

                //bgWorker.RunWorkerAsync(new string[] { this.tempFile });
                File.Copy(tempFile,localFileName);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        //private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
        //    string file = ((string[])e.Argument)[0];
        //    //string updateMd5 = ((string[])e.Argument)[1];

        //    //if (Hasher.HashFile(file, HashType.MD5).ToLower() != updateMd5.ToLower())
        //    //    e.Result = DialogResult.No;
        //    //else
        //    //    e.Result = DialogResult.OK;

        //}

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.DialogResult = (DialogResult)e.Result;
            this.Close();
        }

        private void frmFileDownloader_Load(object sender, EventArgs e) {

        }

        private void frmFileDownloader_FormClosed(object sender, FormClosedEventArgs e) {
            if (webClient.IsBusy) {
                webClient.CancelAsync();
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

            //if (bgWorker.IsBusy) {
            //    bgWorker.CancelAsync();
            //    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            //}
        }
    }
}
