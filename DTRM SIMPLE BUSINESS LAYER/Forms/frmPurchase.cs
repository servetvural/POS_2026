using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmPurchase : Form {
        private StockItemUsage stockItemUsage;
        private StockItem stockItem;
        private DTRMSimpleBusiness bslayer;

        public int sentQuantity;

        public frmPurchase() {
            InitializeComponent();
        }
        public frmPurchase(StockItemUsage stockItemUsage) {
            InitializeComponent();
            this.stockItemUsage = stockItemUsage;

            bslayer = DTRMSimpleBusiness.Instance;
        }
        private void frmPurchase_Load(object sender, EventArgs e) {
            LoadStockItemUsage();
        }

        private async Task LoadStockItemUsage() {
            stockItem =await  DTRMSimpleBusiness.Instance.GetStockItem(stockItemUsage.StockItemIID);
            txtStockItemName.Text = stockItemUsage.StockItem.StockName;
            txtQuantity.Value = (int)stockItemUsage.OrderableQuantity;
            txtConversion.Text = stockItem.Conversion.ToString();
            txtNewConversion.Value = stockItem.Conversion;
            lblOrderType.Text = ((QuantityTypes)stockItem.QuantityType).ToString() + " in " + ((QuantityTypes)stockItem.OrderType).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        private void btnOK_Click(object sender, EventArgs e) {
            //ok it with same quantity and same conversion
            AddToStockItem(txtQuantity.Value, int.Parse(txtConversion.Text));
        }


        private void btnOKNewConversion_Click(object sender, EventArgs e) {
            //ok it with new quantity and new conversion
            AddToStockItem(txtQuantity.Value, txtNewConversion.Value);
        }

        private async void AddToStockItem(int quantity, int conversion) {
            //stockItem.UsedQuantity -= (quantity * conversion);
            sentQuantity = (quantity * conversion * -1);
            if (await  DTRMSimpleBusiness.Instance.UpdateStockItemUsedQuantity(stockItem.IID, sentQuantity)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnAddToStock_Click(object sender, EventArgs e) {
            AddToStockItem(txtQuantity.Value, int.Parse(txtConversion.Text));
        }

        private void btnPlusQty_Click(object sender, EventArgs e) {
            txtQuantity.Value += txtQuantity.Increment;
        }

        private void btnMinusQty_Click(object sender, EventArgs e) {
            txtQuantity.Value -= txtQuantity.Increment;
        }

        private void btnPlusNewQty_Click(object sender, EventArgs e) {
            txtNewConversion.Value += txtNewConversion.Increment;
        }

        private void btnMinusNewQty_Click(object sender, EventArgs e) {
            txtNewConversion.Value -= txtNewConversion.Increment;
        }
    }
}
