using POSLayer.Library;
using PosLibrary;

namespace WinLayer
{
    public partial class frmStockUsagePad : Form
    {
        PosConfig config;

        private string SupplierIID;
        private bool blnOpennedBySupplier;

        public frmStockUsagePad(PosConfig configAsService)
        {
            InitializeComponent();
            config = configAsService;
        }
        public frmStockUsagePad(PosConfig configAsService, string SupplierIID)
        {
            InitializeComponent();
            config = configAsService;
            this.SupplierIID = SupplierIID;
            if (SupplierIID != null)
                blnOpennedBySupplier = true;

        }
        private void frmStockUsagePad_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadUsage();
            if (blnOpennedBySupplier)
            {
                rbSingle.Checked = true;
                cmbSuppliers.SelectedValue = SupplierIID;
            }
        }

        private void LoadUsage()
        {
            //if (rbAll.Checked) {
            //    //if (blnUseSearch)
            //    //    dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageWithSearch(chkOrderableOnly.Checked, txtSearch.Text.Trim());
            //    //else
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsages(true);
            //} else {
            //    //if (blnUseSearch)
            //    //    dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageBySupplierWithSearch(cmbSuppliers.SelectedValue.ToString(), chkOrderableOnly.Checked, txtSearch.Text.Trim());
            //    //else
            //        dgv.DataSource =  DTRMSimpleBusiness.Instance.GetStockItemUsageBySupplier(cmbSuppliers.SelectedValue.ToString(), true);
            //}

            //for (int i = 0; i < dgv.Rows.Count; i++) {
            //    dgv.Rows[i].Cells["colqtylabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colqty"].Value.ToString()));
            //    dgv.Rows[i].Cells["colordlabel"].Value = (QuantityTypes)(int.Parse(dgv.Rows[i].Cells["colord"].Value.ToString()));
            //    dgv.Rows[i].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.trolly32;
            //    dgv.Rows[i].Cells["colStatus"].Value = 0;
            //    //dgv.Rows[i].Cells[4].Value = (System.Drawing.Image)Properties.Resources.okay;
            //}
            //vScroll.Maximum = dgv.RowCount;
            //vScroll.Visible = dgv.DisplayedRowCount(true) < dgv.Rows.Count;

            //theImage = (System.Drawing.Image)Properties.Resources.Ok_1;


        }

        private void LoadSuppliers()
        {
            cmbSuppliers.DataSource = DTRMSimpleBusiness.Instance.GetAllSuppliersAsList();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0)
                dgv.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            vScroll.Value = e.NewValue;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                trmSelectPrinter fsp = new trmSelectPrinter();
                if (fsp.ShowDialog() == DialogResult.OK)
                {

                    //if (chkViewDetails.Checked)
                    //     DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedApplicationPrinter,  DTRMSimpleBusiness.Instance.GetDataTableFromGridVisible(dgv, true, false),
                    //        "Stock Usage Report",  DTRMSimpleBusiness.Instance.GetColumnPrintRatio(dgv), false);
                    //else {
                    int[] arrcols = new int[] { 3, 6, config.GetFontMaximumCharacter(config.ReportFontSize) - 17, 8 };
                    List<int> cols = new List<int>(arrcols);
                    DTRMSimpleBusiness.Instance.PrintDataTable(await DTRMSimpleBusiness.Instance.GetPrinterForClient(fsp.ReturnValue), DRUF.GetDataTableFromGridVisible(dgv, true, false),
                           "Stock Usage Report", cols, false);
                    //}
                }
            }
        }

        private void cmbSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                cmbSuppliers.Visible = false;
            } else
            {
                cmbSuppliers.Visible = true;
            }
            LoadUsage();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = 0;
            if (rbDone.Checked)
            {
                val = int.Parse(dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value.ToString());
                if (val > 0)
                {
                    // dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value = val + 1;
                    dgv.Rows[e.RowIndex].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.Ok_1;
                    dgv.Rows[e.RowIndex].Cells["colStatus"].Value = 1;
                }
            } else if (rbPlus.Checked)
            {
                val = int.Parse(dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value.ToString());
                dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value = val + 1;
                dgv.Rows[e.RowIndex].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.Ok_1;
                dgv.Rows[e.RowIndex].Cells["colStatus"].Value = 1;
            } else if (rbMinus.Checked)
            {
                val = int.Parse(dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value.ToString());
                if (val > 0)
                {
                    dgv.Rows[e.RowIndex].Cells["OrderableQuantity"].Value = val - 1;
                    if (val > 1)
                    {
                        //alindi
                        dgv.Rows[e.RowIndex].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.Ok_1;
                        dgv.Rows[e.RowIndex].Cells["colStatus"].Value = 1;
                    } else
                    {
                        //alinmadi
                        dgv.Rows[e.RowIndex].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.cross_red_32;
                        dgv.Rows[e.RowIndex].Cells["colStatus"].Value = 0;
                    }
                }
            } else
            {
                DataGridViewImageCell cellTick = dgv.Rows[e.RowIndex].Cells[13] as DataGridViewImageCell;
                dgv.Rows[e.RowIndex].Cells["colStatusImage"].Value = theImage;
                dgv.Rows[e.RowIndex].Cells["colStatus"].Value = StatusValue;
            }
        }

        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkALL.Checked)
                chkALL.BackColor = Color.DarkGreen;
            else
                chkALL.BackColor = Color.Black;
        }

        private Image theImage = null;
        private int StatusValue = 0;

        private void rbDone_Click(object sender, EventArgs e)
        {
            if (chkALL.Checked)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.Ok_1;
                    dgv.Rows[i].Cells["colStatus"].Value = 1;
                }
                chkALL.Checked = false;
            }
        }
        private void rbDone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDone.Checked)
                theImage = (System.Drawing.Image)Properties.Resources.Ok_1;
        }

        private void rbNone_Click(object sender, EventArgs e)
        {
            if (chkALL.Checked)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells["colStatusImage"].Value = (System.Drawing.Image)Properties.Resources.cross_red_32;
                    dgv.Rows[i].Cells["colStatus"].Value = 0;
                }
                chkALL.Checked = false;
            }
        }
        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked)
                theImage = (System.Drawing.Image)Properties.Resources.cross_red_32;
        }

        private void rbPlus_Click(object sender, EventArgs e)
        {
            chkALL.Checked = false;
        }

        private void rbMinus_Click(object sender, EventArgs e)
        {
            chkALL.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                int status = int.Parse(dgv.Rows[i].Cells["colStatus"].Value.ToString());
                if (status == 1)
                {
                    string StockItemIID = dgv.Rows[i].Cells["colStockItemIID"].Value.ToString();
                    int OrderableQuantity = int.Parse(dgv.Rows[i].Cells["OrderableQuantity"].Value.ToString());
                    int Conversion = int.Parse(dgv.Rows[i].Cells["colConversion"].Value.ToString());

                    int purchasedQuantity = (OrderableQuantity * Conversion * -1);
                    DTRMSimpleBusiness.Instance.UpdateStockItemUsedQuantity(StockItemIID, purchasedQuantity);
                }

            }
            this.Close();
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadUsage();
        }

        private async void btnEmail_Click(object sender, EventArgs e)
        {
            //if ( DTRMSimpleBusiness.Instance.shop.SmtpEmailAddress != null &&  DTRMSimpleBusiness.Instance.shop.SmtpEmailAddress.Length > 0 &&  DTRMSimpleBusiness.Instance.shop.PurchaseEmail != null &&  DTRMSimpleBusiness.Instance.shop.PurchaseEmail.Length > 0)
            //     DTRMSimpleBusiness.Instance.SendEmailToCustomRecepient( DTRMSimpleBusiness.Instance.shop.PurchaseEmail,  DTRMSimpleBusiness.Instance.shop.ShopName + "  Stock Order List", "Stock Order List Attached.\r\n\r\n" + GenerateCsvFromGrid(),null);


            ////Now time to remove the ordered items from stockitem table if true
            //if (config.Delete_Stock_Usage)
            //     DTRMSimpleBusiness.Instance.RemoveOrderedStockUsage(true);
        }


        private string GenerateCsvFromGrid()
        {
            string textbody = "";
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //OrderableQuantity, colordlabel, colStockItemName, colSupplierName
                textbody += dgv.Rows[i].Cells["OrderableQuantity"].Value.ToString() + "\t" +
                dgv.Rows[i].Cells["colordlabel"].Value.ToString() + "\t" +
                dgv.Rows[i].Cells["colStockItemName"].Value.ToString() + "\t" +
                dgv.Rows[i].Cells["colSupplierName"].Value.ToString() + "\r\n";

            }
            return textbody;
        }
    }
}
