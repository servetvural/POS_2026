using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

using POSLayer.Models;

namespace DTRMNS {
    public partial class frmSupplierList : Form {
        DTRMSimpleBusiness bslayer;
        Supplier selectedSupplier;
        public frmSupplierList() {
            InitializeComponent();
        }
        public frmSupplierList(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmSupplierList_Load(object sender, EventArgs e) {
            LoadSuppliers();
        }

        private void LoadSuppliers() {
            dgv.DataSource = bslayer.GetAllSuppliersAsList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmSupplier frm = new frmSupplier(bslayer, new Supplier());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadSuppliers();
        }

        private async void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                Supplier supplier =await bslayer.GetSupplier(dgv.SelectedRows[0].Cells[0].Value.ToString());
                frmSupplier frm = new frmSupplier(bslayer, supplier);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadSuppliers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Not good Idea", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                for (int i =0; i < dgv.SelectedRows.Count; i++) {
                    bslayer.DeleteSupplier(dgv.SelectedRows[i].Cells[0].Value.ToString(), false);
                }
                LoadSuppliers();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private async void btnSelect_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                selectedSupplier =await bslayer.GetSupplier(dgv.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadSuppliers();
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Supplier> itemList =await bslayer.GetAllSuppliersAsList();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Supplier List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Supplier List");
                        else
                            MessageBox.Show("Failed to Save Supplier List");
                    }
                }
            }
        }

        private void btnImportFromJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                // sfd.FileName = "Stock Item List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            List<Supplier> itemList = JsonConvert.DeserializeObject<List<Supplier>>(content);
                            foreach (Supplier item in itemList)
                            {
                                bslayer.SaveSupplier(item);
                            }
                            MessageBox.Show("Saved Supplier List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Supplier List");
                        }
                        LoadSuppliers();
                    }
                }
            }
        }
    }
}
