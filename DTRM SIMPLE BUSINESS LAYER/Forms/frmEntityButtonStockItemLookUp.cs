using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmEntityButtonStockItemLookUp : Form {
        private DTRMSimpleBusiness bslayer;
        public EntityButtonStockItemLookUp lookup;
        public CategoryItem entityButton;
        private StockItem selectedStockItem;
        private bool blnLoading;

        public frmEntityButtonStockItemLookUp() {
            InitializeComponent();
        }
        public frmEntityButtonStockItemLookUp(DTRMSimpleBusiness bslayer, CategoryItem entityButton) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.entityButton = entityButton;

            //new lookup being created (need display order) or let system to it automatically in the database

            this.lookup = new EntityButtonStockItemLookUp()
            {
                EntityButtonIID = entityButton.IID
            }; 
        }
        public frmEntityButtonStockItemLookUp(DTRMSimpleBusiness bslayer, EntityButtonStockItemLookUp lookup) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.lookup = lookup;
            this.entityButton = bslayer.GetJustEntityButton(lookup.EntityButtonIID).Result;
        }
        private void frmEntityButtonStockItemLookUp_Load(object sender, EventArgs e) {
            blnLoading = true;
            LoadStockItemList();
            LoadLookUp();
            blnLoading = false;
        }

        private void LoadStockItemList() {
            cmbStockItem.DataSource = bslayer.GetAllStockItemsShort(); //  bslayer.GetAllStockItemsShortForEB(entityButton.IID);
        }

        private async Task LoadLookUp() {
            txtEntityButton.Text = entityButton.ItemName;
            lblQuantityType.Text = lookup.QuantityType.ToString();
            incQuantity.Value = lookup.Quantity;
            incUsageAmount.Value = (int)lookup.Quantity;
            txtDisplayOrder.Value = lookup.DisplayOrder;
            txtComment.Text = lookup.Comment;
            if (lookup.StockItemIID == "")
            {
                chkFreeItem.Checked = true;
            } else
            {
                try
                {
                    if (lookup.StockItemIID != null && lookup.StockItemIID.Length > 0)
                    {
                        cmbStockItem.SelectedValue = lookup.StockItemIID;
                        selectedStockItem =await bslayer.GetStockItem(lookup.StockItemIID);
                    } else
                    {
                        //it is a free item
                        
                    }
                } catch { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (cmbStockItem.SelectedIndex >= 0 || chkFreeItem.Checked ) {
                lookup.EntityButtonIID = entityButton.IID;
                if (chkFreeItem.Checked)
                {
                    lookup.StockItemIID = "";
                    lookup.Quantity = 0;
                    lookup.QuantityType = QuantityTypes.None;

                } else
                {
                    //not free item but combo box not selected for item
                    if (selectedStockItem == null)
                        return;
                    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
                    lookup.Quantity = (float)incQuantity.Value;
                    lookup.QuantityType = selectedStockItem.QuantityType; // (QuantityTypes)cmbQuantityType.SelectedIndex;

                }               

                
                lookup.DisplayOrder = txtDisplayOrder.Value;
                lookup.Comment = txtComment.Text;
                if (await bslayer.SaveEntityButtonStockItemLookUp(lookup)) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void cmbStockItem_SelectionChangeCommitted(object sender, EventArgs e) {
            //try
            //{
            //    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
            //    selectedStockItem = bslayer.GetStockItem(lookup.StockItemIID);
            //    lblQuantityType.Text = selectedStockItem.QuantityType.ToString();
            //} catch { }
        }

        private async void cmbStockItem_SelectedValueChanged(object sender, EventArgs e) {
            try {
                if (!blnLoading) {
                    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
                    selectedStockItem =await bslayer.GetStockItem(lookup.StockItemIID);
                    lblQuantityType.Text = selectedStockItem.QuantityType.ToString();
                }
            } catch { }
        }

        private void btnAddStockItem_Click(object sender, EventArgs e) {
            StockItem si = new StockItem();
            si.StockName = entityButton.ItemName;
            frmStockItem frm = new frmStockItem(bslayer, si);
            if (frm.ShowDialog() == DialogResult.OK) {
                LoadStockItemList();
                cmbStockItem.SelectedValue = frm.stockItem.IID;
            }
        }

        private void frmEntityButtonStockItemLookUp_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F3) {
                btnAddStockItem_Click(null, null);
            }
        }

        private void btnPlusQty_Click(object sender, EventArgs e) {
            incQuantity.IncrementValue();
        }

        private void btnMinusQty_Click(object sender, EventArgs e) {
            incQuantity.DecrementValue();
        }
        private void chkFreeItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFreeItem.Checked)
            {
                cmbStockItem.Enabled = false;
                incQuantity.Value = 0;
                incQuantity.Enabled = false;
            } else
            {
                cmbStockItem.Enabled = true;
                incQuantity.Value = 1;
                incQuantity.Enabled = true;
            }
        }

        private void incUsageAmount_ValueChanged(object sender, EventArgs e)
        {
            txtComment.Text = incUsageAmount.Value.ToString() + " " + cmbUsageAmountType.Text;
        }

        private void cmbUsageAmountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtComment.Text = incUsageAmount.Value.ToString() + " " + cmbUsageAmountType.Text;
        }
    }
}
