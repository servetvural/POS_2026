using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Newtonsoft.Json;

using POSLayer.Models;

using PosLibrary;

namespace DTRMSimpleBackOffice {
    public partial class frmDistributionList : Form {
        DTRMSimpleBusiness bslayer;

        public frmDistributionList() {
            InitializeComponent();
        }
        public frmDistributionList(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }        

        private void frmDistributionList_Load(object sender, EventArgs e) {
            LoadDistributions();
        }

        private void LoadDistributions() {
            //dgv.DataSource = bslayer.db.GetDataTable("Select * from DistributionView Where ParentMenuIID ='" + bslayer.config.CurrentMenuIID + "'");
            dgv.DataSource = bslayer.db.GetDataTable("Select * from DistributionView order by ParentMenuIID, DistributionName");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmDistribution frm = new frmDistribution(bslayer, new Distribution());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadDistributions();
        }

        private async void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                Distribution distribution =await bslayer.GetDistribution(dgv.SelectedRows[0].Cells[0].Value.ToString());
                frmDistribution frm = new frmDistribution(bslayer, distribution);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadDistributions();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Not good Idea", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                if (dgv.SelectedRows.Count > 0) {
                    bslayer.DeleteDistribution(dgv.SelectedRows[0].Cells[0].Value.ToString());
                    LoadDistributions();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            //if (e.RowIndex >= 0) {
            //    switch (e.ColumnIndex) {
            //        case 9:
            //            e.CellStyle.BackColor = Color.FromArgb(int.Parse(e.Value.ToString()));
            //            break;
            //        case 10:
            //            e.CellStyle.BackColor = Color.FromArgb(int.Parse(e.Value.ToString()));
            //            break;
            //        default:
            //            break;

            //    }
            //}
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadDistributions();
        }

        private void btnPrintList_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.GenerateAsTabular(true, true, new int[] { -15, -4, -18, -10 })) {
                frmAppPrinterDialog frm = new frmAppPrinterDialog(bslayer);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    PrintHandler printer = new PrintHandler(bslayer, exporter.csvText, frm.SelectedPrinterNetworkName);
                    printer.PrintNow();
                }
            }
        }



        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Distribution> theList =await bslayer.GetDistributionList();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Distribution List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {


                        var jsonString = JsonConvert.SerializeObject(theList, Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Distribution List");
                        else
                            MessageBox.Show("Failed to Save Distribution List");
                    }
                }
            }
        }

        private void btnImportFromJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {
                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            List<Distribution> theList = JsonConvert.DeserializeObject<List<Distribution>>(content);
                            foreach (var item in theList)
                            {
                                bslayer.SaveDistribution(item);
                            }
                            MessageBox.Show("Saved Distribution List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Distribution List");
                        }
                        LoadDistributions();
                    }
                }
            }
        }
    }
}
