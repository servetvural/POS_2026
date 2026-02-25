using System;
using System.ComponentModel;
using System.Windows.Forms;
using PosLibrary;
using PosLibrary.DBSpace;
using System.Globalization;
using System.Linq;

namespace DTRMNS {
    /// <summary>
    /// Summary description for ctlConfig.
    /// </summary>
    public class frmConfig : Form{

        private DTRMNS.DTRMSimpleBusiness bslayer;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button btnSave;
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
        private PropertyGrid pGridConfig;
        private PropertyGrid pGridLuv;
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
        private TabPage tabHelper;
        private Label lblCulture;
        private Label label8;
        private ComboBox cmbCurrencyCulture;
        private Label lblVersion;
        private Button btnRegisterSoftware;
        private Button btnCopyLicence;
        private bool blnEmpty;
        private Label lblLicenceNumber;
        private DataGridView dgv;
        public ToolStripButton RegistrationButton;

        public frmConfig() {
            InitializeComponent();
        }

        public frmConfig(DTRMNS.DTRMSimpleBusiness bslayer) {
            this.bslayer = bslayer;

            if (bslayer == null)
            {
                //Empty config required
                blnEmpty = true;
                config = UF.GetConfig();
                if (config == null)
                    config = new DTRMConfig();

            } else
            {
                this.config = bslayer.config;
                if (config == null)
                    config = bslayer.config = UF.GetConfig();
                if (config == null)
                    config = bslayer.config = new DTRMConfig();
                
            }
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpTerminal = new System.Windows.Forms.TabPage();
            this.pGridConfig = new System.Windows.Forms.PropertyGrid();
            this.tpShop = new System.Windows.Forms.TabPage();
            this.pGridLuv = new System.Windows.Forms.PropertyGrid();
            this.tpOthers = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblLicenceNumber = new System.Windows.Forms.Label();
            this.btnRegisterSoftware = new System.Windows.Forms.Button();
            this.btnCopyLicence = new System.Windows.Forms.Button();
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
            this.tabHelper = new System.Windows.Forms.TabPage();
            this.lblCulture = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCurrencyCulture = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogListBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpTerminal.SuspendLayout();
            this.tpShop.SuspendLayout();
            this.tpOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo1)).BeginInit();
            this.tabHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.pBox);
            this.panel2.Controls.Add(this.btnChangeConnection);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 630);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1014, 71);
            this.panel2.TabIndex = 71;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(537, 8);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(330, 35);
            this.lblVersion.TabIndex = 89;
            this.lblVersion.Text = "0.0.0.0";
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
            this.btnSave.Location = new System.Drawing.Point(834, 5);
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
            this.label5.Size = new System.Drawing.Size(95, 16);
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
            this.label16.Size = new System.Drawing.Size(117, 16);
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
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpTerminal);
            this.tabMain.Controls.Add(this.tpShop);
            this.tabMain.Controls.Add(this.tpOthers);
            this.tabMain.Controls.Add(this.tabHelper);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(200, 40);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1014, 620);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 138;
            // 
            // tpTerminal
            // 
            this.tpTerminal.Controls.Add(this.pGridConfig);
            this.tpTerminal.Location = new System.Drawing.Point(4, 44);
            this.tpTerminal.Name = "tpTerminal";
            this.tpTerminal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTerminal.Size = new System.Drawing.Size(1006, 572);
            this.tpTerminal.TabIndex = 0;
            this.tpTerminal.Text = "TERMINAL SETTINGS";
            this.tpTerminal.UseVisualStyleBackColor = true;
            // 
            // pGridConfig
            // 
            this.pGridConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridConfig.Location = new System.Drawing.Point(3, 3);
            this.pGridConfig.Name = "pGridConfig";
            this.pGridConfig.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pGridConfig.Size = new System.Drawing.Size(1000, 566);
            this.pGridConfig.TabIndex = 1;
            // 
            // tpShop
            // 
            this.tpShop.Controls.Add(this.pGridLuv);
            this.tpShop.Location = new System.Drawing.Point(4, 44);
            this.tpShop.Name = "tpShop";
            this.tpShop.Padding = new System.Windows.Forms.Padding(3);
            this.tpShop.Size = new System.Drawing.Size(1006, 572);
            this.tpShop.TabIndex = 1;
            this.tpShop.Text = "SHOP SETTINGS";
            this.tpShop.UseVisualStyleBackColor = true;
            // 
            // pGridLuv
            // 
            this.pGridLuv.Location = new System.Drawing.Point(3, 3);
            this.pGridLuv.Name = "pGridLuv";
            this.pGridLuv.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pGridLuv.Size = new System.Drawing.Size(1039, 588);
            this.pGridLuv.TabIndex = 126;
            // 
            // tpOthers
            // 
            this.tpOthers.BackColor = System.Drawing.SystemColors.Control;
            this.tpOthers.Controls.Add(this.dgv);
            this.tpOthers.Controls.Add(this.lblLicenceNumber);
            this.tpOthers.Controls.Add(this.btnRegisterSoftware);
            this.tpOthers.Controls.Add(this.btnCopyLicence);
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
            this.tpOthers.Size = new System.Drawing.Size(1006, 572);
            this.tpOthers.TabIndex = 2;
            this.tpOthers.Text = "OTHERS";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(317, 412);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(276, 108);
            this.dgv.TabIndex = 184;
            // 
            // lblLicenceNumber
            // 
            this.lblLicenceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLicenceNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLicenceNumber.Location = new System.Drawing.Point(152, 172);
            this.lblLicenceNumber.Name = "lblLicenceNumber";
            this.lblLicenceNumber.Size = new System.Drawing.Size(697, 22);
            this.lblLicenceNumber.TabIndex = 182;
            this.lblLicenceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenceNumber.Visible = false;
            // 
            // btnRegisterSoftware
            // 
            this.btnRegisterSoftware.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegisterSoftware.Location = new System.Drawing.Point(65, 168);
            this.btnRegisterSoftware.Name = "btnRegisterSoftware";
            this.btnRegisterSoftware.Size = new System.Drawing.Size(81, 30);
            this.btnRegisterSoftware.TabIndex = 178;
            this.btnRegisterSoftware.Text = "Register";
            this.btnRegisterSoftware.UseVisualStyleBackColor = true;
            this.btnRegisterSoftware.Visible = false;
            this.btnRegisterSoftware.Click += new System.EventHandler(this.btnRegisterSoftware_Click);
            // 
            // btnCopyLicence
            // 
            this.btnCopyLicence.BackgroundImage = global::DTRMNS.Properties.Resources.Duplicate;
            this.btnCopyLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyLicence.Location = new System.Drawing.Point(27, 168);
            this.btnCopyLicence.Name = "btnCopyLicence";
            this.btnCopyLicence.Size = new System.Drawing.Size(32, 30);
            this.btnCopyLicence.TabIndex = 176;
            this.btnCopyLicence.UseVisualStyleBackColor = true;
            this.btnCopyLicence.Visible = false;
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
            this.btnDeleteLogo2.Image = global::DTRMNS.Properties.Resources.Cancel;
            this.btnDeleteLogo2.Location = new System.Drawing.Point(480, 288);
            this.btnDeleteLogo2.Name = "btnDeleteLogo2";
            this.btnDeleteLogo2.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteLogo2.TabIndex = 143;
            this.btnDeleteLogo2.UseVisualStyleBackColor = true;
            this.btnDeleteLogo2.Click += new System.EventHandler(this.btnDeleteLogo2_Click);
            // 
            // btnDeleteLogo1
            // 
            this.btnDeleteLogo1.Image = global::DTRMNS.Properties.Resources.Cancel;
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
            // tabHelper
            // 
            this.tabHelper.Controls.Add(this.lblCulture);
            this.tabHelper.Controls.Add(this.label8);
            this.tabHelper.Controls.Add(this.cmbCurrencyCulture);
            this.tabHelper.Location = new System.Drawing.Point(4, 44);
            this.tabHelper.Name = "tabHelper";
            this.tabHelper.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelper.Size = new System.Drawing.Size(1006, 572);
            this.tabHelper.TabIndex = 3;
            this.tabHelper.Text = "HELPER";
            this.tabHelper.UseVisualStyleBackColor = true;
            // 
            // lblCulture
            // 
            this.lblCulture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCulture.AutoSize = true;
            this.lblCulture.Location = new System.Drawing.Point(315, 26);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(50, 21);
            this.lblCulture.TabIndex = 173;
            this.lblCulture.Text = "- - - - ";
            this.lblCulture.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 21);
            this.label8.TabIndex = 172;
            this.label8.Text = "Find your currency culture";
            // 
            // cmbCurrencyCulture
            // 
            this.cmbCurrencyCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyCulture.FormattingEnabled = true;
            this.cmbCurrencyCulture.Location = new System.Drawing.Point(22, 50);
            this.cmbCurrencyCulture.Name = "cmbCurrencyCulture";
            this.cmbCurrencyCulture.Size = new System.Drawing.Size(345, 29);
            this.cmbCurrencyCulture.TabIndex = 171;
            this.cmbCurrencyCulture.SelectionChangeCommitted += new System.EventHandler(this.cmbCurrencyCulture_SelectionChangeCommitted);
            // 
            // frmConfig
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogListBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpTerminal.ResumeLayout(false);
            this.tpShop.ResumeLayout(false);
            this.tpOthers.ResumeLayout(false);
            this.tpOthers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo1)).EndInit();
            this.tabHelper.ResumeLayout(false);
            this.tabHelper.PerformLayout();
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

            //this section is for version printing even if the system not connected
            #region Display Application Version
            if (bslayer == null) {
                bslayer = new DTRMSimpleBusiness();
                lblVersion.Text = "Version : " +  bslayer.ApplicationVersion;
                bslayer = null;
            }
            if (bslayer!= null)
                lblVersion.Text = "Version : " + bslayer.ApplicationVersion;
            #endregion

            LoadConfig();

            pGridConfig.VerticalScroll.Visible = false;

            LoadCultures();
        }

        private void LoadCultures() {
            // string[] rather than char[] due to NumberFormatInfo.CurrencySymbol returning a string
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            cultures.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));
            //// This will select the currency symbol for each given Culture
            //// Because cultures define a host of number formatting rules, you have to dig into the NumberFormat property to get Currency Symbol
            //.Select(culture => culture.EnglishName) // NumberFormat.CurrencySymbol)

            //// Since some cultures use the same currency symbol, this will trim out duplicates
            //.Distinct()
            //.OrderBy(culture => culture)
            //// Enumerate this to an array in order to avoid reevaluating the entire process every time it's accessed
            ////.ToArray();
            cmbCurrencyCulture.ValueMember = "Name";
            cmbCurrencyCulture.DisplayMember = "DisplayName";
            cmbCurrencyCulture.Items.AddRange(cultures.ToArray());
        }

        private void LoadConfig() {

            pGridConfig.SelectedObject = config;


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


            EnsureConnectionImage();

            //run this lines if you want the property grid list in developer mode
            //string test = PrintNodes(false, pGridConfig.PropertyTree.Nodes);
            //File.WriteAllText("propertygrid.txt", test);
        }


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
                }
                catch {
                }
            }
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
                //config.data = db.ConnectionName;                  
                config.Database_Instance = db.ServerIP;
                config.Database_Name =  db.DatabaseName;
                config.Database_User_Name = db.UserName;
                config.Database_Password = db.Password;
                LoadConfig();


            }
        }


        private void EnsureConnectionImage() {            
                    pBox.Image = Properties.Resources.ThinClient;
                   
        }

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



        private async void btnRegisterSoftware_Click(object sender, EventArgs e) {

           
            //string CustomerKey = ""; //bslayer.luv.CustomerKey;
            //string CustomerPassword = ""; // bslayer.luv.CustomerPassword;

            //string licenceHash = LicenceClient.GetRegistration(ref CustomerKey,ref CustomerPassword, bslayer.SoftwareID,true,"Try Later");
            //if (licenceHash != "") {
            //    bslayer.ValidateLicence();
            //    config.TerminalLicence = licenceHash; 
            //    lblLicenceNumber.Text = config.TerminalLicence;
            //    btnRegisterSoftware.Enabled = false;
            //    btnCopyLicence.Visible = true;
            //    bslayer.luv.CustomerKey = CustomerKey;
            //    bslayer.luv.CustomerPassword = CustomerPassword;
            //    bslayer.SaveLuv();
            //} 
        }

       

        private void cmbCurrencyCulture_SelectionChangeCommitted(object sender, EventArgs e) {
            lblCulture.Text = cmbCurrencyCulture.SelectedItem.ToString();
        }
    }
}