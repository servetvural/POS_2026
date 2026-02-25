using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTRMNS;

namespace DTRM {
    public partial class frmEntityButtonStockItemLookUp : Form {
        private DTRMSimpleBusiness bslayer;
        public EntityButtonStockItemLookUp lookup;
        public EntityButton entityButton;
        private StockItem selectedStockItem;
        private bool blnLoading;

        public frmEntityButtonStockItemLookUp() {
            InitializeComponent();
        }
        public frmEntityButtonStockItemLookUp(DTRMSimpleBusiness bslayer, EntityButton entityButton) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.entityButton = entityButton;
            this.lookup = new EntityButtonStockItemLookUp(entityButton.IID, "", 0, 1,0,"");
        }
        public frmEntityButtonStockItemLookUp(DTRMSimpleBusiness bslayer, EntityButtonStockItemLookUp lookup) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.lookup = lookup;
            this.entityButton = bslayer.GetJustEntityButton(lookup.EntityButtonIID);
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

        private void LoadLookUp() {
            txtEntityButton.Text = entityButton.EntityButtonName;
            lblQuantityType.Text = lookup.QuantityType.ToString();
            incQuantity.Value = lookup.Quantity;
            txtDisplayOrder.Value = lookup.DisplayOrder;
            txtComment.Text = lookup.Comment;
            try {
                cmbStockItem.SelectedValue = lookup.StockItemIID;
                selectedStockItem = bslayer.GetStockItem(lookup.StockItemIID);
            } catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (cmbStockItem.SelectedIndex >= 0 ) {
                lookup.EntityButtonIID = entityButton.IID;
                if (chkFreeItem.Checked)
                    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
                else
                    lookup.StockItemIID = "";
                lookup.QuantityType = selectedStockItem.QuantityType; // (QuantityTypes)cmbQuantityType.SelectedIndex;
                lookup.Quantity = incQuantity.Value;
                lookup.DisplayOrder = txtDisplayOrder.Value;
                lookup.Comment = txtComment.Text;
                if (bslayer.SaveEntityButtonStockItemLookUp(lookup)) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void cmbStockItem_SelectionChangeCommitted(object sender, EventArgs e) {
            //try {
            //    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
            //    selectedStockItem = bslayer.GetStockItem(lookup.StockItemIID);
            //    lblQuantityType.Text = selectedStockItem.QuantityType.ToString();
            //} catch { }
        }

        private void cmbStockItem_SelectedValueChanged(object sender, EventArgs e) {
            try {
                if (!blnLoading) {
                    lookup.StockItemIID = cmbStockItem.SelectedValue.ToString();
                    selectedStockItem = bslayer.GetStockItem(lookup.StockItemIID);
                    lblQuantityType.Text = selectedStockItem.QuantityType.ToString();
                }
            } catch { }
        }

        private void btnAddStockItem_Click(object sender, EventArgs e) {
            StockItem si = new StockItem();
            si.StockName = entityButton.EntityButtonName;
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
            incQuantity.IncreaseValue();
        }

        private void btnMinusQty_Click(object sender, EventArgs e) {
            incQuantity.DecreaseValue();
        }

        private void chkFreeItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFreeItem.Checked)
            {
                cmbStockItem.Enabled = false;
                incQuantity.Value = 0;
            } else
            {
                cmbStockItem.Enabled = true;
                incQuantity.Value = 1;
            }
        }
    }
}
