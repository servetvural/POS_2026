using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using PosLibrary;

using POSLayer.Library;
using POSLayer.Repository.IRepository;
using POSLayer.Models;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WinLayer {
    /// <summary>
    /// Summary description for ctlCustomer.
    /// </summary>
    public class ctlCustomer : UserControl {
        IRepository<Customer> repoCustomer;

        private Label label7;
        private Label label10;

       
        private Button btnAddCustomerToDatabase;


        private string CustomerIID;
        public TextBox txtName;
        public TextBox txtPostCode1;
        public TextBox txtAddress;
        public TextBox txtTown;
        public TextBox txtEmail;
        public TextBox txtTel;

        public bool Success;

        private Label label1;
        private Label label2;

        private GenericFunctionCallAsync CloseFunction;

        private RemoteCompleteAttachedOrderAsync CompleteAttachedOrder;
        private int NumberOfCopy;
        private bool blnArchive;
        private bool blnPrintLocal;
        private bool blnEnforceDeliveryArchive;
        public TextBox txtPostCode2;
        private Label label3;
        private DataGridView dgv;
        private BindingSource customerBindingSource;
        private Button btnSelect;
        private Panel pnlTop;
        private DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private Label label5;
        private Button btnClearCustomerDetails;
        private Button btnSearchByPostCode;
        private Button btnSearchByAddress;
        private Button btnDeleteCustomerFromDatabase;
        private Button btnSearchByTel;
        private Button btnNotRequired;
        private IContainer components;

        public ctlCustomer() {
            InitializeComponent();
        }

        public ctlCustomer( GenericFunctionCallAsync CloseFunction,
         RemoteCompleteAttachedOrderAsync CompleteAttachedOrder,
         int NumberOfCopy, bool blnArchive, bool blnPrintLocal, bool blnEnforceDeliveryArchive) {
            InitializeComponent();
            repoCustomer = ServiceHelper.GetService<IRepository<Customer>>();


            this.CloseFunction = CloseFunction;
            this.CompleteAttachedOrder = CompleteAttachedOrder;
            this.NumberOfCopy = NumberOfCopy;
            this.blnArchive = blnArchive;
            this.blnPrintLocal = blnPrintLocal;
            this.blnEnforceDeliveryArchive = blnEnforceDeliveryArchive;

           // UpdateChangeOrderTypeButton();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ctlCustomer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtName = new TextBox();
            txtPostCode1 = new TextBox();
            txtAddress = new TextBox();
            txtTown = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            btnAddCustomerToDatabase = new Button();
            txtTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPostCode2 = new TextBox();
            label3 = new Label();
            dgv = new DataGridView();
            iIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            btnSelect = new Button();
            pnlTop = new Panel();
            btnNotRequired = new Button();
            btnSearchByTel = new Button();
            btnDeleteCustomerFromDatabase = new Button();
            btnSearchByPostCode = new Button();
            btnSearchByAddress = new Button();
            btnClearCustomerDetails = new Button();
            label5 = new Label();
            ((ISupportInitialize)dgv).BeginInit();
            ((ISupportInitialize)customerBindingSource).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.Bisque;
            txtName.Font = new Font("Arial", 14F);
            txtName.Location = new Point(92, 61);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 29);
            txtName.TabIndex = 1;
            txtName.TextChanged += btnGetByName_Click;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtPostCode1
            // 
            txtPostCode1.Font = new Font("Arial", 14F);
            txtPostCode1.Location = new Point(92, 147);
            txtPostCode1.MaxLength = 4;
            txtPostCode1.Name = "txtPostCode1";
            txtPostCode1.Size = new Size(69, 29);
            txtPostCode1.TabIndex = 4;
            txtPostCode1.TextChanged += btnGetByPostCode_Click;
            txtPostCode1.KeyDown += txtPostCode_KeyDown;
            txtPostCode1.Leave += txtPostCode1_Leave;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(92, 108);
            txtAddress.MaxLength = 255;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 26);
            txtAddress.TabIndex = 2;
            txtAddress.TextChanged += btnGetByAddress_Click;
            // 
            // txtTown
            // 
            txtTown.Font = new Font("Arial", 14F);
            txtTown.Location = new Point(92, 187);
            txtTown.MaxLength = 255;
            txtTown.Name = "txtTown";
            txtTown.Size = new Size(270, 29);
            txtTown.TabIndex = 6;
            txtTown.KeyDown += MainKeyHandler;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 191);
            label7.Name = "label7";
            label7.Size = new Size(49, 16);
            label7.TabIndex = 17;
            label7.Text = "TOWN";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 14F);
            txtEmail.Location = new Point(92, 230);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 29);
            txtEmail.TabIndex = 8;
            txtEmail.KeyDown += MainKeyHandler;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(32, 233);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 19;
            label10.Text = "EMAIL";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddCustomerToDatabase
            // 
            btnAddCustomerToDatabase.AutoEllipsis = true;
            btnAddCustomerToDatabase.BackColor = Color.FromArgb(0, 192, 0);
            btnAddCustomerToDatabase.BackgroundImage = (Image)resources.GetObject("btnAddCustomerToDatabase.BackgroundImage");
            btnAddCustomerToDatabase.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddCustomerToDatabase.FlatAppearance.BorderSize = 0;
            btnAddCustomerToDatabase.FlatStyle = FlatStyle.Flat;
            btnAddCustomerToDatabase.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddCustomerToDatabase.ForeColor = Color.FromArgb(0, 0, 0);
            btnAddCustomerToDatabase.Location = new Point(526, 236);
            btnAddCustomerToDatabase.Name = "btnAddCustomerToDatabase";
            btnAddCustomerToDatabase.Size = new Size(138, 57);
            btnAddCustomerToDatabase.TabIndex = 9;
            btnAddCustomerToDatabase.Text = "SAVE CUSTOMER DETAILS AND CLOSE";
            btnAddCustomerToDatabase.UseVisualStyleBackColor = false;
            btnAddCustomerToDatabase.Click += btnUpdateCustomer_Click;
            btnAddCustomerToDatabase.KeyDown += MainKeyHandler;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.Bisque;
            txtTel.Font = new Font("Arial", 14F);
            txtTel.Location = new Point(92, 18);
            txtTel.MaxLength = 50;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(163, 29);
            txtTel.TabIndex = 0;
            txtTel.TextChanged += btnGetByPhone_Click;
            txtTel.KeyDown += txtTel_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 20;
            label1.Text = "TEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 65);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 21;
            label2.Text = "NAME";
            // 
            // txtPostCode2
            // 
            txtPostCode2.Font = new Font("Arial", 14F);
            txtPostCode2.Location = new Point(177, 147);
            txtPostCode2.MaxLength = 4;
            txtPostCode2.Name = "txtPostCode2";
            txtPostCode2.Size = new Size(78, 29);
            txtPostCode2.TabIndex = 5;
            txtPostCode2.KeyDown += MainKeyHandler;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 111);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 23;
            label3.Text = "ADDRESS";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = Color.Black;
            dgv.BorderStyle = BorderStyle.None;
            dgv.Columns.AddRange(new DataGridViewColumn[] { iIDDataGridViewTextBoxColumn, cNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, telDataGridViewTextBoxColumn });
            dgv.DataSource = customerBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.FromArgb(208, 215, 229);
            dgv.Location = new Point(5, 317);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 15;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(682, 243);
            dgv.TabIndex = 88;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            iIDDataGridViewTextBoxColumn.ReadOnly = true;
            iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            cNameDataGridViewTextBoxColumn.ReadOnly = true;
            cNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // telDataGridViewTextBoxColumn
            // 
            telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            telDataGridViewTextBoxColumn.HeaderText = "Tel";
            telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            telDataGridViewTextBoxColumn.ReadOnly = true;
            telDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(POSLayer.Models.Customer);
            // 
            // btnSelect
            // 
            btnSelect.AutoEllipsis = true;
            btnSelect.BackColor = Color.DarkBlue;
            btnSelect.BackgroundImage = (Image)resources.GetObject("btnSelect.BackgroundImage");
            btnSelect.BackgroundImageLayout = ImageLayout.Stretch;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(526, 91);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(138, 57);
            btnSelect.TabIndex = 11;
            btnSelect.Text = "SELECT  FROM  LIST";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            btnSelect.KeyDown += MainKeyHandler;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Black;
            pnlTop.Controls.Add(btnNotRequired);
            pnlTop.Controls.Add(btnSearchByTel);
            pnlTop.Controls.Add(btnDeleteCustomerFromDatabase);
            pnlTop.Controls.Add(btnSearchByPostCode);
            pnlTop.Controls.Add(btnSearchByAddress);
            pnlTop.Controls.Add(btnClearCustomerDetails);
            pnlTop.Controls.Add(label5);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(btnSelect);
            pnlTop.Controls.Add(label7);
            pnlTop.Controls.Add(label3);
            pnlTop.Controls.Add(txtPostCode2);
            pnlTop.Controls.Add(label10);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(txtName);
            pnlTop.Controls.Add(txtTel);
            pnlTop.Controls.Add(txtPostCode1);
            pnlTop.Controls.Add(txtAddress);
            pnlTop.Controls.Add(txtTown);
            pnlTop.Controls.Add(btnAddCustomerToDatabase);
            pnlTop.Controls.Add(txtEmail);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(5, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(682, 312);
            pnlTop.TabIndex = 89;
            // 
            // btnNotRequired
            // 
            btnNotRequired.AutoEllipsis = true;
            btnNotRequired.BackColor = Color.MediumAquamarine;
            btnNotRequired.BackgroundImage = (Image)resources.GetObject("btnNotRequired.BackgroundImage");
            btnNotRequired.BackgroundImageLayout = ImageLayout.Stretch;
            btnNotRequired.FlatAppearance.BorderSize = 0;
            btnNotRequired.FlatStyle = FlatStyle.Flat;
            btnNotRequired.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnNotRequired.ForeColor = Color.FromArgb(0, 0, 0);
            btnNotRequired.Location = new Point(370, 236);
            btnNotRequired.Name = "btnNotRequired";
            btnNotRequired.Size = new Size(138, 57);
            btnNotRequired.TabIndex = 30;
            btnNotRequired.Text = "NOT REQUIRED";
            btnNotRequired.UseVisualStyleBackColor = false;
            btnNotRequired.Click += btnNotRequired_Click;
            // 
            // btnSearchByTel
            // 
            btnSearchByTel.AutoEllipsis = true;
            btnSearchByTel.BackColor = Color.FromArgb(255, 128, 0);
            btnSearchByTel.BackgroundImage = (Image)resources.GetObject("btnSearchByTel.BackgroundImage");
            btnSearchByTel.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchByTel.FlatAppearance.BorderSize = 0;
            btnSearchByTel.FlatStyle = FlatStyle.Flat;
            btnSearchByTel.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSearchByTel.ForeColor = Color.FromArgb(0, 0, 0);
            btnSearchByTel.Location = new Point(370, 18);
            btnSearchByTel.Name = "btnSearchByTel";
            btnSearchByTel.Size = new Size(138, 57);
            btnSearchByTel.TabIndex = 29;
            btnSearchByTel.Text = "SEARCH BY TEL";
            btnSearchByTel.UseVisualStyleBackColor = false;
            btnSearchByTel.Click += btnGetByPhone_Click;
            // 
            // btnDeleteCustomerFromDatabase
            // 
            btnDeleteCustomerFromDatabase.AutoEllipsis = true;
            btnDeleteCustomerFromDatabase.BackColor = Color.Red;
            btnDeleteCustomerFromDatabase.BackgroundImage = (Image)resources.GetObject("btnDeleteCustomerFromDatabase.BackgroundImage");
            btnDeleteCustomerFromDatabase.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteCustomerFromDatabase.FlatAppearance.BorderSize = 0;
            btnDeleteCustomerFromDatabase.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomerFromDatabase.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDeleteCustomerFromDatabase.ForeColor = Color.White;
            btnDeleteCustomerFromDatabase.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteCustomerFromDatabase.Location = new Point(526, 166);
            btnDeleteCustomerFromDatabase.Name = "btnDeleteCustomerFromDatabase";
            btnDeleteCustomerFromDatabase.Size = new Size(138, 57);
            btnDeleteCustomerFromDatabase.TabIndex = 28;
            btnDeleteCustomerFromDatabase.Text = "Delete Selected Customer From Database";
            btnDeleteCustomerFromDatabase.UseVisualStyleBackColor = false;
            btnDeleteCustomerFromDatabase.Click += btnDeleteCustomerFromDatabase_Click;
            // 
            // btnSearchByPostCode
            // 
            btnSearchByPostCode.AutoEllipsis = true;
            btnSearchByPostCode.BackColor = Color.FromArgb(255, 128, 0);
            btnSearchByPostCode.BackgroundImage = (Image)resources.GetObject("btnSearchByPostCode.BackgroundImage");
            btnSearchByPostCode.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchByPostCode.FlatAppearance.BorderSize = 0;
            btnSearchByPostCode.FlatStyle = FlatStyle.Flat;
            btnSearchByPostCode.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSearchByPostCode.ForeColor = Color.FromArgb(0, 0, 0);
            btnSearchByPostCode.Location = new Point(370, 166);
            btnSearchByPostCode.Name = "btnSearchByPostCode";
            btnSearchByPostCode.Size = new Size(138, 57);
            btnSearchByPostCode.TabIndex = 27;
            btnSearchByPostCode.Text = "SEARCH BY POSTCODE";
            btnSearchByPostCode.UseVisualStyleBackColor = false;
            btnSearchByPostCode.Click += btnGetByPostCode_Click;
            // 
            // btnSearchByAddress
            // 
            btnSearchByAddress.AutoEllipsis = true;
            btnSearchByAddress.BackColor = Color.FromArgb(255, 128, 0);
            btnSearchByAddress.BackgroundImage = (Image)resources.GetObject("btnSearchByAddress.BackgroundImage");
            btnSearchByAddress.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchByAddress.FlatAppearance.BorderSize = 0;
            btnSearchByAddress.FlatStyle = FlatStyle.Flat;
            btnSearchByAddress.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSearchByAddress.ForeColor = Color.FromArgb(0, 0, 0);
            btnSearchByAddress.Location = new Point(370, 92);
            btnSearchByAddress.Name = "btnSearchByAddress";
            btnSearchByAddress.Size = new Size(138, 57);
            btnSearchByAddress.TabIndex = 26;
            btnSearchByAddress.Text = "SEARCH BY ADDRESS";
            btnSearchByAddress.UseVisualStyleBackColor = false;
            btnSearchByAddress.Click += btnGetByAddress_Click;
            // 
            // btnClearCustomerDetails
            // 
            btnClearCustomerDetails.AutoEllipsis = true;
            btnClearCustomerDetails.BackColor = Color.Red;
            btnClearCustomerDetails.BackgroundImage = (Image)resources.GetObject("btnClearCustomerDetails.BackgroundImage");
            btnClearCustomerDetails.BackgroundImageLayout = ImageLayout.Stretch;
            btnClearCustomerDetails.FlatAppearance.BorderSize = 0;
            btnClearCustomerDetails.FlatStyle = FlatStyle.Flat;
            btnClearCustomerDetails.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClearCustomerDetails.ForeColor = Color.White;
            btnClearCustomerDetails.Location = new Point(526, 18);
            btnClearCustomerDetails.Name = "btnClearCustomerDetails";
            btnClearCustomerDetails.RightToLeft = RightToLeft.Yes;
            btnClearCustomerDetails.Size = new Size(138, 57);
            btnClearCustomerDetails.TabIndex = 25;
            btnClearCustomerDetails.Text = "CLEAR CUSTOMER DETAILS";
            btnClearCustomerDetails.UseVisualStyleBackColor = false;
            btnClearCustomerDetails.Click += btnClearCustomerDetails_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-2, 152);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 24;
            label5.Text = "POSTCODE";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ctlCustomer
            // 
            BackColor = Color.Black;
            Controls.Add(dgv);
            Controls.Add(pnlTop);
            Location = new Point(0, 74);
            Name = "ctlCustomer";
            Padding = new Padding(5);
            Size = new Size(692, 565);
            Load += frmCustomer_Load;
            KeyDown += MainKeyHandler;
            ((ISupportInitialize)dgv).EndInit();
            ((ISupportInitialize)customerBindingSource).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);

        }
        #endregion
        private void frmCustomer_Load(object sender, System.EventArgs e) {
            LoadCustomer();
            txtTel.Focus();
            if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Delivery ) {
                txtAddress.BackColor = Color.Bisque;
            }
        }

        public void LoadCustomer() {
            try {
                CustomerIID =  DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID;
                txtName.Text =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.CName;
                try {
                    string[] parr =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Postcode.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parr.Length > 0)
                        txtPostCode1.Text = parr[0];
                    if (parr.Length > 1)
                        txtPostCode2.Text = parr[1];
                } catch { }
                txtAddress.Text =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Address;
                txtTown.Text =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Town;
                txtTel.Text =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Tel;
                txtEmail.Text =  DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Email;
            } catch { }
        }

        public void ClearUI() {
            CustomerIID = "";
            txtName.Text = "";
            txtPostCode1.Text = "";
            txtPostCode2.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
        }
        public bool IsUIHaveCustomerData() {
            if (txtName.Text.Trim().Length > 0 ||
                txtPostCode1.Text.Trim().Length > 0 ||
                txtAddress.Text.Trim().Length > 0 ||
                txtTown.Text.Trim().Length > 0 ||
                txtTel.Text.Trim().Length > 0 ||
                txtEmail.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }
        public void LoadSearchResults() {
            LoadCustomer();
        }
        private async void btnGetByName_Click(object sender, System.EventArgs e) {
            if (txtName.Text.Trim().Length > 3)
          await  ReloadSearch("Name");
        }
        private async void btnGetByAddress_Click(object sender, System.EventArgs e) {
            if (txtAddress.Text.Trim().Length > 3)
            await ReloadSearch("Address");
        }
        private async void btnGetByPostCode_Click(object sender, System.EventArgs e) {
            if (txtPostCode1.Text.Trim().Length > 1)
          await  ReloadSearch("PostCode");
        }
        private async void btnGetByPhone_Click(object sender, System.EventArgs e) {
            if (txtTel.Text.Trim().Length > 3)
              await  ReloadSearch("Phone");
        }
        private async Task ReloadSearch(string SearchType) {
            switch (SearchType) {
                case "Name":
                    dgv.DataSource = await repoCustomer.GetByField("CName",txtName.Text.Trim().Replace("'", "''"));
                    break;
                case "Address":
                    dgv.DataSource = await repoCustomer.GetByField("Address",txtAddress.Text.Trim().Replace("'", "''"));
                    break;
                case "Phone":
                    dgv.DataSource = await repoCustomer.GetByField("Tel",txtTel.Text.Trim().Replace("'", "''"));
                    break;
                case "PostCode":
                    dgv.DataSource = await repoCustomer.GetByField("Postcode",txtPostCode1.Text.Trim().Replace("'", "''"));
                    break;
                case "Email":
                    dgv.DataSource = await repoCustomer.GetByField("Email",txtEmail.Text.Trim().Replace("'", "''"));
                    break;
                default:
                    break;
            }
        }
        private async void btnUpdateCustomer_Click(object sender, System.EventArgs e) {
            if (txtName.Text.Trim().Length == 0 || txtTel.Text.Trim().Length == 0) {
                MessageBox.Show("Name and Tel fields are compulsory !");
                return;
            }

            if ( DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID == null ||  DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID == "")
                 DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID = POSLayer.Library.ShortGuid.NewGuid().ToString();

            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.CName = txtName.Text;
            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Address = txtAddress.Text;
            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Postcode = txtPostCode1.Text.Trim() + " " + txtPostCode2.Text.Trim();
            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Town = txtTown.Text;
            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Tel = txtTel.Text;
            DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Email = txtEmail.Text;

            if (await repoCustomer.Save( DTRMSimpleBusiness.Instance.AttachedOrder.Customer) != null) {
                Success = true;
                CloseFunction();
                if (CompleteAttachedOrder != null)
                    CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
            }
        }

        public void UICustomerToCustomer() {
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.CName = txtName.Text;
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Postcode = txtPostCode1.Text.Trim() + " " + txtPostCode2.Text.Trim();
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Address = txtAddress.Text;
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Town = txtTown.Text;
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Tel = txtTel.Text;
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Email = txtEmail.Text;
        }

        private void MainKeyHandler(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape)
                ClearUI();
            if (e.KeyCode == Keys.Up) {
                if (dgv.SelectedRows[0].Index > 0)
                    dgv.Rows[dgv.SelectedRows[0].Index - 1].Selected = true;
            }
            if (e.KeyCode == Keys.Down) {
                if (dgv.SelectedRows[0].Index + 1 < dgv.Rows.Count)
                    dgv.Rows[dgv.SelectedRows[0].Index + 1].Selected = true;
            }
            if (e.KeyCode == Keys.Enter)
                btnSelect_Click(null, null);

            if (e.KeyCode == Keys.Enter && e.Control) 
                CloseFunction();
                //btnClose_Click(null, null);
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            MainKeyHandler(null, e);
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.Handled = true;
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e) {
            MainKeyHandler(null, e);
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.Handled = true;
        }
        private void txtPostCode_KeyDown(object sender, KeyEventArgs e) {
            MainKeyHandler(null, e);
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.Handled = true;
        }
        private void txtTel_KeyDown(object sender, KeyEventArgs e) {
            MainKeyHandler(null, e);
            if (e.KeyCode == Keys.Space ||  char.IsPunctuation((char)e.KeyData) || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtPostCode1_Leave(object sender, EventArgs e) {
            //make sure first pcode has data
            txtPostCode2.Enabled = (txtPostCode1.Text.Trim() != "");
        }
        private async void btnSelect_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                string SelectedCustomerIID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                // DTRMSimpleBusiness.Instance.CustomerDetailsToOrder(await  DTRMSimpleBusiness.Instance.GetCustomer(SelectedCustomerIID));
                LoadSearchResults();
            }
        }          

        private async void btnDeleteCustomerFromDatabase_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                string DeleteCustomerIID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                await repoCustomer.Delete(DeleteCustomerIID);
                btnGetByPhone_Click(null, null);
            }
        }

        private void btnClearCustomerDetails_Click(object sender, EventArgs e) {
            ClearUI();
            UICustomerToCustomer();
             DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID = "";
                        
        }

        private void btnNotRequired_Click(object sender, EventArgs e) {
            if ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.Delivery)
                return;

             DTRMSimpleBusiness.Instance.AttachedOrder.CustomerIID = null;
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.CName = ".";
             DTRMSimpleBusiness.Instance.AttachedOrder.Customer.Tel = ".";
            Success = true;
            CloseFunction();
            if (CompleteAttachedOrder != null)
                CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
        }
    }
}
