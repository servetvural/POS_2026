using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTRMNS;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary;
using POSWinFormLayer.Library;

namespace DTRMSimpleBackOffice {
    public partial class frmDistributionList : Form {

        DTRMSimpleBusiness bslayer;
        IRepository<Distribution> repoDistribution;

        public frmDistributionList(DTRMSimpleBusiness bslayer, IRepository<Distribution> _repoDistribution) {
            InitializeComponent();
            this.bslayer = bslayer;
            repoDistribution = _repoDistribution;
        }        

        private async void frmDistributionList_Load(object sender, EventArgs e) {
            await LoadDistributions();
        }

        private async Task LoadDistributions() {
            dgv.DataSource = (await repoDistribution.GetAllAsync("Menu, printers")).ToBindingList();     
        }

        private async void btnAdd_Click(object sender, EventArgs e) {
            frmDistribution frm = ActivatorUtilities.CreateInstance< frmDistribution>(ServiceHelper.Services, new Distribution());
            if (frm.ShowDialog() == DialogResult.OK)
              await  LoadDistributions();
        }

        private async void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                Distribution distribution =await bslayer.GetDistribution(dgv.SelectedRows[0].Cells[0].Value.ToString());
                frmDistribution frm = ActivatorUtilities.CreateInstance < frmDistribution>(ServiceHelper.Services, distribution);
                if (frm.ShowDialog() == DialogResult.OK)
                   await  LoadDistributions();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Not good Idea", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                if (dgv.SelectedRows.Count > 0) {
                   await bslayer.DeleteDistribution(dgv.SelectedRows[0].Cells[0].Value.ToString());
                   await LoadDistributions();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }

        private async void btnReload_Click(object sender, EventArgs e) {
            await LoadDistributions();
        }

        private void btnPrintList_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.GenerateAsTabular(true, true, new int[] { -15, -4, -18, -10 })) {
                frmAppPrinterDialog frm = new frmAppPrinterDialog(bslayer);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    PrintHandler printer = ActivatorUtilities.CreateInstance < PrintHandler>(ServiceHelper.Services, exporter.csvText, frm.SelectedPrinterNetworkName);
                    printer.PrintNow();
                }
            }
        }



        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Distribution> theList =await bslayer.GetAllDistributions();
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

        private async void btnImportFromJson_Click(object sender, EventArgs e)
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
                              await  bslayer.SaveDistribution(item);
                            }
                            MessageBox.Show("Saved Distribution List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Distribution List");
                        }
                       await  LoadDistributions();
                    }
                }
            }
        }
    }
}
