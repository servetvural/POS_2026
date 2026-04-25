using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary;
using WinLayer;

namespace BSLayer
{
    public partial class frmStockItemList : Form
    {
        PosConfig config;
        IRepository<Supplier> repoSupplier;
        IRepository<StockItem> repoStockItem;
        IRepository<StockItemUsage> repoStockItemUsage;
        public StockItem selectedStockItem;

        private BindingSource _supplierSource = new BindingSource();
        private BindingSource _stockItemSource = new BindingSource();
        private BindingSource _usageSource = new BindingSource();
        public frmStockItemList()
        {
            InitializeComponent();
        }
        public frmStockItemList(PosConfig configAsService, IRepository<Supplier> _repoSupplier, IRepository<StockItem> _repoStockItem,
            IRepository<StockItemUsage> _repoStockItemUsage)
        {
            InitializeComponent();
            config = configAsService;
            repoSupplier = _repoSupplier;
            repoStockItem = _repoStockItem;
            repoStockItemUsage = _repoStockItemUsage;
            rbAll.Checked = true;
        }

        private void frmStockItemList_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private async void LoadAll()
        {
            dgv.AutoGenerateColumns = false;
            await PopulatePopup();
            await LoadSuppliers();
            await LoadStockItems();

            await FormatStockItemGrid();
        }

        private async Task PopulatePopup()
        {
            popSupplier.DropDownItems.Clear();
            popQuantityType.DropDownItems.Clear();
            popOrderType.DropDownItems.Clear();

            List<Supplier> suppliers = await repoSupplier.GetAllAsync();
            foreach (var sup in suppliers)
            {
                ToolStripMenuItem tsi = new ToolStripMenuItem();
                tsi.Text = sup.SupplierName;
                tsi.Tag = sup.IID;
                popSupplier.DropDownItems.Add(tsi);
                tsi.Click += Tsi_Click;
            }

            for (int i = 0; i < 9; i++)
            {
                ToolStripMenuItem tsi = new ToolStripMenuItem();
                tsi.Text = ((QuantityTypes)i).ToString();
                tsi.Tag = i;
                popQuantityType.DropDownItems.Add(tsi);
                tsi.Click += QuantityType_Click;
            }

            for (int i = 0; i < 9; i++)
            {
                ToolStripMenuItem tsi = new ToolStripMenuItem();
                tsi.Text = ((QuantityTypes)i).ToString();
                tsi.Tag = i;
                popOrderType.DropDownItems.Add(tsi);
                tsi.Click += OrderType_Click;
            }
        }

        private async void Tsi_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ToolStripMenuItem tsi = (ToolStripMenuItem)sender;
                string supIID = tsi.Tag.ToString();
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    StockItem si = _stockItemSource.Current as StockItem;
                    si.SupplierIID = supIID;
                    await repoStockItem.Save(si);
                }
                await LoadStockItems();
            }
        }

        private async Task LoadSuppliers()
        {
            _supplierSource.DataSource = (await repoSupplier.GetAllAsync()).ToBindingList();
            cmbSuppliers.DataSource = _supplierSource;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "IID";
        }

        private async Task LoadStockItems()
        {
            if (rbAll.Checked)
            {
                _stockItemSource.DataSource = (await repoStockItem.GetAllAsync("Supplier")).ToBindingList();
                dgv.DataSource = _stockItemSource;
            } else
            {
                if (cmbSuppliers.SelectedValue != null)
                {
                    _stockItemSource.DataSource = (await repoStockItem.GetListByField("SupplierIID", cmbSuppliers.SelectedValue.ToString(), "Supplier")).ToBindingList();
                    dgv.DataSource = _stockItemSource;
                } else
                    _stockItemSource.DataSource = null;
            }
        }

        private async void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
                cmbSuppliers.Visible = false;
            else
            {
                cmbSuppliers.Visible = true;
            }
            await LoadStockItems();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            frmStockItem frm = ActivatorUtilities.CreateInstance<frmStockItem>(ServiceHelper.Services, new StockItem());
            if (frm.ShowDialog() == DialogResult.OK)
                await LoadStockItems();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                frmStockItem frm = ActivatorUtilities.CreateInstance<frmStockItem>(ServiceHelper.Services, selectedStockItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadStockItems();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                if (MessageBox.Show("Not good Idea", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    await repoStockItem.Delete(selectedStockItem.IID);
                    await LoadStockItems();
                }
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


        private async void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private async void cmbSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadStockItems();
        }

        private async void QuantityType_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                selectedStockItem.QuantityType = (QuantityTypes)(int.Parse(mi.Tag.ToString()));
                await repoStockItem.Save(selectedStockItem);
                await LoadStockItems();
            }
        }

        private async void OrderType_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                selectedStockItem.OrderType = (QuantityTypes)(int.Parse(mi.Tag.ToString()));
                await repoStockItem.Save(selectedStockItem);
                await LoadStockItems();
            }
        }

        private async void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                frmNo frm = new frmNo();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedStockItem.Conversion = frm.val;
                    await repoStockItem.Save(selectedStockItem);
                    await LoadStockItems();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btnExportAsCsv_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                DataTable dt = DRUF.GetDataTableFromGridVisible(dgv, true, false);

                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = dlg.FileName.EndsWith(".csv") ? dlg.FileName : dlg.FileName + ".csv";
                    if (DataGridViewCsvExporter.Export(filename, DTRMSimpleBusiness.Instance.GenerateCsvTextFromDataTable(dt)))
                    {
                        if (MessageBox.Show("Do you want to open the file?", "Export Completed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            System.Diagnostics.Process.Start(filename);
                    } else
                        MessageBox.Show("Export Failed");
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                // Filter by exact match
                //myBindingSource.Filter = "SupplierName = 'ACME Corp'";

                if (rbAll.Checked)
                    // Filter using 'LIKE' for partial matches (search as you type)
                    _stockItemSource.Filter = string.Format("StockName LIKE '%{0}%'", txtSearch.Text.Trim());

                //  dgv.DataSource =  DTRMSimpleBusiness.Instance.SearchStockItems(txtSearch.Text.Trim());
                else
                {
                    _stockItemSource.Filter = string.Format("StockName LIKE '%{0}%' and SupplierIID = '{1}", txtSearch.Text.Trim(), cmbSuppliers.SelectedItem);
                    // dgv.DataSource =  DTRMSimpleBusiness.Instance.SearchStockItems(txtSearch.Text.Trim(), cmbSuppliers.SelectedValue.ToString());

                }
                txtSearch.Text = "";
            } else
            {
                _stockItemSource.Filter = null;
                await LoadStockItems();
            }
        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void frmStockItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                txtSearch.Focus();
        }

        private async void dgv_SelectionChanged(object sender, EventArgs e)
        {
            selectedStockItem = (StockItem)_stockItemSource.Current;
            if (selectedStockItem != null)
            {
                GenericImage gim = await repoStockItem.GetImageAsync(selectedStockItem.IID);
                if (gim != null && gim.DisplayImage != null)
                {
                    pBox.Image = UFWin.ByteArrayToImage(gim.DisplayImage);
                    btnSample.Image = UFWin.ReSizeImageTo(pBox.Image, 60, 50, true);
                } else
                {
                    pBox.Image = null;
                    btnSample.Image = null;
                }
                await LoadUsage();
            }


        }

        private void btnSample_Paint(object sender, PaintEventArgs e)
        {
            // Draw a solid red border around the button's content area
            ControlPaint.DrawBorder(e.Graphics, btnSample.ContentRectangle,
                Color.Black, ButtonBorderStyle.Solid);
        }
        private async Task LoadUsage()
        {
            if (selectedStockItem != null)
            {

                // string StockItemIID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                // dgvUsage.DataSource =  DTRMSimpleBusiness.Instance.GetEntityButtonStockItemRecipeFromStockItem(selectedStockItem.IID);

                _usageSource.DataSource = await repoStockItemUsage.GetListByField("StockItemIID", selectedStockItem.IID, "CategoryItem,StockItem");
                dgvUsage.DataSource = _usageSource;

                //  vScrolldgvUsage.Maximum = dgvUsage.RowCount;
            } else
                dgvUsage.DataSource = null;

        }


        private void dgvUsage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvUsage.SelectedRows.Count > 0) {
            //    string EntityButtonIID = dgvUsage.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
            //    string StockItemIID = dgvUsage.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();

            //    frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer,  DTRMSimpleBusiness.Instance.GetEntityButtonStockItemLookUp(EntityButtonIID, StockItemIID));
            //    if (frm.ShowDialog() == DialogResult.OK)
            //        LoadUsage();
            //}
        }

        private async void btnWideRowToggle_Click(object sender, EventArgs e)
        {
            if (dgv.RowTemplate.Height == 22)
            {
                dgv.RowTemplate.Height = 50;
            } else
            {
                dgv.RowTemplate.Height = 22;
            }
            await LoadStockItems();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    int[] arrcols = null;
                    List<int> cols = null;
                    if (chkIncludeSupplierInPrint.Checked)
                    {
                        arrcols = new int[] { config.GetFontMaximumCharacter(config.ReportFontSize) - 31, -6, 6, 6, -4, 4 };
                        cols = new List<int>(arrcols);
                    } else
                    {
                        arrcols = new int[] { config.GetFontMaximumCharacter(config.ReportFontSize) - 31, -6, 7, 7, -6, 0 };
                        cols = new List<int>(arrcols);
                    }

                    DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedPrinter, DRUF.GetDataTableFromGridVisible(dgv, true, true),
                       "Stock Items Report " + DateTime.Now.ToString("dd MM yyyy HH:mm"), cols, true);
                }
            }
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            vScrolldgv.Value = e.NewValue;
        }

        private void vScrolldgv_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0)
                dgv.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dgvUsage_Scroll(object sender, ScrollEventArgs e)
        {
            vScrolldgvUsage.Value = e.NewValue;
        }

        private void vScrolldgvUsage_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0)
                dgvUsage.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<StockItem> itemList = await repoStockItem.GetAllAsync();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Stock Item List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Stock Item List");
                        else
                            MessageBox.Show("Failed to Save Stock Item List");
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
                            List<StockItem> itemList = JsonConvert.DeserializeObject<List<StockItem>>(content);
                            foreach (StockItem item in itemList)
                            {
                                await repoStockItem.Save(item);
                            }
                            MessageBox.Show("Saved Stock Item List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Stock Item List");
                        }
                        await LoadStockItems();
                    }
                }
            }
        }

        async Task FormatStockItemGrid()
        {
            dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "StockName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 250; c.HeaderText = "Stock Item"; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "QuantityType").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "OrderType").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Conversion").ToList().ForEach(c => { c.Width = 100; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "SupplierName").ToList().ForEach(c => { c.Width = 250; c.HeaderText = "Supplier"; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "UsedQuantity").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DOrder").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            pBox.Visible = !pBox.Visible;
        }

        private async void tsSort_Click(object sender, EventArgs e)
        {
            await repoStockItem.Sort();
            await LoadStockItems();
        }
        private async void tsMoveUp_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoStockItem.MoveUp((StockItem)dgv.SelectedRows[0].DataBoundItem);
                await LoadStockItems();
            }
        }
        private async void tsMoveDown_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoStockItem.MoveDown((StockItem)dgv.SelectedRows[0].DataBoundItem);
                await LoadStockItems();
            }
        }


    }
}
