using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTRMNS;
using PosLibrary;
using Newtonsoft.Json;

namespace DTRMSimpleBackOffice {
    public partial class frmBonusList : Form {

        DTRMSimpleBusiness bslayer;
        public frmBonusList() {
            InitializeComponent();
        }
        public frmBonusList(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmBonusList_Load(object sender, EventArgs e) {
            LoadBonusList();
        }
        private void LoadBonusList () {
            DataTable dt = bslayer.GetAllBonus();

            for (int i = 0; i < dt.Rows.Count; i++) {
                int daysInteger = int.Parse(dt.Rows[i]["DaysAvailable"].ToString());

                dt.Rows[i]["DaysAvailableAsString"] = UF.GetBonusDaysAsString(daysInteger);
            }
            ((DataGridViewTextBoxColumn)dgv.Columns[columnName: "colDaysAvailableAsString"]).DataPropertyName = "DaysAvailableAsString";
            dgv.DataSource = dt;

           
            
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmBonus frm = new frmBonus(bslayer, new Bonus());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadBonusList();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                Bonus bonus = bslayer.GetBonus(dgv.SelectedRows[0].Cells[0].Value.ToString());
                frmBonus frm = new frmBonus(bslayer, bonus);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadBonusList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will delete Bonus Plan", "Delete Bonus Plan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                if (dgv.SelectedRows.Count > 0) {
                    bslayer.DeleteBonus(dgv.SelectedRows[0].Cells[0].Value.ToString());
                    LoadBonusList();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadBonusList();
        }

        private void bar1_ItemClick(object sender, EventArgs e) {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }

        private void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Bonus> itemList = bslayer.GetAllBonusList();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Bonus List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Bonus List");
                        else
                            MessageBox.Show("Failed to Save Bonus List");
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
                            List<Bonus> itemList = JsonConvert.DeserializeObject<List<Bonus>>(content);
                            foreach (Bonus item in itemList)
                            {
                                bslayer.SaveBonus(item);
                            }
                            MessageBox.Show("Saved Bonus List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Bonus List");
                        }
                        LoadBonusList();
                    }
                }
            }
        }
    }
}
