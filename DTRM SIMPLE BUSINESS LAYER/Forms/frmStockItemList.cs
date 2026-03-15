using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using Newtonsoft.Json;

using POSLayer.Library;
using POSLayer.Models;

using PosLibrary;

namespace DTRMNS
{
    public partial class frmStockItemList : Form
    {
        DTRMSimpleBusiness bslayer;
        StockItem selectedStockItem;

        public frmStockItemList()
        {
            InitializeComponent();
        }
        public frmStockItemList(DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            this.bslayer = bslayer;
            rbAll.Checked = true;
        }

        private void frmStockItemList_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            PopulatePopup();
            LoadSuppliers();
            LoadStockItems();
        }

        private async Task PopulatePopup()
        {
            popSupplier.DropDownItems.Clear();
            popQuantityType.DropDownItems.Clear();
            popOrderType.DropDownItems.Clear();

            //DataTable dt = bslayer.GetAllSuppliers();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Supplier sup = new Supplier(dt.Rows[i]);
            //    ToolStripMenuItem tsi = new System.Windows.Forms.ToolStripMenuItem();
            //    tsi.Text = sup.SupplierName;
            //    tsi.Tag = sup.IID;
            //    popSupplier.DropDownItems.Add(tsi);
            //    tsi.Click += Tsi_Click;
            //}
            List<Supplier> suppliers = await bslayer.GetAllSuppliersAsList();
            foreach (var sup in suppliers)
            {
                ToolStripMenuItem tsi = new System.Windows.Forms.ToolStripMenuItem();
                tsi.Text = sup.SupplierName;
                tsi.Tag = sup.IID;
                popSupplier.DropDownItems.Add(tsi);
                tsi.Click += Tsi_Click;
            }

            for (int i = 0; i < 9; i++)
            {
                ToolStripMenuItem tsi = new System.Windows.Forms.ToolStripMenuItem();
                tsi.Text = ((QuantityTypes)i).ToString();
                tsi.Tag = i;
                popQuantityType.DropDownItems.Add(tsi);
                tsi.Click += QuantityType_Click;
            }

            for (int i = 0; i < 9; i++)
            {
                ToolStripMenuItem tsi = new System.Windows.Forms.ToolStripMenuItem();
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
                    StockItem si =await bslayer.GetStockItem(dgv.SelectedRows[i].Cells[0].Value.ToString());
                    si.SupplierIID = supIID;
                    bslayer.SaveStockItem(si);
                }
                LoadStockItems();
            }
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.DataSource = bslayer.GetAllSuppliersAsList();
        }

        private void LoadStockItems()
        {
            if (rbAll.Checked)
            {
                dgv.DataSource = bslayer.GetAllStockItems();
            } else
            {
                if (cmbSuppliers.SelectedValue != null)
                {
                    dgv.DataSource = bslayer.GetStockItemsForSupplier(cmbSuppliers.SelectedValue.ToString());
                }
            }
            PopulateRows();

        }

        private void PopulateRows()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["colqtylabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colqty"].Value.ToString()));
                dgv.Rows[i].Cells["colordlabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colord"].Value.ToString()));
            }
            vScrolldgv.Maximum = dgv.RowCount;
        }


        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
                cmbSuppliers.Visible = false;
            else
            {
                cmbSuppliers.Visible = true;
            }
            LoadStockItems();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStockItem frm = new frmStockItem(bslayer, new StockItem());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadStockItems();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                StockItem stockItem =await bslayer.GetStockItem(dgv.SelectedRows[0].Cells[0].Value.ToString());
                frmStockItem frm = new frmStockItem(bslayer, stockItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadStockItems();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Not good Idea", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    bslayer.DeleteStockItem(dgv.SelectedRows[i].Cells[0].Value.ToString(), false);
                }
                LoadStockItems();
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
                selectedStockItem =await bslayer.GetStockItem(dgv.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cmbSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadStockItems();
        }

        private async void QuantityType_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    StockItem si =await bslayer.GetStockItem(dgv.SelectedRows[i].Cells[0].Value.ToString());
                    si.QuantityType = (QuantityTypes)(int.Parse(mi.Tag.ToString()));
                    bslayer.SaveStockItem(si);
                }
                LoadStockItems();
            }
        }

        private async void OrderType_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    StockItem si =await bslayer.GetStockItem(dgv.SelectedRows[i].Cells[0].Value.ToString());
                    si.OrderType = (QuantityTypes)(int.Parse(mi.Tag.ToString()));
                    bslayer.SaveStockItem(si);
                }
                LoadStockItems();
            }
        }

        private async void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmNo frm = new frmNo();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dgv.SelectedRows.Count; i++)
                    {
                        StockItem si =await bslayer.GetStockItem(dgv.SelectedRows[i].Cells[0].Value.ToString());
                        si.Conversion = frm.val;
                        bslayer.SaveStockItem(si);
                    }
                    LoadStockItems();
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
                    if (DataGridViewCsvExporter.Export(filename, bslayer.GenerateCsvTextFromDataTable(dt)))
                    {
                        if (MessageBox.Show("Do you want to open the file?", "Export Completed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            System.Diagnostics.Process.Start(filename);
                    } else
                        MessageBox.Show("Export Failed");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                if (rbAll.Checked)
                    dgv.DataSource = bslayer.SearchStockItems(txtSearch.Text.Trim());
                else
                    dgv.DataSource = bslayer.SearchStockItems(txtSearch.Text.Trim(), cmbSuppliers.SelectedValue.ToString());
                PopulateRows();
                txtSearch.Text = "";
            } else
                LoadStockItems();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void frmStockItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                txtSearch.Focus();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void LoadUsage()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string StockItemIID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //string sql = "select IID, EntityButtonName from EntityButton where IID in (select EntityButtonIID from entitybuttonstockItemLookup where stockItemIID = '" + IID + "')";
                dgvUsage.DataSource = bslayer.GetEntityButtonStockItemRecipeFromStockItem(StockItemIID);
                //bslayer.GetDataTable(sql);

                PopulateUsageData();

                vScrolldgvUsage.Maximum = dgvUsage.RowCount;
            } else
                dgvUsage.DataSource = null;

        }

        private void PopulateUsageData()
        {
            for (int i = 0; i < dgvUsage.Rows.Count; i++)
            {
                dgvUsage.Rows[i].Cells["colQuantityTypeLabel"].Value = (QuantityTypes)(int.Parse(dgvUsage.Rows[i].Cells["colQuantityType"].Value.ToString()));
            }
        }

        private void dgvUsage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvUsage.SelectedRows.Count > 0) {
            //    string EntityButtonIID = dgvUsage.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
            //    string StockItemIID = dgvUsage.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();

            //    frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer, bslayer.GetEntityButtonStockItemLookUp(EntityButtonIID, StockItemIID));
            //    if (frm.ShowDialog() == DialogResult.OK)
            //        LoadUsage();
            //}
        }

        private void btnWideRowToggle_Click(object sender, EventArgs e)
        {
            if (dgv.RowTemplate.Height == 22)
            {
                dgv.RowTemplate.Height = 50;
            } else
            {
                dgv.RowTemplate.Height = 22;
            }
            LoadStockItems();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                frmAppPrinterDialog fsp = new frmAppPrinterDialog(bslayer);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    int[] arrcols = null;
                    List<int> cols = null;
                    if (chkIncludeSupplierInPrint.Checked)
                    {
                        arrcols = new int[] { bslayer.config.GetFontMaximumCharacter(bslayer.config.ReportFontSize) - 31, -6, 6, 6, -4, 4 };
                        cols = new List<int>(arrcols);
                    } else
                    {
                        arrcols = new int[] { bslayer.config.GetFontMaximumCharacter(bslayer.config.ReportFontSize) - 31, -6, 7, 7, -6, 0 };
                        cols = new List<int>(arrcols);
                    }

                    bslayer.PrintDataTable(fsp.SelectedApplicationPrinter, DRUF.GetDataTableFromGridVisible(dgv, true, true),
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

        private void dgv_Sorted(object sender, EventArgs e)
        {
            PopulateRows();
        }

        private void dgvUsage_Sorted(object sender, EventArgs e)
        {
            PopulateUsageData();
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<StockItem> itemList =await bslayer.GetAllStockItemsList();
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
                            List<StockItem> itemList = JsonConvert.DeserializeObject<List<StockItem>>(content);
                            foreach (StockItem item in itemList)
                            {
                                bslayer.SaveStockItem(item);
                            }
                            MessageBox.Show("Saved Stock Item List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Stock Item List");
                        }
                        LoadStockItems();
                    }
                }
            }
        }
    }
}
