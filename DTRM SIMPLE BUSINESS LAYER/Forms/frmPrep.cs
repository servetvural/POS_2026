using System;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmPrep : Form {
        private DTRMSimpleBusiness bslayer;
        private KitchenOrder korder;
        public PrepDialogReturnTypes prepResult;
        public frmPrep() {
            InitializeComponent();
        }
        public frmPrep(DTRMSimpleBusiness bslayer, KitchenOrder korder) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.korder = korder;
           
        }
        private void frmPrep_Load(object sender, EventArgs e) {
            LoadPrep();
            btnHold.Visible = bslayer.config.Prep_Can_Hold;
            btnCashAndOK.Visible = bslayer.config.Prep_Can_Hold_And_Cash;
            btnCashPrintAndOK.Visible = bslayer.config.Prep_Can_Hold_Cash_And_Print;

            this.Top = 0;
            this.Height = bslayer.maxHeight;
            //this.Refresh();
           // MessageBox.Show("refreshed @ " + DateTime.Now.ToLongTimeString());

        }
        private void LoadPrep() {
            prepDisplay.Initilise(bslayer, korder);
        }

        //private void btnPrint_Click(object sender, EventArgs e) {
        //    bslayer.PrintForKitchenSpecial(korder);
        //}

        //private void btnPrintAsReceipt_Click(object sender, EventArgs e) {
        //    bslayer.PrintReceipt(korder.OrderIID, bslayer.GetDefaultReceiptPrinter(), 1);
        //}

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.prepResult = PrepDialogReturnTypes.Cancel;
            this.Close();
        }


        private void btnCash_Click(object sender, EventArgs e) {
            CompletePrep(PrepDialogReturnTypes.Cash, true);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.Cash;
            //if (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None)
            //    bslayer.OpenCashDrawer(false);
            //this.Close();
        }

        private void btnCashAndPrint_Click(object sender, EventArgs e) {
            CompletePrep(PrepDialogReturnTypes.CashAndPrint, true);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.CashAndPrint;
            //if (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None)
            //    bslayer.OpenCashDrawer(false);
            //this.Close();
        }


        private void btnHold_Click(object sender, EventArgs e) {
            CompletePrep(PrepDialogReturnTypes.Hold, false);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.Hold;
            //this.Close();
        }

        private void CompletePrep(PrepDialogReturnTypes result, bool blnOpenCashDrawer) {
            this.DialogResult = DialogResult.OK;
            this.prepResult = result;
            foreach (KitchenOrderItem item in korder.items) {
                if (item.Status == KitchenOrderStatusTypes.Completed)
                    bslayer.UpdateCompletedQuantityForRelatedKitchenOrderItem(item);
            }

            if (blnOpenCashDrawer && bslayer.config.Attached_Cash_Drawer_Type != POSLayer.Library.CashDrawerTypes.None)
                bslayer.OpenCashDrawer(false);
            this.Close();
        }


        private void btnOKAll_Click(object sender, EventArgs e) {
            prepDisplay.ChangeStatus();
        }

        
    }
}
