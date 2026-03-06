namespace DTRMSimpleBackOffice {
    partial class frmSessionReportsQuick
    {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionReportsQuick));
            dgvDatabase = new System.Windows.Forms.DataGridView();
            dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellDatabaseGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionViewBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrders = new System.Windows.Forms.DataGridView();
            colOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ordersViewBindingSource = new System.Windows.Forms.BindingSource(components);
            orderItemBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvArchive = new System.Windows.Forms.DataGridView();
            colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellArchivedGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlOrders = new System.Windows.Forms.Panel();
            pnl3661 = new System.Windows.Forms.Panel();
            btnLoadSelectables = new System.Windows.Forms.Button();
            cmbRange = new System.Windows.Forms.ComboBox();
            sRangeBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSil = new System.Windows.Forms.Button();
            tsSessionOrders = new System.Windows.Forms.ToolStrip();
            btnWizard = new System.Windows.Forms.ToolStripButton();
            lblTotal = new System.Windows.Forms.ToolStripLabel();
            lblCash = new System.Windows.Forms.ToolStripLabel();
            lblCard = new System.Windows.Forms.ToolStripLabel();
            lblSelectedOrdersTotal = new System.Windows.Forms.ToolStripLabel();
            lblInfo = new System.Windows.Forms.ToolStripLabel();
            pnlSessions = new System.Windows.Forms.Panel();
            tsSessions = new System.Windows.Forms.ToolStrip();
            btnSessionDBReload = new System.Windows.Forms.ToolStripButton();
            btnArchiveSessions = new System.Windows.Forms.ToolStripButton();
            btnPrintReport = new System.Windows.Forms.ToolStripButton();
            btnAllSessionTotal = new System.Windows.Forms.ToolStripButton();
            lblDatabaseSelectedTotal = new System.Windows.Forms.ToolStripLabel();
            pnlArchivedSessions = new System.Windows.Forms.Panel();
            tsArchivedSessions = new System.Windows.Forms.ToolStrip();
            btnSessionARCReload = new System.Windows.Forms.ToolStripButton();
            btnLoadSessions = new System.Windows.Forms.ToolStripButton();
            lblArchivedSelectedTotal = new System.Windows.Forms.ToolStripLabel();
            barMain = new System.Windows.Forms.ToolStrip();
            btnReload = new System.Windows.Forms.ToolStripButton();
            btnLoadSessionsFromDirectory = new System.Windows.Forms.ToolStripButton();
            btnShowHideArchive = new System.Windows.Forms.ToolStripButton();
            btnRefreshDatabase = new System.Windows.Forms.ToolStripButton();
            btnBackup = new System.Windows.Forms.ToolStripButton();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            pnlOrders.SuspendLayout();
            pnl3661.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sRangeBindingSource).BeginInit();
            tsSessionOrders.SuspendLayout();
            pnlSessions.SuspendLayout();
            tsSessions.SuspendLayout();
            pnlArchivedSessions.SuspendLayout();
            tsArchivedSessions.SuspendLayout();
            barMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatabase
            // 
            dgvDatabase.AllowUserToAddRows = false;
            dgvDatabase.AllowUserToDeleteRows = false;
            dgvDatabase.AllowUserToResizeRows = false;
            dgvDatabase.AutoGenerateColumns = false;
            dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dbIID, colDBStartDate, colDBEndDate, cellDatabaseGrossTotal });
            dgvDatabase.DataSource = sessionViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDatabase.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDatabase.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvDatabase.Location = new System.Drawing.Point(5, 59);
            dgvDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.ReadOnly = true;
            dgvDatabase.RowHeadersWidth = 20;
            dgvDatabase.RowTemplate.Height = 30;
            dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDatabase.Size = new System.Drawing.Size(490, 508);
            dgvDatabase.TabIndex = 1;
            dgvDatabase.SelectionChanged += dgvDatabase_SelectionChanged;
            // 
            // dbIID
            // 
            dbIID.DataPropertyName = "IID";
            dbIID.HeaderText = "IID";
            dbIID.Name = "dbIID";
            dbIID.ReadOnly = true;
            dbIID.Visible = false;
            dbIID.Width = 5;
            // 
            // colDBStartDate
            // 
            colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            colDBStartDate.HeaderText = "Session Start @";
            colDBStartDate.Name = "colDBStartDate";
            colDBStartDate.ReadOnly = true;
            colDBStartDate.Width = 160;
            // 
            // colDBEndDate
            // 
            colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            colDBEndDate.HeaderText = "Session End @";
            colDBEndDate.Name = "colDBEndDate";
            colDBEndDate.ReadOnly = true;
            colDBEndDate.Width = 160;
            // 
            // cellDatabaseGrossTotal
            // 
            cellDatabaseGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            cellDatabaseGrossTotal.DefaultCellStyle = dataGridViewCellStyle3;
            cellDatabaseGrossTotal.HeaderText = "Gross Total";
            cellDatabaseGrossTotal.Name = "cellDatabaseGrossTotal";
            cellDatabaseGrossTotal.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            sessionViewBindingSource.DataSource = typeof(DTRMNS.SessionView);
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOrderIID, orderDateDataGridViewTextBoxColumn, colPaymentMethod, colCalculatedValue });
            dgvOrders.DataSource = ordersViewBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle8;
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrders.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrders.Location = new System.Drawing.Point(5, 112);
            dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 25;
            dgvOrders.RowTemplate.Height = 30;
            dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new System.Drawing.Size(524, 455);
            dgvOrders.TabIndex = 71;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // colOrderIID
            // 
            colOrderIID.DataPropertyName = "IID";
            colOrderIID.HeaderText = "IID";
            colOrderIID.Name = "colOrderIID";
            colOrderIID.ReadOnly = true;
            colOrderIID.Visible = false;
            colOrderIID.Width = 5;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MMM/yy HH:mm:ss";
            dataGridViewCellStyle5.NullValue = null;
            orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.DataPropertyName = "Payment";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colPaymentMethod.DefaultCellStyle = dataGridViewCellStyle6;
            colPaymentMethod.HeaderText = "Pymt";
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            colPaymentMethod.Width = 60;
            // 
            // colCalculatedValue
            // 
            colCalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            colCalculatedValue.DefaultCellStyle = dataGridViewCellStyle7;
            colCalculatedValue.HeaderText = "Total";
            colCalculatedValue.Name = "colCalculatedValue";
            colCalculatedValue.ReadOnly = true;
            colCalculatedValue.Width = 90;
            // 
            // ordersViewBindingSource
            // 
            ordersViewBindingSource.DataSource = typeof(DTRMNS.OrdersView);
            // 
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(DTRMNS.OrderItem);
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.AutoGenerateColumns = false;
            dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colArcIID, colArcStartDate, colArcEndDate, cellArchivedGrossTotal });
            dgvArchive.DataSource = sessionViewBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle12;
            dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchive.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvArchive.Location = new System.Drawing.Point(5, 59);
            dgvArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersWidth = 20;
            dgvArchive.RowTemplate.Height = 30;
            dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.Size = new System.Drawing.Size(540, 508);
            dgvArchive.TabIndex = 2;
            dgvArchive.SelectionChanged += dgvArchive_SelectionChanged;
            // 
            // colArcIID
            // 
            colArcIID.DataPropertyName = "IID";
            colArcIID.HeaderText = "IID";
            colArcIID.Name = "colArcIID";
            colArcIID.ReadOnly = true;
            colArcIID.Visible = false;
            colArcIID.Width = 5;
            // 
            // colArcStartDate
            // 
            colArcStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcStartDate.DefaultCellStyle = dataGridViewCellStyle9;
            colArcStartDate.HeaderText = "Session Start @";
            colArcStartDate.Name = "colArcStartDate";
            colArcStartDate.ReadOnly = true;
            colArcStartDate.Width = 180;
            // 
            // colArcEndDate
            // 
            colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcEndDate.DefaultCellStyle = dataGridViewCellStyle10;
            colArcEndDate.HeaderText = "Session End @";
            colArcEndDate.Name = "colArcEndDate";
            colArcEndDate.ReadOnly = true;
            colArcEndDate.Width = 180;
            // 
            // cellArchivedGrossTotal
            // 
            cellArchivedGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "0";
            cellArchivedGrossTotal.DefaultCellStyle = dataGridViewCellStyle11;
            cellArchivedGrossTotal.HeaderText = "Gross Total";
            cellArchivedGrossTotal.Name = "cellArchivedGrossTotal";
            cellArchivedGrossTotal.ReadOnly = true;
            cellArchivedGrossTotal.Width = 120;
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = System.Drawing.Color.Yellow;
            pnlOrders.Controls.Add(dgvOrders);
            pnlOrders.Controls.Add(pnl3661);
            pnlOrders.Controls.Add(tsSessionOrders);
            pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlOrders.Location = new System.Drawing.Point(1050, 54);
            pnlOrders.MinimumSize = new System.Drawing.Size(20, 200);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Padding = new System.Windows.Forms.Padding(5);
            pnlOrders.Size = new System.Drawing.Size(534, 572);
            pnlOrders.TabIndex = 74;
            // 
            // pnl3661
            // 
            pnl3661.BackColor = System.Drawing.SystemColors.Control;
            pnl3661.Controls.Add(btnLoadSelectables);
            pnl3661.Controls.Add(cmbRange);
            pnl3661.Controls.Add(btnSil);
            pnl3661.Dock = System.Windows.Forms.DockStyle.Top;
            pnl3661.Location = new System.Drawing.Point(5, 59);
            pnl3661.Name = "pnl3661";
            pnl3661.Size = new System.Drawing.Size(524, 53);
            pnl3661.TabIndex = 75;
            pnl3661.Visible = false;
            // 
            // btnLoadSelectables
            // 
            btnLoadSelectables.Font = new System.Drawing.Font("Segoe UI", 16F);
            btnLoadSelectables.Location = new System.Drawing.Point(3, 3);
            btnLoadSelectables.Name = "btnLoadSelectables";
            btnLoadSelectables.Size = new System.Drawing.Size(52, 45);
            btnLoadSelectables.TabIndex = 5;
            btnLoadSelectables.Text = "L";
            btnLoadSelectables.UseVisualStyleBackColor = true;
            btnLoadSelectables.Click += btnLoadSelectables_Click;
            // 
            // cmbRange
            // 
            cmbRange.DataSource = sRangeBindingSource;
            cmbRange.DisplayMember = "DisplayValue";
            cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRange.Font = new System.Drawing.Font("Segoe UI", 14F);
            cmbRange.FormattingEnabled = true;
            cmbRange.Location = new System.Drawing.Point(125, 8);
            cmbRange.Name = "cmbRange";
            cmbRange.Size = new System.Drawing.Size(379, 33);
            cmbRange.TabIndex = 4;
            cmbRange.ValueMember = "ItemGap";
            cmbRange.SelectedValueChanged += cmbRange_SelectedValueChanged;
            // 
            // btnSil
            // 
            btnSil.Font = new System.Drawing.Font("Segoe UI", 16F);
            btnSil.Location = new System.Drawing.Point(63, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(50, 45);
            btnSil.TabIndex = 1;
            btnSil.Text = "S";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += tsSil_Click;
            // 
            // tsSessionOrders
            // 
            tsSessionOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnWizard, lblTotal, lblCash, lblCard, lblSelectedOrdersTotal, lblInfo });
            tsSessionOrders.Location = new System.Drawing.Point(5, 5);
            tsSessionOrders.Name = "tsSessionOrders";
            tsSessionOrders.Size = new System.Drawing.Size(524, 54);
            tsSessionOrders.TabIndex = 0;
            tsSessionOrders.Text = "toolStrip2";
            // 
            // btnWizard
            // 
            btnWizard.AutoSize = false;
            btnWizard.Image = Properties.Resources.Wizard;
            btnWizard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnWizard.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnWizard.Name = "btnWizard";
            btnWizard.Size = new System.Drawing.Size(70, 51);
            btnWizard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnWizard.Click += btnWizard_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = false;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTotal.Image = Properties.Resources.Sigma32;
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTotal.Size = new System.Drawing.Size(80, 51);
            lblTotal.Text = "Total";
            lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCash
            // 
            lblCash.AutoSize = false;
            lblCash.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblCash.Image = Properties.Resources.cash32;
            lblCash.Name = "lblCash";
            lblCash.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCash.Size = new System.Drawing.Size(80, 51);
            lblCash.Text = "Cash";
            lblCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCard
            // 
            lblCard.AutoSize = false;
            lblCard.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblCard.Image = Properties.Resources.card32;
            lblCard.Name = "lblCard";
            lblCard.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCard.Size = new System.Drawing.Size(80, 51);
            lblCard.Text = "Card";
            lblCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblSelectedOrdersTotal
            // 
            lblSelectedOrdersTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSelectedOrdersTotal.Name = "lblSelectedOrdersTotal";
            lblSelectedOrdersTotal.Size = new System.Drawing.Size(0, 51);
            // 
            // lblInfo
            // 
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(0, 51);
            // 
            // pnlSessions
            // 
            pnlSessions.BackColor = System.Drawing.Color.SteelBlue;
            pnlSessions.Controls.Add(dgvDatabase);
            pnlSessions.Controls.Add(tsSessions);
            pnlSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSessions.Location = new System.Drawing.Point(550, 54);
            pnlSessions.MinimumSize = new System.Drawing.Size(20, 0);
            pnlSessions.Name = "pnlSessions";
            pnlSessions.Padding = new System.Windows.Forms.Padding(5);
            pnlSessions.Size = new System.Drawing.Size(500, 572);
            pnlSessions.TabIndex = 72;
            // 
            // tsSessions
            // 
            tsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionDBReload, btnArchiveSessions, btnPrintReport, btnAllSessionTotal, lblDatabaseSelectedTotal });
            tsSessions.Location = new System.Drawing.Point(5, 5);
            tsSessions.Name = "tsSessions";
            tsSessions.Size = new System.Drawing.Size(490, 54);
            tsSessions.TabIndex = 0;
            tsSessions.Text = "toolStrip1";
            // 
            // btnSessionDBReload
            // 
            btnSessionDBReload.AutoSize = false;
            btnSessionDBReload.Image = Properties.Resources.Reload_32;
            btnSessionDBReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionDBReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionDBReload.Name = "btnSessionDBReload";
            btnSessionDBReload.Size = new System.Drawing.Size(70, 51);
            btnSessionDBReload.Text = "Reload";
            btnSessionDBReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionDBReload.Click += btnSessionDBReload_Click;
            // 
            // btnArchiveSessions
            // 
            btnArchiveSessions.AutoSize = false;
            btnArchiveSessions.Image = Properties.Resources.DBToFolder32;
            btnArchiveSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnArchiveSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnArchiveSessions.Name = "btnArchiveSessions";
            btnArchiveSessions.Size = new System.Drawing.Size(70, 51);
            btnArchiveSessions.Text = "Archive";
            btnArchiveSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnArchiveSessions.Click += btnArchiveSessions_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.AutoSize = false;
            btnPrintReport.Image = Properties.Resources.Printer32;
            btnPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new System.Drawing.Size(70, 51);
            btnPrintReport.Text = "Print";
            btnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // btnAllSessionTotal
            // 
            btnAllSessionTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAllSessionTotal.Image = Properties.Resources.Sigma32;
            btnAllSessionTotal.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAllSessionTotal.Name = "btnAllSessionTotal";
            btnAllSessionTotal.Size = new System.Drawing.Size(46, 51);
            btnAllSessionTotal.Text = "Total";
            btnAllSessionTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAllSessionTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAllSessionTotal.Click += btnAllSessionTotal_Click;
            // 
            // lblDatabaseSelectedTotal
            // 
            lblDatabaseSelectedTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDatabaseSelectedTotal.Name = "lblDatabaseSelectedTotal";
            lblDatabaseSelectedTotal.Size = new System.Drawing.Size(0, 51);
            // 
            // pnlArchivedSessions
            // 
            pnlArchivedSessions.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
            pnlArchivedSessions.Controls.Add(dgvArchive);
            pnlArchivedSessions.Controls.Add(tsArchivedSessions);
            pnlArchivedSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlArchivedSessions.Location = new System.Drawing.Point(0, 54);
            pnlArchivedSessions.MinimumSize = new System.Drawing.Size(20, 0);
            pnlArchivedSessions.Name = "pnlArchivedSessions";
            pnlArchivedSessions.Padding = new System.Windows.Forms.Padding(5);
            pnlArchivedSessions.Size = new System.Drawing.Size(550, 572);
            pnlArchivedSessions.TabIndex = 3;
            // 
            // tsArchivedSessions
            // 
            tsArchivedSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionARCReload, btnLoadSessions, lblArchivedSelectedTotal });
            tsArchivedSessions.Location = new System.Drawing.Point(5, 5);
            tsArchivedSessions.Name = "tsArchivedSessions";
            tsArchivedSessions.Size = new System.Drawing.Size(540, 54);
            tsArchivedSessions.TabIndex = 0;
            tsArchivedSessions.Text = "toolStrip1";
            // 
            // btnSessionARCReload
            // 
            btnSessionARCReload.AutoSize = false;
            btnSessionARCReload.Image = Properties.Resources.Reload_32;
            btnSessionARCReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionARCReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionARCReload.Name = "btnSessionARCReload";
            btnSessionARCReload.Size = new System.Drawing.Size(70, 51);
            btnSessionARCReload.Text = "Reload";
            btnSessionARCReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionARCReload.Click += btnSessionARCReload_Click;
            // 
            // btnLoadSessions
            // 
            btnLoadSessions.AutoSize = false;
            btnLoadSessions.Image = Properties.Resources.FolderToDB32;
            btnLoadSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadSessions.Name = "btnLoadSessions";
            btnLoadSessions.Size = new System.Drawing.Size(90, 51);
            btnLoadSessions.Text = "Load Sessions";
            btnLoadSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadSessions.Click += btnLoadSessions_Click;
            // 
            // lblArchivedSelectedTotal
            // 
            lblArchivedSelectedTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblArchivedSelectedTotal.Image = Properties.Resources.Sigma32;
            lblArchivedSelectedTotal.Name = "lblArchivedSelectedTotal";
            lblArchivedSelectedTotal.Size = new System.Drawing.Size(48, 51);
            lblArchivedSelectedTotal.Text = "Total";
            lblArchivedSelectedTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnReload, btnLoadSessionsFromDirectory, btnShowHideArchive, btnRefreshDatabase, btnBackup });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(1584, 54);
            barMain.TabIndex = 13;
            barMain.Text = "toolStrip1";
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Reload_32;
            btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(47, 51);
            btnReload.Text = "Reload";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
            // 
            // btnLoadSessionsFromDirectory
            // 
            btnLoadSessionsFromDirectory.Image = Properties.Resources.FolderToDBPlus32;
            btnLoadSessionsFromDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadSessionsFromDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadSessionsFromDirectory.Name = "btnLoadSessionsFromDirectory";
            btnLoadSessionsFromDirectory.Size = new System.Drawing.Size(119, 51);
            btnLoadSessionsFromDirectory.Text = "Load From Directory";
            btnLoadSessionsFromDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadSessionsFromDirectory.Click += btnLoadSessionsFromDirectory_Click;
            // 
            // btnShowHideArchive
            // 
            btnShowHideArchive.AutoSize = false;
            btnShowHideArchive.Image = Properties.Resources.XML32;
            btnShowHideArchive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnShowHideArchive.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnShowHideArchive.Name = "btnShowHideArchive";
            btnShowHideArchive.Size = new System.Drawing.Size(70, 51);
            btnShowHideArchive.Text = "Archive";
            btnShowHideArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnShowHideArchive.Click += btnShowHideArchive_Click;
            // 
            // btnRefreshDatabase
            // 
            btnRefreshDatabase.AutoSize = false;
            btnRefreshDatabase.Image = Properties.Resources.Refresh_2;
            btnRefreshDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnRefreshDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRefreshDatabase.Name = "btnRefreshDatabase";
            btnRefreshDatabase.Size = new System.Drawing.Size(70, 51);
            btnRefreshDatabase.Text = "Refresh";
            btnRefreshDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRefreshDatabase.Click += btnRefreshDatabase_Click;
            // 
            // btnBackup
            // 
            btnBackup.AutoSize = false;
            btnBackup.Image = Properties.Resources.backup;
            btnBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new System.Drawing.Size(70, 51);
            btnBackup.Text = "Backup";
            btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnBackup.Click += btnBackup_Click;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn7.HeaderText = "Item";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn8.HeaderText = "Price";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "IID";
            dataGridViewTextBoxColumn9.HeaderText = "IID";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "IID";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn10.HeaderText = "IID";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "OrderDate";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Format = "F";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn11.HeaderText = "OrderDate";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn12.HeaderText = "Total";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "IID";
            dataGridViewTextBoxColumn13.HeaderText = "IID";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Quantity";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn14.HeaderText = "Quantity";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn15.HeaderText = "Item";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "Price";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn16.HeaderText = "Price";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Total";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn17.HeaderText = "Total";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 60;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "IID";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn18.HeaderText = "IID";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "StartDate";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn19.HeaderText = "Session Start @";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.Visible = false;
            dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "EndDate";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn20.HeaderText = "Session End @";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = "0";
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewTextBoxColumn21.HeaderText = "Gross Total";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Width = 200;
            // 
            // frmSessionReportsQuick
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1584, 626);
            Controls.Add(pnlOrders);
            Controls.Add(pnlSessions);
            Controls.Add(pnlArchivedSessions);
            Controls.Add(barMain);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSessionReportsQuick";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Session Reports";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmSessionReportsQuick_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnl3661.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sRangeBindingSource).EndInit();
            tsSessionOrders.ResumeLayout(false);
            tsSessionOrders.PerformLayout();
            pnlSessions.ResumeLayout(false);
            pnlSessions.PerformLayout();
            tsSessions.ResumeLayout(false);
            tsSessions.PerformLayout();
            pnlArchivedSessions.ResumeLayout(false);
            pnlArchivedSessions.PerformLayout();
            tsArchivedSessions.ResumeLayout(false);
            tsArchivedSessions.PerformLayout();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.BindingSource sessionViewBindingSource;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.ToolStrip tsArchivedSessions;
        private System.Windows.Forms.ToolStripButton btnSessionARCReload;
        private System.Windows.Forms.ToolStripButton btnLoadSessions;
        private System.Windows.Forms.ToolStripLabel lblArchivedSelectedTotal;
        private System.Windows.Forms.ToolStrip tsSessionOrders;
        private System.Windows.Forms.ToolStripLabel lblTotal;
        private System.Windows.Forms.ToolStrip tsSessions;
        private System.Windows.Forms.ToolStripButton btnSessionDBReload;
        private System.Windows.Forms.ToolStripButton btnArchiveSessions;
        private System.Windows.Forms.ToolStripButton btnPrintReport;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnLoadSessionsFromDirectory;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel pnlArchivedSessions;
        private System.Windows.Forms.Panel pnl3661;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.BindingSource sRangeBindingSource;
        private System.Windows.Forms.Button btnLoadSelectables;
        private System.Windows.Forms.ToolStripLabel lblCard;
        private System.Windows.Forms.ToolStripLabel lblCash;
        private System.Windows.Forms.ToolStripButton btnShowHideArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellArchivedGrossTotal;
        private System.Windows.Forms.ToolStripButton btnAllSessionTotal;
        private System.Windows.Forms.ToolStripLabel lblInfo;
        private System.Windows.Forms.ToolStripButton btnWizard;
        private System.Windows.Forms.ToolStripLabel lblDatabaseSelectedTotal;
        private System.Windows.Forms.ToolStripLabel lblSelectedOrdersTotal;
        private System.Windows.Forms.ToolStripButton btnRefreshDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDatabaseGrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalculatedValue;
        private System.Windows.Forms.ToolStripButton btnBackup;
    }
}