using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel; 
using System.Windows.Forms;
using System.IO;
using DTRMNS;
using DronaxLibrary;
using DronaxLibrary.DBSpace;
using System.Collections.Generic;

using System.ComponentModel.Design;
using System.ServiceModel;

namespace DTRMNS {
    /// <summary>
    /// Summary description for ctlConfig.
    /// </summary>
    public class frmConfig : Form{

        private DTRMNS.DTRMSimpleBusiness bslayer;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button btnSave;
        private BindingSource remoteStationBindingSource;
        private ImageList ilMain;
        private BindingSource applicationPrinterBindingSource;
        private BindingSource userBindingSource;
        private BindingSource catalogListBindingSource;
        private Label label16;
        private ComboBox cmbMenuTaxRates;
        private Button cmbChangeTaxRate;
        private Label label5;
        private ComboBox cmbMenu;
        private Button btnImportMenu;
        private System.Windows.Forms.TabControl tabMain;
        private TabPage tpTerminal;
        private TabPage tpShop;
        private TabPage tpOthers;
        private Button btnCancel;
        private System.Windows.Forms.PropertyGrid pGridConfig;
        private System.Windows.Forms.PropertyGrid pGridLuv;
        private IContainer components;

        public DTRMConfig config;
        private Button btnChangeConnection;
        private PictureBox pBox;
        private Label label2;
        private Label label1;
        private Button btnLoadLogo2;
        private PictureBox pBoxLogo2;
        private Button btnLoadLogo1;
        private PictureBox pBoxLogo1;
        private Button btnDeleteLogo2;
        private Button btnDeleteLogo1;
        private Button btnSendTestEmailToNotification;
        private Button btnSendTestEmailToReport;
        private Button btnSendTestEmailToOrders;
        private Button btnSendTestEmailToPurchase;
        private TextBox txtCustomerPassword;
        private Label label4;
        private TextBox txtCustomerKey;
        private Label label3;
        private Label lblLicence;
        private Button btnCopyLicence;
        private TextBox txtLicence;
        private Label label7;
        private Button btnRegisterSoftware;
        private Label lblPurchaseCode;
        private Label lblCustomerPassword;
        private Label lblCustomerKey;
        private TextBox txtPurchaseCode;
        private Label label6;
        private bool blnEmpty;
        public ToolStripButton RegistrationButton;

        public frmConfig() {
            InitializeComponent();
        }



        public frmConfig(DTRMNS.DTRMSimpleBusiness bslayer) {
            this.bslayer = bslayer;

            if (bslayer == null) {
                //Empty config required
                blnEmpty = true;
                config = UF.GetConfig();
                if (config == null)
                    config = new DTRMConfig();

            }
            else
                this.config = bslayer.config;
            InitializeComponent();            
        }


        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.remoteStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnChangeConnection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.catalogListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImportMenu = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbMenuTaxRates = new System.Windows.Forms.ComboBox();
            this.cmbChangeTaxRate = new System.Windows.Forms.Button();
            this.applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpTerminal = new System.Windows.Forms.TabPage();
            this.pGridConfig = new System.Windows.Forms.PropertyGrid();
            this.tpShop = new System.Windows.Forms.TabPage();
            this.pGridLuv = new System.Windows.Forms.PropertyGrid();
            this.tpOthers = new System.Windows.Forms.TabPage();
            this.lblPurchaseCode = new System.Windows.Forms.Label();
            this.lblCustomerPassword = new System.Windows.Forms.Label();
            this.lblCustomerKey = new System.Windows.Forms.Label();
            this.btnRegisterSoftware = new System.Windows.Forms.Button();
            this.lblLicence = new System.Windows.Forms.Label();
            this.btnCopyLicence = new System.Windows.Forms.Button();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchaseCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendTestEmailToNotification = new System.Windows.Forms.Button();
            this.btnSendTestEmailToReport = new System.Windows.Forms.Button();
            this.btnSendTestEmailToOrders = new System.Windows.Forms.Button();
            this.btnSendTestEmailToPurchase = new System.Windows.Forms.Button();
            this.btnDeleteLogo2 = new System.Windows.Forms.Button();
            this.btnDeleteLogo1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadLogo2 = new System.Windows.Forms.Button();
            this.pBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.btnLoadLogo1 = new System.Windows.Forms.Button();
            this.pBoxLogo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.remoteStationBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pGridConfig)).BeginInit();
            this.tpShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pGridLuv)).BeginInit();
            this.tpOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "userbig.png");
            this.ilMain.Images.SetKeyName(1, "userbigblue.png");
            this.ilMain.Images.SetKeyName(2, "userbiggreen.png");
            this.ilMain.Images.SetKeyName(3, "userbigred.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pBox);
            this.panel2.Controls.Add(this.btnChangeConnection);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 652);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1053, 71);
            this.panel2.TabIndex = 71;
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Transparent;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(356, 6);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(175, 58);
            this.pBox.TabIndex = 88;
            this.pBox.TabStop = false;
            // 
            // btnChangeConnection
            // 
            this.btnChangeConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeConnection.FlatAppearance.BorderSize = 0;
            this.btnChangeConnection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChangeConnection.Location = new System.Drawing.Point(180, 5);
            this.btnChangeConnection.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnChangeConnection.Name = "btnChangeConnection";
            this.btnChangeConnection.Size = new System.Drawing.Size(175, 61);
            this.btnChangeConnection.TabIndex = 87;
            this.btnChangeConnection.Text = "CHANGE CONNECTION";
            this.btnChangeConnection.UseVisualStyleBackColor = false;
            this.btnChangeConnection.Click += new System.EventHandler(this.btnChangeConnection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(5, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 61);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(873, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 61);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(25, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "ACTIVE MENU";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DataSource = this.catalogListBindingSource;
            this.cmbMenu.DisplayMember = "MenuName";
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(28, 119);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(306, 32);
            this.cmbMenu.TabIndex = 134;
            this.cmbMenu.ValueMember = "IID";
            this.cmbMenu.SelectionChangeCommitted += new System.EventHandler(this.cmbMenus_SelectionChangeCommitted);
            // 
            // catalogListBindingSource
            // 
            this.catalogListBindingSource.DataSource = typeof(DTRMNS.FMenuList);
            // 
            // btnImportMenu
            // 
            this.btnImportMenu.FlatAppearance.BorderSize = 0;
            this.btnImportMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportMenu.Location = new System.Drawing.Point(342, 119);
            this.btnImportMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnImportMenu.Name = "btnImportMenu";
            this.btnImportMenu.Size = new System.Drawing.Size(115, 32);
            this.btnImportMenu.TabIndex = 133;
            this.btnImportMenu.Text = "IMPORT MENU";
            this.btnImportMenu.UseVisualStyleBackColor = false;
            this.btnImportMenu.Click += new System.EventHandler(this.btnImportMenu_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(28, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 16);
            this.label16.TabIndex = 127;
            this.label16.Text = "MENU TAX RATES";
            // 
            // cmbMenuTaxRates
            // 
            this.cmbMenuTaxRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuTaxRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbMenuTaxRates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMenuTaxRates.FormattingEnabled = true;
            this.cmbMenuTaxRates.Location = new System.Drawing.Point(28, 48);
            this.cmbMenuTaxRates.Name = "cmbMenuTaxRates";
            this.cmbMenuTaxRates.Size = new System.Drawing.Size(114, 33);
            this.cmbMenuTaxRates.TabIndex = 126;
            // 
            // cmbChangeTaxRate
            // 
            this.cmbChangeTaxRate.FlatAppearance.BorderSize = 0;
            this.cmbChangeTaxRate.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbChangeTaxRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbChangeTaxRate.Location = new System.Drawing.Point(158, 44);
            this.cmbChangeTaxRate.Name = "cmbChangeTaxRate";
            this.cmbChangeTaxRate.Size = new System.Drawing.Size(110, 37);
            this.cmbChangeTaxRate.TabIndex = 128;
            this.cmbChangeTaxRate.Text = "Change Tax Rate";
            this.cmbChangeTaxRate.UseVisualStyleBackColor = false;
            this.cmbChangeTaxRate.Click += new System.EventHandler(this.cmbChangeTaxRate_Click);
            // 
            // applicationPrinterBindingSource
            // 
            this.applicationPrinterBindingSource.DataSource = typeof(DTRMNS.ApplicationPrinter);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DTRMNS.User);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpTerminal);
            this.tabMain.Controls.Add(this.tpShop);
            this.tabMain.Controls.Add(this.tpOthers);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(200, 40);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1053, 642);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 138;
            // 
            // tpTerminal
            // 
            this.tpTerminal.Controls.Add(this.pGridConfig);
            this.tpTerminal.Location = new System.Drawing.Point(4, 44);
            this.tpTerminal.Name = "tpTerminal";
            this.tpTerminal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTerminal.Size = new System.Drawing.Size(1045, 594);
            this.tpTerminal.TabIndex = 0;
            this.tpTerminal.Text = "TERMINAL SETTINGS";
            this.tpTerminal.UseVisualStyleBackColor = true;
            // 
            // pGridConfig
            // 
            this.pGridConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridConfig.Location = new System.Drawing.Point(3, 3);
            this.pGridConfig.Name = "pGridConfig";
            this.pGridConfig.Size = new System.Drawing.Size(1039, 588);
            this.pGridConfig.TabIndex = 1;
            this.pGridConfig.Text = "advPropertyGrid1";
           // 
            // tpShop
            // 
            this.tpShop.Controls.Add(this.pGridLuv);
            this.tpShop.Location = new System.Drawing.Point(4, 44);
            this.tpShop.Name = "tpShop";
            this.tpShop.Padding = new System.Windows.Forms.Padding(3);
            this.tpShop.Size = new System.Drawing.Size(1045, 594);
            this.tpShop.TabIndex = 1;
            this.tpShop.Text = "SHOP SETTINGS";
            this.tpShop.UseVisualStyleBackColor = true;
            // 
            // pGridLuv
            // 
            this.pGridLuv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridLuv.Location = new System.Drawing.Point(3, 3);
            this.pGridLuv.Name = "pGridLuv";
            this.pGridLuv.Size = new System.Drawing.Size(1039, 588);
            this.pGridLuv.TabIndex = 126;
            this.pGridLuv.Text = "advPropertyGrid1";
            // 
            // tpOthers
            // 
            this.tpOthers.BackColor = System.Drawing.SystemColors.Control;
            this.tpOthers.Controls.Add(this.lblPurchaseCode);
            this.tpOthers.Controls.Add(this.lblCustomerPassword);
            this.tpOthers.Controls.Add(this.lblCustomerKey);
            this.tpOthers.Controls.Add(this.btnRegisterSoftware);
            this.tpOthers.Controls.Add(this.lblLicence);
            this.tpOthers.Controls.Add(this.btnCopyLicence);
            this.tpOthers.Controls.Add(this.txtLicence);
            this.tpOthers.Controls.Add(this.label7);
            this.tpOthers.Controls.Add(this.txtPurchaseCode);
            this.tpOthers.Controls.Add(this.label6);
            this.tpOthers.Controls.Add(this.txtCustomerPassword);
            this.tpOthers.Controls.Add(this.label4);
            this.tpOthers.Controls.Add(this.txtCustomerKey);
            this.tpOthers.Controls.Add(this.label3);
            this.tpOthers.Controls.Add(this.btnSendTestEmailToNotification);
            this.tpOthers.Controls.Add(this.btnSendTestEmailToReport);
            this.tpOthers.Controls.Add(this.btnSendTestEmailToOrders);
            this.tpOthers.Controls.Add(this.btnSendTestEmailToPurchase);
            this.tpOthers.Controls.Add(this.btnDeleteLogo2);
            this.tpOthers.Controls.Add(this.btnDeleteLogo1);
            this.tpOthers.Controls.Add(this.label2);
            this.tpOthers.Controls.Add(this.label1);
            this.tpOthers.Controls.Add(this.btnLoadLogo2);
            this.tpOthers.Controls.Add(this.pBoxLogo2);
            this.tpOthers.Controls.Add(this.btnLoadLogo1);
            this.tpOthers.Controls.Add(this.pBoxLogo1);
            this.tpOthers.Controls.Add(this.label16);
            this.tpOthers.Controls.Add(this.cmbChangeTaxRate);
            this.tpOthers.Controls.Add(this.btnImportMenu);
            this.tpOthers.Controls.Add(this.label5);
            this.tpOthers.Controls.Add(this.cmbMenu);
            this.tpOthers.Controls.Add(this.cmbMenuTaxRates);
            this.tpOthers.Location = new System.Drawing.Point(4, 44);
            this.tpOthers.Name = "tpOthers";
            this.tpOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tpOthers.Size = new System.Drawing.Size(1045, 594);
            this.tpOthers.TabIndex = 2;
            this.tpOthers.Text = "OTHERS";
            // 
            // lblPurchaseCode
            // 
            this.lblPurchaseCode.AutoSize = true;
            this.lblPurchaseCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPurchaseCode.ForeColor = System.Drawing.Color.Red;
            this.lblPurchaseCode.Location = new System.Drawing.Point(594, 254);
            this.lblPurchaseCode.Name = "lblPurchaseCode";
            this.lblPurchaseCode.Size = new System.Drawing.Size(377, 19);
            this.lblPurchaseCode.TabIndex = 162;
            this.lblPurchaseCode.Text = "Purchase code is given to you when you make the payment.";
            // 
            // lblCustomerPassword
            // 
            this.lblCustomerPassword.AutoSize = true;
            this.lblCustomerPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerPassword.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerPassword.Location = new System.Drawing.Point(594, 166);
            this.lblCustomerPassword.Name = "lblCustomerPassword";
            this.lblCustomerPassword.Size = new System.Drawing.Size(391, 19);
            this.lblCustomerPassword.TabIndex = 161;
            this.lblCustomerPassword.Text = "This is your Dronax customer password for all your computers.";
            // 
            // lblCustomerKey
            // 
            this.lblCustomerKey.AutoSize = true;
            this.lblCustomerKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerKey.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerKey.Location = new System.Drawing.Point(594, 76);
            this.lblCustomerKey.Name = "lblCustomerKey";
            this.lblCustomerKey.Size = new System.Drawing.Size(411, 19);
            this.lblCustomerKey.TabIndex = 160;
            this.lblCustomerKey.Text = "This is your Dronax customer identification for all your computers.";
            // 
            // btnRegisterSoftware
            // 
            this.btnRegisterSoftware.Location = new System.Drawing.Point(598, 447);
            this.btnRegisterSoftware.Name = "btnRegisterSoftware";
            this.btnRegisterSoftware.Size = new System.Drawing.Size(345, 42);
            this.btnRegisterSoftware.TabIndex = 159;
            this.btnRegisterSoftware.Text = "Register This Computer \'s Software";
            this.btnRegisterSoftware.UseVisualStyleBackColor = true;
            this.btnRegisterSoftware.Click += new System.EventHandler(this.btnRegisterSoftware_Click);
            // 
            // lblLicence
            // 
            this.lblLicence.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicence.ForeColor = System.Drawing.Color.Red;
            this.lblLicence.Location = new System.Drawing.Point(605, 344);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(338, 66);
            this.lblLicence.TabIndex = 158;
            this.lblLicence.Text = "Licence will allow you to use your software properly without any limits. Fail to " +
    "do so will limit your maximum order items to 3.";
            // 
            // btnCopyLicence
            // 
            this.btnCopyLicence.BackgroundImage = global::DTRMSimpleBackOffice.Properties.Resources.Duplicate;
            this.btnCopyLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyLicence.Location = new System.Drawing.Point(950, 311);
            this.btnCopyLicence.Name = "btnCopyLicence";
            this.btnCopyLicence.Size = new System.Drawing.Size(32, 30);
            this.btnCopyLicence.TabIndex = 157;
            this.btnCopyLicence.UseVisualStyleBackColor = true;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(598, 312);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(345, 29);
            this.txtLicence.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 21);
            this.label7.TabIndex = 155;
            this.label7.Text = "Licence (Only for this computer)";
            // 
            // txtPurchaseCode
            // 
            this.txtPurchaseCode.Location = new System.Drawing.Point(598, 222);
            this.txtPurchaseCode.Name = "txtPurchaseCode";
            this.txtPurchaseCode.Size = new System.Drawing.Size(345, 29);
            this.txtPurchaseCode.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 152;
            this.label6.Text = "Purchase Code";
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Location = new System.Drawing.Point(598, 136);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.PasswordChar = '*';
            this.txtCustomerPassword.Size = new System.Drawing.Size(345, 29);
            this.txtCustomerPassword.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 21);
            this.label4.TabIndex = 150;
            this.label4.Text = "Customer Password (Licence)";
            // 
            // txtCustomerKey
            // 
            this.txtCustomerKey.Location = new System.Drawing.Point(598, 47);
            this.txtCustomerKey.Name = "txtCustomerKey";
            this.txtCustomerKey.Size = new System.Drawing.Size(345, 29);
            this.txtCustomerKey.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 148;
            this.label3.Text = "Customer Key (Licence)";
            // 
            // btnSendTestEmailToNotification
            // 
            this.btnSendTestEmailToNotification.Location = new System.Drawing.Point(27, 520);
            this.btnSendTestEmailToNotification.Name = "btnSendTestEmailToNotification";
            this.btnSendTestEmailToNotification.Size = new System.Drawing.Size(276, 30);
            this.btnSendTestEmailToNotification.TabIndex = 147;
            this.btnSendTestEmailToNotification.Text = "Send Test Email To Notification Email";
            this.btnSendTestEmailToNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTestEmailToNotification.UseVisualStyleBackColor = true;
            this.btnSendTestEmailToNotification.Click += new System.EventHandler(this.btnSendTestEmailToNotification_Click);
            // 
            // btnSendTestEmailToReport
            // 
            this.btnSendTestEmailToReport.Location = new System.Drawing.Point(27, 484);
            this.btnSendTestEmailToReport.Name = "btnSendTestEmailToReport";
            this.btnSendTestEmailToReport.Size = new System.Drawing.Size(276, 30);
            this.btnSendTestEmailToReport.TabIndex = 146;
            this.btnSendTestEmailToReport.Text = "Send Test Email To Report Email";
            this.btnSendTestEmailToReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTestEmailToReport.UseVisualStyleBackColor = true;
            this.btnSendTestEmailToReport.Click += new System.EventHandler(this.btnSendTestEmailToReport_Click);
            // 
            // btnSendTestEmailToOrders
            // 
            this.btnSendTestEmailToOrders.Location = new System.Drawing.Point(27, 448);
            this.btnSendTestEmailToOrders.Name = "btnSendTestEmailToOrders";
            this.btnSendTestEmailToOrders.Size = new System.Drawing.Size(276, 30);
            this.btnSendTestEmailToOrders.TabIndex = 145;
            this.btnSendTestEmailToOrders.Text = "Send Test Email To Orders Email";
            this.btnSendTestEmailToOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTestEmailToOrders.UseVisualStyleBackColor = true;
            this.btnSendTestEmailToOrders.Click += new System.EventHandler(this.btnSendTestEmailToOrders_Click);
            // 
            // btnSendTestEmailToPurchase
            // 
            this.btnSendTestEmailToPurchase.Location = new System.Drawing.Point(27, 412);
            this.btnSendTestEmailToPurchase.Name = "btnSendTestEmailToPurchase";
            this.btnSendTestEmailToPurchase.Size = new System.Drawing.Size(276, 30);
            this.btnSendTestEmailToPurchase.TabIndex = 144;
            this.btnSendTestEmailToPurchase.Text = "Send Test Email To Purchase Email";
            this.btnSendTestEmailToPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTestEmailToPurchase.UseVisualStyleBackColor = true;
            this.btnSendTestEmailToPurchase.Click += new System.EventHandler(this.btnSendTestEmailToPurchase_Click);
            // 
            // btnDeleteLogo2
            // 
            this.btnDeleteLogo2.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeleteLogo2.Location = new System.Drawing.Point(480, 288);
            this.btnDeleteLogo2.Name = "btnDeleteLogo2";
            this.btnDeleteLogo2.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteLogo2.TabIndex = 143;
            this.btnDeleteLogo2.UseVisualStyleBackColor = true;
            this.btnDeleteLogo2.Click += new System.EventHandler(this.btnDeleteLogo2_Click);
            // 
            // btnDeleteLogo1
            // 
            this.btnDeleteLogo1.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeleteLogo1.Location = new System.Drawing.Point(211, 288);
            this.btnDeleteLogo1.Name = "btnDeleteLogo1";
            this.btnDeleteLogo1.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteLogo1.TabIndex = 142;
            this.btnDeleteLogo1.UseVisualStyleBackColor = true;
            this.btnDeleteLogo1.Click += new System.EventHandler(this.btnDeleteLogo1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 141;
            this.label2.Text = "Logo 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 140;
            this.label1.Text = "Logo 1";
            // 
            // btnLoadLogo2
            // 
            this.btnLoadLogo2.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadLogo2.Image")));
            this.btnLoadLogo2.Location = new System.Drawing.Point(480, 225);
            this.btnLoadLogo2.Name = "btnLoadLogo2";
            this.btnLoadLogo2.Size = new System.Drawing.Size(48, 48);
            this.btnLoadLogo2.TabIndex = 139;
            this.btnLoadLogo2.UseVisualStyleBackColor = true;
            this.btnLoadLogo2.Click += new System.EventHandler(this.btnLoadLogo2_Click);
            // 
            // pBoxLogo2
            // 
            this.pBoxLogo2.BackColor = System.Drawing.Color.White;
            this.pBoxLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxLogo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxLogo2.Location = new System.Drawing.Point(297, 225);
            this.pBoxLogo2.Name = "pBoxLogo2";
            this.pBoxLogo2.Size = new System.Drawing.Size(176, 168);
            this.pBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo2.TabIndex = 138;
            this.pBoxLogo2.TabStop = false;
            // 
            // btnLoadLogo1
            // 
            this.btnLoadLogo1.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadLogo1.Image")));
            this.btnLoadLogo1.Location = new System.Drawing.Point(211, 225);
            this.btnLoadLogo1.Name = "btnLoadLogo1";
            this.btnLoadLogo1.Size = new System.Drawing.Size(48, 48);
            this.btnLoadLogo1.TabIndex = 137;
            this.btnLoadLogo1.UseVisualStyleBackColor = true;
            this.btnLoadLogo1.Click += new System.EventHandler(this.btnLoadLogo1_Click);
            // 
            // pBoxLogo1
            // 
            this.pBoxLogo1.BackColor = System.Drawing.Color.White;
            this.pBoxLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxLogo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxLogo1.Location = new System.Drawing.Point(28, 225);
            this.pBoxLogo1.Name = "pBoxLogo1";
            this.pBoxLogo1.Size = new System.Drawing.Size(176, 168);
            this.pBoxLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo1.TabIndex = 136;
            this.pBoxLogo1.TabStop = false;
            // 
            // frmConfig
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1073, 733);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remoteStationBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpTerminal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pGridConfig)).EndInit();
            this.tpShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pGridLuv)).EndInit();
            this.tpOthers.ResumeLayout(false);
            this.tpOthers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public void SwitchToRegistrationPanel() {
            try {
                tabMain.SelectedIndex = 2;
            } catch { }
            
        }

        private void frmConfig_Load(object sender, System.EventArgs e) {
            if (bslayer== null || bslayer.OfficeConnectionStatus == ConnectionStatus.Disconnected) {
                tabMain.TabPages.Remove(tabMain.TabPages["tpShop"]);
                tabMain.TabPages.Remove(tabMain.TabPages["tpOthers"]);
            }
            LoadConfig();

            pGridConfig.VerticalScroll.Visible = false;

            
        }

        private void LoadConfig() { 
           
            //independent assignment 
            //if (config.Local_Database_File_Name == "") {
            //    DTRMSimpleBusiness bslayerdummy = new DTRMSimpleBusiness();
            //    config.Local_Database_File_Name = DRFile.GetApplicationPath() + "Db\\" +
            //                                      bslayerdummy.DatabaseFilesRootName + ".mdf";
            //}

            pGridConfig.SelectedObject = config;

            //pGridConfig.PropertyTree.Nodes[1].Nodes[0].Enabled = false;
            //ValidateApplicationType(config.Application_Type);

            //ValidateServerConnectionType(config.Database_Type);

            //ValidateDirectSale(config.Direct_Sale_Allowed);
            //ValidateInHouse(config.Table_Orders_Allowed);
            //ValidateTakeAway(config.TakeAway_Orders_Allowed);
            //ValidateDelivery(config.Delivery_Orders_Allowed);
            //ValidateCashDrawer(config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
            //ValidateServiceSettings(config.ServiceEnabled);
            //ValidateCustomerDisplay(config.Customer_Display_Type != CustomerDisplayTypes.NONE);

            if (!blnEmpty) {
                if (bslayer.IsServerConnected()) {
                    try {
                        LoadMenuList();
                    }
                    catch {
                    }

                    try {
                        LoadCompanyDetails();
                    }
                    catch {
                    }
                }
            }


            //EnsureConnectionImage();

            //run this lines if you want the property grid list in developer mode
            //string test = PrintNodes(false, pGridConfig.PropertyTree.Nodes);
            //File.WriteAllText("propertygrid.txt", test);
        }

        //private string PrintNodes(bool blnChild, NodeCollection nodes) {
        //    string nodelist = "";
        //    foreach (Node nd in nodes) {
        //        nodelist += (blnChild ? "\t" : "") + nd.Index + "-" + nd.ToString() + "\r\n" + PrintNodes(true, nd.Nodes);

        //    }
        //    return nodelist;

        //}

        private void btnClose_Click(object sender, System.EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadMenuList() {
            if (!blnEmpty) {
                cmbMenu.DataSource = bslayer.GetMenuList();
                try {
                    cmbMenu.SelectedValue = bslayer.config.ActiveMenuIID;
                }
                catch {
                }
            }
        }

        private void cmbMenus_SelectionChangeCommitted(object sender, EventArgs e) {
            if (!blnEmpty) {
                bslayer.config.ActiveMenuIID = cmbMenu.SelectedValue.ToString();
                UF.SaveConfig(bslayer.config);
                LoadMenuList();
                bslayer.GetActiveMenu(true, true);
            }
        }

        #region "COMPANY DETAILS THINGS"

        private void LoadTaxRates() {
            if (!blnEmpty) {
                try {
                    cmbMenuTaxRates.DataSource = bslayer.GetAllTaxRates();
                    cmbMenuTaxRates.DisplayMember = "TaxPercent";
                    cmbMenuTaxRates.ValueMember = "TaxPercent";
                }
                catch {
                }
            }
        }

        private void LoadCompanyDetails() {
            if (!blnEmpty) {
                try {


                    pGridLuv.SelectedObject = bslayer.GetLuv();

                    LoadTaxRates();

                    LoadLogoImages();

                    LoadLicenceDetails();
                }
                catch {
                }
            }
        }

        private void LoadLicenceDetails() {
            txtCustomerKey.Text = bslayer.luv.CustomerKey;
            txtCustomerPassword.Text = bslayer.luv.CustomerPassword;
            txtPurchaseCode.Text = config.PurchaseCode;
            txtLicence.Text = config.TerminalLicence;

            btnRegisterSoftware.Visible =!bslayer.LicenceVerified;

            LicenceVerifiedActions();
        }

        private void LoadLogoImages() {
            GenericImage gim1 = bslayer.GetGenericImage("Logo1");
            if (gim1 != null)
                pBoxLogo1.Image = gim1.DisplayImage;
            GenericImage gim2 = bslayer.GetGenericImage("Logo2");
            if (gim2 != null)
                pBoxLogo2.Image =gim2.DisplayImage;
        }
        private void SaveCompanyDetails() {
            if (!blnEmpty) {
                bslayer.luv = (Luv) pGridLuv.SelectedObject;
                bslayer.luv.VoidText = (bslayer.luv.VoidText.Length > 5 ? bslayer.luv.VoidText.Substring(0, 5) : bslayer.luv.VoidText);
                bslayer.luv.CustomerKey = txtCustomerKey.Text;
                bslayer.luv.CustomerPassword = txtCustomerPassword.Text;
                bslayer.SaveLuv(bslayer.luv);
            }
        }

        #endregion


        private void SaveClientConfig() {
            //Now save 


        }

        private void btnImportMenu_Click(object sender, EventArgs e) {
            if (!blnEmpty) {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (ofd.FileName != "") {
                    FMenu fm = null;
                    try {
                        fm = (FMenu) DRFile.XmlDeSerialize(ofd.FileName, typeof(FMenu), false);
                    }
                    catch {
                        MessageBox.Show("Menu cannot be imported");
                        return;
                    }

                    bslayer.SaveMenuDB(fm);
                    bslayer.SaveMenuA(fm);
                    LoadMenuList();
                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e) {

            //string filename = "DTRMConfig.xml";
            try {
                if (UF.SaveConfig(config)) {
                    MessageBox.Show("Configuration file saved");
                    if (!blnEmpty) {
                        bslayer.config = config;
                        SaveCompanyDetails();
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Failed to save configuration file");
            }
            catch {
                MessageBox.Show("Failed to save configuration file");
            }
        }


        private void cmbChangeTaxRate_Click(object sender, EventArgs e) {
            if (!blnEmpty) {
                if (cmbMenuTaxRates.Items.Count > 0) {
                    float SelectedTaxRate = float.Parse(cmbMenuTaxRates.SelectedValue.ToString(),
                        System.Globalization.NumberStyles.Any);
                    TrmGetValue frm = new TrmGetValue(NumberModes.FloatMode);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        bslayer.SetTaxRate(SelectedTaxRate, frm.ReturnValue);
                        LoadTaxRates();
                    }
                }
            }
        }


//        private void pGridConfig_PropertyValueChanging(object sender, DevComponents.DotNetBar.PropertyValueChangingEventArgs e) {
//            if (e.PropertyName == "Application_Type")
//                ValidateApplicationType((ApplicationTypes)e.NewValue);

//            if (e.PropertyName == "Database_Type")
//                ValidateServerConnectionType((DTRMNS.DatabaseTypes)e.NewValue);

//            if (e.PropertyName == "Direct_Orders_Allowed")
//                ValidateDirectSale((bool) e.NewValue); // Is_Direct_Sale_Allowed

//            if (e.PropertyName == "Table_Orders_Allowed")
//                ValidateInHouse((bool) e.NewValue); // Is_InHouse_Sale_Allowed

//            if (e.PropertyName == "TakeAway_Orders_Allowed")
//                ValidateTakeAway((bool) e.NewValue); // Is_TakeAway_Sale_Allowed
//            if (e.PropertyName == "Delivery_Orders_Allowed")
//                ValidateDelivery((bool) e.NewValue); // Is_Delivery_Sale_Allowed
//            if (e.PropertyName == "Attached_Cash_Drawer_Type")
//                ValidateCashDrawer(CashDrawerTypes.None != (CashDrawerTypes) e.NewValue);
//            if (e.PropertyName == "ServiceEnabled")
//                ValidateServiceSettings((bool) e.NewValue); // ServiceEnabled

//            if (e.PropertyName == "Customer_Display_Type")
//                ValidateCustomerDisplay(CustomerDisplayTypes.NONE != (CustomerDisplayTypes) e.NewValue);
//        }

//        private void ValidateApplicationType(ApplicationTypes appType) {

//            switch (appType) {
//                case ApplicationTypes.ThinClient:
//                    config.Database_Type = DatabaseTypes.RemoteSQLExpress;
//                    ValidateServerConnectionType(DatabaseTypes.RemoteSQLExpress);
//                    break;
//                case ApplicationTypes.StandAlone:
//                    config.Database_Type = DatabaseTypes.LocalDB;
//                    ValidateServerConnectionType(DatabaseTypes.LocalDB);
//                    break;
//                case ApplicationTypes.MultiClientServer:
//                    config.Database_Type = DatabaseTypes.LocalSQLExpress;
//                    ValidateServerConnectionType(DatabaseTypes.LocalSQLExpress);
//                    break;
//                default:
//                    break;
//            }
//            pGridConfig.RefreshPropertyValues();

//        }

//        private void ValidateServerConnectionType(DatabaseTypes dbType) {
//            /*Thin Client - RemoteSQLExpress
//                ===================
//                Hide
//                1-Local_Database_File_Name

//                Show
//                0,2,3,4,5

//                Stand Alone - LocalDB
//                ===================
//                Hide
//                2-Database_Instance
//                3-Database_Name
//                4-Database_User_Name
//                5-Database_Password

//                Show
//                0,1

//                MultiClientServer - LocalSQLExpress
//                ===================
//                Hide
//                None
//                Show
//                All
//                */

//            /*pGridConfig.PropertyTree.Nodes[Connection Settings-1].Nodes[Database_Instance -4]

//                        _Connection_Name 0
//                        Database_Type 1
//                        Local_Database_File_Name 2
//                        Database_Instance 3
//                        _Attach_Database_File 4
//                        Database_Name 5
//                        Database_User_Name 6
//                        Database_Password 7  */

//            pGridConfig.PropertyTree.Nodes[1].Nodes[1].Enabled = false;
//            pGridConfig.PropertyTree.Nodes[1].Nodes[4].Enabled = false;

//            switch (dbType) {
//                    case DatabaseTypes.LocalDB:
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[0].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[1].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[2].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[3].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[4].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[5].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[6].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[7].Visible = false;

//                    config.Attach_Database_File = true;
//                    break;
//                    case DatabaseTypes.LocalSQLExpress:
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[0].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[1].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[2].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[3].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[4].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[5].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[6].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[7].Visible = true;

//                    config.Attach_Database_File = false;
//                    break;
//                    case DatabaseTypes.RemoteSQLExpress:
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[0].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[1].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[2].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[3].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[4].Visible = false;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[5].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[6].Visible = true;
//                    pGridConfig.PropertyTree.Nodes[1].Nodes[7].Visible = true;

//                    config.Attach_Database_File = false;
//                    break;
//            }
//        }

//        private void ValidateDirectSale(bool blnCheck) {
//            /*
//2-Sale Types - Direct
//   0-Is_Direct_Sale_Allowed, True***

//   1-Direct_Sale_Receipt_Count, 1
//   2-Direct_Sale_Auto_Payment_Mehtod, AutoCash
//   3-Direct_Sale_Order_Button_Text, Direct Sale   
//   4-Direct_Sale_Button_Width, 76
//            */
//            for (int i = 1; i <= 4; i++)
//                pGridConfig.PropertyTree.Nodes[2].Nodes[i].Visible = blnCheck;
//        }

//        private void ValidateInHouse(bool blnCheck) {
//            /*
//3-Sale Types - In-House
//0-Is_InHouse_Sale_Allowed, True***

//1-InHouse_Receipt_Count, 0
//2-InHouse_Kitchen_Receipt_Count, 1
//3-InHouse_Auto_Payment_Method, Selective
//4-InHouse_Order_Button_Text, IN-House
//5-_Table_Sale_Button_Width
////6-_Table_Order_Items_Stepable
// */
//            for (int i = 1; i <= 5; i++)
//                pGridConfig.PropertyTree.Nodes[3].Nodes[i].Visible = blnCheck;

//        }

//        private void ValidateTakeAway(bool blnCheck) {
//            /*
//4-Sale Take-Away
//0-Is_TakeAway_Sale_Allowed, True***

//1-TakeAway_Receipt_Count, 1
//2-TakeAway_Auto_Payment_Method, AutoCash
//3-TakeAway_Order_Button_Text, Take Away
//*/
//            for (int i = 1; i <= 3; i++)
//                pGridConfig.PropertyTree.Nodes[4].Nodes[i].Visible = blnCheck;
//        }

//        private void ValidateDelivery(bool blnCheck) {
//            /*
//5-Sale Delivery
//0-Is_Delivery_Sale_Allowed, True***

//1-Delivery_Receipt_Count, 2
//2-Delivery_Auto_Payment_Method, Selective
//3-Delivery_Order_Button_Text, Delivery
//*/
//            for (int i = 1; i <= 3; i++)
//                pGridConfig.PropertyTree.Nodes[5].Nodes[i].Visible = blnCheck;
//        }


//        /*
//6-Defaults
//0-Order_Pad_Default_Order_Type, DirectSale
//1-Auto_Order_Type, Unknown
//*/

//        private void ValidateCustomerDisplay(bool blnCheck) {
//            /*
//7-Customer Display
//0-Customer_Display_Type, NONE***
//1-Customer_Display_Character_Set, UK	
//2-Customer_Display_Unit_Connected_To_COM, NONE
//3-Customer_Display_Text_Length, 20
//*/
//            for (int i = 1; i <= 3; i++)
//                pGridConfig.PropertyTree.Nodes[7].Nodes[i].Visible = blnCheck;
//        }

//        private void ValidateCashDrawer(bool blnCheck) {
//            /*            
//8-Cash Drawer
//	0-Attached_Cash_Drawer_Type, None***

//	1-Cash_Drawer_Serial_Port, COM1
//            */
//            pGridConfig.PropertyTree.Nodes[8].Nodes[1].Visible = blnCheck;
//        }


//        private void ValidateServiceSettings(bool blnCheck) {
//            /*
//15-Service Settings
//0-ServiceEnabled, False***

//1-ServiceAutoStart, False
//2-ServiceLocalPort, 5555
//3-ServiceRemoteURL, http://localhost:5555
//*/
//            for (int i = 1; i <= 3; i++)
//                pGridConfig.PropertyTree.Nodes[15].Nodes[i].Visible = blnCheck;
//        }



        

//        private void PropertyValueChangeHandler(DevComponents.DotNetBar.PropertyValueChangingEventArgs e) {


//        }

//        private void pGridConfig_ProvideUITypeEditor(object sender, DevComponents.DotNetBar.ProvideUITypeEditorEventArgs e) {
            
//            //if (e.PropertyName == "Database_Instance") {
//            //    MessageBox.Show("oldu");
//            //    MultilineStringEditor editor = (MultilineStringEditor) e.UITypeEditor;
                
//            //}
//        }

//        private void pGridConfig_ProvidePropertyValueList(object sender, DevComponents.DotNetBar.PropertyValueListEventArgs e) {
//            if (e.PropertyName == "Database_Instance") {
//                MessageBox.Show("loading");
//                //MultilineStringEditor editor = (MultilineStringEditor)e.ValueList;

//            }
//        }

        private void btnChangeConnection_Click(object sender, EventArgs e) {
            if (!UF.IsDBListFileExist()) {
                DBList dblist = new DBList();
                dblist.Items.Add(new DB(".", "DTRMSimple", "sa", "."));
                DRFile.XmlSerialize(UF.DBListConfigFileName, dblist, typeof(DBList), false);
            }

            frmConnectionList frm = new frmConnectionList(UF.DBListConfigFileName);
            if (frm.ShowDialog() == DialogResult.OK) {
                DB db = frm.SelectedDB;
                if (config == null)
                    config = new DTRMConfig();
                //config.Connection_Name = db.ConnectionName;
                config.Database_Name = db.DatabaseName;
                config.Database_Instance = db.ServerIP;
                config.Database_User_Name = db.UserName;
                config.Database_Password = db.Password;
                LoadConfig();


            }
        }

        private void pGridConfig_PropertyValueChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Application_Type") {
                //EnsureConnectionImage();
            }
        }

        //private void EnsureConnectionImage() {
        //    switch (config.Application_Type) {
        //        case ApplicationTypes.ThinClient:
        //            pBox.Image = Properties.Resources.ThinClient;
        //            break;
        //        case ApplicationTypes.StandAlone:
        //            pBox.Image = Properties.Resources.StandAlone;
        //            break;
        //        case ApplicationTypes.MultiClientServer:
        //            pBox.Image = Properties.Resources.MultiClientServer;
        //            break;
        //        default:
        //            pBox.Image = null;
        //            break;
        //    }
        //}

        private void btnLoadLogo1_Click(object sender, EventArgs e) {
            frmGenericImageEditor frm = new frmGenericImageEditor(bslayer, null, "Logo1");
            if (frm.ShowDialog() == DialogResult.OK) {
                pBoxLogo1.Image = frm.gim.DisplayImage;
            }
        }

        private void btnLoadLogo2_Click(object sender, EventArgs e) {
            frmGenericImageEditor frm = new frmGenericImageEditor(bslayer, null, "Logo2");
            if (frm.ShowDialog() == DialogResult.OK) {
                pBoxLogo2.Image = frm.gim.DisplayImage;
            }
        }

        private void btnDeleteLogo1_Click(object sender, EventArgs e) {
            bslayer.DeletePrepImage("Logo1");
            pBoxLogo1.Image = null;
            LoadLogoImages();
        }

        private void btnDeleteLogo2_Click(object sender, EventArgs e) {
            bslayer.DeletePrepImage("Logo2");
            pBoxLogo2.Image = null;
            LoadLogoImages();
        }

        private void btnSendTestEmailToPurchase_Click(object sender, EventArgs e) {
            bslayer.SendEmailToCustomRecepient(bslayer.luv.PurchaseEmail, "Test email from DTRMSimple to Purchase", "test", null);
        }

        private void btnSendTestEmailToOrders_Click(object sender, EventArgs e) {
            bslayer.SendEmailToCustomRecepient(bslayer.luv.OrdersEmail, "Test email from DTRMSimple to Orders", "test", null);
        }

        private void btnSendTestEmailToReport_Click(object sender, EventArgs e) {
            bslayer.SendEmailToCustomRecepient(bslayer.luv.ReportEmail, "Test email from DTRMSimple to Report", "test", null);
        }

        private void btnSendTestEmailToNotification_Click(object sender, EventArgs e) {
            bslayer.SendEmailToCustomRecepient(bslayer.luv.NotificationEmail, "Test email from DTRMSimple to Notification", "test", null);
        }



        private void btnRegisterSoftware_Click(object sender, EventArgs e) {
            //if (txtCustomerKey.Text.Trim().Length > 0 &&
            //    txtCustomerPassword.Text.Trim().Length > 0 &&
            //    txtPurchaseCode.Text.Trim().Length > 0 ) {
            //    //Now you can register

            //    LicenceItem item = new LicenceItem();

            //    item.MachineID = FingerPrint.Value();
            //    item.CustomerKey = txtCustomerKey.Text.Trim();
            //    item.SoftwareID = bslayer.SoftwareID;
            //    item.Password = txtCustomerPassword.Text.Trim();
            //    item.PurchaseCode = txtPurchaseCode.Text.Trim();

            //    bslayer.luv.CustomerKey = txtCustomerKey.Text.Trim();
            //    bslayer.luv.CustomerPassword = txtCustomerPassword.Text.Trim();
            //    bslayer.SaveLuv(bslayer.luv);

            //    BasicHttpBinding basicHttpbinding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            //    basicHttpbinding.Name = "BasicHttpBinding_IDronaxLicenceService"; 
            //    basicHttpbinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            //    basicHttpbinding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;

            //    EndpointAddress endpointAddress = new EndpointAddress("http://www.dronax.com/DronaxLicence/DronaxLicenceService.svc/DronaxLicenceService");
            //    //Service1Client proxyClient = new Service1Client(basicHttpbinding, endpointAddress);


            //    DronaxLicenceServiceReference.DronaxLicenceServiceClient client = new DronaxLicenceServiceReference.DronaxLicenceServiceClient(basicHttpbinding, endpointAddress);
            //    if (client.DBTest() != null && client.DBTest() != "") {
            //        LicenceItem processitem = client.RegisterByPurchase(item);
                    
            //        switch (processitem.Status) {
            //            case LicenceRegistrationErrorCodes.SuccessfullyRegistered:
            //            case LicenceRegistrationErrorCodes.MachineAlreadyRegisteredForCustomer:
            //            case LicenceRegistrationErrorCodes.MachineAlreadyRegisteredForPurchase:
            //                txtPurchaseCode.Text = processitem.PurchaseCode;
            //                txtLicence.Text = processitem.LicenceHash;

            //                bslayer.config.PurchaseCode = processitem.PurchaseCode;
            //                bslayer.config.TerminalLicence = processitem.LicenceHash;
            //                UF.SaveConfig(bslayer.config);

            //                DRFile.BinarySerialize(bslayer.SoftwareID, processitem);

            //                bslayer.LicenceVerified = true;
                            
            //                LicenceVerifiedActions();
            //                break;
            //            default:
            //                MessageBox.Show(item.Status.ToString() + Environment.NewLine + processitem.Message);
            //                break;
            //        }                   
                    
            //    }
            //    client.Close();

            //} else {
            //    MessageBox.Show("Please fill in all the required fields.");
            //}
        }

        private void LicenceVerifiedActions() {
            if (bslayer.LicenceVerified) {
                lblCustomerKey.ForeColor = lblCustomerPassword.ForeColor = lblPurchaseCode.ForeColor= Color.Blue;
                lblLicence.Visible = false;
                txtCustomerKey.Enabled = txtCustomerPassword.Enabled = txtPurchaseCode.Enabled = txtLicence.Enabled = false;
                btnRegisterSoftware.Visible = false;
                if (RegistrationButton != null)
                    RegistrationButton.Visible = false;
            }
        }
    }
}