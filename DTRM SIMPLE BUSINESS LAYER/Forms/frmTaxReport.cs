using System;
using System.Data;
using System.Windows.Forms;

using System.IO;
using PosLibrary;

namespace DTRMNS {
    public partial class frmTaxReport : Form {
        private DTRMSimpleBusiness bslayer;
        private DataSet  dsReport;

        DateTime FirstStartDate;
        DateTime LastEndDate;

        public frmTaxReport(DTRMSimpleBusiness bslayer, DateTime FirstStartDate, DateTime LastEndDate) { // DataSet dsReport) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.FirstStartDate = FirstStartDate;
            this.LastEndDate = LastEndDate;
            
        }

        private void frmTaxReport_Load(object sender, EventArgs e) {
            Reload();
        }

        public void Reload()
        {
            this.dsReport = bslayer.GetTaxSummaryReport(FirstStartDate, LastEndDate);
            dgvDaily.DataSource = dsReport.Tables["Daily"];
            dgvPercent.DataSource = dsReport.Tables["Percent"];
            for (int i = 0; i < dgvPercent.Rows.Count; i++)
            {
                dgvPercent.Rows[i].Cells[1].Value = "Sum of % ";
            }

            dgvSum.DataSource = dsReport.Tables["Sum"];
            if (dgvSum.Rows.Count > 0)
            {
                dgvSum.Rows[0].Cells[1].Value = "Total";
            }
        }

        public string GenerateFileName() {
            DateTime startDate = DateTime.Parse(dgvDaily.Rows[0].Cells["colDailyStartDate"].Value.ToString());
            DateTime endDate = DateTime.Parse(dgvDaily.Rows[dgvDaily.Rows.Count - 1].Cells["colDailyEndDate"].Value.ToString());
            return GenerateFileName(startDate, endDate, "csv");
        }

        public string GenerateFileName(DateTime startDate, DateTime endDate, string extention) {
            return startDate.ToString("yyyyMMdd_HHmmss") + "_to_" + endDate.ToString("yyyyMMdd_HHmmss") + "." + extention;
        }

        private void btnArcExportToCsv_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDaily);
            
            exporter.Generate(true, true,";");
            exporter.NewLine();

            exporter.ResetDataGridView(dgvPercent);
            exporter.Generate(false, true, ";");
            exporter.NewLine();

            exporter.ResetDataGridView(dgvSum);
            exporter.Generate(false, true, ";");

            string filename =  GenerateFileName();
            if (exporter.Export(Path.Combine("CustomReports",filename)))
                MessageBox.Show("File saved CustomReports directory on memory stick as " + filename);
            else
                MessageBox.Show("Failed to save report");

        }

        private async  void btnArcEmailAsCsv_Click(object sender, EventArgs e) {
            POSLayer.Models.Luv luv = await bslayer.GetLuv();
            if (luv.NotificationEmail == "") {
                MessageBox.Show("There is no valid email address to send");
                return;
            }

            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgvDaily);
            exporter.Generate(true, true, ";");
            exporter.NewLine();

            exporter.ResetDataGridView(dgvPercent);
            exporter.Generate(false, true, ";");
            exporter.NewLine();

            exporter.ResetDataGridView(dgvSum);
            exporter.Generate(false, true, ";");

            //frmInputForm frm = new frmInputForm("Recepient email address");
            //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {                
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(exporter.csvText);
            writer.Flush();
            stream.Position = 0;
            if (bslayer.SendEmailToCustomRecepient(luv.NotificationEmail, "Tax Report ", "", new System.Net.Mail.Attachment(stream, GenerateFileName(), "text/csv")))
                MessageBox.Show("Email Sent");

            //}            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
