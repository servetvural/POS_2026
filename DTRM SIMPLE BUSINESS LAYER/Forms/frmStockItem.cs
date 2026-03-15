using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using POSLayer.Models;
using POSLayer.Library;
using System.Threading.Tasks;
using POSWinFormLayer;

namespace DTRMNS {
    public partial class frmStockItem : Form {
        private DTRMSimpleBusiness bslayer;
        public StockItem stockItem;
        private UndoItem oldItem;
        private bool blnModified;

        private int originalValue = 0;
        GenericImage gim;

        public frmStockItem() {
            InitializeComponent();
        }
        public frmStockItem(DTRMSimpleBusiness bslayer, StockItem stockItem) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.stockItem = stockItem;
        }

        private void frmStockItem_Load(object sender, EventArgs e) {
            LoadSuppliers();
            LoadStockItem();

        }
        private void LoadSuppliers() {
            cmbSupplier.DataSource = bslayer.GetAllSuppliersAsList();
            cmbOrderType.Items.Clear();
            cmbQuantityType.Items.Clear();
            for (int i = 0; i < 25; i++) {
                cmbQuantityType.Items.Add(((QuantityTypes)i).ToString());
                cmbOrderType.Items.Add(((QuantityTypes)i).ToString());                
            }
        }
        private async void LoadStockItem() {
            txtStockName.Text = stockItem.StockName;
            cmbQuantityType.SelectedIndex = (int)stockItem.QuantityType;
            cmbOrderType.SelectedIndex = (int)stockItem.OrderType;
            txtConversion.Value = stockItem.Conversion;
            txtUsedQuantity.Text = stockItem.UsedQuantity.ToString();
            //PreviousQuantity = stockItem.UsedQuantity;

            lblUsed.Text = stockItem.QuantityType.ToString();
            try {
                cmbSupplier.SelectedValue = stockItem.SupplierIID;
            } catch { }

            try {
                gim =await bslayer.GetGenericImage(stockItem.IID);
                pBox.BackgroundImage = gim?.DisplayImage.ToImage();
                txtImageFile.Text = gim?.ImageFileName;
            } catch (Exception ex) {
                string str = ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            if (blnModified)
                bslayer.SetStockItemQuantity(stockItem.IID, originalValue);
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (txtStockName.Text.Length > 0) {
                stockItem.StockName = txtStockName.Text;
                stockItem.QuantityType = (QuantityTypes)cmbQuantityType.SelectedIndex;
                stockItem.OrderType = (QuantityTypes)cmbOrderType.SelectedIndex;
                stockItem.Conversion = txtConversion.Value;
                stockItem.SupplierIID = cmbSupplier.SelectedValue.ToString();
                if (bslayer.SaveStockItem(stockItem)) {
                    if (pBox.BackgroundImage != null) {
                        GenericImage gim = new GenericImage()
                        {
                            ReferenceIID = stockItem.IID,
                            DisplayImage = pBox.BackgroundImage.ToByteArray(),
                            ExtraText = stockItem.StockName,
                            ImageFileName = txtImageFile.Text
                        };
                       await bslayer.SaveGenericImage(gim);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnSet0_Click(object sender, EventArgs e) {
            if (oldItem == null) {
                //First time so set to zero
                oldItem = new UndoItem(stockItem.IID, (int)stockItem.UsedQuantity, true);
                stockItem.UsedQuantity = 0;
                bslayer.SetStockItemQuantity(stockItem.IID, 0);
                txtUsedQuantity.Text = "0";
                btnSet0.Image = global::DTRMNS.Properties.Resources.ActionUndo;
                btnSet0.Text = "";
                blnModified = true;
                btnSetCustom.Enabled = false;
            } else {
                //Already set to 0 so converted back
                stockItem.UsedQuantity = oldItem.Quantity;
                bslayer.SetStockItemQuantity(stockItem.IID, oldItem.Quantity);
                txtUsedQuantity.Text = oldItem.Quantity.ToString();
                btnSet0.Text = "Set  0";
                btnSet0.Image = null;
                oldItem = null;
                btnSetCustom.Enabled = true;
            }
           
        }

        private void btnSetCustom_Click(object sender, EventArgs e) {
            if (oldItem == null) {
                //First time so set to custom value  
                TrmGetValue frm = new TrmGetValue(NumberModes.IntegerMode, SystemColors.Control);              
                if (frm.ShowDialog() == DialogResult.OK) {
                    int val = (int)frm.ReturnValue;
                    oldItem = new UndoItem(stockItem.IID, (int)stockItem.UsedQuantity, true);
                    stockItem.UsedQuantity = val;
                    bslayer.SetStockItemQuantity(stockItem.IID, val);
                    txtUsedQuantity.Text = val.ToString();
                    btnSetCustom.Image = global::DTRMNS.Properties.Resources.ActionUndo;
                    btnSetCustom.Text = "";
                    blnModified = true;
                    btnSet0.Enabled = false;
                } 
            } else {
                //Already set to custom so convert back 
                stockItem.UsedQuantity = oldItem.Quantity;
                bslayer.SetStockItemQuantity(stockItem.IID, oldItem.Quantity);
                txtUsedQuantity.Text = oldItem.Quantity.ToString();
                btnSetCustom.Text = "Set ?";
                btnSetCustom.Image = null;
                oldItem = null;
                btnSet0.Enabled = true;
            }
        }

        private void btnLoadImageFromDirectory_Click(object sender, EventArgs e) {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Stock Item Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
                txtImageFile.Text = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = img;

                gim = new GenericImage()
                {
                    ReferenceIID = stockItem.IID,
                    DisplayImage = img.ToByteArray(), 
                    ExtraText = stockItem.StockName, 
                    ImageFileName = finfo.Name
                };

                //DisplayButton();
            }
        }

        private async void btnDeleteImage_Click(object sender, EventArgs e) {
           await bslayer.DeleteGenericImage(stockItem.IID);
            pBox.BackgroundImage = null;
        }

        private void btnLoadImageFromDatabase_Click(object sender, EventArgs e) {
            frmImageList frm = new frmImageList(bslayer, true);
            if (frm.ShowDialog() == DialogResult.OK) {
                pBox.BackgroundImage = frm.SelectedImage;
            }
        }

        private void btnMinusQty_Click(object sender, EventArgs e)
        {
            if (txtConversion.Value > 0)
                txtConversion.Value--;
        }

        private void btnPlusQty_Click(object sender, EventArgs e)
        {
            txtConversion.Value++;
        }
    }
}
