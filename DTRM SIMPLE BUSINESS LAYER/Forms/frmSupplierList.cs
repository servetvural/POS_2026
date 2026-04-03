using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMNS {
    public partial class frmSupplierList : Form
    {
        IRepository<Supplier> repoSupplier;
        Supplier selectedSupplier;

        private BindingSource _supplierSource = new BindingSource();
        public frmSupplierList()
        {
            InitializeComponent();
        }
        public frmSupplierList(IRepository<Supplier> _repoSupplier)
        {
            InitializeComponent();
            repoSupplier = _repoSupplier;
        }

        private async void frmSupplierList_Load(object sender, EventArgs e)
        {
            await LoadSuppliers();
        }

        private async Task LoadSuppliers()
        {
            _supplierSource.DataSource = await repoSupplier.GetAllAsync();
            dgv.DataSource = _supplierSource;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplier frm = ActivatorUtilities.CreateInstance<frmSupplier>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
                await LoadSuppliers();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmSupplier frm = ActivatorUtilities.CreateInstance<frmSupplier>(ServiceHelper.Services, (Supplier)dgv.SelectedRows[0].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadSuppliers();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Not good Idea. Do you still want to delete the supplier?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    await repoSupplier.Delete(((Supplier)dgv.SelectedRows[0].DataBoundItem).IID);
                }
                await LoadSuppliers();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                selectedSupplier = (Supplier)dgv.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadSuppliers();
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Supplier List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(await repoSupplier.GetAllAsync(), Newtonsoft.Json.Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Supplier List");
                        else
                            MessageBox.Show("Failed to Save Supplier List");
                    }
                }
            }
        }

        private async void btnImportFromJson_Click(object sender, EventArgs e)
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
                                await repoSupplier.Save(item);
                            }
                            MessageBox.Show("Saved Supplier List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Supplier List");
                        }
                        await LoadSuppliers();
                    }
                }
            }
        }

        private async void tsSort_Click(object sender, EventArgs e)
        {
            await repoSupplier.Sort();
            await LoadSuppliers();
        }

        private async void tsMoveUp_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoSupplier.MoveUp((Supplier)dgv.SelectedRows[0].DataBoundItem);
                await LoadSuppliers();
            }
        }

        private async void tsMoveDown_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoSupplier.MoveDown((Supplier)dgv.SelectedRows[0].DataBoundItem);
                await LoadSuppliers();
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
