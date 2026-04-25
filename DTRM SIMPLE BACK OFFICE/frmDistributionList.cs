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

namespace POSOffice
{
    public partial class frmDistributionList : Form
    {
        IRepository<TheMenu> repoMenu;
        IRepository<Distribution> repoDistribution;

        private BindingSource _menuSource = new BindingSource();
        private BindingSource _distributionSource = new BindingSource();
        public frmDistributionList(IRepository<Distribution> _repoDistribution, IRepository<TheMenu> _repoMenu)
        {
            InitializeComponent();
            repoMenu = _repoMenu;
            repoDistribution = _repoDistribution;
        }

        private async void frmDistributionList_Load(object sender, EventArgs e)
        {
            await LoadMenus();
            await LoadDistributions();
        }
        private async Task LoadMenus()
        {
            _menuSource.DataSource = (await repoMenu.GetAllAsync()).ToBindingList();
            cmbMenu.DataSource = _menuSource;
            cmbMenu.DisplayMember = "MenuName";
        }

        private async Task LoadDistributions(bool blnSort = false)
        {
            if (chkAllMenus.Checked)
            {
                if (blnSort)
                    _distributionSource.DataSource = (await repoDistribution.GetAllAsync("Menu, DistributionPrinters.Printer")).ReOrder().ToBindingList();
                else
                    _distributionSource.DataSource = (await repoDistribution.GetAllAsync("Menu, DistributionPrinters.Printer")).ToBindingList();
            } else
            {
                if (cmbMenu.SelectedItem != null)
                {
                    TheMenu menu = (TheMenu)cmbMenu.SelectedItem;
                    _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID", menu.IID, "Menu, DistributionPrinters.Printer")).ToBindingList();
                }
            }
            dgv.DataSource = _distributionSource;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            frmDistribution frm = ActivatorUtilities.CreateInstance<frmDistribution>(ServiceHelper.Services, new Distribution() { DOrder = dgv.Rows.Count + 1} );
            if (frm.ShowDialog() == DialogResult.OK)
                await LoadDistributions();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmDistribution frm = ActivatorUtilities.CreateInstance<frmDistribution>(ServiceHelper.Services, (Distribution)dgv.SelectedRows[0].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadDistributions();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Not a good Idea. Do you want to continue to delete?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    await repoDistribution.Delete(((Distribution)dgv.SelectedRows[0].DataBoundItem).IID);
                    await LoadDistributions();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadDistributions();
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.GenerateAsTabular(true, true, new int[] { -15, -4, -18, -10 }))
            {
                frmAppPrinterDialog frm = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PrintHandler printer = ActivatorUtilities.CreateInstance<PrintHandler>(ServiceHelper.Services, exporter.csvText, frm.SelectedPrinterNetworkName);
                    printer.PrintNow();
                }
            }
        }



        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Distribution> theList = await repoDistribution.GetAllAsync("Menu, DistributionPrinters.Printer");
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
                                await repoDistribution.Save(item);
                            }
                            MessageBox.Show("Saved Distribution List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Distribution List");
                        }
                        await LoadDistributions();
                    }
                }
            }
        }

        private async void tsSort_Click(object sender, EventArgs e)
        {
            await repoDistribution.Sort();
            await LoadDistributions();
        }

        private async void tsMoveUp_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoDistribution.MoveUp((Distribution)dgv.SelectedRows[0].DataBoundItem);
                await LoadDistributions();
            }
        }

        private async void tsMoveDown_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoDistribution.MoveDown((Distribution)dgv.SelectedRows[0].DataBoundItem);
                await LoadDistributions();
            }
        }

        private async void chkAllMenus_CheckedChanged(object sender, EventArgs e)
        {
            cmbMenu.Enabled = !chkAllMenus.Checked;
            await LoadDistributions();
        }

        private async void cmbMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadDistributions();
        }
    }
}
