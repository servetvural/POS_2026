namespace DTRMSimpleAdaptor {
    partial class FrmMainAdaptor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdaptor));
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataShortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.colDBIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlArchive = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowTotalArchived = new System.Windows.Forms.Button();
            this.btnArcEmailAsCsv = new System.Windows.Forms.Button();
            this.btnArcExportToCsv = new System.Windows.Forms.Button();
            this.lblArcTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowTotalDatabase = new System.Windows.Forms.Button();
            this.btnDBEmailAsCsv = new System.Windows.Forms.Button();
            this.btnDBExportToCsv = new System.Windows.Forms.Button();
            this.lblDBTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnViewTaxReport = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkPrintWhenProcessed = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnProcessSessions = new System.Windows.Forms.Button();
            this.btnArchiveSessions = new System.Windows.Forms.Button();
            this.btnLoadSelectedIntoDatabase = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataShortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.pnlArchive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDatabase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArchive
            // 
            this.dgvArchive.AllowUserToAddRows = false;
            this.dgvArchive.AllowUserToDeleteRows = false;
            this.dgvArchive.AutoGenerateColumns = false;
            this.dgvArchive.BackgroundColor = System.Drawing.Color.White;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArcIID,
            this.colArcStartDate,
            this.colArcEndDate,
            this.colArcTotal});
            this.dgvArchive.DataSource = this.sessionDataShortBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchive.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArchive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvArchive.Location = new System.Drawing.Point(0, 24);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.RowHeadersWidth = 25;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(450, 580);
            this.dgvArchive.TabIndex = 69;
            // 
            // colArcIID
            // 
            this.colArcIID.DataPropertyName = "IID";
            this.colArcIID.HeaderText = "IID";
            this.colArcIID.Name = "colArcIID";
            this.colArcIID.ReadOnly = true;
            this.colArcIID.Visible = false;
            // 
            // colArcStartDate
            // 
            this.colArcStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "dd ddd MMM yyyy  HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.colArcStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colArcStartDate.HeaderText = "StartDate";
            this.colArcStartDate.Name = "colArcStartDate";
            this.colArcStartDate.ReadOnly = true;
            this.colArcStartDate.Width = 140;
            // 
            // colArcEndDate
            // 
            this.colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "dd ddd MMM yyyy  HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.colArcEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colArcEndDate.HeaderText = "EndDate";
            this.colArcEndDate.Name = "colArcEndDate";
            this.colArcEndDate.ReadOnly = true;
            this.colArcEndDate.Width = 140;
            // 
            // colArcTotal
            // 
            this.colArcTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colArcTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colArcTotal.HeaderText = "Total";
            this.colArcTotal.Name = "colArcTotal";
            this.colArcTotal.ReadOnly = true;
            // 
            // sessionDataShortBindingSource
            // 
            this.sessionDataShortBindingSource.DataSource = typeof(DTRMNS.SessionDataShort);
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AutoGenerateColumns = false;
            this.dgvDatabase.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDBIID,
            this.colDBStartDate,
            this.colDBEndDate,
            this.colDBTotal});
            this.dgvDatabase.DataSource = this.sessionDataShortBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabase.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatabase.Location = new System.Drawing.Point(0, 24);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            this.dgvDatabase.RowHeadersWidth = 25;
            this.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabase.Size = new System.Drawing.Size(451, 580);
            this.dgvDatabase.TabIndex = 70;
            // 
            // colDBIID
            // 
            this.colDBIID.DataPropertyName = "IID";
            this.colDBIID.HeaderText = "IID";
            this.colDBIID.Name = "colDBIID";
            this.colDBIID.ReadOnly = true;
            this.colDBIID.Visible = false;
            // 
            // colDBStartDate
            // 
            this.colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "dd ddd MMM yyyy  HH:mm";
            dataGridViewCellStyle5.NullValue = null;
            this.colDBStartDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDBStartDate.HeaderText = "StartDate";
            this.colDBStartDate.Name = "colDBStartDate";
            this.colDBStartDate.ReadOnly = true;
            this.colDBStartDate.Width = 140;
            // 
            // colDBEndDate
            // 
            this.colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "dd ddd MMM yyyy  HH:mm";
            dataGridViewCellStyle6.NullValue = null;
            this.colDBEndDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDBEndDate.HeaderText = "EndDate";
            this.colDBEndDate.Name = "colDBEndDate";
            this.colDBEndDate.ReadOnly = true;
            this.colDBEndDate.Width = 140;
            // 
            // colDBTotal
            // 
            this.colDBTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.colDBTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDBTotal.HeaderText = "Total";
            this.colDBTotal.Name = "colDBTotal";
            this.colDBTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archived Files / Directory";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Files in  Database";
            // 
            // pnlArchive
            // 
            this.pnlArchive.Controls.Add(this.dgvArchive);
            this.pnlArchive.Controls.Add(this.panel1);
            this.pnlArchive.Controls.Add(this.label1);
            this.pnlArchive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlArchive.Location = new System.Drawing.Point(0, 24);
            this.pnlArchive.Name = "pnlArchive";
            this.pnlArchive.Size = new System.Drawing.Size(450, 649);
            this.pnlArchive.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnShowTotalArchived);
            this.panel1.Controls.Add(this.btnArcEmailAsCsv);
            this.panel1.Controls.Add(this.btnArcExportToCsv);
            this.panel1.Controls.Add(this.lblArcTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 45);
            this.panel1.TabIndex = 70;
            // 
            // btnShowTotalArchived
            // 
            this.btnShowTotalArchived.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnShowTotalArchived.Location = new System.Drawing.Point(366, 4);
            this.btnShowTotalArchived.Name = "btnShowTotalArchived";
            this.btnShowTotalArchived.Size = new System.Drawing.Size(80, 36);
            this.btnShowTotalArchived.TabIndex = 9;
            this.btnShowTotalArchived.Text = "SHOW TOTAL";
            this.btnShowTotalArchived.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowTotalArchived.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTotalArchived.UseVisualStyleBackColor = true;
            this.btnShowTotalArchived.Click += new System.EventHandler(this.BtnShowTotalArchived_Click);
            // 
            // btnArcEmailAsCsv
            // 
            this.btnArcEmailAsCsv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnArcEmailAsCsv.Image = global::DTRMSimpleAdaptor.Properties.Resources.mektup32;
            this.btnArcEmailAsCsv.Location = new System.Drawing.Point(280, 4);
            this.btnArcEmailAsCsv.Name = "btnArcEmailAsCsv";
            this.btnArcEmailAsCsv.Size = new System.Drawing.Size(80, 36);
            this.btnArcEmailAsCsv.TabIndex = 8;
            this.btnArcEmailAsCsv.Text = "  Email";
            this.btnArcEmailAsCsv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArcEmailAsCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArcEmailAsCsv.UseVisualStyleBackColor = true;
            this.btnArcEmailAsCsv.Click += new System.EventHandler(this.BtnArcEmailAsCsv_Click);
            // 
            // btnArcExportToCsv
            // 
            this.btnArcExportToCsv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnArcExportToCsv.Image = global::DTRMSimpleAdaptor.Properties.Resources.Export32;
            this.btnArcExportToCsv.Location = new System.Drawing.Point(182, 4);
            this.btnArcExportToCsv.Name = "btnArcExportToCsv";
            this.btnArcExportToCsv.Size = new System.Drawing.Size(90, 36);
            this.btnArcExportToCsv.TabIndex = 7;
            this.btnArcExportToCsv.Text = "Spread\r\n Sheet";
            this.btnArcExportToCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArcExportToCsv.UseVisualStyleBackColor = true;
            this.btnArcExportToCsv.Click += new System.EventHandler(this.BtnArcExportToCsv_Click);
            // 
            // lblArcTotal
            // 
            this.lblArcTotal.BackColor = System.Drawing.Color.White;
            this.lblArcTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArcTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblArcTotal.Location = new System.Drawing.Point(40, 11);
            this.lblArcTotal.Name = "lblArcTotal";
            this.lblArcTotal.Size = new System.Drawing.Size(136, 25);
            this.lblArcTotal.TabIndex = 1;
            this.lblArcTotal.Text = "0.00";
            this.lblArcTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(-1, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total";
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.Controls.Add(this.dgvDatabase);
            this.pnlDatabase.Controls.Add(this.panel2);
            this.pnlDatabase.Controls.Add(this.label2);
            this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatabase.Location = new System.Drawing.Point(560, 24);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(451, 649);
            this.pnlDatabase.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnShowTotalDatabase);
            this.panel2.Controls.Add(this.btnDBEmailAsCsv);
            this.panel2.Controls.Add(this.btnDBExportToCsv);
            this.panel2.Controls.Add(this.lblDBTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 45);
            this.panel2.TabIndex = 71;
            // 
            // btnShowTotalDatabase
            // 
            this.btnShowTotalDatabase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnShowTotalDatabase.Location = new System.Drawing.Point(365, 4);
            this.btnShowTotalDatabase.Name = "btnShowTotalDatabase";
            this.btnShowTotalDatabase.Size = new System.Drawing.Size(80, 36);
            this.btnShowTotalDatabase.TabIndex = 10;
            this.btnShowTotalDatabase.Text = "SHOW TOTAL";
            this.btnShowTotalDatabase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowTotalDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTotalDatabase.UseVisualStyleBackColor = true;
            this.btnShowTotalDatabase.Click += new System.EventHandler(this.BtnShowTotalDatabase_Click);
            // 
            // btnDBEmailAsCsv
            // 
            this.btnDBEmailAsCsv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDBEmailAsCsv.Image = global::DTRMSimpleAdaptor.Properties.Resources.mektup32;
            this.btnDBEmailAsCsv.Location = new System.Drawing.Point(274, 4);
            this.btnDBEmailAsCsv.Name = "btnDBEmailAsCsv";
            this.btnDBEmailAsCsv.Size = new System.Drawing.Size(80, 36);
            this.btnDBEmailAsCsv.TabIndex = 9;
            this.btnDBEmailAsCsv.Text = "  Email";
            this.btnDBEmailAsCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDBEmailAsCsv.UseVisualStyleBackColor = true;
            this.btnDBEmailAsCsv.Click += new System.EventHandler(this.BtnDBEmailAsCsv_Click);
            // 
            // btnDBExportToCsv
            // 
            this.btnDBExportToCsv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDBExportToCsv.Image = global::DTRMSimpleAdaptor.Properties.Resources.Export32;
            this.btnDBExportToCsv.Location = new System.Drawing.Point(175, 4);
            this.btnDBExportToCsv.Name = "btnDBExportToCsv";
            this.btnDBExportToCsv.Size = new System.Drawing.Size(90, 36);
            this.btnDBExportToCsv.TabIndex = 6;
            this.btnDBExportToCsv.Text = "Spread\r\n Sheet";
            this.btnDBExportToCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDBExportToCsv.UseVisualStyleBackColor = true;
            this.btnDBExportToCsv.Click += new System.EventHandler(this.BtnDBExportToCsv_Click);
            // 
            // lblDBTotal
            // 
            this.lblDBTotal.BackColor = System.Drawing.Color.White;
            this.lblDBTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDBTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDBTotal.Location = new System.Drawing.Point(40, 11);
            this.lblDBTotal.Name = "lblDBTotal";
            this.lblDBTotal.Size = new System.Drawing.Size(129, 25);
            this.lblDBTotal.TabIndex = 3;
            this.lblDBTotal.Text = "0.00";
            this.lblDBTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(0, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(450, 24);
            this.splitter1.MinExtra = 150;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(22, 649);
            this.splitter1.TabIndex = 75;
            this.splitter1.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.White;
            this.pnlMiddle.Controls.Add(this.btnViewTaxReport);
            this.pnlMiddle.Controls.Add(this.btnViewOrders);
            this.pnlMiddle.Controls.Add(this.btnPrint);
            this.pnlMiddle.Controls.Add(this.chkPrintWhenProcessed);
            this.pnlMiddle.Controls.Add(this.btnRefresh);
            this.pnlMiddle.Controls.Add(this.btnProcessSessions);
            this.pnlMiddle.Controls.Add(this.btnArchiveSessions);
            this.pnlMiddle.Controls.Add(this.btnLoadSelectedIntoDatabase);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMiddle.Location = new System.Drawing.Point(472, 24);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(88, 649);
            this.pnlMiddle.TabIndex = 76;
            // 
            // btnViewTaxReport
            // 
            this.btnViewTaxReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewTaxReport.Location = new System.Drawing.Point(11, 460);
            this.btnViewTaxReport.Name = "btnViewTaxReport";
            this.btnViewTaxReport.Size = new System.Drawing.Size(67, 67);
            this.btnViewTaxReport.TabIndex = 8;
            this.btnViewTaxReport.Text = "View Tax\r\nReport";
            this.btnViewTaxReport.UseVisualStyleBackColor = true;
            this.btnViewTaxReport.Click += new System.EventHandler(this.BtnViewTaxReport_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewOrders.Location = new System.Drawing.Point(11, 392);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(67, 52);
            this.btnViewOrders.TabIndex = 6;
            this.btnViewOrders.Text = "View\r\nOrders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Image = global::DTRMSimpleAdaptor.Properties.Resources.Printer32;
            this.btnPrint.Location = new System.Drawing.Point(11, 334);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 52);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // chkPrintWhenProcessed
            // 
            this.chkPrintWhenProcessed.AutoSize = true;
            this.chkPrintWhenProcessed.Location = new System.Drawing.Point(6, 298);
            this.chkPrintWhenProcessed.Name = "chkPrintWhenProcessed";
            this.chkPrintWhenProcessed.Size = new System.Drawing.Size(76, 30);
            this.chkPrintWhenProcessed.TabIndex = 4;
            this.chkPrintWhenProcessed.Text = "Print when\r\nprocessed";
            this.chkPrintWhenProcessed.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Image = global::DTRMSimpleAdaptor.Properties.Resources.Update;
            this.btnRefresh.Location = new System.Drawing.Point(11, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 60);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Reload";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnProcessSessions
            // 
            this.btnProcessSessions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProcessSessions.Image = global::DTRMSimpleAdaptor.Properties.Resources.Gears32;
            this.btnProcessSessions.Location = new System.Drawing.Point(11, 233);
            this.btnProcessSessions.Name = "btnProcessSessions";
            this.btnProcessSessions.Size = new System.Drawing.Size(67, 59);
            this.btnProcessSessions.TabIndex = 2;
            this.btnProcessSessions.Text = "Process";
            this.btnProcessSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcessSessions.UseVisualStyleBackColor = true;
            this.btnProcessSessions.Click += new System.EventHandler(this.BtnProcessSessions_Click);
            // 
            // btnArchiveSessions
            // 
            this.btnArchiveSessions.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnArchiveSessions.Image = global::DTRMSimpleAdaptor.Properties.Resources.Arrow_Red___Left;
            this.btnArchiveSessions.Location = new System.Drawing.Point(11, 161);
            this.btnArchiveSessions.Name = "btnArchiveSessions";
            this.btnArchiveSessions.Size = new System.Drawing.Size(67, 52);
            this.btnArchiveSessions.TabIndex = 1;
            this.btnArchiveSessions.UseVisualStyleBackColor = true;
            this.btnArchiveSessions.Click += new System.EventHandler(this.BtnArchiveSessions_Click);
            // 
            // btnLoadSelectedIntoDatabase
            // 
            this.btnLoadSelectedIntoDatabase.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLoadSelectedIntoDatabase.Image = global::DTRMSimpleAdaptor.Properties.Resources.Arrow_Green___Right;
            this.btnLoadSelectedIntoDatabase.Location = new System.Drawing.Point(11, 103);
            this.btnLoadSelectedIntoDatabase.Name = "btnLoadSelectedIntoDatabase";
            this.btnLoadSelectedIntoDatabase.Size = new System.Drawing.Size(67, 52);
            this.btnLoadSelectedIntoDatabase.TabIndex = 0;
            this.btnLoadSelectedIntoDatabase.UseVisualStyleBackColor = true;
            this.btnLoadSelectedIntoDatabase.Click += new System.EventHandler(this.BtnLoadSelectedIntoDatabase_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // FrmMainAdaptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DTRMSimpleAdaptor.Properties.Resources.Gears32;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1011, 673);
            this.Controls.Add(this.pnlDatabase);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlArchive);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainAdaptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADAPTOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainAdaptor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainAdaptor_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainAdaptor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataShortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.pnlArchive.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDatabase.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sessionDataShortBindingSource;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlArchive;
        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Button btnProcessSessions;
        private System.Windows.Forms.Button btnArchiveSessions;
        private System.Windows.Forms.Button btnLoadSelectedIntoDatabase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkPrintWhenProcessed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblArcTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDBTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnDBExportToCsv;
        private System.Windows.Forms.Button btnArcExportToCsv;
        private System.Windows.Forms.Button btnArcEmailAsCsv;
        private System.Windows.Forms.Button btnDBEmailAsCsv;
        private System.Windows.Forms.Button btnViewTaxReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.Button btnShowTotalArchived;
        private System.Windows.Forms.Button btnShowTotalDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBTotal;
    }
}

