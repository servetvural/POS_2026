using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

using PosLibrary;

namespace DTRMNS
{
    public partial class frmStockItemUsage : Form
    {
        PosConfig config;

        private Stack<UndoItem> undoList;
        private bool blnUseSearch;
        public frmStockItemUsage()
        {
            InitializeComponent();
        }
        public frmStockItemUsage(PosConfig configAsService)
        {
            InitializeComponent();
            config = configAsService;
            this.undoList = new Stack<UndoItem>();
        }
        private void frmStockItemUsage_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadUsage();
        }
        private void LoadUsage()
        {
            //if (rbAll.Checked) {
            //    if (blnUseSearch)
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageWithSearch(chkOrderableOnly.Checked, txtSearch.Text.Trim());
            //    else
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsages(chkOrderableOnly.Checked);
            //} else {
            //    if (blnUseSearch)
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageBySupplierWithSearch(cmbSuppliers.SelectedValue.ToString(), chkOrderableOnly.Checked, txtSearch.Text.Trim());
            //    else
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageBySupplier(cmbSuppliers.SelectedValue.ToString(), chkOrderableOnly.Checked);
            //}

            //PopulateUsage();
            //blnUseSearch = false;
            //vScroll.Maximum = dgv.RowCount;
        }

        private void PopulateUsage()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["colqtylabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colqty"].Value.ToString()));
                dgv.Rows[i].Cells["colordlabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colord"].Value.ToString()));
            }
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.DataSource = DTRMSimpleBusiness.Instance.GetAllSuppliersAsList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    //  DTRMSimpleBusiness.Instance.PrintStockUsage(fsp.SelectedPrinterIID,  DTRMSimpleBusiness.Instance.GetDataTableFromGridVisible(dgv, true));
                    if (chkViewDetails.Checked)
                        DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedPrinter, DRUF.GetDataTableFromGridVisible(dgv, true, false),
                            "Stock Usage Report", DTRMSimpleBusiness.Instance.GetColumnPrintRatio(dgv), false);
                    else
                    {
                        int[] arrcols = new int[] { 3, 6, config.GetFontMaximumCharacter(config.ReportFontSize) - 21, 8 };
                        List<int> cols = new List<int>(arrcols);
                        DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedPrinter, DRUF.GetDataTableFromGridVisible(dgv, true, false),
                           "Stock Usage Report", cols, false);
                    }


                }
            }




            //    if (rbSingle.Checked)
            //     DTRMSimpleBusiness.Instance.PrintStockUsage( DTRMSimpleBusiness.Instance.GetDataTableFromGridVisible(dgv,true),
            //         DTRMSimpleBusiness.Instance.GetSupplier(cmbSuppliers.SelectedValue.ToString()).SupplierName);
            //else 
            //     DTRMSimpleBusiness.Instance.PrintStockUsage( DTRMSimpleBusiness.Instance.GetDataTableFromGridVisible(dgv, true), null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                cmbSuppliers.Visible = false;
                pnlTop.Height = 47;
            } else
            {
                cmbSuppliers.Visible = true;
                pnlTop.Height = 92;
            }
            LoadUsage();
        }

        private void cmbSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void chkOrderableOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void chkViewDetails_CheckedChanged(object sender, EventArgs e)
        {
            dgv.Columns["SessionQuantity"].Visible = dgv.Columns["XSessionQuantity"].Visible = dgv.Columns["PreviousQuantity"].Visible = dgv.Columns["TotalQuantity"].Visible = dgv.Columns["colqtylabel"].Visible = chkViewDetails.Checked;
        }

        private void btnIncrementUsage_Click(object sender, EventArgs e)
        {
            // DTRMSimpleBusiness.Instance.TransferStockItemUsageNow( DTRMSimpleBusiness.Instance.config.Stock_Usage_Incremental);
            //LoadUsage();
        }

        private void btnExportAsCsv_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                DataTable dt = DRUF.GetDataTableFromGridVisible(dgv, true, false);

                SaveFileDialog dlg = new SaveFileDialog();

                //dlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                dlg.Filter = "csv files (*.csv)|*.csv";
                //dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;
                dlg.FileName = "Purchase list for " + DateTime.Now.ToString("dd MM yyyy HH_mm") + ".csv";

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


        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string StockItemIID = dgv.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();
                frmStockItem frm = ActivatorUtilities.CreateInstance<frmStockItem>(ServiceHelper.Services, await DTRMSimpleBusiness.Instance.GetStockItem(StockItemIID));
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadUsage();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                PurchaseClicked();
        }

        private async void PurchaseClicked()
        {
            //if (dgv.SelectedRows.Count > 0) {
            //    string StockItemIID = dgv.SelectedRows[0].Cells["colStockItemIID"].Value.ToString();
            //    StockItemUsage stockitemusage =await  DTRMSimpleBusiness.Instance.GetSingleStockItemUsageAsObject(StockItemIID);
            //    if (stockitemusage != null) {
            //        frmPurchase frm = new frmPurchase(bslayer, stockitemusage);
            //        if (frm.ShowDialog() == DialogResult.OK) {
            //            //Apply changes and reload
            //            undoList.Push(new UndoItem() { 
            //                IID = StockItemIID,
            //                Quantity = frm.sentQuantity,
            //                blnConverted = true 
            //            });
            //            LoadUsage();
            //            btnUndo.Enabled = undoList.Count > 0;
            //        }
            //    }

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
            LoadUsage();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Remove the last action from the done list
            UndoItem item = undoList.Pop();
            if (item != null)
            {
                if (item.blnConverted)
                    // DTRMSimpleBusiness.Instance.BifileStockItem(item.IID, item.Quantity);
                    DTRMSimpleBusiness.Instance.UpdateStockItemUsedQuantity(item.IID, item.Quantity * -1);
                else
                    DTRMSimpleBusiness.Instance.BifileStockItem(item.IID, item.Quantity * -1);
                //if ( DTRMSimpleBusiness.Instance.UpdateStockItemUsedQuantity(item.IID,item.Quantity * -1)) 
                LoadUsage();
                btnUndo.Enabled = undoList.Count > 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                blnUseSearch = true;
            }
            LoadUsage();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStockItem frm = ActivatorUtilities.CreateInstance<frmStockItem>(ServiceHelper.Services, new StockItem());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadUsage();
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            vScroll.Value = e.NewValue;
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0)
                dgv.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgv_Sorted(object sender, EventArgs e)
        {
            PopulateUsage();
        }


        private async void btnBoughtAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                int Qty = int.Parse(dgv.Rows[i].Cells["colOrderableQuantity"].Value.ToString());
                string StockItemIID = dgv.Rows[i].Cells["colStockItemIID"].Value.ToString();
                if (await DTRMSimpleBusiness.Instance.BifileStockItem(StockItemIID, Qty))
                {
                    undoList.Push(new UndoItem()
                    {
                        IID = StockItemIID,
                        Quantity = Qty,
                        blnConverted = false
                    });
                }
            }
            btnUndo.Enabled = undoList.Count > 0;
            LoadUsage();
        }
    }
}
