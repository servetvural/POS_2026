using System;
using System.Drawing;
using System.Windows.Forms;
using DTRMNS;
using PosLibrary;
using System.Globalization;
using System.IO;
using POSLayer.Models;
using POSLayer.Library;
using POSWinFormLayer;
using System.Threading.Tasks;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Drawing.Configuration;

namespace DTRMSimpleBackOffice
{
    /// <summary>
    /// Summary description for frmEntitiButtonsEditor.
    /// </summary>
    public class frmCategoryItemUpsert : Form
    {



        private Button btnClose;
        private Button btnUpdateButtonDetails;
        private Label label5;
        private Label label2;
        private Button btnButtonColor;
        private Label label4;
        private ComboBox cmbButtonType;
        private Button btnForeColor;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DoubleTextBox txtInHousePrice;
        private DoubleTextBox txtDeliveryPrice;
        private DoubleTextBox txtTakeAwayPrice;
        private CheckBox chkAvailableDelivery;
        private CheckBox chkAvailableTakeAway;
        private CheckBox chkAvailableInHouse;
        private CheckBox chkAvailableInternetDelivery;
        private CheckBox chkAvailableAll;
        private Label label9;
        private DoubleTextBox txtDirectSalePrice;
        private CheckBox chkAvailableDirect;
        private CheckBox chkCompulsary;
        private CheckBox chkAvailableInternetTakeAway;
        private DoubleTextBox txtDeliveryTaxRate;
        private DoubleTextBox txtTakeAwayTaxRate;
        private DoubleTextBox txtInHouseTaxRate;
        private DoubleTextBox txtDirectSaleTaxRate;
        private Label label15;
        private ComboBox cmbPadFlag;
        private Button btnSetTaxToDefault;
        private Button btnSetTaxToZero;
        private TextBox txtCategoryItemName;
        private PosLibrary.IntegerTextBox incWidth;
        private PosLibrary.IntegerTextBox incHeight;
        private Label label16;
        private Label label17;
        private TextBox txtImageFile;
        private Label lblFont;
        private Button btnFont;
        private PosLibrary.IntegerTextBox incDisplayOrder;
        private Label label20;
        private ComboBox cmbDistributions;
        private Label label21;
        private PictureBox pBox;
        private Button btnLoadPrepImageFromDirectory;
        private Button btnDeletePrepImage;
        private TextBox txtExtraText;
        private Button btnLoadPrepImageFromDatabase;
        private CheckBox chkAvailableNone;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private Label lblImageSize;
        private GenericImage gim;



        PosConfig config;
        IRepository<Category> repoCategory;
        IRepository<CategoryItem> repoCategoryItem;
        IRepository<Distribution> repoDistribution;
        IRepository<GenericImage> repoImage;
        IRepository<Shop> repoShop;

        public Category category;
        public CategoryItem categoryItem;
        string CategoryIID;
        private ComboBox cmbButtonDisplayStyle;
        private ComboBox cmbImageAlign;
        private Label label11;
        private Label label12;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSample;
        private BindingSource _distributionSource = new BindingSource();
        private Label label1;
        private ComboBox cmbTextAlign;
        private Label label3;
        private ComboBox cmbTextImageRelation;
        Shop currentShop;

        public frmCategoryItemUpsert(PosConfig configAsService, IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Distribution> _repoDistribution, IRepository<GenericImage> _repoImage,
            IRepository<Shop> _repoShop, CategoryItem categoryItem, string CategoryIID = null)
        {
            InitializeComponent();
            config = configAsService;
            repoCategory = _repoCategory;
            repoCategoryItem = _repoCategoryItem;
            repoDistribution = _repoDistribution;
            repoImage = _repoImage;
            repoShop = _repoShop;

            this.CategoryIID = CategoryIID;
            this.categoryItem = categoryItem;

            Thread.CurrentThread.CurrentUICulture = UF.GetCulture(config.Terminal_Currency_Culture);

        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label5 = new Label();
            txtInHousePrice = new DoubleTextBox();
            label2 = new Label();
            label4 = new Label();
            cmbButtonType = new ComboBox();
            btnSetTaxToDefault = new Button();
            btnSetTaxToZero = new Button();
            label15 = new Label();
            cmbPadFlag = new ComboBox();
            txtDeliveryTaxRate = new DoubleTextBox();
            txtTakeAwayTaxRate = new DoubleTextBox();
            txtInHouseTaxRate = new DoubleTextBox();
            txtDirectSaleTaxRate = new DoubleTextBox();
            chkCompulsary = new CheckBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtDirectSalePrice = new DoubleTextBox();
            txtDeliveryPrice = new DoubleTextBox();
            label8 = new Label();
            txtTakeAwayPrice = new DoubleTextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            chkAvailableNone = new CheckBox();
            chkAvailableInternetTakeAway = new CheckBox();
            chkAvailableAll = new CheckBox();
            chkAvailableInternetDelivery = new CheckBox();
            chkAvailableDelivery = new CheckBox();
            chkAvailableTakeAway = new CheckBox();
            chkAvailableInHouse = new CheckBox();
            chkAvailableDirect = new CheckBox();
            btnForeColor = new Button();
            btnButtonColor = new Button();
            btnUpdateButtonDetails = new Button();
            btnClose = new Button();
            txtCategoryItemName = new TextBox();
            incWidth = new IntegerTextBox();
            incHeight = new IntegerTextBox();
            label16 = new Label();
            label17 = new Label();
            txtImageFile = new TextBox();
            lblFont = new Label();
            btnFont = new Button();
            incDisplayOrder = new IntegerTextBox();
            label20 = new Label();
            cmbDistributions = new ComboBox();
            label21 = new Label();
            txtExtraText = new TextBox();
            btnDeletePrepImage = new Button();
            btnLoadPrepImageFromDirectory = new Button();
            pBox = new PictureBox();
            btnLoadPrepImageFromDatabase = new Button();
            toolTip1 = new ToolTip(components);
            lblImageSize = new Label();
            cmbButtonDisplayStyle = new ComboBox();
            cmbImageAlign = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            toolStrip1 = new ToolStrip();
            btnSample = new ToolStripButton();
            label1 = new Label();
            cmbTextAlign = new ComboBox();
            label3 = new Label();
            cmbTextImageRelation = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(19, 63);
            label5.Margin = new Padding(3, 3, 1, 3);
            label5.Name = "label5";
            label5.Size = new Size(36, 18);
            label5.TabIndex = 42;
            label5.Text = "Sitin";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtInHousePrice
            // 
            txtInHousePrice.CustomFormat = "C2";
            txtInHousePrice.CustomUICulture = "en-US";
            txtInHousePrice.Font = new Font("Microsoft Sans Serif", 11F);
            txtInHousePrice.Increment = 1D;
            txtInHousePrice.Location = new Point(114, 57);
            txtInHousePrice.Margin = new Padding(1, 3, 3, 3);
            txtInHousePrice.MaxValue = 100000D;
            txtInHousePrice.MinValue = -100000D;
            txtInHousePrice.Name = "txtInHousePrice";
            txtInHousePrice.Size = new Size(84, 24);
            txtInHousePrice.TabIndex = 3;
            txtInHousePrice.Text = "$0.00";
            txtInHousePrice.TextAlign = HorizontalAlignment.Right;
            txtInHousePrice.Value = 0D;
            txtInHousePrice.KeyDown += Price_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(31, 14);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 34;
            label2.Text = "Item Text";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(31, 47);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 37;
            label4.Text = "Functional Type";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbButtonType
            // 
            cmbButtonType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbButtonType.Font = new Font("Microsoft Sans Serif", 11F);
            cmbButtonType.FormattingEnabled = true;
            cmbButtonType.ItemHeight = 18;
            cmbButtonType.Items.AddRange(new object[] { "Simple Item", "Extra Item", "Ex & Disco Amount Addition", "Ex & Disco Percent Addition", "Ex & Disco Custom Addition", "Ex & Disco Amount Deduction", "Ex & Disco Percent Deduction", "Ex & Disco Custom Deduction", "Space Button" });
            cmbButtonType.Location = new Point(176, 44);
            cmbButtonType.MaxDropDownItems = 40;
            cmbButtonType.Name = "cmbButtonType";
            cmbButtonType.Size = new Size(246, 26);
            cmbButtonType.TabIndex = 1;
            cmbButtonType.TabStop = false;
            cmbButtonType.SelectedIndexChanged += cmbButtonType_SelectedIndexChanged;
            // 
            // btnSetTaxToDefault
            // 
            btnSetTaxToDefault.BackColor = SystemColors.Control;
            btnSetTaxToDefault.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetTaxToDefault.FlatAppearance.BorderSize = 0;
            btnSetTaxToDefault.Font = new Font("Microsoft Sans Serif", 11F);
            btnSetTaxToDefault.ForeColor = SystemColors.ControlText;
            btnSetTaxToDefault.Location = new Point(307, 647);
            btnSetTaxToDefault.Margin = new Padding(3, 2, 3, 3);
            btnSetTaxToDefault.Name = "btnSetTaxToDefault";
            btnSetTaxToDefault.Size = new Size(120, 50);
            btnSetTaxToDefault.TabIndex = 82;
            btnSetTaxToDefault.Text = "Set Tax Default";
            btnSetTaxToDefault.UseVisualStyleBackColor = true;
            btnSetTaxToDefault.Click += btnSetTaxToDefault_Click;
            // 
            // btnSetTaxToZero
            // 
            btnSetTaxToZero.BackColor = SystemColors.Control;
            btnSetTaxToZero.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetTaxToZero.FlatAppearance.BorderSize = 0;
            btnSetTaxToZero.Font = new Font("Microsoft Sans Serif", 11F);
            btnSetTaxToZero.ForeColor = SystemColors.ControlText;
            btnSetTaxToZero.Location = new Point(172, 647);
            btnSetTaxToZero.Margin = new Padding(3, 2, 3, 3);
            btnSetTaxToZero.Name = "btnSetTaxToZero";
            btnSetTaxToZero.Size = new Size(120, 50);
            btnSetTaxToZero.TabIndex = 81;
            btnSetTaxToZero.Text = "Set Tax 0% ";
            btnSetTaxToZero.UseVisualStyleBackColor = true;
            btnSetTaxToZero.Click += btnSetTaxToZero_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 11F);
            label15.Location = new Point(31, 222);
            label15.Name = "label15";
            label15.Size = new Size(89, 18);
            label15.TabIndex = 80;
            label15.Text = "Available On";
            // 
            // cmbPadFlag
            // 
            cmbPadFlag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPadFlag.Font = new Font("Microsoft Sans Serif", 11F);
            cmbPadFlag.FormattingEnabled = true;
            cmbPadFlag.Items.AddRange(new object[] { "Normal Sale Panel Only", "Order Pad Only", "ALL" });
            cmbPadFlag.Location = new Point(176, 219);
            cmbPadFlag.Name = "cmbPadFlag";
            cmbPadFlag.Size = new Size(246, 26);
            cmbPadFlag.TabIndex = 79;
            // 
            // txtDeliveryTaxRate
            // 
            txtDeliveryTaxRate.CustomFormat = "0.00";
            txtDeliveryTaxRate.CustomUICulture = "en-US";
            txtDeliveryTaxRate.Font = new Font("Microsoft Sans Serif", 11F);
            txtDeliveryTaxRate.Increment = 1D;
            txtDeliveryTaxRate.Location = new Point(242, 127);
            txtDeliveryTaxRate.MaxValue = 100000D;
            txtDeliveryTaxRate.MinValue = -100000D;
            txtDeliveryTaxRate.Name = "txtDeliveryTaxRate";
            txtDeliveryTaxRate.Size = new Size(80, 24);
            txtDeliveryTaxRate.TabIndex = 77;
            txtDeliveryTaxRate.Text = "0.00";
            txtDeliveryTaxRate.TextAlign = HorizontalAlignment.Right;
            txtDeliveryTaxRate.Value = 0D;
            txtDeliveryTaxRate.KeyDown += Tax_KeyDown;
            // 
            // txtTakeAwayTaxRate
            // 
            txtTakeAwayTaxRate.CustomFormat = "0.00";
            txtTakeAwayTaxRate.CustomUICulture = "en-US";
            txtTakeAwayTaxRate.Font = new Font("Microsoft Sans Serif", 11F);
            txtTakeAwayTaxRate.Increment = 1D;
            txtTakeAwayTaxRate.Location = new Point(242, 93);
            txtTakeAwayTaxRate.MaxValue = 100000D;
            txtTakeAwayTaxRate.MinValue = -100000D;
            txtTakeAwayTaxRate.Name = "txtTakeAwayTaxRate";
            txtTakeAwayTaxRate.Size = new Size(80, 24);
            txtTakeAwayTaxRate.TabIndex = 75;
            txtTakeAwayTaxRate.Text = "0.00";
            txtTakeAwayTaxRate.TextAlign = HorizontalAlignment.Right;
            txtTakeAwayTaxRate.Value = 0D;
            txtTakeAwayTaxRate.KeyDown += Tax_KeyDown;
            // 
            // txtInHouseTaxRate
            // 
            txtInHouseTaxRate.CustomFormat = "0.00";
            txtInHouseTaxRate.CustomUICulture = "en-US";
            txtInHouseTaxRate.Font = new Font("Microsoft Sans Serif", 11F);
            txtInHouseTaxRate.Increment = 1D;
            txtInHouseTaxRate.Location = new Point(242, 56);
            txtInHouseTaxRate.MaxValue = 100000D;
            txtInHouseTaxRate.MinValue = -100000D;
            txtInHouseTaxRate.Name = "txtInHouseTaxRate";
            txtInHouseTaxRate.Size = new Size(80, 24);
            txtInHouseTaxRate.TabIndex = 73;
            txtInHouseTaxRate.Text = "0.00";
            txtInHouseTaxRate.TextAlign = HorizontalAlignment.Right;
            txtInHouseTaxRate.Value = 0D;
            txtInHouseTaxRate.KeyDown += Tax_KeyDown;
            // 
            // txtDirectSaleTaxRate
            // 
            txtDirectSaleTaxRate.CustomFormat = "0.00";
            txtDirectSaleTaxRate.CustomUICulture = "en-US";
            txtDirectSaleTaxRate.Font = new Font("Microsoft Sans Serif", 11F);
            txtDirectSaleTaxRate.Increment = 1D;
            txtDirectSaleTaxRate.Location = new Point(242, 23);
            txtDirectSaleTaxRate.MaxValue = 100000D;
            txtDirectSaleTaxRate.MinValue = -100000D;
            txtDirectSaleTaxRate.Name = "txtDirectSaleTaxRate";
            txtDirectSaleTaxRate.Size = new Size(80, 24);
            txtDirectSaleTaxRate.TabIndex = 71;
            txtDirectSaleTaxRate.Text = "0.00";
            txtDirectSaleTaxRate.TextAlign = HorizontalAlignment.Right;
            txtDirectSaleTaxRate.Value = 0D;
            txtDirectSaleTaxRate.KeyDown += Tax_KeyDown;
            // 
            // chkCompulsary
            // 
            chkCompulsary.AutoSize = true;
            chkCompulsary.BackgroundImageLayout = ImageLayout.Stretch;
            chkCompulsary.FlatAppearance.BorderSize = 0;
            chkCompulsary.Font = new Font("Microsoft Sans Serif", 11F);
            chkCompulsary.ForeColor = SystemColors.ControlText;
            chkCompulsary.Location = new Point(176, 430);
            chkCompulsary.Margin = new Padding(3, 3, 3, 0);
            chkCompulsary.Name = "chkCompulsary";
            chkCompulsary.Size = new Size(107, 22);
            chkCompulsary.TabIndex = 68;
            chkCompulsary.Text = "Compulsary";
            chkCompulsary.UseVisualStyleBackColor = false;
            chkCompulsary.CheckedChanged += chkCompulsary_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtInHouseTaxRate);
            groupBox1.Controls.Add(txtDirectSaleTaxRate);
            groupBox1.Controls.Add(txtTakeAwayTaxRate);
            groupBox1.Controls.Add(txtDeliveryTaxRate);
            groupBox1.Controls.Add(txtDirectSalePrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDeliveryPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTakeAwayPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtInHousePrice);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11F);
            groupBox1.Location = new Point(64, 462);
            groupBox1.Margin = new Padding(3, 3, 1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Price && Tax Rates";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Microsoft Sans Serif", 11F);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(19, 28);
            label9.Margin = new Padding(3, 3, 1, 3);
            label9.Name = "label9";
            label9.Size = new Size(37, 18);
            label9.TabIndex = 65;
            label9.Text = "Sale";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDirectSalePrice
            // 
            txtDirectSalePrice.CustomFormat = "C2";
            txtDirectSalePrice.CustomUICulture = "en-US";
            txtDirectSalePrice.Font = new Font("Microsoft Sans Serif", 11F);
            txtDirectSalePrice.Increment = 1D;
            txtDirectSalePrice.Location = new Point(115, 23);
            txtDirectSalePrice.Margin = new Padding(1, 2, 3, 3);
            txtDirectSalePrice.MaxValue = 100000D;
            txtDirectSalePrice.MinValue = -100000D;
            txtDirectSalePrice.Name = "txtDirectSalePrice";
            txtDirectSalePrice.Size = new Size(84, 24);
            txtDirectSalePrice.TabIndex = 1;
            txtDirectSalePrice.Text = "$0.00";
            txtDirectSalePrice.TextAlign = HorizontalAlignment.Right;
            txtDirectSalePrice.Value = 0D;
            txtDirectSalePrice.KeyDown += Price_KeyDown;
            // 
            // txtDeliveryPrice
            // 
            txtDeliveryPrice.CustomFormat = "C2";
            txtDeliveryPrice.CustomUICulture = "en-US";
            txtDeliveryPrice.Font = new Font("Microsoft Sans Serif", 11F);
            txtDeliveryPrice.Increment = 1D;
            txtDeliveryPrice.Location = new Point(115, 129);
            txtDeliveryPrice.Margin = new Padding(1, 3, 3, 3);
            txtDeliveryPrice.MaxValue = 100000D;
            txtDeliveryPrice.MinValue = -100000D;
            txtDeliveryPrice.Name = "txtDeliveryPrice";
            txtDeliveryPrice.Size = new Size(84, 24);
            txtDeliveryPrice.TabIndex = 4;
            txtDeliveryPrice.Text = "$0.00";
            txtDeliveryPrice.TextAlign = HorizontalAlignment.Right;
            txtDeliveryPrice.Value = 0D;
            txtDeliveryPrice.KeyDown += Price_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft Sans Serif", 11F);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(19, 134);
            label8.Margin = new Padding(3, 3, 1, 3);
            label8.Name = "label8";
            label8.Size = new Size(60, 18);
            label8.TabIndex = 60;
            label8.Text = "Delivery";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTakeAwayPrice
            // 
            txtTakeAwayPrice.CustomFormat = "C2";
            txtTakeAwayPrice.CustomUICulture = "en-US";
            txtTakeAwayPrice.Font = new Font("Microsoft Sans Serif", 11F);
            txtTakeAwayPrice.Increment = 1D;
            txtTakeAwayPrice.Location = new Point(115, 93);
            txtTakeAwayPrice.Margin = new Padding(1, 3, 3, 3);
            txtTakeAwayPrice.MaxValue = 100000D;
            txtTakeAwayPrice.MinValue = -100000D;
            txtTakeAwayPrice.Name = "txtTakeAwayPrice";
            txtTakeAwayPrice.Size = new Size(85, 24);
            txtTakeAwayPrice.TabIndex = 2;
            txtTakeAwayPrice.Text = "$0.00";
            txtTakeAwayPrice.TextAlign = HorizontalAlignment.Right;
            txtTakeAwayPrice.Value = 0D;
            txtTakeAwayPrice.KeyDown += Price_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(19, 97);
            label7.Margin = new Padding(3, 3, 1, 3);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 58;
            label7.Text = "Take Away";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkAvailableNone);
            groupBox3.Controls.Add(chkAvailableInternetTakeAway);
            groupBox3.Controls.Add(chkAvailableAll);
            groupBox3.Controls.Add(chkAvailableInternetDelivery);
            groupBox3.Controls.Add(chkAvailableDelivery);
            groupBox3.Controls.Add(chkAvailableTakeAway);
            groupBox3.Controls.Add(chkAvailableInHouse);
            groupBox3.Controls.Add(chkAvailableDirect);
            groupBox3.Font = new Font("Microsoft Sans Serif", 11F);
            groupBox3.Location = new Point(462, 325);
            groupBox3.Margin = new Padding(1, 3, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 306);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Available For";
            // 
            // chkAvailableNone
            // 
            chkAvailableNone.AutoSize = true;
            chkAvailableNone.FlatAppearance.BorderSize = 0;
            chkAvailableNone.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableNone.ForeColor = SystemColors.ControlText;
            chkAvailableNone.Location = new Point(16, 260);
            chkAvailableNone.Margin = new Padding(3, 1, 3, 3);
            chkAvailableNone.Name = "chkAvailableNone";
            chkAvailableNone.Size = new Size(91, 22);
            chkAvailableNone.TabIndex = 7;
            chkAvailableNone.Text = "NO SALE";
            chkAvailableNone.UseVisualStyleBackColor = false;
            chkAvailableNone.CheckedChanged += chkAvailableNone_CheckedChanged;
            // 
            // chkAvailableInternetTakeAway
            // 
            chkAvailableInternetTakeAway.AutoSize = true;
            chkAvailableInternetTakeAway.FlatAppearance.BorderSize = 0;
            chkAvailableInternetTakeAway.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableInternetTakeAway.ForeColor = SystemColors.ControlText;
            chkAvailableInternetTakeAway.Location = new Point(16, 161);
            chkAvailableInternetTakeAway.Name = "chkAvailableInternetTakeAway";
            chkAvailableInternetTakeAway.Size = new Size(151, 22);
            chkAvailableInternetTakeAway.TabIndex = 6;
            chkAvailableInternetTakeAway.Text = "Internet Take Away";
            chkAvailableInternetTakeAway.UseVisualStyleBackColor = false;
            chkAvailableInternetTakeAway.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // chkAvailableAll
            // 
            chkAvailableAll.AutoSize = true;
            chkAvailableAll.FlatAppearance.BorderSize = 0;
            chkAvailableAll.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableAll.ForeColor = SystemColors.ControlText;
            chkAvailableAll.Location = new Point(16, 227);
            chkAvailableAll.Margin = new Padding(3, 1, 3, 3);
            chkAvailableAll.Name = "chkAvailableAll";
            chkAvailableAll.Size = new Size(136, 22);
            chkAvailableAll.TabIndex = 4;
            chkAvailableAll.Text = "All Type of Sales";
            chkAvailableAll.UseVisualStyleBackColor = false;
            chkAvailableAll.CheckedChanged += chkAvailableAll_CheckedChanged;
            // 
            // chkAvailableInternetDelivery
            // 
            chkAvailableInternetDelivery.AutoSize = true;
            chkAvailableInternetDelivery.FlatAppearance.BorderSize = 0;
            chkAvailableInternetDelivery.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableInternetDelivery.ForeColor = SystemColors.ControlText;
            chkAvailableInternetDelivery.Location = new Point(16, 194);
            chkAvailableInternetDelivery.Name = "chkAvailableInternetDelivery";
            chkAvailableInternetDelivery.Size = new Size(131, 22);
            chkAvailableInternetDelivery.TabIndex = 3;
            chkAvailableInternetDelivery.Text = "Internet Delivery";
            chkAvailableInternetDelivery.UseVisualStyleBackColor = false;
            chkAvailableInternetDelivery.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // chkAvailableDelivery
            // 
            chkAvailableDelivery.AutoSize = true;
            chkAvailableDelivery.FlatAppearance.BorderSize = 0;
            chkAvailableDelivery.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableDelivery.ForeColor = SystemColors.ControlText;
            chkAvailableDelivery.Location = new Point(16, 128);
            chkAvailableDelivery.Name = "chkAvailableDelivery";
            chkAvailableDelivery.Size = new Size(79, 22);
            chkAvailableDelivery.TabIndex = 2;
            chkAvailableDelivery.Text = "Delivery";
            chkAvailableDelivery.UseVisualStyleBackColor = false;
            chkAvailableDelivery.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // chkAvailableTakeAway
            // 
            chkAvailableTakeAway.AutoSize = true;
            chkAvailableTakeAway.FlatAppearance.BorderSize = 0;
            chkAvailableTakeAway.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableTakeAway.ForeColor = SystemColors.ControlText;
            chkAvailableTakeAway.Location = new Point(16, 95);
            chkAvailableTakeAway.Margin = new Padding(3, 3, 3, 1);
            chkAvailableTakeAway.Name = "chkAvailableTakeAway";
            chkAvailableTakeAway.Size = new Size(99, 22);
            chkAvailableTakeAway.TabIndex = 1;
            chkAvailableTakeAway.Text = "Take Away";
            chkAvailableTakeAway.UseVisualStyleBackColor = false;
            chkAvailableTakeAway.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // chkAvailableInHouse
            // 
            chkAvailableInHouse.AutoSize = true;
            chkAvailableInHouse.FlatAppearance.BorderSize = 0;
            chkAvailableInHouse.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableInHouse.ForeColor = SystemColors.ControlText;
            chkAvailableInHouse.Location = new Point(16, 62);
            chkAvailableInHouse.Name = "chkAvailableInHouse";
            chkAvailableInHouse.Size = new Size(62, 22);
            chkAvailableInHouse.TabIndex = 0;
            chkAvailableInHouse.Text = "Sit IN";
            chkAvailableInHouse.UseVisualStyleBackColor = false;
            chkAvailableInHouse.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // chkAvailableDirect
            // 
            chkAvailableDirect.AutoSize = true;
            chkAvailableDirect.FlatAppearance.BorderSize = 0;
            chkAvailableDirect.Font = new Font("Microsoft Sans Serif", 11F);
            chkAvailableDirect.ForeColor = SystemColors.ControlText;
            chkAvailableDirect.Location = new Point(16, 29);
            chkAvailableDirect.Name = "chkAvailableDirect";
            chkAvailableDirect.Size = new Size(56, 22);
            chkAvailableDirect.TabIndex = 5;
            chkAvailableDirect.Text = "Sale";
            chkAvailableDirect.UseVisualStyleBackColor = false;
            chkAvailableDirect.CheckedChanged += chkAvailableOthers_CheckedChanged;
            // 
            // btnForeColor
            // 
            btnForeColor.BackColor = SystemColors.Control;
            btnForeColor.FlatAppearance.BorderSize = 0;
            btnForeColor.ForeColor = SystemColors.ControlText;
            btnForeColor.Location = new Point(558, 190);
            btnForeColor.Margin = new Padding(1, 3, 3, 3);
            btnForeColor.Name = "btnForeColor";
            btnForeColor.Size = new Size(82, 36);
            btnForeColor.TabIndex = 51;
            btnForeColor.TabStop = false;
            btnForeColor.Text = "Text Colour";
            btnForeColor.UseVisualStyleBackColor = true;
            btnForeColor.Click += btnForeColor_Click;
            // 
            // btnButtonColor
            // 
            btnButtonColor.BackColor = SystemColors.Control;
            btnButtonColor.FlatAppearance.BorderSize = 0;
            btnButtonColor.ForeColor = SystemColors.ControlText;
            btnButtonColor.Location = new Point(464, 190);
            btnButtonColor.Name = "btnButtonColor";
            btnButtonColor.Size = new Size(83, 36);
            btnButtonColor.TabIndex = 2;
            btnButtonColor.TabStop = false;
            btnButtonColor.Text = "Back Colour";
            btnButtonColor.UseVisualStyleBackColor = true;
            btnButtonColor.Click += btnButtonColor_Click;
            // 
            // btnUpdateButtonDetails
            // 
            btnUpdateButtonDetails.AutoEllipsis = true;
            btnUpdateButtonDetails.BackColor = SystemColors.Control;
            btnUpdateButtonDetails.FlatAppearance.BorderSize = 0;
            btnUpdateButtonDetails.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnUpdateButtonDetails.ForeColor = SystemColors.ControlText;
            btnUpdateButtonDetails.Location = new Point(586, 647);
            btnUpdateButtonDetails.Name = "btnUpdateButtonDetails";
            btnUpdateButtonDetails.Size = new Size(106, 50);
            btnUpdateButtonDetails.TabIndex = 2;
            btnUpdateButtonDetails.Text = "SAVE";
            btnUpdateButtonDetails.UseVisualStyleBackColor = false;
            btnUpdateButtonDetails.Click += btnUpdateButtonDetails_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(462, 647);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 50);
            btnClose.TabIndex = 9;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtCategoryItemName
            // 
            txtCategoryItemName.Font = new Font("Microsoft Sans Serif", 11F);
            txtCategoryItemName.Location = new Point(176, 11);
            txtCategoryItemName.Name = "txtCategoryItemName";
            txtCategoryItemName.Size = new Size(246, 24);
            txtCategoryItemName.TabIndex = 83;
            txtCategoryItemName.TextChanged += txtEntityButtonName_TextChanged;
            // 
            // incWidth
            // 
            incWidth.Font = new Font("Microsoft Sans Serif", 11F);
            incWidth.Increment = 10;
            incWidth.Location = new Point(176, 254);
            incWidth.MaxValue = 500;
            incWidth.MinValue = 20;
            incWidth.Name = "incWidth";
            incWidth.Size = new Size(80, 24);
            incWidth.TabIndex = 85;
            incWidth.Text = "20";
            incWidth.TextAlign = HorizontalAlignment.Center;
            incWidth.Value = 20;
            incWidth.ValueChanged += txtButtonWidth_ValueChanged;
            // 
            // incHeight
            // 
            incHeight.Font = new Font("Microsoft Sans Serif", 11F);
            incHeight.Increment = 10;
            incHeight.Location = new Point(176, 287);
            incHeight.MaxValue = 200;
            incHeight.MinValue = 20;
            incHeight.Name = "incHeight";
            incHeight.Size = new Size(80, 24);
            incHeight.TabIndex = 86;
            incHeight.Text = "20";
            incHeight.TextAlign = HorizontalAlignment.Center;
            incHeight.Value = 20;
            incHeight.ValueChanged += txtButtonHeight_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 11F);
            label16.Location = new Point(31, 257);
            label16.Name = "label16";
            label16.Size = new Size(93, 18);
            label16.TabIndex = 87;
            label16.Text = "Button Width";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 11F);
            label17.Location = new Point(31, 290);
            label17.Name = "label17";
            label17.Size = new Size(97, 18);
            label17.TabIndex = 88;
            label17.Text = "Button Height";
            // 
            // txtImageFile
            // 
            txtImageFile.BackColor = Color.FromArgb(250, 250, 250);
            txtImageFile.Font = new Font("Microsoft Sans Serif", 11F);
            txtImageFile.Location = new Point(464, 149);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.ReadOnly = true;
            txtImageFile.Size = new Size(175, 24);
            txtImageFile.TabIndex = 89;
            txtImageFile.TextChanged += txtImageFile_TextChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Font = new Font("Microsoft Sans Serif", 11F);
            lblFont.ForeColor = SystemColors.ControlText;
            lblFont.Location = new Point(31, 393);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(38, 18);
            lblFont.TabIndex = 94;
            lblFont.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.BackColor = SystemColors.Control;
            btnFont.FlatAppearance.BorderSize = 0;
            btnFont.ForeColor = SystemColors.ControlText;
            btnFont.Location = new Point(176, 388);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(247, 30);
            btnFont.TabIndex = 95;
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // incDisplayOrder
            // 
            incDisplayOrder.Font = new Font("Microsoft Sans Serif", 11F);
            incDisplayOrder.Increment = 1;
            incDisplayOrder.Location = new Point(176, 355);
            incDisplayOrder.MaxValue = 1000;
            incDisplayOrder.MinValue = 0;
            incDisplayOrder.Name = "incDisplayOrder";
            incDisplayOrder.Size = new Size(80, 24);
            incDisplayOrder.TabIndex = 96;
            incDisplayOrder.Text = "0";
            incDisplayOrder.TextAlign = HorizontalAlignment.Center;
            incDisplayOrder.Value = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 11F);
            label20.Location = new Point(31, 358);
            label20.Name = "label20";
            label20.Size = new Size(98, 18);
            label20.TabIndex = 97;
            label20.Text = "Display Order";
            // 
            // cmbDistributions
            // 
            cmbDistributions.DisplayMember = "DistributionName";
            cmbDistributions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistributions.Font = new Font("Microsoft Sans Serif", 11F);
            cmbDistributions.FormattingEnabled = true;
            cmbDistributions.Location = new Point(176, 320);
            cmbDistributions.Name = "cmbDistributions";
            cmbDistributions.Size = new Size(247, 26);
            cmbDistributions.TabIndex = 100;
            cmbDistributions.ValueMember = "IID";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 11F);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(31, 323);
            label21.Margin = new Padding(3, 3, 3, 1);
            label21.Name = "label21";
            label21.Size = new Size(82, 18);
            label21.TabIndex = 101;
            label21.Text = "Distribution";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtExtraText
            // 
            txtExtraText.AcceptsReturn = true;
            txtExtraText.AcceptsTab = true;
            txtExtraText.Font = new Font("Microsoft Sans Serif", 11F);
            txtExtraText.Location = new Point(262, 254);
            txtExtraText.Multiline = true;
            txtExtraText.Name = "txtExtraText";
            txtExtraText.Size = new Size(161, 57);
            txtExtraText.TabIndex = 105;
            // 
            // btnDeletePrepImage
            // 
            btnDeletePrepImage.Image = Properties.Resources.Cancel;
            btnDeletePrepImage.Location = new Point(591, 86);
            btnDeletePrepImage.Name = "btnDeletePrepImage";
            btnDeletePrepImage.Size = new Size(48, 48);
            btnDeletePrepImage.TabIndex = 104;
            btnDeletePrepImage.UseVisualStyleBackColor = true;
            btnDeletePrepImage.Click += btnDeletePrepImage_Click;
            // 
            // btnLoadPrepImageFromDirectory
            // 
            btnLoadPrepImageFromDirectory.Image = Properties.Resources.FolderOpen_32;
            btnLoadPrepImageFromDirectory.Location = new Point(592, 28);
            btnLoadPrepImageFromDirectory.Name = "btnLoadPrepImageFromDirectory";
            btnLoadPrepImageFromDirectory.Size = new Size(48, 48);
            btnLoadPrepImageFromDirectory.TabIndex = 103;
            btnLoadPrepImageFromDirectory.UseVisualStyleBackColor = true;
            btnLoadPrepImageFromDirectory.Click += btnLoadPrepImageFromDirectory_Click;
            // 
            // pBox
            // 
            pBox.BackColor = Color.White;
            pBox.BackgroundImageLayout = ImageLayout.Zoom;
            pBox.BorderStyle = BorderStyle.FixedSingle;
            pBox.Location = new Point(464, 28);
            pBox.Name = "pBox";
            pBox.Size = new Size(122, 106);
            pBox.TabIndex = 102;
            pBox.TabStop = false;
            pBox.DoubleClick += pBox_DoubleClick;
            // 
            // btnLoadPrepImageFromDatabase
            // 
            btnLoadPrepImageFromDatabase.Image = Properties.Resources.DBSource32;
            btnLoadPrepImageFromDatabase.Location = new Point(646, 28);
            btnLoadPrepImageFromDatabase.Name = "btnLoadPrepImageFromDatabase";
            btnLoadPrepImageFromDatabase.Size = new Size(48, 48);
            btnLoadPrepImageFromDatabase.TabIndex = 106;
            toolTip1.SetToolTip(btnLoadPrepImageFromDatabase, "Choose Image From Database");
            btnLoadPrepImageFromDatabase.UseVisualStyleBackColor = true;
            btnLoadPrepImageFromDatabase.Click += btnLoadPrepImageFromDatabase_Click;
            // 
            // lblImageSize
            // 
            lblImageSize.AutoSize = true;
            lblImageSize.Location = new Point(464, 10);
            lblImageSize.Name = "lblImageSize";
            lblImageSize.Size = new Size(30, 15);
            lblImageSize.TabIndex = 115;
            lblImageSize.Text = "0 KB";
            // 
            // cmbButtonDisplayStyle
            // 
            cmbButtonDisplayStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbButtonDisplayStyle.Font = new Font("Microsoft Sans Serif", 11F);
            cmbButtonDisplayStyle.FormattingEnabled = true;
            cmbButtonDisplayStyle.Location = new Point(176, 79);
            cmbButtonDisplayStyle.Name = "cmbButtonDisplayStyle";
            cmbButtonDisplayStyle.Size = new Size(247, 26);
            cmbButtonDisplayStyle.TabIndex = 116;
            cmbButtonDisplayStyle.SelectionChangeCommitted += cmbButtonDisplayStyle_SelectionChangeCommitted;
            // 
            // cmbImageAlign
            // 
            cmbImageAlign.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbImageAlign.Font = new Font("Microsoft Sans Serif", 11F);
            cmbImageAlign.FormattingEnabled = true;
            cmbImageAlign.Location = new Point(176, 114);
            cmbImageAlign.Name = "cmbImageAlign";
            cmbImageAlign.Size = new Size(246, 26);
            cmbImageAlign.TabIndex = 117;
            cmbImageAlign.SelectionChangeCommitted += cmbImageAlign_SelectionChangeCommitted;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11F);
            label11.Location = new Point(31, 82);
            label11.Name = "label11";
            label11.Size = new Size(87, 18);
            label11.TabIndex = 118;
            label11.Text = "Button Style";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11F);
            label12.Location = new Point(31, 117);
            label12.Name = "label12";
            label12.Size = new Size(83, 18);
            label12.TabIndex = 119;
            label12.Text = "Image Align";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSample });
            toolStrip1.Location = new Point(464, 235);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(103, 56);
            toolStrip1.TabIndex = 120;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSample
            // 
            btnSample.AutoSize = false;
            btnSample.ImageScaling = ToolStripItemImageScaling.None;
            btnSample.ImageTransparentColor = Color.Magenta;
            btnSample.Name = "btnSample";
            btnSample.Size = new Size(100, 53);
            btnSample.Text = "Sample";
            btnSample.Paint += btnSample_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(31, 152);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 122;
            label1.Text = "Text Align";
            // 
            // cmbTextAlign
            // 
            cmbTextAlign.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTextAlign.Font = new Font("Microsoft Sans Serif", 11F);
            cmbTextAlign.FormattingEnabled = true;
            cmbTextAlign.Location = new Point(176, 149);
            cmbTextAlign.Name = "cmbTextAlign";
            cmbTextAlign.Size = new Size(246, 26);
            cmbTextAlign.TabIndex = 121;
            cmbTextAlign.SelectionChangeCommitted += cmbTextAlign_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(31, 187);
            label3.Name = "label3";
            label3.Size = new Size(138, 18);
            label3.TabIndex = 124;
            label3.Text = "Text Image Relation";
            // 
            // cmbTextImageRelation
            // 
            cmbTextImageRelation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTextImageRelation.Font = new Font("Microsoft Sans Serif", 11F);
            cmbTextImageRelation.FormattingEnabled = true;
            cmbTextImageRelation.Location = new Point(177, 184);
            cmbTextImageRelation.Name = "cmbTextImageRelation";
            cmbTextImageRelation.Size = new Size(246, 26);
            cmbTextImageRelation.TabIndex = 123;
            cmbTextImageRelation.SelectionChangeCommitted += cmbTextImageRelation_SelectionChangeCommitted;
            // 
            // frmCategoryItemUpsert
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(725, 718);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(cmbTextImageRelation);
            Controls.Add(label1);
            Controls.Add(cmbTextAlign);
            Controls.Add(toolStrip1);
            Controls.Add(btnSetTaxToDefault);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cmbImageAlign);
            Controls.Add(cmbButtonDisplayStyle);
            Controls.Add(btnSetTaxToZero);
            Controls.Add(lblImageSize);
            Controls.Add(btnLoadPrepImageFromDatabase);
            Controls.Add(txtExtraText);
            Controls.Add(btnDeletePrepImage);
            Controls.Add(btnLoadPrepImageFromDirectory);
            Controls.Add(pBox);
            Controls.Add(label21);
            Controls.Add(cmbDistributions);
            Controls.Add(label20);
            Controls.Add(incDisplayOrder);
            Controls.Add(lblFont);
            Controls.Add(btnFont);
            Controls.Add(txtImageFile);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(incHeight);
            Controls.Add(incWidth);
            Controls.Add(txtCategoryItemName);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(cmbButtonType);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(label15);
            Controls.Add(cmbPadFlag);
            Controls.Add(chkCompulsary);
            Controls.Add(btnUpdateButtonDetails);
            Controls.Add(btnButtonColor);
            Controls.Add(btnForeColor);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCategoryItemUpsert";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CATEGORY ITEM DETAILS";
            Load += frmEntityButtonsEditor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private async void frmEntityButtonsEditor_Load(object sender, System.EventArgs e)
        {
            cmbButtonDisplayStyle.DataSource = Enum.GetValues(typeof(ButtonDisplayStyles));
            cmbImageAlign.DataSource = Enum.GetValues(typeof(ContentAlignmentX));
            cmbTextAlign.DataSource = Enum.GetValues(typeof(ContentAlignmentX));
            cmbTextImageRelation.DataSource = Enum.GetValues(typeof(TextImageRelationX));

            currentShop = await repoShop.GetFirst();

            if (!CategoryIID.IsNullOrEmpty())
            {
                category = await repoCategory.Get(CategoryIID);
            } else
            {
                if (categoryItem != null && !categoryItem.CategoryIID.IsNullOrEmpty())
                    category = await repoCategory.Get(categoryItem.CategoryIID);
                else
                {
                    //Category cannot be identified close this editor
                    Close();
                }
            }
            if (category == null)
            {
                Close();
            }
            if (categoryItem == null)
            {
                categoryItem = new CategoryItem()
                {
                    CategoryIID = category.IID
                };
            } else
            {
                if (categoryItem.IID == null)
                    categoryItem.CategoryIID = category.IID;
                else
                {
                    categoryItem = await repoCategoryItem.Get(categoryItem.IID, "Distribution");
                }
            }
            this.Text = this.Text + categoryItem == null ? "" : category.CategoryName + "  -- " + categoryItem.ItemName ?? "";
            await LoadDistributions();
            await LoadButtonDetails();
        }

        private async Task LoadDistributions()
        {

            _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID", category.MenuIID)).ToBindingList();
            cmbDistributions.DataSource = _distributionSource;
        }
        private async Task LoadButtonDetails()
        {
            UnloadButtonDetails();
            if (categoryItem != null)
            {
                //if (parentEntityButton != null)    //This is a subbutton editor
                //Make sure all the sub buttons of this categoryItem have a priceitem for each sizebarbutton and correctly ordered
                //parentEntityButton.SyncronizePriceItems();
                CultureInfo ci = UF.GetCulture(config.Terminal_Currency_Culture);

                txtCategoryItemName.Text = categoryItem.ItemName;
                btnButtonColor.BackColor = Color.FromArgb(categoryItem.BgColor);
                btnForeColor.BackColor = Color.FromArgb(categoryItem.FgColor);
                cmbButtonType.SelectedIndex = (int)categoryItem.ButtonType;


                txtDirectSaleTaxRate.CustomUICulture = txtInHouseTaxRate.CustomUICulture = txtTakeAwayTaxRate.CustomUICulture = txtDeliveryTaxRate.CustomUICulture = UF.GetCulture(config.Terminal_Currency_Culture).ToString();
                txtDirectSaleTaxRate.Value = categoryItem.SaleTax; //.ToString("f2",CultureInfo.CurrentUICulture);
                txtInHouseTaxRate.Value = categoryItem.SitinTax; //.ToString("f2", CultureInfo.CurrentUICulture);
                txtTakeAwayTaxRate.Value = categoryItem.TaTax; //.ToString("f2", CultureInfo.CurrentUICulture);
                txtDeliveryTaxRate.Value = categoryItem.DTax; //.ToString("f2", CultureInfo.CurrentUICulture);

                switch (categoryItem.PadFlag)
                {
                    case PadFlags.EBOnly:
                        cmbPadFlag.SelectedIndex = 0;
                        break;
                    case PadFlags.PadOnly:
                        cmbPadFlag.SelectedIndex = 1;
                        break;
                    case PadFlags.EBAndPad:
                        cmbPadFlag.SelectedIndex = 2;
                        break;
                    default:
                        cmbPadFlag.SelectedIndex = 0;
                        break;
                }

                try
                {
                    if (string.IsNullOrEmpty(categoryItem.DistributionIID))
                        categoryItem.DistributionIID = category.DistributionIID;
                    cmbDistributions.SelectedValue = categoryItem.DistributionIID;
                } catch { }

                try
                {

                    txtDirectSalePrice.CustomUICulture = txtInHousePrice.CustomUICulture = txtTakeAwayPrice.CustomUICulture = txtDeliveryPrice.CustomUICulture = UF.GetCulture(config.Terminal_Currency_Culture).ToString();
                    txtDirectSalePrice.Value = categoryItem.SalePrice;
                    txtInHousePrice.Value = categoryItem.SitinPrice;
                    txtTakeAwayPrice.Value = categoryItem.TaPrice;
                    txtDeliveryPrice.Value = categoryItem.DPrice;

                    string format = "c2";
                    if (categoryItem.ButtonType == CategoryItemTypes.PercentAddition || categoryItem.ButtonType == CategoryItemTypes.PercentDeduction)
                        format = "0\" %\"";
                    txtDirectSalePrice.CustomFormat = txtInHousePrice.CustomFormat = txtTakeAwayPrice.CustomFormat = txtDeliveryPrice.CustomFormat = format;


                } catch { }

                //Availability
                if (PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.All))
                    chkAvailableAll.Checked = true;
                else
                {
                    chkAvailableDirect.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.Direct);
                    chkAvailableInHouse.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.InHouse);
                    chkAvailableTakeAway.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.TakeAwayB);
                    chkAvailableDelivery.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.Delivery);
                    chkAvailableInternetTakeAway.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.InternetTakeAway);
                    chkAvailableInternetDelivery.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.InternetDelivery);
                    chkAvailableNone.Checked = PosLibrary.DRNumeric.IsBitSet(categoryItem.AvailableFor, (int)AvailabilityTypes.NoSale);
                }

                chkCompulsary.Checked = (categoryItem.Compulsary == 1);

                incWidth.Value = categoryItem.Width;
                incHeight.Value = categoryItem.Height;

                cmbButtonDisplayStyle.SelectedItem = categoryItem.ButtonDisplayStyle;
                cmbImageAlign.SelectedItem = categoryItem.ImageAlign;
                cmbTextAlign.SelectedItem = categoryItem.TextAlign;
                cmbTextImageRelation.SelectedItem = categoryItem.TextImageRelation;

                btnFont.Text = categoryItem.FFamily + "," + categoryItem.FSize.ToString() + "," + categoryItem.FStyle;
                incDisplayOrder.Value = categoryItem.DOrder;

                await LoadGenericImage();

                DisplaySample();

            }
        }

        private async Task LoadGenericImage()
        {
            try
            {
                gim = await repoImage.GetByField("ReferenceIID", categoryItem.IID);
                if (gim != null)
                {
                    if (gim.DisplayImage != null)
                        pBox.BackgroundImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                    txtExtraText.Text = gim.ExtraText;
                    txtImageFile.Text = gim.ImageFileName;
                    lblImageSize.Text = gim.ImageSizeinKB + " KB";
                }
            } catch
            {
            }
        }

        private void UnloadButtonDetails()
        {
            txtCategoryItemName.Clear();
            btnButtonColor.BackColor = SystemColors.Control;
            btnForeColor.BackColor = Color.Transparent;
            cmbButtonType.SelectedIndex = -1;

            txtDirectSalePrice.Value = 0; // = "0.0";
            txtInHousePrice.Value = 0; // = "0.0";
            txtTakeAwayPrice.Value = 0; // = "0.0";
            txtDeliveryPrice.Value = 0; // = "0.0";

            txtDirectSaleTaxRate.Value = 0; // = "0.0";
            txtInHouseTaxRate.Value = 0; //  = "0.0";
            txtTakeAwayTaxRate.Value = 0; // = "0.0";
            txtDeliveryTaxRate.Value = 0; // = "0.0";
            txtImageFile.Clear();
            btnFont.Text = "";
            incDisplayOrder.Value = 0;

            cmbPadFlag.SelectedIndex = 0;
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        private async void btnUpdateButtonDetails_Click(object sender, System.EventArgs e)
        {
            CultureInfo ci = UF.GetCulture(config.Terminal_Currency_Culture);
            if (categoryItem != null)
            {

                categoryItem.ButtonType = (CategoryItemTypes)cmbButtonType.SelectedIndex;



                categoryItem.SalePrice = (double)txtDirectSalePrice.Value; // double.Parse(txtDirectSalePrice.Text, CultureInfo.CurrentUICulture); // AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                categoryItem.SitinPrice = (double)txtInHousePrice.Value; // double.Parse(txtInHousePrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); //AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                categoryItem.TaPrice = (double)txtTakeAwayPrice.Value; // double.Parse(txtTakeAwayPrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); // AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                categoryItem.DPrice = (double)txtDeliveryPrice.Value; // double.Parse(txtDeliveryPrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); //AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 


                categoryItem.ItemName = txtCategoryItemName.Text;

                categoryItem.BgColor = btnButtonColor.BackColor.ToArgb();
                categoryItem.FgColor = btnForeColor.BackColor.ToArgb();

                //Availability
                categoryItem.AvailableFor = 0;
                if (!chkAvailableAll.Checked)
                {
                    categoryItem.AvailableFor = (chkAvailableDirect.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.Direct) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableInHouse.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.InHouse) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableTakeAway.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.TakeAwayB) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableDelivery.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.Delivery) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableInternetTakeAway.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.InternetTakeAway) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableInternetDelivery.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.InternetDelivery) : categoryItem.AvailableFor);
                    categoryItem.AvailableFor = (chkAvailableNone.Checked ? UF.SetBit(categoryItem.AvailableFor, (int)AvailabilityTypes.NoSale) : categoryItem.AvailableFor);

                }
                if (chkCompulsary.Checked)
                    categoryItem.Compulsary = 1;
                else
                    categoryItem.Compulsary = 0;



                categoryItem.SaleTax = (double)txtDirectSaleTaxRate.Value; // double.Parse(txtDirectSaleTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);
                categoryItem.SitinTax = (double)txtInHouseTaxRate.Value; // double.Parse(txtInHouseTaxRate.Text.Trim(), CultureInfo.CurrentUICulture);// , System.Globalization.NumberStyles.Any, ci);
                categoryItem.TaTax = (double)txtTakeAwayTaxRate.Value; // double.Parse(txtTakeAwayTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);
                categoryItem.DTax = (double)txtDeliveryTaxRate.Value; // double.Parse(txtDeliveryTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);

                switch (cmbPadFlag.SelectedIndex)
                {
                    case 0:
                        categoryItem.PadFlag = PadFlags.EBOnly;
                        break;
                    case 1:
                        categoryItem.PadFlag = PadFlags.PadOnly;
                        break;
                    case 2:
                        categoryItem.PadFlag = PadFlags.EBAndPad;
                        break;
                    default:
                        categoryItem.PadFlag = PadFlags.EBOnly;
                        break;
                }

                categoryItem.DistributionIID = cmbDistributions.SelectedValue.ToString();

                categoryItem.Width = incWidth.Value;
                categoryItem.Height = incHeight.Value;

                categoryItem.DOrder = (int)incDisplayOrder.Value;

                categoryItem.ButtonDisplayStyle = (ButtonDisplayStyles)cmbButtonDisplayStyle.SelectedItem;
                categoryItem.ImageAlign = (ContentAlignmentX)cmbImageAlign.SelectedItem;
                categoryItem.TextAlign = (ContentAlignmentX)cmbTextAlign.SelectedItem;
                categoryItem.TextImageRelation = (TextImageRelationX)cmbTextImageRelation.SelectedItem;

                await repoCategoryItem.Save(categoryItem);

                if ((categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.Image || categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText) && pBox.BackgroundImage != null)
                {
                    byte[] imgBytes = UFWin.ReSizeImageTo(pBox.BackgroundImage, config.CategoryItem_Image_Width, config.CategoryItem_Image_Height, true).ToByteArray();

                    GenericImage gim = new GenericImage()
                    {
                        ReferenceIID = categoryItem.IID,
                        DisplayImage = imgBytes,
                        ExtraText = txtExtraText.Text,
                        ImageFileName = txtImageFile.Text,
                        ImageSizeinKB = imgBytes?.Length / 1024 ?? 0,
                    };
                    if (categoryItem.IID == null)
                        await repoImage.Save(gim);
                    else
                        await repoImage.SaveByField("ReferenceIID", categoryItem.IID, gim);
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }



        private void cmbButtonType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (categoryItem != null)
            {
                if (category.CategoryType == CategoryTypes.SpecialCategory &&
                    cmbButtonType.SelectedIndex < 7)
                    cmbButtonType.SelectedIndex = (int)categoryItem.ButtonType;
            }

            switch (cmbButtonType.SelectedIndex)
            {
                case (int)CategoryItemTypes.SimpleItem:
                    break;
                case (int)CategoryItemTypes.AmountAddition:
                    break;
                case (int)CategoryItemTypes.AmountDeduction:
                    break;
                case (int)CategoryItemTypes.PercentAddition:
                    break;
                case (int)CategoryItemTypes.PercentDeduction:
                    break;
                case (int)CategoryItemTypes.CustomAddition:
                    break;
                case (int)CategoryItemTypes.CustomDeduction:
                    break;
                case (int)CategoryItemTypes.SpaceButton:
                    ResetAndLockForSpaceButton();
                    break;
            }
            txtCategoryItemName.Enabled = true;
        }

        private void ResetAndLockForSpaceButton()
        {
            btnButtonColor.BackColor = Color.Black;
            btnForeColor.BackColor = Color.Black;

        }


        private void chkAvailableAll_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkAvailableAll.Checked)
            {
                chkAvailableNone.Checked = false;
                chkAvailableDirect.Checked = false;
                chkAvailableInHouse.Checked = false;
                chkAvailableTakeAway.Checked = false;
                chkAvailableDelivery.Checked = false;
                chkAvailableInternetDelivery.Checked = false;
                chkAvailableInternetTakeAway.Checked = false;
                //((CheckBox)sender).BackColor = Color.LimeGreen;
            }

        }
        private void chkAvailableNone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvailableNone.Checked)
            {
                chkAvailableDirect.Checked = false;
                chkAvailableInHouse.Checked = false;
                chkAvailableTakeAway.Checked = false;
                chkAvailableDelivery.Checked = false;
                chkAvailableInternetDelivery.Checked = false;
                chkAvailableInternetTakeAway.Checked = false;
                chkAvailableAll.Checked = false;
            }
        }
        private void chkAvailableOthers_CheckedChanged(object sender, System.EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                chkAvailableAll.Checked = false;
                chkAvailableNone.Checked = false;
            }

        }



        private void chkCompulsary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompulsary.Checked)
                ((CheckBox)sender).BackColor = Color.LimeGreen;
            else
                ((CheckBox)sender).BackColor = Color.Brown;
        }

        private void Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoubleTextBox txt = sender as DoubleTextBox;
                txt.ReValidate();
                txtInHousePrice.Value = txtTakeAwayPrice.Value = txtDeliveryPrice.Value = txtDirectSalePrice.Value = txt.Value;
            }
        }

        private void Tax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoubleTextBox txt = sender as DoubleTextBox;
                txt.ReValidate();
                txtDirectSaleTaxRate.Value = txtTakeAwayTaxRate.Value = txtDeliveryTaxRate.Value = txtInHouseTaxRate.Value = txt.Value;
            }
        }

        private void btnSetTaxToZero_Click(object sender, EventArgs e)
        {
            txtDirectSaleTaxRate.Value = txtInHouseTaxRate.Value = txtTakeAwayTaxRate.Value = txtDeliveryTaxRate.Value = 0;
        }

        private async void btnSetTaxToDefault_Click(object sender, EventArgs e)
        {
            txtDirectSaleTaxRate.Value = txtInHouseTaxRate.Value = txtTakeAwayTaxRate.Value = txtDeliveryTaxRate.Value = currentShop.DefaultTaxRate;
        }

        private void btnButtonColor_Click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog cdlg = new ColorDialog
            {
                Color = btn.BackColor
            };
            cdlg.ShowDialog();
            btn.BackColor = cdlg.Color;

            categoryItem.BgColor = btnButtonColor.BackColor.ToArgb();
            DisplaySample();
        }
        private void btnForeColor_Click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = btn.BackColor;
            cdlg.ShowDialog();
            btn.BackColor = cdlg.Color;
            categoryItem.FgColor = btnForeColor.BackColor.ToArgb();
            DisplaySample();
        }

        private void txtEntityButtonName_TextChanged(object sender, EventArgs e)
        {
            categoryItem.ItemName = txtCategoryItemName.Text;
            DisplaySample();
        }

        private void txtButtonWidth_ValueChanged(object sender, EventArgs e)
        {
           categoryItem.Width = incWidth.Value;
            DisplaySample();
        }

        private void txtButtonHeight_ValueChanged(object sender, EventArgs e)
        {
            categoryItem.Height = incHeight.Value;
            DisplaySample();
        }

        private void txtImageFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtImageFile.Text.Length > 0)
                    btnSample.Image = Image.FromFile(txtImageFile.Text);
            } catch { }
        }

        private async void DisplaySample()
        {
            btnSample.Width = categoryItem.Width;
            btnSample.Height = categoryItem.Height;
            btnSample.Text = categoryItem.ItemName;
            btnSample.Font = new Font(categoryItem.FFamily, (float)categoryItem.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), categoryItem.FStyle));
            btnSample.BackColor = Color.FromArgb(categoryItem.BgColor);
            btnSample.ForeColor = Color.FromArgb(categoryItem.FgColor);

            btnSample.DisplayStyle = (ToolStripItemDisplayStyle)categoryItem.ButtonDisplayStyle;
            btnSample.TextAlign = (ContentAlignment)categoryItem.TextAlign;
            btnSample.ImageAlign = (ContentAlignment)categoryItem.ImageAlign;
            btnSample.TextImageRelation = (TextImageRelation)categoryItem.TextImageRelation;

            if (categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.Image || categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
            {
                if (gim != null && gim.DisplayImage != null)
                {
                    Image btnImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                    btnSample.Image = UFWin.ReSizeImageTo(btnImage, btnSample.Height - 5, btnSample.Height - 5);
                    btnSample.ImageScaling = ToolStripItemImageScaling.None;
                    btnSample.Invalidate();
                }
            }
        }
        private void btnSample_Paint(object sender, PaintEventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            // Draw a solid red border around the button's content area
            ControlPaint.DrawBorder(e.Graphics, btn.ContentRectangle,
                Color.Red, ButtonBorderStyle.Solid);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog
            {
                Font = new Font(categoryItem.FFamily, (float)categoryItem.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), categoryItem.FStyle))
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                categoryItem.FFamily = fd.Font.FontFamily.Name;
                categoryItem.FSize = fd.Font.Size;
                categoryItem.FStyle = fd.Font.Style.ToString();
                btnFont.Text = categoryItem.FFamily + "," + categoryItem.FSize.ToString() + "," + categoryItem.FStyle;
                btnSample.Font = new Font(categoryItem.FFamily, (float)categoryItem.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), categoryItem.FStyle));
            }
        }

        private void btnLoadPrepImageFromDirectory_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Button Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo finfo = new FileInfo(dlg.FileName);
                txtImageFile.Text = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = UFWin.ReSizeImageTo(img, 200, 200, true);

                byte[] imgArray = pBox.BackgroundImage.ToByteArray();
                gim = new GenericImage()
                {
                    ReferenceIID = categoryItem.IID,
                    DisplayImage = imgArray,
                    ExtraText = txtExtraText.Text,
                    ImageFileName = finfo.Name,
                    ImageSizeinKB = imgArray?.Length / 1024 ?? 0,
                };

                DisplaySample();
            }
        }

        private async void btnDeletePrepImage_Click(object sender, EventArgs e)
        {
            await repoImage.Delete(categoryItem.IID);
            pBox.BackgroundImage = null;
        }

        private void btnLoadPrepImageFromDatabase_Click(object sender, EventArgs e)
        {
            frmImageList frm = ActivatorUtilities.CreateInstance<frmImageList>(ServiceHelper.Services, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                pBox.BackgroundImage = frm.SelectedImage;
            }
        }

        //private void chkWithImage_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkWithImage.Checked)
        //    {
        //        if (gim != null && gim.DisplayImage != null)
        //        {
        //            try
        //            {
        //                btnSample.Image = UFWin.ByteArrayToImage(gim.DisplayImage);
        //            } catch { }
        //        }
        //    } else
        //    {
        //        btnSample.Image = null;
        //    }
        //}



        private async void pBox_DoubleClick(object sender, EventArgs e)
        {
            frmGenericImageEditor frm = ActivatorUtilities.CreateInstance<frmGenericImageEditor>(ServiceHelper.Services, await repoImage.Get(categoryItem.IID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await LoadGenericImage();
            }
        }

        private void cmbButtonDisplayStyle_SelectionChangeCommitted(object sender, EventArgs e)
        {
              categoryItem.ButtonDisplayStyle = (ButtonDisplayStyles)cmbButtonDisplayStyle.SelectedItem;
            DisplaySample();
        }

        private void cmbImageAlign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryItem.ImageAlign = (ContentAlignmentX)cmbImageAlign.SelectedItem;
            DisplaySample();
        }

        private void cmbTextAlign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryItem.TextAlign = (ContentAlignmentX)cmbTextAlign.SelectedItem;
            DisplaySample();
        }

        private void cmbTextImageRelation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryItem.TextImageRelation = (TextImageRelationX)cmbTextImageRelation.SelectedItem;
            DisplaySample();
        }
    }
}
