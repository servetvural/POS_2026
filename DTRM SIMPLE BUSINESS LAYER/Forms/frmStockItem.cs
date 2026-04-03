using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using POSLayer.Models;
using POSLayer.Library;
using POSWinFormLayer;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace DTRMNS
{
    public partial class frmStockItem : Form
    {
        IRepository<StockItem> repoStockItem;
        IRepository<Supplier> repoSupplier;
        IRepository<GenericImage> repoImage;

        private DTRMSimpleBusiness bslayer;
        public StockItem stockItem;
        private UndoItem oldItem;
        private bool blnModified;

        private int originalValue = 0;
        GenericImage gim;

        private BindingSource _supplierSource = new BindingSource();

        public frmStockItem()
        {
            InitializeComponent();
        }
        public frmStockItem(IRepository<StockItem> _repoStockItem, IRepository<Supplier> _repoSupplier,
            IRepository<GenericImage> _repoImage,
            DTRMSimpleBusiness bslayer, StockItem stockItem)
        {
            InitializeComponent();
            repoStockItem = _repoStockItem;
            repoSupplier = _repoSupplier;
            repoImage = _repoImage;

            this.bslayer = bslayer;
            this.stockItem = stockItem;
        }

        private void frmStockItem_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadStockItem();

        }
        private async void LoadSuppliers()
        {
            _supplierSource.DataSource = (await repoSupplier.GetAllAsync()).ToBindingList();
            cmbSupplier.DataSource = _supplierSource;

            cmbOrderType.DataSource = Enum.GetValues(typeof(QuantityTypes));
            cmbQuantityType.DataSource = Enum.GetValues(typeof(QuantityTypes));
        }
        private async void LoadStockItem()
        {
            txtStockName.Text = stockItem.StockName;
            cmbQuantityType.SelectedItem = stockItem.QuantityType;
            cmbOrderType.SelectedItem = stockItem.OrderType;
            txtConversion.Value = stockItem.Conversion;
            txtUsedQuantity.Text = stockItem.UsedQuantity.ToString();
            //PreviousQuantity = stockItem.UsedQuantity;

            lblUsed.Text = stockItem.QuantityType.ToString();
            try
            {
                cmbSupplier.SelectedValue = stockItem.SupplierIID;
            } catch { }

            try
            {
                gim = await bslayer.GetGenericImage(stockItem.IID);
                pBox.BackgroundImage = gim?.DisplayImage.ToImage();
                txtImageFile.Text = gim?.ImageFileName;
            } catch (Exception ex)
            {
                string str = ex.Message;
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (blnModified)
                await bslayer.SetStockItemQuantity(stockItem.IID, originalValue);
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStockName.Text.Length > 0)
            {
                stockItem.StockName = txtStockName.Text;
                stockItem.QuantityType = (QuantityTypes)cmbQuantityType.SelectedItem;
                stockItem.OrderType = (QuantityTypes)cmbOrderType.SelectedItem;
                stockItem.Conversion = txtConversion.Value;
                stockItem.SupplierIID = cmbSupplier.SelectedValue.ToString();
                if (await repoStockItem.Save(stockItem) != null)
                {
                    if (pBox.BackgroundImage != null)
                    {
                        byte[] imgBytes = UFWin.ReSizeImageTo(pBox.BackgroundImage, 250, 250, true).ToByteArray();

                        GenericImage gim = new GenericImage()
                        {
                            ReferenceIID = stockItem.IID,
                            DisplayImage = imgBytes,
                            ExtraText = stockItem.StockName,
                            ImageFileName = txtImageFile.Text,
                            ImageSizeinKB = imgBytes?.Length / 1024 ?? 0
                        };
                        if (stockItem.IID == null)
                            await repoImage.Save(gim);
                        else
                            await repoImage.SaveByField("ReferenceIID", stockItem.IID, gim);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void btnSet0_Click(object sender, EventArgs e)
        {
            if (oldItem == null)
            {
                //First time so set to zero
                oldItem = new UndoItem()
                {
                    IID = stockItem.IID,
                    Quantity = (int)stockItem.UsedQuantity,
                    blnConverted = true
                };
                stockItem.UsedQuantity = 0;
                await bslayer.SetStockItemQuantity(stockItem.IID, 0);
                txtUsedQuantity.Text = "0";
                btnSet0.Image = global::DTRMNS.Properties.Resources.ActionUndo;
                btnSet0.Text = "";
                blnModified = true;
                btnSetCustom.Enabled = false;
            } else
            {
                //Already set to 0 so converted back
                stockItem.UsedQuantity = oldItem.Quantity;
                await bslayer.SetStockItemQuantity(stockItem.IID, oldItem.Quantity);
                txtUsedQuantity.Text = oldItem.Quantity.ToString();
                btnSet0.Text = "Set  0";
                btnSet0.Image = null;
                oldItem = null;
                btnSetCustom.Enabled = true;
            }

        }

        private void btnSetCustom_Click(object sender, EventArgs e)
        {
            if (oldItem == null)
            {
                //First time so set to custom value  
                TrmGetValue frm = new TrmGetValue(NumberModes.IntegerMode, SystemColors.Control);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int val = (int)frm.ReturnValue;
                    oldItem = new UndoItem()
                    {
                        IID = stockItem.IID,
                        Quantity = (int)stockItem.UsedQuantity,
                        blnConverted = true
                    };
                    stockItem.UsedQuantity = val;
                    bslayer.SetStockItemQuantity(stockItem.IID, val);
                    txtUsedQuantity.Text = val.ToString();
                    btnSetCustom.Image = global::DTRMNS.Properties.Resources.ActionUndo;
                    btnSetCustom.Text = "";
                    blnModified = true;
                    btnSet0.Enabled = false;
                }
            } else
            {
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

        private void btnLoadImageFromDirectory_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Stock Item Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
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

        private async void btnDeleteImage_Click(object sender, EventArgs e)
        {
            await repoImage.DeleteByField("ReferenceIID",stockItem.IID);
            pBox.BackgroundImage = null;
        }

        private void btnLoadImageFromDatabase_Click(object sender, EventArgs e)
        {
            frmImageList frm = ActivatorUtilities.CreateInstance< frmImageList>(ServiceHelper.Services, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
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
