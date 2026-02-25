namespace DTRMNS {
    partial class frmStockUsagePad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockUsagePad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.vScroll = new System.Windows.Forms.VScrollBar();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XSessionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqtylabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockItemUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkALL = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.rbSingle);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 86);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DisplayMember = "SupplierName";
            this.cmbSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(183, 16);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(220, 33);
            this.cmbSuppliers.TabIndex = 0;
            this.cmbSuppliers.ValueMember = "IID";
            this.cmbSuppliers.Visible = false;
            this.cmbSuppliers.SelectionChangeCommitted += new System.EventHandler(this.cmbSuppliers_SelectionChangeCommitted);
            // 
            // rbSingle
            // 
            this.rbSingle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSingle.BackColor = System.Drawing.Color.Black;
            this.rbSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbSingle.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.ForeColor = System.Drawing.Color.White;
            this.rbSingle.Image = global::DTRMNS.Properties.Resources.trolly48;
            this.rbSingle.Location = new System.Drawing.Point(93, 16);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(90, 67);
            this.rbSingle.TabIndex = 1;
            this.rbSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSingle.UseVisualStyleBackColor = false;
            // 
            // rbAll
            // 
            this.rbAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAll.BackColor = System.Drawing.Color.Black;
            this.rbAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbAll.Checked = true;
            this.rbAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAll.ForeColor = System.Drawing.Color.White;
            this.rbAll.Image = global::DTRMNS.Properties.Resources.MultiShopping64;
            this.rbAll.Location = new System.Drawing.Point(3, 16);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(90, 67);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // vScroll
            // 
            this.vScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScroll.Location = new System.Drawing.Point(885, 86);
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(60, 473);
            this.vScroll.TabIndex = 52;
            this.vScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll_Scroll);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Black;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockItemIID,
            this.OrderableQuantity,
            this.colord,
            this.colordlabel,
            this.colStockItemName,
            this.SessionQuantity,
            this.XSessionQuantity,
            this.PreviousQuantity,
            this.TotalQuantity,
            this.colqty,
            this.colqtylabel,
            this.supplierIIDDataGridViewTextBoxColumn,
            this.colSupplierName,
            this.colStatusImage,
            this.colStatus,
            this.colConversion});
            this.dgv.DataSource = this.stockItemUsageBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 86);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(885, 473);
            this.dgv.TabIndex = 53;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // colStockItemIID
            // 
            this.colStockItemIID.DataPropertyName = "StockItemIID";
            this.colStockItemIID.HeaderText = "StockItemIID";
            this.colStockItemIID.Name = "colStockItemIID";
            this.colStockItemIID.ReadOnly = true;
            this.colStockItemIID.Visible = false;
            // 
            // OrderableQuantity
            // 
            this.OrderableQuantity.DataPropertyName = "OrderableQuantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.OrderableQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderableQuantity.HeaderText = "Order Qty";
            this.OrderableQuantity.Name = "OrderableQuantity";
            this.OrderableQuantity.ReadOnly = true;
            this.OrderableQuantity.Width = 50;
            // 
            // colord
            // 
            this.colord.DataPropertyName = "OrderableType";
            this.colord.HeaderText = "Order Type";
            this.colord.Name = "colord";
            this.colord.ReadOnly = true;
            this.colord.Visible = false;
            // 
            // colordlabel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colordlabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.colordlabel.HeaderText = "Order Types";
            this.colordlabel.Name = "colordlabel";
            this.colordlabel.ReadOnly = true;
            this.colordlabel.Width = 60;
            // 
            // colStockItemName
            // 
            this.colStockItemName.DataPropertyName = "StockName";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.colStockItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStockItemName.HeaderText = "Stock Item";
            this.colStockItemName.Name = "colStockItemName";
            this.colStockItemName.ReadOnly = true;
            this.colStockItemName.Width = 250;
            // 
            // SessionQuantity
            // 
            this.SessionQuantity.DataPropertyName = "SessionQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SessionQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.SessionQuantity.HeaderText = "Session Qty";
            this.SessionQuantity.Name = "SessionQuantity";
            this.SessionQuantity.ReadOnly = true;
            this.SessionQuantity.Visible = false;
            this.SessionQuantity.Width = 60;
            // 
            // XSessionQuantity
            // 
            this.XSessionQuantity.DataPropertyName = "XSessionQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.XSessionQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.XSessionQuantity.HeaderText = "XSession Qty";
            this.XSessionQuantity.Name = "XSessionQuantity";
            this.XSessionQuantity.ReadOnly = true;
            this.XSessionQuantity.Visible = false;
            this.XSessionQuantity.Width = 60;
            // 
            // PreviousQuantity
            // 
            this.PreviousQuantity.DataPropertyName = "PreviousQuantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PreviousQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.PreviousQuantity.HeaderText = "Previous Qty";
            this.PreviousQuantity.Name = "PreviousQuantity";
            this.PreviousQuantity.ReadOnly = true;
            this.PreviousQuantity.Visible = false;
            this.PreviousQuantity.Width = 60;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalQuantity.HeaderText = "Total";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            this.TotalQuantity.Visible = false;
            this.TotalQuantity.Width = 60;
            // 
            // colqty
            // 
            this.colqty.DataPropertyName = "QuantityType";
            this.colqty.HeaderText = "Sale Type";
            this.colqty.Name = "colqty";
            this.colqty.ReadOnly = true;
            this.colqty.Visible = false;
            // 
            // colqtylabel
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colqtylabel.DefaultCellStyle = dataGridViewCellStyle8;
            this.colqtylabel.HeaderText = "Sale Types";
            this.colqtylabel.Name = "colqtylabel";
            this.colqtylabel.ReadOnly = true;
            this.colqtylabel.Visible = false;
            this.colqtylabel.Width = 60;
            // 
            // supplierIIDDataGridViewTextBoxColumn
            // 
            this.supplierIIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierIID";
            this.supplierIIDDataGridViewTextBoxColumn.HeaderText = "SupplierIID";
            this.supplierIIDDataGridViewTextBoxColumn.Name = "supplierIIDDataGridViewTextBoxColumn";
            this.supplierIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // colSupplierName
            // 
            this.colSupplierName.DataPropertyName = "SupplierName";
            this.colSupplierName.HeaderText = "Supplier";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            this.colSupplierName.Width = 200;
            // 
            // colStatusImage
            // 
            this.colStatusImage.HeaderText = "Status";
            this.colStatusImage.Image = global::DTRMNS.Properties.Resources.trolly32;
            this.colStatusImage.Name = "colStatusImage";
            this.colStatusImage.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "StatusInt";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // colConversion
            // 
            this.colConversion.DataPropertyName = "Conversion";
            this.colConversion.HeaderText = "Conversion";
            this.colConversion.Name = "colConversion";
            this.colConversion.ReadOnly = true;
            this.colConversion.Visible = false;
            // 
            // stockItemUsageBindingSource
            // 
            this.stockItemUsageBindingSource.DataSource = typeof(DTRMNS.StockItemUsage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 86);
            this.panel1.TabIndex = 54;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Black;
            this.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.btnEmail.Image = global::DTRMNS.Properties.Resources.mektup48;
            this.btnEmail.Location = new System.Drawing.Point(589, 0);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(86, 86);
            this.btnEmail.TabIndex = 52;
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrint.Location = new System.Drawing.Point(503, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 86);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Black;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::DTRMNS.Properties.Resources.Redo48;
            this.btnReload.Location = new System.Drawing.Point(417, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(86, 86);
            this.btnReload.TabIndex = 51;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DTRMNS.Properties.Resources.Delete;
            this.btnClose.Location = new System.Drawing.Point(855, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 86);
            this.btnClose.TabIndex = 10;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.rbMinus);
            this.groupBox2.Controls.Add(this.rbPlus);
            this.groupBox2.Controls.Add(this.rbNone);
            this.groupBox2.Controls.Add(this.rbDone);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(90, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 90);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTIONS";
            // 
            // rbMinus
            // 
            this.rbMinus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMinus.Image = global::DTRMNS.Properties.Resources.eksi48;
            this.rbMinus.Location = new System.Drawing.Point(273, 16);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(90, 71);
            this.rbMinus.TabIndex = 3;
            this.rbMinus.UseVisualStyleBackColor = true;
            this.rbMinus.Click += new System.EventHandler(this.rbMinus_Click);
            // 
            // rbPlus
            // 
            this.rbPlus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPlus.Image = global::DTRMNS.Properties.Resources.arti48;
            this.rbPlus.Location = new System.Drawing.Point(183, 16);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(90, 71);
            this.rbPlus.TabIndex = 2;
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.Click += new System.EventHandler(this.rbPlus_Click);
            // 
            // rbNone
            // 
            this.rbNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNone.Image = global::DTRMNS.Properties.Resources.Delete;
            this.rbNone.Location = new System.Drawing.Point(93, 16);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(90, 71);
            this.rbNone.TabIndex = 1;
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            this.rbNone.Click += new System.EventHandler(this.rbNone_Click);
            // 
            // rbDone
            // 
            this.rbDone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDone.Checked = true;
            this.rbDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDone.Image = global::DTRMNS.Properties.Resources.okay;
            this.rbDone.Location = new System.Drawing.Point(3, 16);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(90, 71);
            this.rbDone.TabIndex = 0;
            this.rbDone.TabStop = true;
            this.rbDone.UseVisualStyleBackColor = true;
            this.rbDone.CheckedChanged += new System.EventHandler(this.rbDone_CheckedChanged);
            this.rbDone.Click += new System.EventHandler(this.rbDone_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.chkALL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 90);
            this.panel2.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::DTRMNS.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(845, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 90);
            this.btnSave.TabIndex = 58;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkALL
            // 
            this.chkALL.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkALL.BackColor = System.Drawing.Color.Black;
            this.chkALL.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkALL.ForeColor = System.Drawing.Color.White;
            this.chkALL.Location = new System.Drawing.Point(0, 0);
            this.chkALL.Name = "chkALL";
            this.chkALL.Size = new System.Drawing.Size(90, 90);
            this.chkALL.TabIndex = 57;
            this.chkALL.Text = "ALL";
            this.chkALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkALL.UseVisualStyleBackColor = false;
            this.chkALL.CheckedChanged += new System.EventHandler(this.chkALL_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DTRMNS.Properties.Resources.okay24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::DTRMNS.Properties.Resources.cross_red_32;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::DTRMNS.Properties.Resources.arti48;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Minus 1";
            this.dataGridViewImageColumn4.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // frmStockUsagePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(945, 649);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.vScroll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockUsagePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STOCK USAGE PAD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockUsagePad_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.VScrollBar vScroll;
        private System.Windows.Forms.BindingSource stockItemUsageBindingSource;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkALL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn XSessionQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqtylabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewImageColumn colStatusImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversion;
    }
}