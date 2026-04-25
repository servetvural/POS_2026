using POSLayer.Models;
using POSLayer.Views;

namespace POSOffice {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionReportsQuick));
            dgvDatabase = new System.Windows.Forms.DataGridView();
            dgvOrders = new System.Windows.Forms.DataGridView();
            dgvArchive = new System.Windows.Forms.DataGridView();
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
            sessionBindingSource = new System.Windows.Forms.BindingSource(components);
            orderBindingSource = new System.Windows.Forms.BindingSource(components);
            startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
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
            dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dgvDatabase.DataSource = sessionBindingSource;
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
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderDateDataGridViewTextBoxColumn, paymentDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn2 });
            dgvOrders.DataSource = orderBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle7;
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
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.AutoGenerateColumns = false;
            dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { startDateDataGridViewTextBoxColumn1, endDateDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1 });
            dgvArchive.DataSource = sessionBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle11;
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
            // sessionBindingSource
            // 
            sessionBindingSource.DataSource = typeof(Session);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            startDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            startDateDataGridViewTextBoxColumn.HeaderText = "Session Start @";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            endDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            endDateDataGridViewTextBoxColumn.HeaderText = "Session End @";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy ddd HH:mm:ss";
            startDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            startDateDataGridViewTextBoxColumn1.HeaderText = "Session Start @\t";
            startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            startDateDataGridViewTextBoxColumn1.Width = 160;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy ddd HH:mm:ss";
            endDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            endDateDataGridViewTextBoxColumn1.HeaderText = "Session End @";
            endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            endDateDataGridViewTextBoxColumn1.ReadOnly = true;
            endDateDataGridViewTextBoxColumn1.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            totalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
            totalDataGridViewTextBoxColumn1.Width = 80;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MMM/yy ddd HH:mm:ss";
            orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            totalDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            totalDataGridViewTextBoxColumn2.Width = 80;
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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvArchive;
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
        private System.Windows.Forms.Panel pnlArchivedSessions;
        private System.Windows.Forms.Panel pnl3661;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.BindingSource sRangeBindingSource;
        private System.Windows.Forms.Button btnLoadSelectables;
        private System.Windows.Forms.ToolStripLabel lblCard;
        private System.Windows.Forms.ToolStripLabel lblCash;
        private System.Windows.Forms.ToolStripButton btnShowHideArchive;
        private System.Windows.Forms.ToolStripButton btnAllSessionTotal;
        private System.Windows.Forms.ToolStripLabel lblInfo;
        private System.Windows.Forms.ToolStripButton btnWizard;
        private System.Windows.Forms.ToolStripLabel lblDatabaseSelectedTotal;
        private System.Windows.Forms.ToolStripLabel lblSelectedOrdersTotal;
        private System.Windows.Forms.ToolStripButton btnRefreshDatabase;
        private System.Windows.Forms.ToolStripButton btnBackup;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
    }
}