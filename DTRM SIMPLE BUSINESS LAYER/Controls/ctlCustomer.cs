using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using PosLibrary;

using POSLayer.Library;

namespace DTRMNS {
    /// <summary>
    /// Summary description for ctlCustomer.
    /// </summary>
    public class ctlCustomer : System.Windows.Forms.UserControl {
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private DTRMNS.DTRMSimpleBusiness bslayer;
        private Button btnAddCustomerToDatabase;


        private string CustomerIID;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtBuzzer;
        public System.Windows.Forms.TextBox txtPostCode1;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtTown;
        public System.Windows.Forms.TextBox txtMobile;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTel;

        public bool Success;

        private Label label1;
        private Label label2;

        private GenericFunctionCall CloseFunction;

        private RemoteCompleteAttachedOrder CompleteAttachedOrder;
        private int NumberOfCopy;
        private bool blnArchive;
        private bool blnPrintLocal;
        private bool blnEnforceDeliveryArchive;
        public System.Windows.Forms.TextBox txtPostCode2;
        private Label label3;
        private System.Windows.Forms.DataGridView dgv;
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

        public ctlCustomer(DTRMNS.DTRMSimpleBusiness bs, GenericFunctionCall CloseFunction,
         RemoteCompleteAttachedOrder CompleteAttachedOrder,
         int NumberOfCopy, bool blnArchive, bool blnPrintLocal, bool blnEnforceDeliveryArchive) {
            InitializeComponent();
            bslayer = bs;
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBuzzer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostCode1 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddCustomerToDatabase = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostCode2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new DataGridView();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnNotRequired = new System.Windows.Forms.Button();
            this.btnSearchByTel = new System.Windows.Forms.Button();
            this.btnDeleteCustomerFromDatabase = new System.Windows.Forms.Button();
            this.btnSearchByPostCode = new System.Windows.Forms.Button();
            this.btnSearchByAddress = new System.Windows.Forms.Button();
            this.btnClearCustomerDetails = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Bisque;
            // 
            // 
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 14F);
            this.txtName.Location = new System.Drawing.Point(92, 61);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.TextChanged += new System.EventHandler(this.btnGetByName_Click);
            // 
            // txtBuzzer
            // 
            // 
            // 
            // 
            this.txtBuzzer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuzzer.Location = new System.Drawing.Point(92, 153);
            this.txtBuzzer.MaxLength = 255;
            this.txtBuzzer.Name = "txtBuzzer";
            this.txtBuzzer.Size = new System.Drawing.Size(270, 19);
            this.txtBuzzer.TabIndex = 3;
            this.txtBuzzer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "BUZZER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPostCode1
            // 
            // 
            // 
            // 
            this.txtPostCode1.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPostCode1.Location = new System.Drawing.Point(92, 192);
            this.txtPostCode1.MaxLength = 4;
            this.txtPostCode1.Name = "txtPostCode1";
            this.txtPostCode1.Size = new System.Drawing.Size(69, 22);
            this.txtPostCode1.TabIndex = 4;
            this.txtPostCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostCode_KeyDown);
            this.txtPostCode1.Leave += new System.EventHandler(this.txtPostCode1_Leave);
            this.txtPostCode1.TextChanged += new System.EventHandler(this.btnGetByPostCode_Click);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(92, 108);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 19);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.btnGetByAddress_Click);
            // 
            // txtTown
            // 
            // 
            // 
            // 
            this.txtTown.Font = new System.Drawing.Font("Arial", 14F);
            this.txtTown.Location = new System.Drawing.Point(92, 232);
            this.txtTown.MaxLength = 255;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(270, 22);
            this.txtTown.TabIndex = 6;
            this.txtTown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "TOWN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Font = new System.Drawing.Font("Arial", 14F);
            this.txtMobile.Location = new System.Drawing.Point(92, 275);
            this.txtMobile.MaxLength = 50;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(163, 22);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "MOBILE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.txtEmail.Location = new System.Drawing.Point(92, 318);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "EMAIL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddCustomerToDatabase
            // 
            this.btnAddCustomerToDatabase.AutoEllipsis = true;
            this.btnAddCustomerToDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCustomerToDatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerToDatabase.BackgroundImage")));
            this.btnAddCustomerToDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomerToDatabase.FlatAppearance.BorderSize = 0;
            this.btnAddCustomerToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomerToDatabase.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomerToDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCustomerToDatabase.Location = new System.Drawing.Point(526, 236);
            this.btnAddCustomerToDatabase.Name = "btnAddCustomerToDatabase";
            this.btnAddCustomerToDatabase.Size = new System.Drawing.Size(138, 122);
            this.btnAddCustomerToDatabase.TabIndex = 9;
            this.btnAddCustomerToDatabase.Text = "SAVE CUSTOMER DETAILS AND CLOSE";
            this.btnAddCustomerToDatabase.UseVisualStyleBackColor = false;
            this.btnAddCustomerToDatabase.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            this.btnAddCustomerToDatabase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Bisque;
            // 
            // 
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 14F);
            this.txtTel.Location = new System.Drawing.Point(92, 18);
            this.txtTel.MaxLength = 50;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(163, 22);
            this.txtTel.TabIndex = 0;
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTel_KeyDown);
            this.txtTel.TextChanged += new System.EventHandler(this.btnGetByPhone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "TEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "NAME";
            // 
            // txtPostCode2
            // 
            // 
            // 
            // 
            this.txtPostCode2.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPostCode2.Location = new System.Drawing.Point(177, 192);
            this.txtPostCode2.MaxLength = 4;
            this.txtPostCode2.Name = "txtPostCode2";
            this.txtPostCode2.Size = new System.Drawing.Size(78, 22);
            this.txtPostCode2.TabIndex = 5;
            this.txtPostCode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ADDRESS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Black;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.customerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(5, 371);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 15;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(682, 189);
            this.dgv.TabIndex = 88;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 110;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(POSLayer.Models.Customer);
            // 
            // btnSelect
            // 
            this.btnSelect.AutoEllipsis = true;
            this.btnSelect.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(526, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(138, 57);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "SELECT  FROM  LIST";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.btnNotRequired);
            this.pnlTop.Controls.Add(this.btnSearchByTel);
            this.pnlTop.Controls.Add(this.btnDeleteCustomerFromDatabase);
            this.pnlTop.Controls.Add(this.btnSearchByPostCode);
            this.pnlTop.Controls.Add(this.btnSearchByAddress);
            this.pnlTop.Controls.Add(this.btnClearCustomerDetails);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnSelect);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.txtPostCode2);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtName);
            this.pnlTop.Controls.Add(this.txtBuzzer);
            this.pnlTop.Controls.Add(this.txtTel);
            this.pnlTop.Controls.Add(this.txtPostCode1);
            this.pnlTop.Controls.Add(this.txtAddress);
            this.pnlTop.Controls.Add(this.txtTown);
            this.pnlTop.Controls.Add(this.btnAddCustomerToDatabase);
            this.pnlTop.Controls.Add(this.txtMobile);
            this.pnlTop.Controls.Add(this.txtEmail);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(682, 366);
            this.pnlTop.TabIndex = 89;
            // 
            // btnNotRequired
            // 
            this.btnNotRequired.AutoEllipsis = true;
            this.btnNotRequired.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNotRequired.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotRequired.BackgroundImage")));
            this.btnNotRequired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotRequired.FlatAppearance.BorderSize = 0;
            this.btnNotRequired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotRequired.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNotRequired.Location = new System.Drawing.Point(370, 236);
            this.btnNotRequired.Name = "btnNotRequired";
            this.btnNotRequired.Size = new System.Drawing.Size(138, 57);
            this.btnNotRequired.TabIndex = 30;
            this.btnNotRequired.Text = "NOT REQUIRED";
            this.btnNotRequired.UseVisualStyleBackColor = false;
            this.btnNotRequired.Click += new System.EventHandler(this.btnNotRequired_Click);
            // 
            // btnSearchByTel
            // 
            this.btnSearchByTel.AutoEllipsis = true;
            this.btnSearchByTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchByTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByTel.BackgroundImage")));
            this.btnSearchByTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByTel.FlatAppearance.BorderSize = 0;
            this.btnSearchByTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByTel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchByTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearchByTel.Location = new System.Drawing.Point(370, 18);
            this.btnSearchByTel.Name = "btnSearchByTel";
            this.btnSearchByTel.Size = new System.Drawing.Size(138, 57);
            this.btnSearchByTel.TabIndex = 29;
            this.btnSearchByTel.Text = "SEARCH BY TEL";
            this.btnSearchByTel.UseVisualStyleBackColor = false;
            this.btnSearchByTel.Click += new System.EventHandler(this.btnGetByPhone_Click);
            // 
            // btnDeleteCustomerFromDatabase
            // 
            this.btnDeleteCustomerFromDatabase.AutoEllipsis = true;
            this.btnDeleteCustomerFromDatabase.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomerFromDatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomerFromDatabase.BackgroundImage")));
            this.btnDeleteCustomerFromDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCustomerFromDatabase.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomerFromDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomerFromDatabase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomerFromDatabase.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomerFromDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomerFromDatabase.Location = new System.Drawing.Point(526, 166);
            this.btnDeleteCustomerFromDatabase.Name = "btnDeleteCustomerFromDatabase";
            this.btnDeleteCustomerFromDatabase.Size = new System.Drawing.Size(138, 57);
            this.btnDeleteCustomerFromDatabase.TabIndex = 28;
            this.btnDeleteCustomerFromDatabase.Text = "Delete Selected Customer From Database";
            this.btnDeleteCustomerFromDatabase.UseVisualStyleBackColor = false;
            this.btnDeleteCustomerFromDatabase.Click += new System.EventHandler(this.btnDeleteCustomerFromDatabase_Click);
            // 
            // btnSearchByPostCode
            // 
            this.btnSearchByPostCode.AutoEllipsis = true;
            this.btnSearchByPostCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchByPostCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByPostCode.BackgroundImage")));
            this.btnSearchByPostCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByPostCode.FlatAppearance.BorderSize = 0;
            this.btnSearchByPostCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByPostCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchByPostCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearchByPostCode.Location = new System.Drawing.Point(370, 166);
            this.btnSearchByPostCode.Name = "btnSearchByPostCode";
            this.btnSearchByPostCode.Size = new System.Drawing.Size(138, 57);
            this.btnSearchByPostCode.TabIndex = 27;
            this.btnSearchByPostCode.Text = "SEARCH BY POSTCODE";
            this.btnSearchByPostCode.UseVisualStyleBackColor = false;
            this.btnSearchByPostCode.Click += new System.EventHandler(this.btnGetByPostCode_Click);
            // 
            // btnSearchByAddress
            // 
            this.btnSearchByAddress.AutoEllipsis = true;
            this.btnSearchByAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchByAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByAddress.BackgroundImage")));
            this.btnSearchByAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByAddress.FlatAppearance.BorderSize = 0;
            this.btnSearchByAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchByAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearchByAddress.Location = new System.Drawing.Point(370, 92);
            this.btnSearchByAddress.Name = "btnSearchByAddress";
            this.btnSearchByAddress.Size = new System.Drawing.Size(138, 57);
            this.btnSearchByAddress.TabIndex = 26;
            this.btnSearchByAddress.Text = "SEARCH BY ADDRESS";
            this.btnSearchByAddress.UseVisualStyleBackColor = false;
            this.btnSearchByAddress.Click += new System.EventHandler(this.btnGetByAddress_Click);
            // 
            // btnClearCustomerDetails
            // 
            this.btnClearCustomerDetails.AutoEllipsis = true;
            this.btnClearCustomerDetails.BackColor = System.Drawing.Color.Red;
            this.btnClearCustomerDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearCustomerDetails.BackgroundImage")));
            this.btnClearCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearCustomerDetails.FlatAppearance.BorderSize = 0;
            this.btnClearCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCustomerDetails.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnClearCustomerDetails.Location = new System.Drawing.Point(526, 18);
            this.btnClearCustomerDetails.Name = "btnClearCustomerDetails";
            this.btnClearCustomerDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClearCustomerDetails.Size = new System.Drawing.Size(138, 57);
            this.btnClearCustomerDetails.TabIndex = 25;
            this.btnClearCustomerDetails.Text = "CLEAR CUSTOMER DETAILS";
            this.btnClearCustomerDetails.UseVisualStyleBackColor = false;
            this.btnClearCustomerDetails.Click += new System.EventHandler(this.btnClearCustomerDetails_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "POSTCODE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctlCustomer
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Location = new System.Drawing.Point(0, 74);
            this.Name = "ctlCustomer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(692, 565);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyHandler);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion



        private void frmCustomer_Load(object sender, System.EventArgs e) {
            LoadCustomer();
            txtTel.Focus();
            if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery ||
               bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery) {
                txtAddress.BackColor = Color.Bisque;
            }
        }


        public void LoadCustomer() {
            try {
                CustomerIID = bslayer.AttachedOrder.CustomerIID;
                txtName.Text = bslayer.AttachedOrder.CName;
                txtBuzzer.Text = bslayer.AttachedOrder.Buzzer;
                try {
                    string[] parr = bslayer.AttachedOrder.Postcode.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parr.Length > 0)
                        txtPostCode1.Text = parr[0];
                    if (parr.Length > 1)
                        txtPostCode2.Text = parr[1];
                } catch { }
                txtAddress.Text = bslayer.AttachedOrder.Address;
                txtTown.Text = bslayer.AttachedOrder.Town;
                txtTel.Text = bslayer.AttachedOrder.Tel;
                txtMobile.Text = bslayer.AttachedOrder.Mobile;
                txtEmail.Text = bslayer.AttachedOrder.Email;
            } catch { }
        }

        public void ClearUI() {
            CustomerIID = "";
            txtName.Text = "";
            txtBuzzer.Text = "";
            txtPostCode1.Text = "";
            txtPostCode2.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtTel.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        public bool IsUIHaveCustomerData() {
            if (txtName.Text.Trim().Length > 0 ||
                txtBuzzer.Text.Trim().Length > 0 ||
                txtPostCode1.Text.Trim().Length > 0 ||
                txtAddress.Text.Trim().Length > 0 ||
                txtTown.Text.Trim().Length > 0 ||
                txtTel.Text.Trim().Length > 0 ||
                txtMobile.Text.Trim().Length > 0 ||
                txtEmail.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }
        public void LoadSearchResults() {
            LoadCustomer();
        }
        private void btnGetByName_Click(object sender, System.EventArgs e) {
            if (txtName.Text.Trim().Length > 3)
            ReloadSearch("Name");
        }
        private void btnGetByAddress_Click(object sender, System.EventArgs e) {
            if (txtAddress.Text.Trim().Length > 3)
             ReloadSearch("Address");
        }
        private void btnGetByPostCode_Click(object sender, System.EventArgs e) {
            if (txtPostCode1.Text.Trim().Length > 1)
            ReloadSearch("PostCode");
        }
        private void btnGetByPhone_Click(object sender, System.EventArgs e) {
            if (txtTel.Text.Trim().Length > 3)
                ReloadSearch("Phone");
        }
        private void ReloadSearch(string SearchType) {
            switch (SearchType) {
                case "Name":
                    dgv.DataSource = bslayer.SearchCustomersByName(txtName.Text.Trim().Replace("'", "''"));
                    break;
                case "Address":
                    dgv.DataSource = bslayer.SearchCustomersByAddress(txtAddress.Text.Trim().Replace("'", "''"));
                    break;
                case "Phone":
                    dgv.DataSource = bslayer.SearchCustomersByTel(txtTel.Text.Trim().Replace("'", "''"));
                    break;
                case "PostCode":
                    dgv.DataSource = bslayer.SearchCustomersByPostCode(txtPostCode1.Text.Trim().Replace("'", "''"));
                    break;
                case "Email":
                    dgv.DataSource = bslayer.SearchCustomersByEmail(txtEmail.Text.Trim().Replace("'", "''"));
                    break;
                default:
                    break;
            }
        }
        private void btnUpdateCustomer_Click(object sender, System.EventArgs e) {
            if (txtName.Text.Trim().Length == 0 || txtTel.Text.Trim().Length == 0) {
                MessageBox.Show("Name and Tel fields are compulsory !");
                return;
            }

            if (bslayer.AttachedOrder.CustomerIID == null || bslayer.AttachedOrder.CustomerIID == "")
                bslayer.AttachedOrder.CustomerIID = POSLayer.Library.ShortGuid.NewGuid().ToString();

            this.bslayer.AttachedOrder.CName = txtName.Text;
            this.bslayer.AttachedOrder.Buzzer = txtBuzzer.Text;
            this.bslayer.AttachedOrder.Address = txtAddress.Text;
            this.bslayer.AttachedOrder.Postcode = txtPostCode1.Text.Trim() + " " + txtPostCode2.Text.Trim();
            this.bslayer.AttachedOrder.Town = txtTown.Text;
            this.bslayer.AttachedOrder.Tel = txtTel.Text;
            this.bslayer.AttachedOrder.Mobile = txtMobile.Text;
            this.bslayer.AttachedOrder.Email = txtEmail.Text;

            if (bslayer.SaveCustomer(bslayer.CustomerDetailsFromOrder())) {
                Success = true;
                CloseFunction();
                if (CompleteAttachedOrder != null)
                    CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
            }
        }

        public void UICustomerToCustomer() {
            bslayer.AttachedOrder.CName = txtName.Text;
            bslayer.AttachedOrder.Buzzer = txtBuzzer.Text;
            bslayer.AttachedOrder.Postcode = txtPostCode1.Text.Trim() + " " + txtPostCode2.Text.Trim();
            bslayer.AttachedOrder.Address = txtAddress.Text;
            bslayer.AttachedOrder.Town = txtTown.Text;
            bslayer.AttachedOrder.Tel = txtTel.Text;
            bslayer.AttachedOrder.Mobile = txtMobile.Text;
            bslayer.AttachedOrder.Email = txtEmail.Text;
        }

        //private void btnCustomerNotRequired_Click(object sender, EventArgs e) {
        //    if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery)
        //        return;

        //    bslayer.AttachedOrder.CustomerIID = null;
        //    Success = true;
        //    CloseFunction();
        //    if (CompleteAttachedOrder != null)
        //        CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
        //}
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
                bslayer.CustomerDetailsToOrder(await bslayer.GetCustomer(SelectedCustomerIID));
                LoadSearchResults();
            }
        }

       

        private void btnDeleteCustomerFromDatabase_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                string DeleteCustomerIID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                bslayer.DeleteCustomer(DeleteCustomerIID);
                //bslayer.CustomerDetailsToOrder(bslayer.GetCustomer(SelectedCustomerIID));
                //LoadSearchResults();
                btnGetByPhone_Click(null, null);
            }
        }

        private void btnClearCustomerDetails_Click(object sender, EventArgs e) {
            ClearUI();
            UICustomerToCustomer();
            bslayer.AttachedOrder.CustomerIID = "";
                        
        }

        private void btnNotRequired_Click(object sender, EventArgs e) {
            if (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.Delivery)
                return;

            //bslayer.AttachedOrder.IsCustomerDetailsRequired = false;
            bslayer.AttachedOrder.CustomerIID = null;
            bslayer.AttachedOrder.CName = ".";
            bslayer.AttachedOrder.Tel = ".";
            Success = true;
            CloseFunction();
            if (CompleteAttachedOrder != null)
                CompleteAttachedOrder(NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive);
        }
    }
}
