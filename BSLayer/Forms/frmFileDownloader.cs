using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSLayer {
    //public partial class frmFileDownloader : Form {
    //    private WebClient webClient;
    //    private string tempFile;

    //    internal string TempFilePath { get { return this.tempFile; } }

    //    private string localFileName;

    //    public frmFileDownloader(string localFileName, Uri sourceFileUrl) {
    //        InitializeComponent();

    //        tempFile = Path.GetTempFileName();
    //        this.localFileName = localFileName;

    //        webClient = new WebClient();
    //        webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
    //        webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;

    //        try {
    //            webClient.DownloadFileAsync(sourceFileUrl, this.tempFile);
    //        } catch {
    //            this.DialogResult = System.Windows.Forms.DialogResult.No;
    //            this.Close();
    //        }
    //    }

    //    private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
    //        progressBar.Value = e.ProgressPercentage;
    //        lblProgress.Text = String.Format("Downloaded {0} of {1}", FormatBytes(e.BytesReceived, 1, true), FormatBytes(e.TotalBytesToReceive, 1, true));
    //    }

    //    private string FormatBytes(long bytes, int decimalPlaces, bool showByteType) {
    //        double newBytes = bytes;
    //        string formatString = "{0";
    //        string byteType = "B";

    //        if (newBytes > 1024 && newBytes < 1048576) {
    //            newBytes /= 1024;
    //            byteType = "KB";
    //        } else if (newBytes > 1048576 && newBytes < 1073741824) {
    //            newBytes /= 1048576;
    //            byteType = "MB";
    //        } else {
    //            newBytes /= 1073741824;
    //            byteType = "GB";
    //        }

    //        if (decimalPlaces > 0)
    //            formatString += ":0.";

    //        for (int i = 0; i < decimalPlaces; i++)
    //            formatString += "0";

    //        formatString += "}";

    //        if (showByteType)
    //            formatString += byteType;

    //        return string.Format(formatString, newBytes);


    //    }

    //    private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
    //        if (e.Error != null) {
    //            this.DialogResult = System.Windows.Forms.DialogResult.No;
    //            this.Close();
    //        } else if (e.Cancelled) {
    //            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
    //            this.Close();
    //        } else {
    //            lblProgress.Text = "Download Completing...";
    //            File.Copy(tempFile,localFileName);

    //            this.DialogResult = System.Windows.Forms.DialogResult.OK;
    //            this.Close();
    //        }
    //    }
    //    private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
    //        this.DialogResult = (DialogResult)e.Result;
    //        this.Close();
    //    }

    //    private void frmFileDownloader_Load(object sender, EventArgs e) {

    //    }

    //    private void frmFileDownloader_FormClosed(object sender, FormClosedEventArgs e) {
    //        if (webClient.IsBusy) {
    //            webClient.CancelAsync();
    //            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
    //        }
    //    }
    //}


    public partial class frmFileDownloader : Form
    {
        // HttpClient should be static and reused to prevent socket exhaustion
        private static readonly HttpClient _httpClient = new HttpClient();
        private CancellationTokenSource _cts;
        private string _tempFile;
        private string _localFileName;
        private Uri _sourceUrl;

        public string TempFilePath => _tempFile;

        public frmFileDownloader(string localFileName, Uri sourceFileUrl)
        {
            InitializeComponent();
            _tempFile = Path.GetTempFileName();
            _localFileName = localFileName;
            _sourceUrl = sourceFileUrl;
        }

        private async void frmFileDownloader_Load(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            await StartDownloadAsync();
        }

        private async Task StartDownloadAsync()
        {
            // Progress<T> automatically dispatches back to the UI thread
            var progress = new Progress<(long Received, long Total)>(stats => {
                if (stats.Total > 0)
                {
                    int percent = (int)((double)stats.Received / stats.Total * 100);
                    progressBar.Value = Math.Clamp(percent, 0, 100);
                    lblProgress.Text = $"Downloaded {FormatBytes(stats.Received)} of {FormatBytes(stats.Total)}";
                }
            });

            try
            {
                await DownloadWithProgressAsync(_sourceUrl, _tempFile, progress, _cts.Token);

                lblProgress.Text = "Download Completing...";
                File.Move(_tempFile, _localFileName, overwrite: true); // Move is more efficient than Copy

                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (OperationCanceledException)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            } catch (Exception)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private async Task DownloadWithProgressAsync(Uri url, string path, IProgress<(long, long)> progress, CancellationToken ct)
        {
            using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, ct);
            response.EnsureSuccessStatusCode();

            long totalBytes = response.Content.Headers.ContentLength ?? -1L;
            using var contentStream = await response.Content.ReadAsStreamAsync(ct);
            using var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);

            var buffer = new byte[8192];
            long totalRead = 0;
            int bytesRead;

            while ((bytesRead = await contentStream.ReadAsync(buffer, ct)) != 0)
            {
                await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead), ct);
                totalRead += bytesRead;
                progress?.Report((totalRead, totalBytes));
            }
        }

        private string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return $"{dblSByte:0.1} {Suffix[i]}";
        }

        private void frmFileDownloader_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cts?.Cancel();
            _cts?.Dispose();
        }
    }

}
