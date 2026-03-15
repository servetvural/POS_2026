using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using POSLayer.Library;

using PosLibrary;

namespace DTRMNS {
    public partial class frmStockItemUsage : Form {
        private DTRMSimpleBusiness bslayer;
        
        private Stack<UndoItem> undoList;
        private bool blnUseSearch;
        public frmStockItemUsage() {
            InitializeComponent();
        }
        public frmStockItemUsage(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.undoList = new Stack<UndoItem>();
        }
        private void frmStockItemUsage_Load(object sender, EventArgs e) {
            LoadSuppliers();
            LoadUsage();
        }
        private void LoadUsage() {
            if (rbAll.Checked) {
                if (blnUseSearch)
                    dgv.DataSource = bslayer.GetStockItemUsageWithSearch(chkOrderableOnly.Checked, txtSearch.Text.Trim());
                else
                    dgv.DataSource = bslayer.GetStockItemUsage(chkOrderableOnly.Checked);
            } else {
                if (blnUseSearch)
                    dgv.DataSource = bslayer.GetStockItemUsageBySupplierWithSearch(cmbSuppliers.SelectedValue.ToString(), chkOrderableOnly.Checked, txtSearch.Text.Trim());
                else
                    dgv.DataSource = bslayer.GetStockItemUsageBySupplier(cmbSuppliers.SelectedValue.ToString(), chkOrderableOnly.Checked);
            }

            PopulateUsage();
            blnUseSearch = false;
            vScroll.Maximum = dgv.RowCount;
        }

        private void PopulateUsage() {
            for (int i = 0; i < dgv.Rows.Count; i++) {
                dgv.Rows[i].Cells["colqtylabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colqty"].Value.ToString()));
                dgv.Rows[i].Cells["colordlabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colord"].Value.ToString()));
            }
        }

        private void LoadSuppliers() {
            cmbSuppliers.DataSource = bslayer.GetAllSuppliersAsList();
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            if (dgv.Rows.Count > 0) {
                frmAppPrinterDialog fsp = new frmAppPrinterDialog(bslayer);
                if (fsp.ShowDialog() == DialogResult.OK) {
                    // bslayer.PrintStockUsage(fsp.SelectedPrinterIID, bslayer.GetDataTableFromGridVisible(dgv, true));
                    if (chkViewDetails.Checked)
                        bslayer.PrintDataTable(fsp.SelectedApplicationPrinter, DRUF.GetDataTableFromGridVisible(dgv, true,false),
                            "Stock Usage Report", bslayer.GetColumnPrintRatio(dgv),false);
                    else {
                        int[] arrcols = new int[] { 3, 6, bslayer.config.GetFontMaximumCharacter(bslayer.config.ReportFontSize) - 21, 8 };
                        List<int> cols = new List<int>(arrcols);
                        bslayer.PrintDataTable(fsp.SelectedApplicationPrinter, DRUF.GetDataTableFromGridVisible(dgv, true,false),
                           "Stock Usage Report",cols,false);
                    }


                }
            }




            //    if (rbSingle.Checked)
            //    bslayer.PrintStockUsage(bslayer.GetDataTableFromGridVisible(dgv,true),
            //        bslayer.GetSupplier(cmbSuppliers.SelectedValue.ToString()).SupplierName);
            //else 
            //    bslayer.PrintStockUsage(bslayer.GetDataTableFromGridVisible(dgv, true), null);
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            LoadUsage();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e) {
            if (rbAll.Checked) {
                cmbSuppliers.Visible = false;
                pnlTop.Height = 47;
            } else {
                cmbSuppliers.Visible = true;
                pnlTop.Height = 92;
            }
            LoadUsage();
        }

        private void cmbSuppliers_SelectionChangeCommitted(object sender, EventArgs e) {
            LoadUsage();
        }

        private void chkOrderableOnly_CheckedChanged(object sender, EventArgs e) {
            LoadUsage();
        }

        private void chkViewDetails_CheckedChanged(object sender, EventArgs e) {
            dgv.Columns["SessionQuantity"].Visible = dgv.Columns["XSessionQuantity"].Visible = dgv.Columns["PreviousQuantity"].Visible = dgv.Columns["TotalQuantity"].Visible = dgv.Columns["colqtylabel"].Visible = chkViewDetails.Checked;
        }

        private void btnIncrementUsage_Click(object sender, EventArgs e) {
            //bslayer.TransferStockItemUsageNow(bslayer.config.Stock_Usage_Incremental);
            //LoadUsage();
        }

        private void btnExportAsCsv_Click(object sender, EventArgs e) {
            if (dgv.DataSource != null) {
                DataTable dt = DRUF.GetDataTableFromGridVisible(dgv,true,false);
                    
                SaveFileDialog dlg = new SaveFileDialog();

                //dlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                dlg.Filter = "csv files (*.csv)|*.csv";
                //dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;
                dlg.FileName = "Purchase list for " + DateTime.Now.ToString("dd MM yyyy HH_mm") + ".csv";

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    string filename = dlg.FileName.EndsWith(".csv") ? dlg.FileName : dlg.FileName + ".csv";
                    if (DataGridViewCsvExporter.Export(filename, bslayer.GenerateCsvTextFromDataTable(dt))) {
                        if (MessageBox.Show("Do you want to open the file?", "Export Completed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            System.Diagnostics.Process.Start(filename);
                    }
                       
                    else
                        MessageBox.Show("Export Failed");
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e) {
           if (dgv.SelectedRows.Count > 0) {
                string StockItemIID = dgv.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();
                frmStockItem frm = new frmStockItem(bslayer, bslayer.GetStockItem(StockItemIID));
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadUsage();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0)
                PurchaseClicked();
        }

        private void PurchaseClicked() { 
            if (dgv.SelectedRows.Count > 0) {
                string StockItemIID = dgv.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();
                StockItemUsage stockitemusage = bslayer.GetSingleStockItemUsageAsObject(StockItemIID);
                if (stockitemusage != null) {
                    frmPurchase frm = new frmPurchase(bslayer, stockitemusage);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        //Apply changes and reload
                        undoList.Push(new UndoItem(StockItemIID, frm.sentQuantity,true));
                        LoadUsage();
                        btnUndo.Enabled = undoList.Count > 0;
                    }
                }

            }
        }

        private void btnWideRowToggle_Click(object sender, EventArgs e) {
            if (dgv.RowTemplate.Height == 22) {
                dgv.RowTemplate.Height = 50;
            } else {
                dgv.RowTemplate.Height = 22;
            }
            LoadUsage();
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            //Remove the last action from the done list
            UndoItem item =  undoList.Pop();
            if (item != null) {
                if (item.blnConverted)
                    //bslayer.BifileStockItem(item.IID, item.Quantity);
                    bslayer.UpdateStockItemUsedQuantity(item.IID, item.Quantity * -1);
                else
                    bslayer.BifileStockItem(item.IID, item.Quantity * -1);
                //if (bslayer.UpdateStockItemUsedQuantity(item.IID,item.Quantity * -1)) 
                LoadUsage();
                btnUndo.Enabled = undoList.Count > 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtSearch.Text.Length > 0) {
                blnUseSearch = true;
            }
            LoadUsage();            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmStockItem frm = new frmStockItem(bslayer, new StockItem());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadUsage();
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e) {
            vScroll.Value = e.NewValue;
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e) {
            if (e.NewValue >= 0)
            dgv.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgv_Sorted(object sender, EventArgs e) {
            PopulateUsage();
        }


        private void btnBoughtAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgv.Rows.Count; i++) {
                int Qty = int.Parse(dgv.Rows[i].Cells["colOrderableQuantity"].Value.ToString());
                string StockItemIID = dgv.Rows[i].Cells["colStockItemIID"].Value.ToString();
                if (bslayer.BifileStockItem(StockItemIID, Qty)) {
                    undoList.Push(new UndoItem(StockItemIID, Qty, false));


                }

            }
            btnUndo.Enabled = undoList.Count > 0;
            LoadUsage();
        }
    }
}
