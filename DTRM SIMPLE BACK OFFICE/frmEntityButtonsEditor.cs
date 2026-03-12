using System;
using System.Drawing;
using System.Windows.Forms;
using DTRMNS;
using PosLibrary;
using System.Globalization;
using System.IO;

namespace DTRMSimpleBackOffice {
    /// <summary>
    /// Summary description for frmEntitiButtonsEditor.
    /// </summary>
    public class FrmEntityButtonsEditor : Form {

        private DTRMNS.DTRMSimpleBusiness bslayer;

        public Entity entity;
        public EntityButton entityButton;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateButtonDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnButtonColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbButtonType;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DoubleTextBox txtInHousePrice;
        private DoubleTextBox txtDeliveryPrice;
        private DoubleTextBox txtTakeAwayPrice;


        private System.Windows.Forms.Button btnDeliveryOthersSame;
        private System.Windows.Forms.Button btnTakeAwayOthersSame;
        private System.Windows.Forms.Button btnInHouseOthersSame;
        private System.Windows.Forms.CheckBox chkAvailableDelivery;
        private System.Windows.Forms.CheckBox chkAvailableTakeAway;
        private System.Windows.Forms.CheckBox chkAvailableInHouse;
        private System.Windows.Forms.CheckBox chkAvailableInternetDelivery;
        private System.Windows.Forms.CheckBox chkAvailableAll;
        private System.Windows.Forms.Button btnDirectOthersSame;
        private System.Windows.Forms.Label label9;
        private DoubleTextBox txtDirectSalePrice;
        private System.Windows.Forms.CheckBox chkAvailableDirect;
        private CheckBox chkCompulsary;
        private CheckBox chkAvailableInternetTakeAway;
        private Label label14;
        private DoubleTextBox txtDeliveryTaxRate;
        private Label label6;
        private DoubleTextBox txtTakeAwayTaxRate;
        private Label label3;
        private DoubleTextBox txtInHouseTaxRate;
        private Label label1;
        private DoubleTextBox txtDirectSaleTaxRate;
        private Label label15;
        private ComboBox cmbPadFlag;
        private System.Windows.Forms.Button btnSetTaxToDefault;
        private System.Windows.Forms.Button btnSetTaxToZero;
        private TextBox txtEntityButtonName;
        private PosLibrary.IntegerTextBox incWidth;
        private PosLibrary.IntegerTextBox incHeight;
        private Label label16;
        private Label label17;
        private TextBox txtImageFile;
        private Label label18;
        private Button btnSample;
        private Label lblFont;
        private Button btnFont;
        private PosLibrary.IntegerTextBox incDisplayOrder;
        private Label label20;
        private Button btnDeliveryTaxOthersSame;
        private Button btnInHouseTaxOthersSame;
        private Button btnDirectTaxOthersSame;
        private Button btnTakeAwayTaxOthersSame;
        private ComboBox cmbDistributions;
        private Label label21;
        private PictureBox pBox;
        private Button btnLoadPrepImageFromDirectory;
        private Button btnDeletePrepImage;
        private TextBox txtExtraText;
        private Button btnLoadPrepImageFromDatabase;
        private CheckBox chkWithImage;
        private GroupBox groupBox2;
        private Button btnMinusWidth;
        private Button btnPlusWidth;
        private Button btnMinusHeight;
        private Button btnPlusHeight;
        private Button btnMInusOrder;
        private Button btnPlusOrder;
        private CheckBox chkAvailableNone;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private Label label10;
        private Label lblImageSize;
        private GenericImage gim;

        public FrmEntityButtonsEditor() {
            InitializeComponent();
        }
        public FrmEntityButtonsEditor(DTRMNS.DTRMSimpleBusiness bslayer,  EntityButton entityButton) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.entity = bslayer.GetJustEntity(entityButton.PEIID);
            this.entityButton = entityButton;

            this.Text = this.Text + "  -- " + entityButton.EntityButtonName;
        }
        public FrmEntityButtonsEditor(DTRMNS.DTRMSimpleBusiness bslayer, Entity entity, EntityButton entityButton) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.entity = entity;
            this.entityButton = entityButton;

            this.Text = this.Text + "  -- " + entityButton.EntityButtonName;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInHousePrice = new PosLibrary.DoubleTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbButtonType = new System.Windows.Forms.ComboBox();
            this.btnSetTaxToDefault = new System.Windows.Forms.Button();
            this.btnSetTaxToZero = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPadFlag = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeliveryTaxRate = new PosLibrary.DoubleTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTakeAwayTaxRate = new PosLibrary.DoubleTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInHouseTaxRate = new PosLibrary.DoubleTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectSaleTaxRate = new PosLibrary.DoubleTextBox();
            this.chkCompulsary = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeliveryOthersSame = new System.Windows.Forms.Button();
            this.btnInHouseOthersSame = new System.Windows.Forms.Button();
            this.btnDirectOthersSame = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDirectSalePrice = new PosLibrary.DoubleTextBox();
            this.btnTakeAwayOthersSame = new System.Windows.Forms.Button();
            this.txtDeliveryPrice = new PosLibrary.DoubleTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTakeAwayPrice = new PosLibrary.DoubleTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAvailableNone = new System.Windows.Forms.CheckBox();
            this.chkAvailableInternetTakeAway = new System.Windows.Forms.CheckBox();
            this.chkAvailableAll = new System.Windows.Forms.CheckBox();
            this.chkAvailableInternetDelivery = new System.Windows.Forms.CheckBox();
            this.chkAvailableDelivery = new System.Windows.Forms.CheckBox();
            this.chkAvailableTakeAway = new System.Windows.Forms.CheckBox();
            this.chkAvailableInHouse = new System.Windows.Forms.CheckBox();
            this.chkAvailableDirect = new System.Windows.Forms.CheckBox();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnButtonColor = new System.Windows.Forms.Button();
            this.btnUpdateButtonDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtEntityButtonName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeliveryTaxOthersSame = new System.Windows.Forms.Button();
            this.btnInHouseTaxOthersSame = new System.Windows.Forms.Button();
            this.btnDirectTaxOthersSame = new System.Windows.Forms.Button();
            this.btnTakeAwayTaxOthersSame = new System.Windows.Forms.Button();
            this.incWidth = new PosLibrary.IntegerTextBox();
            this.incHeight = new PosLibrary.IntegerTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtImageFile = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSample = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.incDisplayOrder = new PosLibrary.IntegerTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbDistributions = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtExtraText = new System.Windows.Forms.TextBox();
            this.btnDeletePrepImage = new System.Windows.Forms.Button();
            this.btnLoadPrepImageFromDirectory = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnLoadPrepImageFromDatabase = new System.Windows.Forms.Button();
            this.chkWithImage = new System.Windows.Forms.CheckBox();
            this.btnMinusWidth = new System.Windows.Forms.Button();
            this.btnPlusWidth = new System.Windows.Forms.Button();
            this.btnMinusHeight = new System.Windows.Forms.Button();
            this.btnPlusHeight = new System.Windows.Forms.Button();
            this.btnMInusOrder = new System.Windows.Forms.Button();
            this.btnPlusOrder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tables";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInHousePrice
            // 
            this.txtInHousePrice.CustomFormat = "C2";
            this.txtInHousePrice.CustomUICulture = "en-US";
            this.txtInHousePrice.Font = new System.Drawing.Font("Arial", 14F);
            this.txtInHousePrice.Increment = 1D;
            this.txtInHousePrice.Location = new System.Drawing.Point(65, 57);
            this.txtInHousePrice.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtInHousePrice.MaxValue = 100000D;
            this.txtInHousePrice.MinValue = -100000D;
            this.txtInHousePrice.Name = "txtInHousePrice";
            this.txtInHousePrice.Size = new System.Drawing.Size(84, 29);
            this.txtInHousePrice.TabIndex = 3;
            this.txtInHousePrice.Text = "$0.00";
            this.txtInHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInHousePrice.Value = 0D;
            this.txtInHousePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInHousePrice_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(400, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbButtonType
            // 
            this.cmbButtonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbButtonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbButtonType.FormattingEnabled = true;
            this.cmbButtonType.ItemHeight = 18;
            this.cmbButtonType.Items.AddRange(new object[] {
            "Simple Item",
            "Extra Item",
            "Ex & Disco Amount Addition",
            "Ex & Disco Percent Addition",
            "Ex & Disco Custom Addition",
            "Ex & Disco Amount Deduction",
            "Ex & Disco Percent Deduction",
            "Ex & Disco Custom Deduction",
            "Space Button"});
            this.cmbButtonType.Location = new System.Drawing.Point(451, 19);
            this.cmbButtonType.MaxDropDownItems = 40;
            this.cmbButtonType.Name = "cmbButtonType";
            this.cmbButtonType.Size = new System.Drawing.Size(246, 26);
            this.cmbButtonType.TabIndex = 1;
            this.cmbButtonType.TabStop = false;
            this.cmbButtonType.SelectedIndexChanged += new System.EventHandler(this.cmbButtonType_SelectedIndexChanged);
            // 
            // btnSetTaxToDefault
            // 
            this.btnSetTaxToDefault.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetTaxToDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetTaxToDefault.FlatAppearance.BorderSize = 0;
            this.btnSetTaxToDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSetTaxToDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetTaxToDefault.Location = new System.Drawing.Point(193, 97);
            this.btnSetTaxToDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnSetTaxToDefault.Name = "btnSetTaxToDefault";
            this.btnSetTaxToDefault.Size = new System.Drawing.Size(81, 65);
            this.btnSetTaxToDefault.TabIndex = 82;
            this.btnSetTaxToDefault.Text = "Set Tax Default";
            this.btnSetTaxToDefault.UseVisualStyleBackColor = false;
            this.btnSetTaxToDefault.Click += new System.EventHandler(this.btnSetTaxToDefault_Click);
            // 
            // btnSetTaxToZero
            // 
            this.btnSetTaxToZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetTaxToZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetTaxToZero.FlatAppearance.BorderSize = 0;
            this.btnSetTaxToZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnSetTaxToZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetTaxToZero.Location = new System.Drawing.Point(193, 23);
            this.btnSetTaxToZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnSetTaxToZero.Name = "btnSetTaxToZero";
            this.btnSetTaxToZero.Size = new System.Drawing.Size(81, 63);
            this.btnSetTaxToZero.TabIndex = 81;
            this.btnSetTaxToZero.Text = "Set Tax 0% ";
            this.btnSetTaxToZero.UseVisualStyleBackColor = false;
            this.btnSetTaxToZero.Click += new System.EventHandler(this.btnSetTaxToZero_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Pad Flag";
            // 
            // cmbPadFlag
            // 
            this.cmbPadFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPadFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPadFlag.FormattingEnabled = true;
            this.cmbPadFlag.Items.AddRange(new object[] {
            "EBOnly",
            "PadOnly",
            "EBAndPad"});
            this.cmbPadFlag.Location = new System.Drawing.Point(194, 256);
            this.cmbPadFlag.Name = "cmbPadFlag";
            this.cmbPadFlag.Size = new System.Drawing.Size(185, 28);
            this.cmbPadFlag.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(14, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 14);
            this.label14.TabIndex = 78;
            this.label14.Text = "Delivery";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeliveryTaxRate
            // 
            this.txtDeliveryTaxRate.CustomFormat = "0\" %\"";
            this.txtDeliveryTaxRate.CustomUICulture = "en-US";
            this.txtDeliveryTaxRate.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDeliveryTaxRate.Increment = 1D;
            this.txtDeliveryTaxRate.Location = new System.Drawing.Point(89, 136);
            this.txtDeliveryTaxRate.MaxValue = 100000D;
            this.txtDeliveryTaxRate.MinValue = -100000D;
            this.txtDeliveryTaxRate.Name = "txtDeliveryTaxRate";
            this.txtDeliveryTaxRate.Size = new System.Drawing.Size(54, 26);
            this.txtDeliveryTaxRate.TabIndex = 77;
            this.txtDeliveryTaxRate.Text = "0 %";
            this.txtDeliveryTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeliveryTaxRate.Value = 0D;
            this.txtDeliveryTaxRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliveryTaxRate_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 76;
            this.label6.Text = "Take Away";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTakeAwayTaxRate
            // 
            this.txtTakeAwayTaxRate.CustomFormat = "0\" %\"";
            this.txtTakeAwayTaxRate.CustomUICulture = "en-US";
            this.txtTakeAwayTaxRate.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTakeAwayTaxRate.Increment = 1D;
            this.txtTakeAwayTaxRate.Location = new System.Drawing.Point(89, 97);
            this.txtTakeAwayTaxRate.MaxValue = 100000D;
            this.txtTakeAwayTaxRate.MinValue = -100000D;
            this.txtTakeAwayTaxRate.Name = "txtTakeAwayTaxRate";
            this.txtTakeAwayTaxRate.Size = new System.Drawing.Size(54, 26);
            this.txtTakeAwayTaxRate.TabIndex = 75;
            this.txtTakeAwayTaxRate.Text = "0 %";
            this.txtTakeAwayTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTakeAwayTaxRate.Value = 0D;
            this.txtTakeAwayTaxRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTakeAwayTaxRate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tables";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInHouseTaxRate
            // 
            this.txtInHouseTaxRate.CustomFormat = "0\" %\"";
            this.txtInHouseTaxRate.CustomUICulture = "en-US";
            this.txtInHouseTaxRate.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInHouseTaxRate.Increment = 1D;
            this.txtInHouseTaxRate.Location = new System.Drawing.Point(89, 60);
            this.txtInHouseTaxRate.MaxValue = 100000D;
            this.txtInHouseTaxRate.MinValue = -100000D;
            this.txtInHouseTaxRate.Name = "txtInHouseTaxRate";
            this.txtInHouseTaxRate.Size = new System.Drawing.Size(54, 26);
            this.txtInHouseTaxRate.TabIndex = 73;
            this.txtInHouseTaxRate.Text = "0 %";
            this.txtInHouseTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInHouseTaxRate.Value = 0D;
            this.txtInHouseTaxRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInHouseTaxRate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 72;
            this.label1.Text = "Direct";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDirectSaleTaxRate
            // 
            this.txtDirectSaleTaxRate.CustomFormat = "0\" %\"";
            this.txtDirectSaleTaxRate.CustomUICulture = "en-US";
            this.txtDirectSaleTaxRate.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDirectSaleTaxRate.Increment = 1D;
            this.txtDirectSaleTaxRate.Location = new System.Drawing.Point(89, 24);
            this.txtDirectSaleTaxRate.MaxValue = 100000D;
            this.txtDirectSaleTaxRate.MinValue = -100000D;
            this.txtDirectSaleTaxRate.Name = "txtDirectSaleTaxRate";
            this.txtDirectSaleTaxRate.Size = new System.Drawing.Size(54, 26);
            this.txtDirectSaleTaxRate.TabIndex = 71;
            this.txtDirectSaleTaxRate.Text = "0 %";
            this.txtDirectSaleTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDirectSaleTaxRate.Value = 0D;
            this.txtDirectSaleTaxRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDirectSaleTaxRate_KeyDown);
            // 
            // chkCompulsary
            // 
            this.chkCompulsary.AutoSize = true;
            this.chkCompulsary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkCompulsary.FlatAppearance.BorderSize = 0;
            this.chkCompulsary.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkCompulsary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCompulsary.Location = new System.Drawing.Point(49, 541);
            this.chkCompulsary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.chkCompulsary.Name = "chkCompulsary";
            this.chkCompulsary.Size = new System.Drawing.Size(93, 18);
            this.chkCompulsary.TabIndex = 68;
            this.chkCompulsary.Text = "Compulsary";
            this.chkCompulsary.UseVisualStyleBackColor = false;
            this.chkCompulsary.CheckedChanged += new System.EventHandler(this.chkCompulsary_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeliveryOthersSame);
            this.groupBox1.Controls.Add(this.btnInHouseOthersSame);
            this.groupBox1.Controls.Add(this.btnDirectOthersSame);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDirectSalePrice);
            this.groupBox1.Controls.Add(this.btnTakeAwayOthersSame);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDeliveryPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTakeAwayPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInHousePrice);
            this.groupBox1.Location = new System.Drawing.Point(38, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // btnDeliveryOthersSame
            // 
            this.btnDeliveryOthersSame.AutoEllipsis = true;
            this.btnDeliveryOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnDeliveryOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeliveryOthersSame.FlatAppearance.BorderSize = 0;
            this.btnDeliveryOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDeliveryOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnDeliveryOthersSame.Location = new System.Drawing.Point(156, 129);
            this.btnDeliveryOthersSame.Name = "btnDeliveryOthersSame";
            this.btnDeliveryOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnDeliveryOthersSame.TabIndex = 63;
            this.btnDeliveryOthersSame.UseVisualStyleBackColor = false;
            this.btnDeliveryOthersSame.Click += new System.EventHandler(this.btnDeliveryOthersSame_Click);
            // 
            // btnInHouseOthersSame
            // 
            this.btnInHouseOthersSame.AutoEllipsis = true;
            this.btnInHouseOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnInHouseOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInHouseOthersSame.FlatAppearance.BorderSize = 0;
            this.btnInHouseOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHouseOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInHouseOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnInHouseOthersSame.Location = new System.Drawing.Point(156, 58);
            this.btnInHouseOthersSame.Name = "btnInHouseOthersSame";
            this.btnInHouseOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnInHouseOthersSame.TabIndex = 61;
            this.btnInHouseOthersSame.UseVisualStyleBackColor = false;
            this.btnInHouseOthersSame.Click += new System.EventHandler(this.btnInHouseOthersSame_Click);
            // 
            // btnDirectOthersSame
            // 
            this.btnDirectOthersSame.AutoEllipsis = true;
            this.btnDirectOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnDirectOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectOthersSame.FlatAppearance.BorderSize = 0;
            this.btnDirectOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDirectOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnDirectOthersSame.Location = new System.Drawing.Point(156, 23);
            this.btnDirectOthersSame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnDirectOthersSame.Name = "btnDirectOthersSame";
            this.btnDirectOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnDirectOthersSame.TabIndex = 66;
            this.btnDirectOthersSame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectOthersSame.UseVisualStyleBackColor = false;
            this.btnDirectOthersSame.Click += new System.EventHandler(this.btnDirectOthersSame_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Direct";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirectSalePrice
            // 
            this.txtDirectSalePrice.CustomFormat = "C2";
            this.txtDirectSalePrice.CustomUICulture = "en-US";
            this.txtDirectSalePrice.Font = new System.Drawing.Font("Arial", 14F);
            this.txtDirectSalePrice.Increment = 1D;
            this.txtDirectSalePrice.Location = new System.Drawing.Point(66, 23);
            this.txtDirectSalePrice.Margin = new System.Windows.Forms.Padding(1, 2, 3, 3);
            this.txtDirectSalePrice.MaxValue = 100000D;
            this.txtDirectSalePrice.MinValue = -100000D;
            this.txtDirectSalePrice.Name = "txtDirectSalePrice";
            this.txtDirectSalePrice.Size = new System.Drawing.Size(84, 29);
            this.txtDirectSalePrice.TabIndex = 1;
            this.txtDirectSalePrice.Text = "$0.00";
            this.txtDirectSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDirectSalePrice.Value = 0D;
            this.txtDirectSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDirectSalePrice_KeyDown);
            // 
            // btnTakeAwayOthersSame
            // 
            this.btnTakeAwayOthersSame.AutoEllipsis = true;
            this.btnTakeAwayOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnTakeAwayOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeAwayOthersSame.FlatAppearance.BorderSize = 0;
            this.btnTakeAwayOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAwayOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTakeAwayOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAwayOthersSame.Location = new System.Drawing.Point(156, 91);
            this.btnTakeAwayOthersSame.Name = "btnTakeAwayOthersSame";
            this.btnTakeAwayOthersSame.Size = new System.Drawing.Size(32, 24);
            this.btnTakeAwayOthersSame.TabIndex = 62;
            this.btnTakeAwayOthersSame.UseVisualStyleBackColor = false;
            this.btnTakeAwayOthersSame.Click += new System.EventHandler(this.btnTakeAwayOthersSame_Click);
            // 
            // txtDeliveryPrice
            // 
            this.txtDeliveryPrice.CustomFormat = "C2";
            this.txtDeliveryPrice.CustomUICulture = "en-US";
            this.txtDeliveryPrice.Font = new System.Drawing.Font("Arial", 14F);
            this.txtDeliveryPrice.Increment = 1D;
            this.txtDeliveryPrice.Location = new System.Drawing.Point(66, 129);
            this.txtDeliveryPrice.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtDeliveryPrice.MaxValue = 100000D;
            this.txtDeliveryPrice.MinValue = -100000D;
            this.txtDeliveryPrice.Name = "txtDeliveryPrice";
            this.txtDeliveryPrice.Size = new System.Drawing.Size(84, 29);
            this.txtDeliveryPrice.TabIndex = 4;
            this.txtDeliveryPrice.Text = "$0.00";
            this.txtDeliveryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeliveryPrice.Value = 0D;
            this.txtDeliveryPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliveryPrice_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Delivery";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTakeAwayPrice
            // 
            this.txtTakeAwayPrice.CustomFormat = "C2";
            this.txtTakeAwayPrice.CustomUICulture = "en-US";
            this.txtTakeAwayPrice.Font = new System.Drawing.Font("Arial", 14F);
            this.txtTakeAwayPrice.Increment = 1D;
            this.txtTakeAwayPrice.Location = new System.Drawing.Point(66, 93);
            this.txtTakeAwayPrice.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtTakeAwayPrice.MaxValue = 100000D;
            this.txtTakeAwayPrice.MinValue = -100000D;
            this.txtTakeAwayPrice.Name = "txtTakeAwayPrice";
            this.txtTakeAwayPrice.Size = new System.Drawing.Size(85, 29);
            this.txtTakeAwayPrice.TabIndex = 2;
            this.txtTakeAwayPrice.Text = "$0.00";
            this.txtTakeAwayPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTakeAwayPrice.Value = 0D;
            this.txtTakeAwayPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTakeAwayPrice_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "TakeAway";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAvailableNone);
            this.groupBox3.Controls.Add(this.chkAvailableInternetTakeAway);
            this.groupBox3.Controls.Add(this.chkAvailableAll);
            this.groupBox3.Controls.Add(this.chkAvailableInternetDelivery);
            this.groupBox3.Controls.Add(this.chkAvailableDelivery);
            this.groupBox3.Controls.Add(this.chkAvailableTakeAway);
            this.groupBox3.Controls.Add(this.chkAvailableInHouse);
            this.groupBox3.Controls.Add(this.chkAvailableDirect);
            this.groupBox3.Location = new System.Drawing.Point(38, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 262);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available For";
            // 
            // chkAvailableNone
            // 
            this.chkAvailableNone.AutoSize = true;
            this.chkAvailableNone.FlatAppearance.BorderSize = 0;
            this.chkAvailableNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableNone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableNone.Location = new System.Drawing.Point(11, 232);
            this.chkAvailableNone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.chkAvailableNone.Name = "chkAvailableNone";
            this.chkAvailableNone.Size = new System.Drawing.Size(72, 17);
            this.chkAvailableNone.TabIndex = 7;
            this.chkAvailableNone.Text = "NO SALE";
            this.chkAvailableNone.UseVisualStyleBackColor = false;
            this.chkAvailableNone.CheckedChanged += new System.EventHandler(this.chkAvailableNone_CheckedChanged);
            // 
            // chkAvailableInternetTakeAway
            // 
            this.chkAvailableInternetTakeAway.AutoSize = true;
            this.chkAvailableInternetTakeAway.FlatAppearance.BorderSize = 0;
            this.chkAvailableInternetTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableInternetTakeAway.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableInternetTakeAway.Location = new System.Drawing.Point(11, 145);
            this.chkAvailableInternetTakeAway.Name = "chkAvailableInternetTakeAway";
            this.chkAvailableInternetTakeAway.Size = new System.Drawing.Size(119, 17);
            this.chkAvailableInternetTakeAway.TabIndex = 6;
            this.chkAvailableInternetTakeAway.Text = "Internet Take Away";
            this.chkAvailableInternetTakeAway.UseVisualStyleBackColor = false;
            this.chkAvailableInternetTakeAway.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // chkAvailableAll
            // 
            this.chkAvailableAll.AutoSize = true;
            this.chkAvailableAll.FlatAppearance.BorderSize = 0;
            this.chkAvailableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableAll.Location = new System.Drawing.Point(11, 203);
            this.chkAvailableAll.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.chkAvailableAll.Name = "chkAvailableAll";
            this.chkAvailableAll.Size = new System.Drawing.Size(105, 17);
            this.chkAvailableAll.TabIndex = 4;
            this.chkAvailableAll.Text = "All Type of Sales";
            this.chkAvailableAll.UseVisualStyleBackColor = false;
            this.chkAvailableAll.CheckedChanged += new System.EventHandler(this.chkAvailableAll_CheckedChanged);
            // 
            // chkAvailableInternetDelivery
            // 
            this.chkAvailableInternetDelivery.AutoSize = true;
            this.chkAvailableInternetDelivery.FlatAppearance.BorderSize = 0;
            this.chkAvailableInternetDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableInternetDelivery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableInternetDelivery.Location = new System.Drawing.Point(11, 174);
            this.chkAvailableInternetDelivery.Name = "chkAvailableInternetDelivery";
            this.chkAvailableInternetDelivery.Size = new System.Drawing.Size(103, 17);
            this.chkAvailableInternetDelivery.TabIndex = 3;
            this.chkAvailableInternetDelivery.Text = "Internet Delivery";
            this.chkAvailableInternetDelivery.UseVisualStyleBackColor = false;
            this.chkAvailableInternetDelivery.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // chkAvailableDelivery
            // 
            this.chkAvailableDelivery.AutoSize = true;
            this.chkAvailableDelivery.FlatAppearance.BorderSize = 0;
            this.chkAvailableDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableDelivery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableDelivery.Location = new System.Drawing.Point(11, 116);
            this.chkAvailableDelivery.Name = "chkAvailableDelivery";
            this.chkAvailableDelivery.Size = new System.Drawing.Size(64, 17);
            this.chkAvailableDelivery.TabIndex = 2;
            this.chkAvailableDelivery.Text = "Delivery";
            this.chkAvailableDelivery.UseVisualStyleBackColor = false;
            this.chkAvailableDelivery.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // chkAvailableTakeAway
            // 
            this.chkAvailableTakeAway.AutoSize = true;
            this.chkAvailableTakeAway.FlatAppearance.BorderSize = 0;
            this.chkAvailableTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableTakeAway.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableTakeAway.Location = new System.Drawing.Point(11, 87);
            this.chkAvailableTakeAway.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkAvailableTakeAway.Name = "chkAvailableTakeAway";
            this.chkAvailableTakeAway.Size = new System.Drawing.Size(80, 17);
            this.chkAvailableTakeAway.TabIndex = 1;
            this.chkAvailableTakeAway.Text = "Take Away";
            this.chkAvailableTakeAway.UseVisualStyleBackColor = false;
            this.chkAvailableTakeAway.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // chkAvailableInHouse
            // 
            this.chkAvailableInHouse.AutoSize = true;
            this.chkAvailableInHouse.FlatAppearance.BorderSize = 0;
            this.chkAvailableInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableInHouse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableInHouse.Location = new System.Drawing.Point(11, 58);
            this.chkAvailableInHouse.Name = "chkAvailableInHouse";
            this.chkAvailableInHouse.Size = new System.Drawing.Size(58, 17);
            this.chkAvailableInHouse.TabIndex = 0;
            this.chkAvailableInHouse.Text = "Tables";
            this.chkAvailableInHouse.UseVisualStyleBackColor = false;
            this.chkAvailableInHouse.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // chkAvailableDirect
            // 
            this.chkAvailableDirect.AutoSize = true;
            this.chkAvailableDirect.FlatAppearance.BorderSize = 0;
            this.chkAvailableDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAvailableDirect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAvailableDirect.Location = new System.Drawing.Point(11, 29);
            this.chkAvailableDirect.Name = "chkAvailableDirect";
            this.chkAvailableDirect.Size = new System.Drawing.Size(78, 17);
            this.chkAvailableDirect.TabIndex = 5;
            this.chkAvailableDirect.Text = "Direct Sale";
            this.chkAvailableDirect.UseVisualStyleBackColor = false;
            this.chkAvailableDirect.CheckedChanged += new System.EventHandler(this.chkAvailableOthers_CheckedChanged);
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnForeColor.FlatAppearance.BorderSize = 0;
            this.btnForeColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnForeColor.Location = new System.Drawing.Point(615, 157);
            this.btnForeColor.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(82, 66);
            this.btnForeColor.TabIndex = 51;
            this.btnForeColor.TabStop = false;
            this.btnForeColor.Text = "Text Colour";
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnButtonColor
            // 
            this.btnButtonColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnButtonColor.FlatAppearance.BorderSize = 0;
            this.btnButtonColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnButtonColor.Location = new System.Drawing.Point(614, 80);
            this.btnButtonColor.Name = "btnButtonColor";
            this.btnButtonColor.Size = new System.Drawing.Size(83, 66);
            this.btnButtonColor.TabIndex = 2;
            this.btnButtonColor.TabStop = false;
            this.btnButtonColor.Text = "Back Colour";
            this.btnButtonColor.UseVisualStyleBackColor = false;
            this.btnButtonColor.Click += new System.EventHandler(this.btnButtonColor_Click);
            // 
            // btnUpdateButtonDetails
            // 
            this.btnUpdateButtonDetails.AutoEllipsis = true;
            this.btnUpdateButtonDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateButtonDetails.FlatAppearance.BorderSize = 0;
            this.btnUpdateButtonDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateButtonDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateButtonDetails.Location = new System.Drawing.Point(591, 558);
            this.btnUpdateButtonDetails.Name = "btnUpdateButtonDetails";
            this.btnUpdateButtonDetails.Size = new System.Drawing.Size(106, 50);
            this.btnUpdateButtonDetails.TabIndex = 2;
            this.btnUpdateButtonDetails.Text = "SAVE";
            this.btnUpdateButtonDetails.UseVisualStyleBackColor = false;
            this.btnUpdateButtonDetails.Click += new System.EventHandler(this.btnUpdateButtonDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(467, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEntityButtonName
            // 
            this.txtEntityButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEntityButtonName.Location = new System.Drawing.Point(93, 19);
            this.txtEntityButtonName.Name = "txtEntityButtonName";
            this.txtEntityButtonName.Size = new System.Drawing.Size(246, 24);
            this.txtEntityButtonName.TabIndex = 83;
            this.txtEntityButtonName.TextChanged += new System.EventHandler(this.txtEntityButtonName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeliveryTaxOthersSame);
            this.groupBox2.Controls.Add(this.btnInHouseTaxOthersSame);
            this.groupBox2.Controls.Add(this.btnDirectTaxOthersSame);
            this.groupBox2.Controls.Add(this.btnTakeAwayTaxOthersSame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDirectSaleTaxRate);
            this.groupBox2.Controls.Add(this.txtInHouseTaxRate);
            this.groupBox2.Controls.Add(this.btnSetTaxToDefault);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTakeAwayTaxRate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDeliveryTaxRate);
            this.groupBox2.Controls.Add(this.btnSetTaxToZero);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(299, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 169);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tax Percentages";
            // 
            // btnDeliveryTaxOthersSame
            // 
            this.btnDeliveryTaxOthersSame.AutoEllipsis = true;
            this.btnDeliveryTaxOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnDeliveryTaxOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeliveryTaxOthersSame.FlatAppearance.BorderSize = 0;
            this.btnDeliveryTaxOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryTaxOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDeliveryTaxOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnDeliveryTaxOthersSame.Location = new System.Drawing.Point(149, 137);
            this.btnDeliveryTaxOthersSame.Name = "btnDeliveryTaxOthersSame";
            this.btnDeliveryTaxOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnDeliveryTaxOthersSame.TabIndex = 85;
            this.btnDeliveryTaxOthersSame.UseVisualStyleBackColor = false;
            this.btnDeliveryTaxOthersSame.Click += new System.EventHandler(this.btnDeliveryTaxOthersSame_Click);
            // 
            // btnInHouseTaxOthersSame
            // 
            this.btnInHouseTaxOthersSame.AutoEllipsis = true;
            this.btnInHouseTaxOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnInHouseTaxOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInHouseTaxOthersSame.FlatAppearance.BorderSize = 0;
            this.btnInHouseTaxOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHouseTaxOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInHouseTaxOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnInHouseTaxOthersSame.Location = new System.Drawing.Point(149, 61);
            this.btnInHouseTaxOthersSame.Name = "btnInHouseTaxOthersSame";
            this.btnInHouseTaxOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnInHouseTaxOthersSame.TabIndex = 83;
            this.btnInHouseTaxOthersSame.UseVisualStyleBackColor = false;
            this.btnInHouseTaxOthersSame.Click += new System.EventHandler(this.btnInHouseTaxOthersSame_Click);
            // 
            // btnDirectTaxOthersSame
            // 
            this.btnDirectTaxOthersSame.AutoEllipsis = true;
            this.btnDirectTaxOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnDirectTaxOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectTaxOthersSame.FlatAppearance.BorderSize = 0;
            this.btnDirectTaxOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectTaxOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDirectTaxOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnDirectTaxOthersSame.Location = new System.Drawing.Point(149, 25);
            this.btnDirectTaxOthersSame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnDirectTaxOthersSame.Name = "btnDirectTaxOthersSame";
            this.btnDirectTaxOthersSame.Size = new System.Drawing.Size(32, 22);
            this.btnDirectTaxOthersSame.TabIndex = 86;
            this.btnDirectTaxOthersSame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectTaxOthersSame.UseVisualStyleBackColor = false;
            this.btnDirectTaxOthersSame.Click += new System.EventHandler(this.btnDirectTaxOthersSame_Click);
            // 
            // btnTakeAwayTaxOthersSame
            // 
            this.btnTakeAwayTaxOthersSame.AutoEllipsis = true;
            this.btnTakeAwayTaxOthersSame.BackColor = System.Drawing.Color.Green;
            this.btnTakeAwayTaxOthersSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeAwayTaxOthersSame.FlatAppearance.BorderSize = 0;
            this.btnTakeAwayTaxOthersSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAwayTaxOthersSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTakeAwayTaxOthersSame.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAwayTaxOthersSame.Location = new System.Drawing.Point(149, 97);
            this.btnTakeAwayTaxOthersSame.Name = "btnTakeAwayTaxOthersSame";
            this.btnTakeAwayTaxOthersSame.Size = new System.Drawing.Size(32, 24);
            this.btnTakeAwayTaxOthersSame.TabIndex = 84;
            this.btnTakeAwayTaxOthersSame.UseVisualStyleBackColor = false;
            this.btnTakeAwayTaxOthersSame.Click += new System.EventHandler(this.btnTakeAwayTaxOthersSame_Click);
            // 
            // incWidth
            // 
            this.incWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.incWidth.Increment = 10;
            this.incWidth.Location = new System.Drawing.Point(468, 257);
            this.incWidth.MaxValue = 500;
            this.incWidth.MinValue = 20;
            this.incWidth.Name = "incWidth";
            this.incWidth.Size = new System.Drawing.Size(80, 32);
            this.incWidth.TabIndex = 85;
            this.incWidth.Text = "20";
            this.incWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incWidth.Value = 20;
            this.incWidth.ValueChanged += new System.EventHandler(this.txtButtonWidth_ValueChanged);
            // 
            // incHeight
            // 
            this.incHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.incHeight.Increment = 10;
            this.incHeight.Location = new System.Drawing.Point(468, 305);
            this.incHeight.MaxValue = 200;
            this.incHeight.MinValue = 20;
            this.incHeight.Name = "incHeight";
            this.incHeight.Size = new System.Drawing.Size(80, 32);
            this.incHeight.TabIndex = 86;
            this.incHeight.Text = "20";
            this.incHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incHeight.Value = 20;
            this.incHeight.ValueChanged += new System.EventHandler(this.txtButtonHeight_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(417, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 87;
            this.label16.Text = "WIDTH";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(413, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 88;
            this.label17.Text = "HEIGHT";
            // 
            // txtImageFile
            // 
            this.txtImageFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImageFile.Location = new System.Drawing.Point(47, 585);
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.ReadOnly = true;
            this.txtImageFile.Size = new System.Drawing.Size(395, 23);
            this.txtImageFile.TabIndex = 89;
            this.txtImageFile.TextChanged += new System.EventHandler(this.txtImageFile_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 569);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 91;
            this.label18.Text = "Image File Name";
            // 
            // btnSample
            // 
            this.btnSample.BackColor = System.Drawing.SystemColors.Control;
            this.btnSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSample.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSample.Location = new System.Drawing.Point(467, 402);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(106, 50);
            this.btnSample.TabIndex = 92;
            this.btnSample.Text = "Sample";
            this.btnSample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSample.UseVisualStyleBackColor = false;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFont.Location = new System.Drawing.Point(191, 290);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 94;
            this.lblFont.Text = "Font";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.Control;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFont.Location = new System.Drawing.Point(194, 306);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(185, 30);
            this.btnFont.TabIndex = 95;
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // incDisplayOrder
            // 
            this.incDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.incDisplayOrder.Increment = 1;
            this.incDisplayOrder.Location = new System.Drawing.Point(468, 354);
            this.incDisplayOrder.MaxValue = 1000;
            this.incDisplayOrder.MinValue = 0;
            this.incDisplayOrder.Name = "incDisplayOrder";
            this.incDisplayOrder.Size = new System.Drawing.Size(80, 32);
            this.incDisplayOrder.TabIndex = 96;
            this.incDisplayOrder.Text = "0";
            this.incDisplayOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incDisplayOrder.Value = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(409, 358);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 26);
            this.label20.TabIndex = 97;
            this.label20.Text = "DISPLAY\r\n ORDER";
            // 
            // cmbDistributions
            // 
            this.cmbDistributions.DisplayMember = "DistributionName";
            this.cmbDistributions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistributions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDistributions.FormattingEnabled = true;
            this.cmbDistributions.Location = new System.Drawing.Point(194, 361);
            this.cmbDistributions.Name = "cmbDistributions";
            this.cmbDistributions.Size = new System.Drawing.Size(185, 28);
            this.cmbDistributions.TabIndex = 100;
            this.cmbDistributions.ValueMember = "IID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(194, 344);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 101;
            this.label21.Text = "Distribution";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExtraText
            // 
            this.txtExtraText.AcceptsReturn = true;
            this.txtExtraText.AcceptsTab = true;
            this.txtExtraText.Location = new System.Drawing.Point(468, 500);
            this.txtExtraText.Multiline = true;
            this.txtExtraText.Name = "txtExtraText";
            this.txtExtraText.Size = new System.Drawing.Size(229, 52);
            this.txtExtraText.TabIndex = 105;
            // 
            // btnDeletePrepImage
            // 
            this.btnDeletePrepImage.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeletePrepImage.Location = new System.Drawing.Point(386, 466);
            this.btnDeletePrepImage.Name = "btnDeletePrepImage";
            this.btnDeletePrepImage.Size = new System.Drawing.Size(48, 48);
            this.btnDeletePrepImage.TabIndex = 104;
            this.btnDeletePrepImage.UseVisualStyleBackColor = true;
            this.btnDeletePrepImage.Click += new System.EventHandler(this.btnDeletePrepImage_Click);
            // 
            // btnLoadPrepImageFromDirectory
            // 
            this.btnLoadPrepImageFromDirectory.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderOpen_32;
            this.btnLoadPrepImageFromDirectory.Location = new System.Drawing.Point(386, 412);
            this.btnLoadPrepImageFromDirectory.Name = "btnLoadPrepImageFromDirectory";
            this.btnLoadPrepImageFromDirectory.Size = new System.Drawing.Size(48, 48);
            this.btnLoadPrepImageFromDirectory.TabIndex = 103;
            this.btnLoadPrepImageFromDirectory.UseVisualStyleBackColor = true;
            this.btnLoadPrepImageFromDirectory.Click += new System.EventHandler(this.btnLoadPrepImageFromDirectory_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(194, 412);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(185, 168);
            this.pBox.TabIndex = 102;
            this.pBox.TabStop = false;
            this.pBox.DoubleClick += new System.EventHandler(this.pBox_DoubleClick);
            // 
            // btnLoadPrepImageFromDatabase
            // 
            this.btnLoadPrepImageFromDatabase.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBSource32;
            this.btnLoadPrepImageFromDatabase.Location = new System.Drawing.Point(385, 532);
            this.btnLoadPrepImageFromDatabase.Name = "btnLoadPrepImageFromDatabase";
            this.btnLoadPrepImageFromDatabase.Size = new System.Drawing.Size(48, 48);
            this.btnLoadPrepImageFromDatabase.TabIndex = 106;
            this.toolTip1.SetToolTip(this.btnLoadPrepImageFromDatabase, "Choose Image From Database");
            this.btnLoadPrepImageFromDatabase.UseVisualStyleBackColor = true;
            this.btnLoadPrepImageFromDatabase.Click += new System.EventHandler(this.btnLoadPrepImageFromDatabase_Click);
            // 
            // chkWithImage
            // 
            this.chkWithImage.AutoSize = true;
            this.chkWithImage.Location = new System.Drawing.Point(49, 508);
            this.chkWithImage.Name = "chkWithImage";
            this.chkWithImage.Size = new System.Drawing.Size(92, 17);
            this.chkWithImage.TabIndex = 107;
            this.chkWithImage.Text = "Display Image";
            this.chkWithImage.UseVisualStyleBackColor = true;
            this.chkWithImage.CheckedChanged += new System.EventHandler(this.chkWithImage_CheckedChanged);
            // 
            // btnMinusWidth
            // 
            this.btnMinusWidth.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMinusWidth.Location = new System.Drawing.Point(637, 255);
            this.btnMinusWidth.Name = "btnMinusWidth";
            this.btnMinusWidth.Size = new System.Drawing.Size(60, 35);
            this.btnMinusWidth.TabIndex = 109;
            this.btnMinusWidth.UseVisualStyleBackColor = true;
            this.btnMinusWidth.Click += new System.EventHandler(this.btnMinusWidth_Click);
            // 
            // btnPlusWidth
            // 
            this.btnPlusWidth.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusWidth.Location = new System.Drawing.Point(565, 255);
            this.btnPlusWidth.Name = "btnPlusWidth";
            this.btnPlusWidth.Size = new System.Drawing.Size(60, 35);
            this.btnPlusWidth.TabIndex = 108;
            this.btnPlusWidth.UseVisualStyleBackColor = true;
            this.btnPlusWidth.Click += new System.EventHandler(this.btnPlusWidth_Click);
            // 
            // btnMinusHeight
            // 
            this.btnMinusHeight.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMinusHeight.Location = new System.Drawing.Point(637, 304);
            this.btnMinusHeight.Name = "btnMinusHeight";
            this.btnMinusHeight.Size = new System.Drawing.Size(60, 35);
            this.btnMinusHeight.TabIndex = 111;
            this.btnMinusHeight.UseVisualStyleBackColor = true;
            this.btnMinusHeight.Click += new System.EventHandler(this.btnMinusHeight_Click);
            // 
            // btnPlusHeight
            // 
            this.btnPlusHeight.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusHeight.Location = new System.Drawing.Point(565, 304);
            this.btnPlusHeight.Name = "btnPlusHeight";
            this.btnPlusHeight.Size = new System.Drawing.Size(60, 35);
            this.btnPlusHeight.TabIndex = 110;
            this.btnPlusHeight.UseVisualStyleBackColor = true;
            this.btnPlusHeight.Click += new System.EventHandler(this.btnPlusHeight_Click);
            // 
            // btnMInusOrder
            // 
            this.btnMInusOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMInusOrder.Location = new System.Drawing.Point(637, 353);
            this.btnMInusOrder.Name = "btnMInusOrder";
            this.btnMInusOrder.Size = new System.Drawing.Size(60, 35);
            this.btnMInusOrder.TabIndex = 113;
            this.btnMInusOrder.UseVisualStyleBackColor = true;
            this.btnMInusOrder.Click += new System.EventHandler(this.btnMInusOrder_Click);
            // 
            // btnPlusOrder
            // 
            this.btnPlusOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusOrder.Location = new System.Drawing.Point(565, 353);
            this.btnPlusOrder.Name = "btnPlusOrder";
            this.btnPlusOrder.Size = new System.Drawing.Size(60, 35);
            this.btnPlusOrder.TabIndex = 112;
            this.btnPlusOrder.UseVisualStyleBackColor = true;
            this.btnPlusOrder.Click += new System.EventHandler(this.btnPlusOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(194, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "W : 300px H : 600px | 300K max";
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(363, 397);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(30, 13);
            this.lblImageSize.TabIndex = 115;
            this.lblImageSize.Text = "0 KB";
            // 
            // FrmEntityButtonsEditor
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 626);
            this.ControlBox = false;
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMInusOrder);
            this.Controls.Add(this.btnPlusOrder);
            this.Controls.Add(this.btnMinusHeight);
            this.Controls.Add(this.btnPlusHeight);
            this.Controls.Add(this.btnMinusWidth);
            this.Controls.Add(this.btnPlusWidth);
            this.Controls.Add(this.chkWithImage);
            this.Controls.Add(this.btnLoadPrepImageFromDatabase);
            this.Controls.Add(this.txtExtraText);
            this.Controls.Add(this.btnDeletePrepImage);
            this.Controls.Add(this.btnLoadPrepImageFromDirectory);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cmbDistributions);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.incDisplayOrder);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtImageFile);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.incHeight);
            this.Controls.Add(this.incWidth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEntityButtonName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbButtonType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbPadFlag);
            this.Controls.Add(this.chkCompulsary);
            this.Controls.Add(this.btnUpdateButtonDetails);
            this.Controls.Add(this.btnButtonColor);
            this.Controls.Add(this.btnForeColor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEntityButtonsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUCT EDİTOR";
            this.Load += new System.EventHandler(this.frmEntityButtonsEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void frmEntityButtonsEditor_Load(object sender, System.EventArgs e) {
            
            LoadDistributions();
            LoadButtonDetails();
        }

        private void LoadDistributions() {
            if (entity.ParentMenuIID == null || entity.ParentMenuIID == "")
                cmbDistributions.DataSource = bslayer.GetAllDistributions(bslayer.config.ActiveMenuIID);
            else
                cmbDistributions.DataSource = bslayer.GetAllDistributions(entity.ParentMenuIID);


            //cmbDistributions.DataSource = bslayer.GetAllDistributions(bslayer.config.ActiveMenuIID);
        }
        private void LoadButtonDetails() {
            UnloadButtonDetails();
            if (entityButton != null) {
                //if (parentEntityButton != null)    //This is a subbutton editor
                    //Make sure all the sub buttons of this entitybutton have a priceitem for each sizebarbutton and correctly ordered
                    //parentEntityButton.SyncronizePriceItems();
                CultureInfo ci = bslayer.GetUICulture(); 

                txtEntityButtonName.Text = entityButton.EntityButtonName;
                btnButtonColor.BackColor = Color.FromArgb(entityButton.ButtonColor);
                btnForeColor.BackColor = Color.FromArgb(entityButton.ForeColor);
                cmbButtonType.SelectedIndex = (int)entityButton.ButtonType;



                txtDirectSaleTaxRate.Value = entityButton.DirectSaleTaxPercent; //.ToString("f2",CultureInfo.CurrentUICulture);
                txtInHouseTaxRate.Value = entityButton.InHouseTaxPercent; //.ToString("f2", CultureInfo.CurrentUICulture);
                txtTakeAwayTaxRate.Value = entityButton.TakeAwayTaxPercent; //.ToString("f2", CultureInfo.CurrentUICulture);
                txtDeliveryTaxRate.Value = entityButton.DeliveryTaxPercent; //.ToString("f2", CultureInfo.CurrentUICulture);

                switch (entityButton.PadFlag) {
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

                try {
                    if (string.IsNullOrEmpty(entityButton.DistributionIID))
                        entityButton.DistributionIID = entity.DistributionIID;
                    cmbDistributions.SelectedValue = entityButton.DistributionIID;
                } catch { }

                try {
                    
                    txtDirectSalePrice.CustomUICulture = txtInHousePrice.CustomUICulture = txtTakeAwayPrice.CustomUICulture= txtDeliveryPrice.CustomUICulture =  bslayer.GetUICulture().ToString();
                    txtDirectSalePrice.Value = entityButton.DirectSalePrice; 
                    txtInHousePrice.Value = entityButton.InHousePrice; 
                    txtTakeAwayPrice.Value = entityButton.TakeAwayPrice; 
                    txtDeliveryPrice.Value = entityButton.DeliveryPrice;

                    string format = "c2";
                    if (entityButton.ButtonType == EntityButtonTypes.PercentAddition || entityButton.ButtonType == EntityButtonTypes.PercentDeduction) 
                        format = "0\" %\"";
                    txtDirectSalePrice.CustomFormat = txtInHousePrice.CustomFormat = txtTakeAwayPrice.CustomFormat = txtDeliveryPrice.CustomFormat = format;
                    
                    
                }
                catch { }

                //Availability
                if (PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.All))
                    chkAvailableAll.Checked = true;
                else {
                    chkAvailableDirect.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.Direct);
                    chkAvailableInHouse.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.InHouse);
                    chkAvailableTakeAway.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.TakeAwayB);
                    chkAvailableDelivery.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.Delivery);
                    chkAvailableInternetTakeAway.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.InternetTakeAway);
                    chkAvailableInternetDelivery.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.InternetDelivery);
                    chkAvailableNone.Checked = PosLibrary.DRNumeric.IsBitSet(entityButton.AvailableFor, (int)AvailabilityTypes.NoSale);
                }

                chkCompulsary.Checked = (entityButton.Compulsary == 1);

                incWidth.Value = entityButton.ButtonWidth;
                incHeight.Value = entityButton.ButtonHeight;
               // txtImageFile.Text = entityButton.ImageFileName;
                chkWithImage.Checked = entityButton.WithImage;

                btnFont.Text = entityButton.FFamily + "," + entityButton.FSize.ToString() + "," + entityButton.FStyle;
                incDisplayOrder.Value = entityButton.DisplayOrder;

                LoadGenericImage();
                
                DisplayButton();

            }
        }

        private void LoadGenericImage() {
            try {
                gim = bslayer.GetGenericImage(entityButton.IID);
                if (gim != null) {
                    if (gim.DisplayImage != null)
                        pBox.BackgroundImage = gim.DisplayImage;
                    txtExtraText.Text = gim.ExtraText;
                    txtImageFile.Text = gim.ImageFileName;
                    lblImageSize.Text = gim.ImageSizeinKB + " KB";
                }
            } catch {
            }
        }

        private void UnloadButtonDetails() {
            txtEntityButtonName.Clear();
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
            chkWithImage.Checked = false;
        }

        
        private void btnClose_Click(object sender, System.EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        private void btnUpdateButtonDetails_Click(object sender, System.EventArgs e) {
            System.Globalization.CultureInfo ci = bslayer.GetCulture(bslayer.config.Terminal_Currency_Culture);
            if (entityButton != null) {

                entityButton.ButtonType = (EntityButtonTypes)cmbButtonType.SelectedIndex;



                entityButton.DirectSalePrice = (float)txtDirectSalePrice.Value; // float.Parse(txtDirectSalePrice.Text, CultureInfo.CurrentUICulture); // AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                entityButton.InHousePrice = (float)txtInHousePrice.Value; // float.Parse(txtInHousePrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); //AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                entityButton.TakeAwayPrice = (float)txtTakeAwayPrice.Value; // float.Parse(txtTakeAwayPrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); // AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 
                entityButton.DeliveryPrice = (float)txtDeliveryPrice.Value; // float.Parse(txtDeliveryPrice.Text, CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci); //AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);					 


                entityButton.EntityButtonName = txtEntityButtonName.Text;

                entityButton.ButtonColor = btnButtonColor.BackColor.ToArgb();
                entityButton.ForeColor = btnForeColor.BackColor.ToArgb();

                //Availability
                entityButton.AvailableFor = 0;
                if (!chkAvailableAll.Checked) {
                    entityButton.AvailableFor = (chkAvailableDirect.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.Direct) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableInHouse.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.InHouse) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableTakeAway.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.TakeAwayB) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableDelivery.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.Delivery) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableInternetTakeAway.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.InternetTakeAway) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableInternetDelivery.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.InternetDelivery) : entityButton.AvailableFor);
                    entityButton.AvailableFor = (chkAvailableNone.Checked ? DRNumeric.SetBit(entityButton.AvailableFor, (int)AvailabilityTypes.NoSale) : entityButton.AvailableFor);

                }
                if (chkCompulsary.Checked)
                    entityButton.Compulsary = 1;
                else
                    entityButton.Compulsary = 0;

                entityButton.DirectSaleTaxPercent = (float)txtDirectSaleTaxRate.Value; // float.Parse(txtDirectSaleTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);
                entityButton.InHouseTaxPercent = (float)txtInHouseTaxRate.Value; // float.Parse(txtInHouseTaxRate.Text.Trim(), CultureInfo.CurrentUICulture);// , System.Globalization.NumberStyles.Any, ci);
                entityButton.TakeAwayTaxPercent = (float)txtTakeAwayTaxRate.Value; // float.Parse(txtTakeAwayTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);
                entityButton.DeliveryTaxPercent = (float)txtDeliveryTaxRate.Value; // float.Parse(txtDeliveryTaxRate.Text.Trim(), CultureInfo.CurrentUICulture); //, System.Globalization.NumberStyles.Any, ci);

                switch (cmbPadFlag.SelectedIndex) {
                    case 0:
                        entityButton.PadFlag = PadFlags.EBOnly;
                        break;
                    case 1:
                        entityButton.PadFlag = PadFlags.PadOnly;
                        break;
                    case 2:
                        entityButton.PadFlag = PadFlags.EBAndPad;
                        break;
                    default:
                        entityButton.PadFlag = PadFlags.EBOnly;
                        break;
                }

                entityButton.DistributionIID = cmbDistributions.SelectedValue.ToString();

                entityButton.ButtonWidth = incWidth.Value;
                entityButton.ButtonHeight = incHeight.Value;

                //entityButton.ImageFileName = txtImageFile.Text;
                entityButton.DisplayOrder = (int)incDisplayOrder.Value;

                entityButton.WithImage = chkWithImage.Checked;

                bslayer.SaveJustEntityButton(entityButton, entity.ParentMenuIID); // .ParentMenuIID); // bslayer.config.ActiveMenuIID);

                if (pBox.BackgroundImage != null) {
                    GenericImage gim = new GenericImage(entityButton.IID, pBox.BackgroundImage, txtExtraText.Text, txtImageFile.Text);
                    bslayer.SaveGenericImage(gim);
                }



                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        

        private void cmbButtonType_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (entityButton != null) {
                if (entity.entityType == EntityTypes.SpecialEntity &&
                    cmbButtonType.SelectedIndex < 7)
                    cmbButtonType.SelectedIndex = (int)entityButton.ButtonType;
            }

            switch (cmbButtonType.SelectedIndex) {
                case (int)EntityButtonTypes.SimpleItem:
                    break;
                case (int)EntityButtonTypes.AmountAddition:
                    break;
                case (int)EntityButtonTypes.AmountDeduction:
                    break;
                case (int)EntityButtonTypes.PercentAddition:
                    break;
                case (int)EntityButtonTypes.PercentDeduction:
                    break;
                case (int)EntityButtonTypes.CustomAddition:
                    break;
                case (int)EntityButtonTypes.CustomDeduction:
                    break;
                case (int)EntityButtonTypes.SpaceButton:
                    ResetAndLockForSpaceButton();
                    break;
            }
            txtEntityButtonName.Enabled = true;
        }

        private void ResetAndLockForSpaceButton() {
            btnButtonColor.BackColor = Color.Black;
            btnForeColor.BackColor = Color.Black;
            
        }

        

        private void btnInHouseOthersSame_Click(object sender, System.EventArgs e) {
            txtTakeAwayPrice.Value = txtDeliveryPrice.Value = txtDirectSalePrice.Value = txtInHousePrice.Value;
        }

        private void btnTakeAwayOthersSame_Click(object sender, System.EventArgs e) {
            txtDeliveryPrice.Value = txtDirectSalePrice.Value = txtInHousePrice.Value = txtTakeAwayPrice.Value;
        }

        private void btnDeliveryOthersSame_Click(object sender, System.EventArgs e) {
            txtDirectSalePrice.Value = txtInHousePrice.Value = txtTakeAwayPrice.Value= txtDeliveryPrice.Value ;
        }

        private void chkAvailableAll_CheckedChanged(object sender, System.EventArgs e) {
            if (chkAvailableAll.Checked) {
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
        private void chkAvailableNone_CheckedChanged(object sender, EventArgs e) {
            if (chkAvailableNone.Checked) {
                chkAvailableDirect.Checked = false;
                chkAvailableInHouse.Checked = false;
                chkAvailableTakeAway.Checked = false;
                chkAvailableDelivery.Checked = false;
                chkAvailableInternetDelivery.Checked = false;
                chkAvailableInternetTakeAway.Checked = false;
                chkAvailableAll.Checked = false;
            } 
        }
        private void chkAvailableOthers_CheckedChanged(object sender, System.EventArgs e) {
            if (((CheckBox)sender).Checked) {
                chkAvailableAll.Checked = false;
                chkAvailableNone.Checked = false;
            }
           
        }

        private void btnDirectOthersSame_Click(object sender, System.EventArgs e) {
            txtInHousePrice.Value = txtTakeAwayPrice.Value = txtDeliveryPrice.Value = txtDirectSalePrice.Value;
        }

       

        private void chkCompulsary_CheckedChanged(object sender, EventArgs e) {
            if (chkCompulsary.Checked)
                ((CheckBox)sender).BackColor = Color.LimeGreen;
            else
                ((CheckBox)sender).BackColor = Color.Brown;
        }

        

        private void txtDirectSalePrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtDirectSalePrice.ReValidate();
                if (e.Control) {
                    btnUpdateButtonDetails.Focus();
                    btnUpdateButtonDetails_Click(null, null);
                }
                else
                    btnDirectOthersSame_Click(null, null);
            }
        }

        private void txtTakeAwayPrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtTakeAwayPrice.ReValidate();
                if (e.Control) {
                    btnUpdateButtonDetails.Focus();
                    //txtTakeAwayPrice_Leave(null, null);
                    btnUpdateButtonDetails_Click(null, null);
                }
                else
                    btnTakeAwayOthersSame_Click(null, null);
            }
        }

        private void txtInHousePrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtInHousePrice.ReValidate();
                if (e.Control) {
                    btnUpdateButtonDetails.Focus();
                    //txtInHousePrice_Leave(null, null);
                    btnUpdateButtonDetails_Click(null, null);
                }
                else
                    btnInHouseOthersSame_Click(null, null);
            }
        }

        private void txtDeliveryPrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtDeliveryPrice.ReValidate();
                if (e.Control) {
                    btnUpdateButtonDetails.Focus();
                    //txtDeliveryPrice_Leave(null, null);
                    btnUpdateButtonDetails_Click(null, null);
                }
                else
                    btnDeliveryOthersSame_Click(null, null);
            }
        }





        private void btnSetTaxToZero_Click(object sender, EventArgs e) {
            txtDirectSaleTaxRate.Value = txtInHouseTaxRate.Value = txtTakeAwayTaxRate.Value = txtDeliveryTaxRate.Value = 0;
        }

        private async void btnSetTaxToDefault_Click(object sender, EventArgs e) {
            POSLayer.Models.Luv luv =await bslayer.GetLuv();
            txtDirectSaleTaxRate.Value = txtInHouseTaxRate.Value = txtTakeAwayTaxRate.Value = txtDeliveryTaxRate.Value = luv.DefaultTaxRate;
        }



        private void btnButtonColor_Click(object sender, System.EventArgs e) {
            ColorDialog cdlg = new ColorDialog {
                Color = ((Button)sender).BackColor
            };
            cdlg.ShowDialog();
            ((Button)sender).BackColor = cdlg.Color;
            btnSample.BackColor = btnButtonColor.BackColor;
        }
        private void btnForeColor_Click(object sender, System.EventArgs e) {
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = ((Button)sender).BackColor;
            cdlg.ShowDialog();
            ((Button)sender).BackColor = cdlg.Color;
            btnSample.ForeColor = btnForeColor.BackColor;
        }

        private void txtEntityButtonName_TextChanged(object sender, EventArgs e) {
            btnSample.Text = txtEntityButtonName.Text;
        }

        private void txtButtonWidth_ValueChanged(object sender, EventArgs e) {
            btnSample.Width = incWidth.Value;            
        }

        private void txtButtonHeight_ValueChanged(object sender, EventArgs e) {
            btnSample.Height = incHeight.Value;
        }

        private void txtImageFile_TextChanged(object sender, EventArgs e) {
            try {
                if (txtImageFile.Text.Length > 0)
                    btnSample.Image = Image.FromFile(txtImageFile.Text);
            }
            catch { }
        }

        private void DisplayButton() {
            btnSample.BackColor = btnButtonColor.BackColor;
            btnSample.ForeColor = btnForeColor.BackColor;
            btnSample.Text = txtEntityButtonName.Text;
            btnSample.Width = incWidth.Value;
            btnSample.Height = incHeight.Value;
            try {
                if (entityButton.WithImage && gim != null && gim.DisplayImage != null) {
                    //GenericImage genImage = bslayer.GetGenericImage(entityButton.IID);
                    btnSample.Image = gim.DisplayImage;
                } else
                    btnSample.Image = null;

                   // btnSample.Image = Image.FromFile(txtImageFile.Text);
            }
            catch { }

            try {
                btnSample.Font = new Font(entityButton.FFamily, entityButton.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entityButton.FStyle));
            }
            catch { }
        }

        

        private void btnFont_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog {
                Font = new Font(entityButton.FFamily, entityButton.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entityButton.FStyle))
            };
            if (fd.ShowDialog() == DialogResult.OK) {
                entityButton.FFamily = fd.Font.FontFamily.Name;
                entityButton.FSize = fd.Font.Size;
                entityButton.FStyle = fd.Font.Style.ToString();
                btnFont.Text = entityButton.FFamily + "," + entityButton.FSize.ToString() + "," + entityButton.FStyle;
                btnSample.Font = new Font(entityButton.FFamily, entityButton.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entityButton.FStyle));
            }


        }

        private void btnDirectTaxOthersSame_Click(object sender, EventArgs e) {
            txtInHouseTaxRate.Text = txtTakeAwayTaxRate.Text = txtDeliveryTaxRate.Text = txtDirectSaleTaxRate.Text;
        }

        private void btnInHouseTaxOthersSame_Click(object sender, EventArgs e) {
            txtDirectSaleTaxRate.Text = txtTakeAwayTaxRate.Text = txtDeliveryTaxRate.Text = txtInHouseTaxRate.Text;
        }

        private void btnTakeAwayTaxOthersSame_Click(object sender, EventArgs e) {
            txtDirectSaleTaxRate.Text = txtInHouseTaxRate.Text = txtDeliveryTaxRate.Text = txtTakeAwayTaxRate.Text;
        }

        private void btnDeliveryTaxOthersSame_Click(object sender, EventArgs e) {
            txtDirectSaleTaxRate.Text = txtInHouseTaxRate.Text = txtTakeAwayTaxRate.Text = txtDeliveryTaxRate.Text;
        }

        private void txtDirectSaleTaxRate_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) 
                btnDirectTaxOthersSame_Click(null,null);
        }

        private void txtInHouseTaxRate_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnInHouseTaxOthersSame_Click(null, null);
        }

        private void txtTakeAwayTaxRate_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnTakeAwayTaxOthersSame_Click(null, null);
        }

        private void txtDeliveryTaxRate_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnDeliveryTaxOthersSame_Click(null, null);
        }

        private void btnLoadPrepImageFromDirectory_Click(object sender, EventArgs e) {            

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Button Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
                txtImageFile.Text = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = img;

                gim = new GenericImage(entityButton.IID, img, txtExtraText.Text, finfo.Name);

                DisplayButton();
            }
        }

        private void btnDeletePrepImage_Click(object sender, EventArgs e) {
            bslayer.DeletePrepImage(entityButton.IID);
            pBox.BackgroundImage = null;
        }

        private void btnLoadPrepImageFromDatabase_Click(object sender, EventArgs e) {
            frmImageList frm = new frmImageList(bslayer, true);
            if (frm.ShowDialog() == DialogResult.OK) {
                pBox.BackgroundImage = frm.SelectedImage;
            }
        }

        private void chkWithImage_CheckedChanged(object sender, EventArgs e) {
            if (chkWithImage.Checked) {
                if (gim != null && gim.DisplayImage != null) {
                    try {
                        btnSample.Image = gim.DisplayImage;
                    } catch { }
                } 
            } else {
                btnSample.Image = null;
            }
        }

        private void btnPlusWidth_Click(object sender, EventArgs e) {
            incWidth.IncrementValue();
        }

        private void btnMinusWidth_Click(object sender, EventArgs e) {
            incWidth.DecrementValue();
        }

        private void btnPlusHeight_Click(object sender, EventArgs e) {
            incHeight.IncrementValue();
        }

        private void btnMinusHeight_Click(object sender, EventArgs e) {
            incHeight.DecrementValue();
        }

        private void btnPlusOrder_Click(object sender, EventArgs e) {
            incDisplayOrder.IncrementValue();
        }

        private void btnMInusOrder_Click(object sender, EventArgs e) {
            incDisplayOrder.DecrementValue();
        }

        private void pBox_DoubleClick(object sender, EventArgs e) {
            frmGenericImageEditor frm = new frmGenericImageEditor(bslayer, bslayer.GetGenericImage(entityButton.IID));
            if (frm .ShowDialog() == DialogResult.OK) {
                LoadGenericImage();
            }
        }
    }
}
