using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS
{
    public partial class frmPrep : Form
    {
        PosConfig config;

        private KitchenOrder korder;
        public PrepDialogReturnTypes prepResult;
        public frmPrep()
        {
            InitializeComponent();
        }
        public frmPrep(KitchenOrder korder)
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            this.korder = korder;
        }
        private void frmPrep_Load(object sender, EventArgs e)
        {
            LoadPrep();
            btnHold.Visible = config.Prep_Can_Hold;
            btnCashAndOK.Visible = config.Prep_Can_Hold_And_Cash;
            btnCashPrintAndOK.Visible = config.Prep_Can_Hold_Cash_And_Print;

            this.Top = 0;
            this.Height = DTRMSimpleBusiness.Instance.maxHeight;
            //this.Refresh();
            // MessageBox.Show("refreshed @ " + DateTime.Now.ToLongTimeString());

        }
        private void LoadPrep()
        {
            prepDisplay.Initilise(korder);
        }

        //private void btnPrint_Click(object sender, EventArgs e) {
        //     DTRMSimpleBusiness.Instance.PrintForKitchenSpecial(korder);
        //}

        //private void btnPrintAsReceipt_Click(object sender, EventArgs e) {
        //     DTRMSimpleBusiness.Instance.PrintReceipt(korder.OrderIID,  DTRMSimpleBusiness.Instance.GetDefaultReceiptPrinter(), 1);
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.prepResult = PrepDialogReturnTypes.Cancel;
            this.Close();
        }


        private async void btnCash_Click(object sender, EventArgs e)
        {
            await CompletePrep(PrepDialogReturnTypes.Cash, true);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.Cash;
            //if ( DTRMSimpleBusiness.Instance.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None)
            //     DTRMSimpleBusiness.Instance.OpenCashDrawer(false);
            //this.Close();
        }

        private async void btnCashAndPrint_Click(object sender, EventArgs e)
        {
            await CompletePrep(PrepDialogReturnTypes.CashAndPrint, true);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.CashAndPrint;
            //if ( DTRMSimpleBusiness.Instance.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None)
            //     DTRMSimpleBusiness.Instance.OpenCashDrawer(false);
            //this.Close();
        }


        private async void btnHold_Click(object sender, EventArgs e)
        {
            await CompletePrep(PrepDialogReturnTypes.Hold, false);
            //this.DialogResult = DialogResult.OK;
            //this.prepResult = PrepDialogReturnTypes.Hold;
            //this.Close();
        }

        private async Task CompletePrep(PrepDialogReturnTypes result, bool blnOpenCashDrawer)
        {
            this.DialogResult = DialogResult.OK;
            this.prepResult = result;
            foreach (KitchenOrderItem item in korder.Items)
            {
                if (item.Status == KitchenOrderStatusTypes.Completed)
                    DTRMSimpleBusiness.Instance.UpdateCompletedQuantityForRelatedKitchenOrderItem(item);
            }

            if (blnOpenCashDrawer && config.Attached_Cash_Drawer_Type != POSLayer.Library.CashDrawerTypes.None)
                await DTRMSimpleBusiness.Instance.OpenCashDrawer();
            this.Close();
        }


        private void btnOKAll_Click(object sender, EventArgs e)
        {
            prepDisplay.ChangeStatus();
        }


    }
}
