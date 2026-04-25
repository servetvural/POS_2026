using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTRMNS;
using PosLibrary;
using Newtonsoft.Json;

using POSLayer.Models;
using System.Threading.Tasks;
using POSLayer.Library;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace POSOffice {
    public partial class frmBonusList : Form {
        IRepository<Bonus> repoBonus;

        public frmBonusList() {
            InitializeComponent();
        }
        public frmBonusList(IRepository<Bonus> _repoBonus ) {
            InitializeComponent();
            repoBonus = _repoBonus;
        }

        private void frmBonusList_Load(object sender, EventArgs e) {
            LoadBonusList();
        }
        private async void LoadBonusList () {
            dgv.DataSource = await repoBonus.GetAllAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmBonus frm =new frmBonus(new Bonus());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadBonusList();
        }

        private async void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                Bonus bonus = dgv.SelectedRows[0].DataBoundItem as Bonus;
                frmBonus frm = new frmBonus(bonus);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadBonusList();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will delete Bonus Plan", "Delete Bonus Plan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                if (dgv.SelectedRows.Count > 0) {
                    await repoBonus.Delete(dgv.SelectedRows[0].DataBoundItem as Bonus);
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

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Bonus> itemList = await repoBonus.GetAllAsync();
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
                            List<Bonus> itemList = JsonConvert.DeserializeObject<List<Bonus>>(content);
                            foreach (Bonus item in itemList)
                            {
                               await repoBonus.Save(item);
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
