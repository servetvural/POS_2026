using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using PosLibrary;
using PosLibrary.DBSpace;

using POSWinFormLayer;

namespace DTRMNS
{
    /// <summary>
    /// Summary description for ctlConfig.
    /// </summary>
    public class frmConfig : Form
    {
        PosConfig config;
        IRepository<Shop> repoShop;
        IRepository<TheMenu> repoMenu;
        IRepository<GenericImage> repoImage;

        private DTRMSimpleBusiness bslayer;


        private Panel panel2;

        private Button btnSave;
        private BindingSource catalogListBindingSource;
        private Label label16;
        private ComboBox cmbMenuTaxRates;
        private Button cmbChangeTaxRate;
        private Label label5;
        private ComboBox cmbMenu;
        private Button btnImportMenu;
        private TabControl tabMain;
        private TabPage tpTerminal;
        private TabPage tpShop;
        private TabPage tpOthers;
        private Button btnCancel;
        private PropertyGrid pGridConfig;
        private PropertyGrid pGridLuv;
        private IContainer components;


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
        private Label lblVersion;
        private Button btnRegisterSoftware;
        private Button btnCopyLicence;
        private bool blnEmpty;
        private Label lblLicenceNumber;
        private DataGridView dgv;
        public ToolStripButton RegistrationButton;



        public frmConfig(PosConfig configAsService, IRepository<Shop> _repoShop, IRepository<TheMenu> _repoMenu,
            IRepository<GenericImage> _repoImage )
        {
            config = configAsService;
            repoShop = _repoShop;
            repoMenu = _repoMenu;
            repoImage = _repoImage;

            bslayer = DTRMSimpleBusiness.Instance;
            InitializeComponent();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmConfig));
            panel2 = new Panel();
            lblVersion = new Label();
            pBox = new PictureBox();
            btnChangeConnection = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label5 = new Label();
            cmbMenu = new ComboBox();
            catalogListBindingSource = new BindingSource(components);
            btnImportMenu = new Button();
            label16 = new Label();
            cmbMenuTaxRates = new ComboBox();
            cmbChangeTaxRate = new Button();
            tabMain = new TabControl();
            tpTerminal = new TabPage();
            pGridConfig = new PropertyGrid();
            tpShop = new TabPage();
            pGridLuv = new PropertyGrid();
            tpOthers = new TabPage();
            dgv = new DataGridView();
            lblLicenceNumber = new Label();
            btnRegisterSoftware = new Button();
            btnCopyLicence = new Button();
            btnSendTestEmailToNotification = new Button();
            btnSendTestEmailToReport = new Button();
            btnSendTestEmailToOrders = new Button();
            btnSendTestEmailToPurchase = new Button();
            btnDeleteLogo2 = new Button();
            btnDeleteLogo1 = new Button();
            label2 = new Label();
            label1 = new Label();
            btnLoadLogo2 = new Button();
            pBoxLogo2 = new PictureBox();
            btnLoadLogo1 = new Button();
            pBoxLogo1 = new PictureBox();
            panel2.SuspendLayout();
            ((ISupportInitialize)pBox).BeginInit();
            ((ISupportInitialize)catalogListBindingSource).BeginInit();
            tabMain.SuspendLayout();
            tpTerminal.SuspendLayout();
            tpShop.SuspendLayout();
            tpOthers.SuspendLayout();
            ((ISupportInitialize)dgv).BeginInit();
            ((ISupportInitialize)pBoxLogo2).BeginInit();
            ((ISupportInitialize)pBoxLogo1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(lblVersion);
            panel2.Controls.Add(pBox);
            panel2.Controls.Add(btnChangeConnection);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(10, 630);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new System.Drawing.Size(1014, 71);
            panel2.TabIndex = 71;
            // 
            // lblVersion
            // 
            lblVersion.Location = new System.Drawing.Point(537, 8);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(330, 35);
            lblVersion.TabIndex = 89;
            lblVersion.Text = "0.0.0.0";
            // 
            // pBox
            // 
            pBox.BackColor = System.Drawing.Color.Transparent;
            pBox.BorderStyle = BorderStyle.FixedSingle;
            pBox.Location = new System.Drawing.Point(356, 6);
            pBox.Name = "pBox";
            pBox.Size = new System.Drawing.Size(175, 58);
            pBox.TabIndex = 88;
            pBox.TabStop = false;
            // 
            // btnChangeConnection
            // 
            btnChangeConnection.Dock = DockStyle.Left;
            btnChangeConnection.FlatAppearance.BorderSize = 0;
            btnChangeConnection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnChangeConnection.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnChangeConnection.Location = new System.Drawing.Point(180, 5);
            btnChangeConnection.Margin = new Padding(3, 1, 3, 3);
            btnChangeConnection.Name = "btnChangeConnection";
            btnChangeConnection.Size = new System.Drawing.Size(175, 61);
            btnChangeConnection.TabIndex = 87;
            btnChangeConnection.Text = "CHANGE CONNECTION";
            btnChangeConnection.UseVisualStyleBackColor = false;
            btnChangeConnection.Click += btnChangeConnection_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Left;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnCancel.Location = new System.Drawing.Point(5, 5);
            btnCancel.Margin = new Padding(3, 1, 3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(175, 61);
            btnCancel.TabIndex = 86;
            btnCancel.Text = "CLOSE";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnSave.Location = new System.Drawing.Point(834, 5);
            btnSave.Margin = new Padding(3, 1, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(175, 61);
            btnSave.TabIndex = 85;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Arial", 9.75F);
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(25, 100);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 16);
            label5.TabIndex = 135;
            label5.Text = "ACTIVE MENU";
            // 
            // cmbMenu
            // 
            cmbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new System.Drawing.Point(28, 119);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new System.Drawing.Size(306, 32);
            cmbMenu.TabIndex = 134;
            cmbMenu.ValueMember = "IID";
            cmbMenu.SelectionChangeCommitted += cmbMenus_SelectionChangeCommitted;
            // 
            // btnImportMenu
            // 
            btnImportMenu.FlatAppearance.BorderSize = 0;
            btnImportMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnImportMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            btnImportMenu.Location = new System.Drawing.Point(342, 119);
            btnImportMenu.Margin = new Padding(3, 1, 3, 3);
            btnImportMenu.Name = "btnImportMenu";
            btnImportMenu.Size = new System.Drawing.Size(115, 32);
            btnImportMenu.TabIndex = 133;
            btnImportMenu.Text = "IMPORT MENU";
            btnImportMenu.UseVisualStyleBackColor = false;
            btnImportMenu.Click += btnImportMenu_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Arial", 9.75F);
            label16.ForeColor = System.Drawing.SystemColors.ControlText;
            label16.Location = new System.Drawing.Point(28, 29);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(117, 16);
            label16.TabIndex = 127;
            label16.Text = "MENU TAX RATES";
            // 
            // cmbMenuTaxRates
            // 
            cmbMenuTaxRates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuTaxRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            cmbMenuTaxRates.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbMenuTaxRates.FormattingEnabled = true;
            cmbMenuTaxRates.Location = new System.Drawing.Point(28, 48);
            cmbMenuTaxRates.Name = "cmbMenuTaxRates";
            cmbMenuTaxRates.Size = new System.Drawing.Size(114, 33);
            cmbMenuTaxRates.TabIndex = 126;
            // 
            // cmbChangeTaxRate
            // 
            cmbChangeTaxRate.FlatAppearance.BorderSize = 0;
            cmbChangeTaxRate.Font = new System.Drawing.Font("Arial", 9F);
            cmbChangeTaxRate.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbChangeTaxRate.Location = new System.Drawing.Point(158, 44);
            cmbChangeTaxRate.Name = "cmbChangeTaxRate";
            cmbChangeTaxRate.Size = new System.Drawing.Size(110, 37);
            cmbChangeTaxRate.TabIndex = 128;
            cmbChangeTaxRate.Text = "Change Tax Rate";
            cmbChangeTaxRate.UseVisualStyleBackColor = false;
            cmbChangeTaxRate.Click += cmbChangeTaxRate_Click;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpTerminal);
            tabMain.Controls.Add(tpShop);
            tabMain.Controls.Add(tpOthers);
            tabMain.Dock = DockStyle.Fill;
            tabMain.ItemSize = new System.Drawing.Size(200, 40);
            tabMain.Location = new System.Drawing.Point(10, 10);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(1014, 620);
            tabMain.SizeMode = TabSizeMode.Fixed;
            tabMain.TabIndex = 138;
            // 
            // tpTerminal
            // 
            tpTerminal.Controls.Add(pGridConfig);
            tpTerminal.Location = new System.Drawing.Point(4, 44);
            tpTerminal.Name = "tpTerminal";
            tpTerminal.Padding = new Padding(3);
            tpTerminal.Size = new System.Drawing.Size(1006, 572);
            tpTerminal.TabIndex = 0;
            tpTerminal.Text = "TERMINAL SETTINGS";
            tpTerminal.UseVisualStyleBackColor = true;
            // 
            // pGridConfig
            // 
            pGridConfig.BackColor = System.Drawing.SystemColors.Control;
            pGridConfig.Dock = DockStyle.Fill;
            pGridConfig.Location = new System.Drawing.Point(3, 3);
            pGridConfig.Name = "pGridConfig";
            pGridConfig.PropertySort = PropertySort.Categorized;
            pGridConfig.Size = new System.Drawing.Size(1000, 566);
            pGridConfig.TabIndex = 1;
            // 
            // tpShop
            // 
            tpShop.Controls.Add(pGridLuv);
            tpShop.Location = new System.Drawing.Point(4, 44);
            tpShop.Name = "tpShop";
            tpShop.Padding = new Padding(3);
            tpShop.Size = new System.Drawing.Size(1006, 572);
            tpShop.TabIndex = 1;
            tpShop.Text = "SHOP SETTINGS";
            tpShop.UseVisualStyleBackColor = true;
            // 
            // pGridLuv
            // 
            pGridLuv.BackColor = System.Drawing.SystemColors.Control;
            pGridLuv.Location = new System.Drawing.Point(3, 3);
            pGridLuv.Name = "pGridLuv";
            pGridLuv.PropertySort = PropertySort.Categorized;
            pGridLuv.Size = new System.Drawing.Size(1039, 588);
            pGridLuv.TabIndex = 126;
            // 
            // tpOthers
            // 
            tpOthers.BackColor = System.Drawing.SystemColors.Control;
            tpOthers.Controls.Add(dgv);
            tpOthers.Controls.Add(lblLicenceNumber);
            tpOthers.Controls.Add(btnRegisterSoftware);
            tpOthers.Controls.Add(btnCopyLicence);
            tpOthers.Controls.Add(btnSendTestEmailToNotification);
            tpOthers.Controls.Add(btnSendTestEmailToReport);
            tpOthers.Controls.Add(btnSendTestEmailToOrders);
            tpOthers.Controls.Add(btnSendTestEmailToPurchase);
            tpOthers.Controls.Add(btnDeleteLogo2);
            tpOthers.Controls.Add(btnDeleteLogo1);
            tpOthers.Controls.Add(label2);
            tpOthers.Controls.Add(label1);
            tpOthers.Controls.Add(btnLoadLogo2);
            tpOthers.Controls.Add(pBoxLogo2);
            tpOthers.Controls.Add(btnLoadLogo1);
            tpOthers.Controls.Add(pBoxLogo1);
            tpOthers.Controls.Add(label16);
            tpOthers.Controls.Add(cmbChangeTaxRate);
            tpOthers.Controls.Add(btnImportMenu);
            tpOthers.Controls.Add(label5);
            tpOthers.Controls.Add(cmbMenu);
            tpOthers.Controls.Add(cmbMenuTaxRates);
            tpOthers.Location = new System.Drawing.Point(4, 44);
            tpOthers.Name = "tpOthers";
            tpOthers.Padding = new Padding(3);
            tpOthers.Size = new System.Drawing.Size(1006, 572);
            tpOthers.TabIndex = 2;
            tpOthers.Text = "OTHERS";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new System.Drawing.Point(317, 412);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new System.Drawing.Size(276, 108);
            dgv.TabIndex = 184;
            // 
            // lblLicenceNumber
            // 
            lblLicenceNumber.BorderStyle = BorderStyle.FixedSingle;
            lblLicenceNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLicenceNumber.Location = new System.Drawing.Point(152, 172);
            lblLicenceNumber.Name = "lblLicenceNumber";
            lblLicenceNumber.Size = new System.Drawing.Size(697, 22);
            lblLicenceNumber.TabIndex = 182;
            lblLicenceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblLicenceNumber.Visible = false;
            // 
            // btnRegisterSoftware
            // 
            btnRegisterSoftware.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnRegisterSoftware.Location = new System.Drawing.Point(65, 168);
            btnRegisterSoftware.Name = "btnRegisterSoftware";
            btnRegisterSoftware.Size = new System.Drawing.Size(81, 30);
            btnRegisterSoftware.TabIndex = 178;
            btnRegisterSoftware.Text = "Register";
            btnRegisterSoftware.UseVisualStyleBackColor = true;
            btnRegisterSoftware.Visible = false;
            // 
            // btnCopyLicence
            // 
            btnCopyLicence.BackgroundImage = Properties.Resources.Duplicate;
            btnCopyLicence.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyLicence.Location = new System.Drawing.Point(27, 168);
            btnCopyLicence.Name = "btnCopyLicence";
            btnCopyLicence.Size = new System.Drawing.Size(32, 30);
            btnCopyLicence.TabIndex = 176;
            btnCopyLicence.UseVisualStyleBackColor = true;
            btnCopyLicence.Visible = false;
            // 
            // btnSendTestEmailToNotification
            // 
            btnSendTestEmailToNotification.Location = new System.Drawing.Point(27, 520);
            btnSendTestEmailToNotification.Name = "btnSendTestEmailToNotification";
            btnSendTestEmailToNotification.Size = new System.Drawing.Size(276, 30);
            btnSendTestEmailToNotification.TabIndex = 147;
            btnSendTestEmailToNotification.Text = "Send Test Email To Notification Email";
            btnSendTestEmailToNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSendTestEmailToNotification.UseVisualStyleBackColor = true;
            btnSendTestEmailToNotification.Click += btnSendTestEmailToNotification_Click;
            // 
            // btnSendTestEmailToReport
            // 
            btnSendTestEmailToReport.Location = new System.Drawing.Point(27, 484);
            btnSendTestEmailToReport.Name = "btnSendTestEmailToReport";
            btnSendTestEmailToReport.Size = new System.Drawing.Size(276, 30);
            btnSendTestEmailToReport.TabIndex = 146;
            btnSendTestEmailToReport.Text = "Send Test Email To Report Email";
            btnSendTestEmailToReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSendTestEmailToReport.UseVisualStyleBackColor = true;
            btnSendTestEmailToReport.Click += btnSendTestEmailToReport_Click;
            // 
            // btnSendTestEmailToOrders
            // 
            btnSendTestEmailToOrders.Location = new System.Drawing.Point(27, 448);
            btnSendTestEmailToOrders.Name = "btnSendTestEmailToOrders";
            btnSendTestEmailToOrders.Size = new System.Drawing.Size(276, 30);
            btnSendTestEmailToOrders.TabIndex = 145;
            btnSendTestEmailToOrders.Text = "Send Test Email To Orders Email";
            btnSendTestEmailToOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSendTestEmailToOrders.UseVisualStyleBackColor = true;
            btnSendTestEmailToOrders.Click += btnSendTestEmailToOrders_Click;
            // 
            // btnSendTestEmailToPurchase
            // 
            btnSendTestEmailToPurchase.Location = new System.Drawing.Point(27, 412);
            btnSendTestEmailToPurchase.Name = "btnSendTestEmailToPurchase";
            btnSendTestEmailToPurchase.Size = new System.Drawing.Size(276, 30);
            btnSendTestEmailToPurchase.TabIndex = 144;
            btnSendTestEmailToPurchase.Text = "Send Test Email To Purchase Email";
            btnSendTestEmailToPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSendTestEmailToPurchase.UseVisualStyleBackColor = true;
            btnSendTestEmailToPurchase.Click += btnSendTestEmailToPurchase_Click;
            // 
            // btnDeleteLogo2
            // 
            btnDeleteLogo2.Image = Properties.Resources.Cancel;
            btnDeleteLogo2.Location = new System.Drawing.Point(480, 288);
            btnDeleteLogo2.Name = "btnDeleteLogo2";
            btnDeleteLogo2.Size = new System.Drawing.Size(48, 48);
            btnDeleteLogo2.TabIndex = 143;
            btnDeleteLogo2.UseVisualStyleBackColor = true;
            btnDeleteLogo2.Click += btnDeleteLogo2_Click;
            // 
            // btnDeleteLogo1
            // 
            btnDeleteLogo1.Image = Properties.Resources.Cancel;
            btnDeleteLogo1.Location = new System.Drawing.Point(211, 288);
            btnDeleteLogo1.Name = "btnDeleteLogo1";
            btnDeleteLogo1.Size = new System.Drawing.Size(48, 48);
            btnDeleteLogo1.TabIndex = 142;
            btnDeleteLogo1.UseVisualStyleBackColor = true;
            btnDeleteLogo1.Click += btnDeleteLogo1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(293, 201);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 21);
            label2.TabIndex = 141;
            label2.Text = "Logo 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 201);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 21);
            label1.TabIndex = 140;
            label1.Text = "Logo 1";
            // 
            // btnLoadLogo2
            // 
            btnLoadLogo2.Image = (System.Drawing.Image)resources.GetObject("btnLoadLogo2.Image");
            btnLoadLogo2.Location = new System.Drawing.Point(480, 225);
            btnLoadLogo2.Name = "btnLoadLogo2";
            btnLoadLogo2.Size = new System.Drawing.Size(48, 48);
            btnLoadLogo2.TabIndex = 139;
            btnLoadLogo2.UseVisualStyleBackColor = true;
            btnLoadLogo2.Click += btnLoadLogo2_Click;
            // 
            // pBoxLogo2
            // 
            pBoxLogo2.BackColor = System.Drawing.Color.White;
            pBoxLogo2.BackgroundImageLayout = ImageLayout.Zoom;
            pBoxLogo2.BorderStyle = BorderStyle.FixedSingle;
            pBoxLogo2.Location = new System.Drawing.Point(297, 225);
            pBoxLogo2.Name = "pBoxLogo2";
            pBoxLogo2.Size = new System.Drawing.Size(176, 168);
            pBoxLogo2.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxLogo2.TabIndex = 138;
            pBoxLogo2.TabStop = false;
            // 
            // btnLoadLogo1
            // 
            btnLoadLogo1.Image = (System.Drawing.Image)resources.GetObject("btnLoadLogo1.Image");
            btnLoadLogo1.Location = new System.Drawing.Point(211, 225);
            btnLoadLogo1.Name = "btnLoadLogo1";
            btnLoadLogo1.Size = new System.Drawing.Size(48, 48);
            btnLoadLogo1.TabIndex = 137;
            btnLoadLogo1.UseVisualStyleBackColor = true;
            btnLoadLogo1.Click += btnLoadLogo1_Click;
            // 
            // pBoxLogo1
            // 
            pBoxLogo1.BackColor = System.Drawing.Color.White;
            pBoxLogo1.BackgroundImageLayout = ImageLayout.Zoom;
            pBoxLogo1.BorderStyle = BorderStyle.FixedSingle;
            pBoxLogo1.Location = new System.Drawing.Point(28, 225);
            pBoxLogo1.Name = "pBoxLogo1";
            pBoxLogo1.Size = new System.Drawing.Size(176, 168);
            pBoxLogo1.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxLogo1.TabIndex = 136;
            pBoxLogo1.TabStop = false;
            // 
            // frmConfig
            // 
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1034, 711);
            Controls.Add(tabMain);
            Controls.Add(panel2);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmConfig";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SETTINGS";
            Load += frmConfig_Load;
            panel2.ResumeLayout(false);
            ((ISupportInitialize)pBox).EndInit();
            ((ISupportInitialize)catalogListBindingSource).EndInit();
            tabMain.ResumeLayout(false);
            tpTerminal.ResumeLayout(false);
            tpShop.ResumeLayout(false);
            tpOthers.ResumeLayout(false);
            tpOthers.PerformLayout();
            ((ISupportInitialize)dgv).EndInit();
            ((ISupportInitialize)pBoxLogo2).EndInit();
            ((ISupportInitialize)pBoxLogo1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public void SwitchToRegistrationPanel()
        {
            try
            {
                tabMain.SelectedIndex = 2;
            } catch { }

        }

        private void frmConfig_Load(object sender, System.EventArgs e)
        {
            if (bslayer == null ||  DTRMSimpleBusiness.Instance.OfficeConnectionStatus == ConnectionStatus.Disconnected)
            {
                tabMain.TabPages.Remove(tabMain.TabPages["tpShop"]);
                tabMain.TabPages.Remove(tabMain.TabPages["tpOthers"]);
            }

            //this section is for version printing even if the system not connected
            #region Display Application Version
            if (bslayer == null)
            {
                //bslayer = new DTRMSimpleBusiness();
                lblVersion.Text = "Version : " +  DTRMSimpleBusiness.Instance.ApplicationVersion;
                bslayer = null;
            }
            if (bslayer != null)
                lblVersion.Text = "Version : " +  DTRMSimpleBusiness.Instance.ApplicationVersion;
            #endregion

            LoadConfig();

            pGridConfig.VerticalScroll.Visible = false;

            LoadCultures();
        }

        private void LoadCultures()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            cultures.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));

        }

        private async void LoadConfig()
        {

            pGridConfig.SelectedObject = config;


            if (!blnEmpty)
            {
                if (await repoShop.IsDatabaseExist())
                {
                    try
                    {
                        LoadMenuList();
                    } catch
                    {
                    }

                    try
                    {
                        await LoadCompanyDetails();
                    } catch
                    {
                    }
                }
            }
            EnsureConnectionImage();
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void LoadMenuList()
        {
            if (!blnEmpty)
            {
                cmbMenu.ValueMember = "IID";
                cmbMenu.DisplayMember = "MenuName";
                cmbMenu.DataSource = await repoMenu.GetAllAsync();
                try
                {
                    cmbMenu.SelectedValue = config.ActiveMenuIID;
                } catch (Exception ex)
                {
                    string str = ex.Message;
                }
            }
        }

        private void cmbMenus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!blnEmpty)
            {
                config.ActiveMenuIID = cmbMenu.SelectedValue.ToString();
                UF.SaveConfig(config);
                LoadMenuList();
                 DTRMSimpleBusiness.Instance.GetActiveMenu(true, true);
            }
        }

        #region "COMPANY DETAILS THINGS"

        private async void LoadTaxRates()
        {
            if (!blnEmpty)
            {
                try
                {
                    cmbMenuTaxRates.DataSource = await  DTRMSimpleBusiness.Instance.GetAllTaxRates();
                    //cmbMenuTaxRates.DisplayMember = "TaxPercent";
                    //cmbMenuTaxRates.ValueMember = "TaxPercent";
                } catch
                {
                }
            }
        }

        private async Task LoadCompanyDetails()
        {
            if (!blnEmpty)
            {
                try
                {
                    pGridLuv.SelectedObject = await repoShop.GetFirst();
                    LoadTaxRates();
                    LoadLogoImages();
                } catch
                {
                }
            }
        }

        private async void LoadLogoImages()
        {
            GenericImage gim1 = await repoImage.GetByField("ReferenceIID", "Logo1");
            if (gim1 != null)
                pBoxLogo1.Image = gim1.DisplayImage.ToImage();
            GenericImage gim2 = await repoImage.GetByField("ReferenceIID", "Logo2");
            if (gim2 != null)
                pBoxLogo2.Image = gim2.DisplayImage.ToImage();
        }
        private void SaveShop()
        {
            if (!blnEmpty)
            {
                Shop shop = (Shop)pGridLuv.SelectedObject;
                shop.VoidText = (shop.VoidText.Length > 5 ? shop.VoidText.Substring(0, 5) : shop.VoidText);
                repoShop.Save(shop);
                 DTRMSimpleBusiness.Instance.shop = shop;
            }
        }

        #endregion

        private async void btnImportMenu_Click(object sender, EventArgs e)
        {
            if (!blnEmpty)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    TheMenu fm = null;
                    try
                    {
                        fm = (TheMenu)DRFile.XmlDeSerialize(ofd.FileName, typeof(TheMenu), false);
                    } catch
                    {
                        MessageBox.Show("Menu cannot be imported");
                        return;
                    }
                    await repoMenu.Save(fm);
                    LoadMenuList();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (UF.SaveConfig(config))
                {
                    MessageBox.Show("Configuration file saved");
                    if (!blnEmpty)
                    {
                        //  DTRMSimpleBusiness.Instance.config = config;
                        SaveShop();
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                } else
                    MessageBox.Show("Failed to save configuration file");
            } catch
            {
                MessageBox.Show("Failed to save configuration file");
            }
        }

        private void cmbChangeTaxRate_Click(object sender, EventArgs e)
        {
            if (!blnEmpty)
            {
                if (cmbMenuTaxRates.Items.Count > 0)
                {
                    float SelectedTaxRate = float.Parse(cmbMenuTaxRates.SelectedValue.ToString(),
                        System.Globalization.NumberStyles.Any);
                    TrmGetValue frm = new TrmGetValue(NumberModes.FloatMode);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                         DTRMSimpleBusiness.Instance.SetTaxRate(SelectedTaxRate, frm.ReturnValue);
                        LoadTaxRates();
                    }
                }
            }
        }

        private void btnChangeConnection_Click(object sender, EventArgs e)
        {
            if (!UF.IsDBListFileExist())
            {
                DBList dblist = new DBList();
                dblist.Items.Add(new DB(".", "DTRMSimple", "sa", "."));
                DRFile.XmlSerialize(UF.DBListConfigFileName, dblist, typeof(DBList), false);
            }

            frmConnectionList frm = new frmConnectionList(UF.DBListConfigFileName);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DB db = frm.SelectedDB;
                if (config == null)
                    config = new PosConfig();
                config.Database_Instance = db.ServerIP;
                config.Database_Name = db.DatabaseName;
                config.Database_User_Name = db.UserName;
                config.Database_Password = db.Password;
                LoadConfig();
            }
        }

        private void EnsureConnectionImage()
        {
            pBox.Image = Properties.Resources.ThinClient;
        }

        private void btnLoadLogo1_Click(object sender, EventArgs e)
        {
            frmGenericImageEditor frm = ActivatorUtilities.CreateInstance< frmGenericImageEditor>(ServiceHelper.Services, null, "Logo1");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                pBoxLogo1.Image = UFWin.ByteArrayToImage(frm.gim.DisplayImage);
            }
        }

        private void btnLoadLogo2_Click(object sender, EventArgs e)
        {
            frmGenericImageEditor frm = ActivatorUtilities.CreateInstance<frmGenericImageEditor>(ServiceHelper.Services, null, "Logo2");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                pBoxLogo2.Image = UFWin.ByteArrayToImage(frm.gim.DisplayImage);
            }
        }

        private async void btnDeleteLogo1_Click(object sender, EventArgs e)
        {
            await repoImage.DeleteByField("ReferenceIID","Logo1");
            pBoxLogo1.Image = null;
            LoadLogoImages();
        }

        private async void btnDeleteLogo2_Click(object sender, EventArgs e)
        {
            await repoImage.DeleteByField("ReferenceIID","Logo2");
            pBoxLogo2.Image = null;
            LoadLogoImages();
        }

        private void btnSendTestEmailToPurchase_Click(object sender, EventArgs e)
        {
             DTRMSimpleBusiness.Instance.SendEmailToCustomRecepient( DTRMSimpleBusiness.Instance.shop.PurchaseEmail, "Test email from DTRMSimple to Purchase", "test", null);
        }

        private void btnSendTestEmailToOrders_Click(object sender, EventArgs e)
        {
             DTRMSimpleBusiness.Instance.SendEmailToCustomRecepient( DTRMSimpleBusiness.Instance.shop.OrdersEmail, "Test email from DTRMSimple to Orders", "test", null);
        }

        private void btnSendTestEmailToReport_Click(object sender, EventArgs e)
        {
             DTRMSimpleBusiness.Instance.SendEmailToCustomRecepient( DTRMSimpleBusiness.Instance.shop.ReportEmail, "Test email from DTRMSimple to Report", "test", null);
        }

        private void btnSendTestEmailToNotification_Click(object sender, EventArgs e)
        {
             DTRMSimpleBusiness.Instance.SendEmailToCustomRecepient( DTRMSimpleBusiness.Instance.shop.NotificationEmail, "Test email from DTRMSimple to Notification", "test", null);
        }
    }
}