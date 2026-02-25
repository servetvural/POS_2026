namespace DTRMNS.Forms
{
    partial class frmReportArchive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportArchive));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReloadArchive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellArchivedGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expArchivedSessions = new PosLibrary.Expander();
            this.pnlArchivedSessions = new System.Windows.Forms.Panel();
            this.pnlArchiveControl = new System.Windows.Forms.Panel();
            this.btnLoadSessions = new System.Windows.Forms.Button();
            this.pnlSessions = new System.Windows.Forms.Panel();
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSessionTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDBControl = new System.Windows.Forms.Panel();
            this.btnArchiveSessions = new System.Windows.Forms.Button();
            this.btnReloadDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).BeginInit();
            this.pnlArchivedSessions.SuspendLayout();
            this.pnlArchiveControl.SuspendLayout();
            this.pnlSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource1)).BeginInit();
            this.pnlDBControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrint.Location = new System.Drawing.Point(198, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 56);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "PRINT Z REPORTS";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReloadArchive
            // 
            this.btnReloadArchive.Image = global::DTRMNS.Properties.Resources.Refresh_2;
            this.btnReloadArchive.Location = new System.Drawing.Point(3, 6);
            this.btnReloadArchive.Name = "btnReloadArchive";
            this.btnReloadArchive.Size = new System.Drawing.Size(90, 56);
            this.btnReloadArchive.TabIndex = 4;
            this.btnReloadArchive.Text = "RELOAD Z";
            this.btnReloadArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReloadArchive.UseVisualStyleBackColor = true;
            this.btnReloadArchive.Click += new System.EventHandler(this.btnReloadArchive_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Image = global::DTRMNS.Properties.Resources.Cancel;
            this.btnClose.Location = new System.Drawing.Point(323, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 56);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvArchive
            // 
            this.dgvArchive.AllowUserToAddRows = false;
            this.dgvArchive.AllowUserToDeleteRows = false;
            this.dgvArchive.AllowUserToResizeRows = false;
            this.dgvArchive.AutoGenerateColumns = false;
            this.dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArcIID,
            this.colArcStartDate,
            this.colArcEndDate,
            this.cellArchivedGrossTotal});
            this.dgvArchive.DataSource = this.sessionViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchive.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArchive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvArchive.Location = new System.Drawing.Point(0, 0);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.RowHeadersWidth = 20;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(470, 622);
            this.dgvArchive.TabIndex = 10;
            // 
            // colArcIID
            // 
            this.colArcIID.DataPropertyName = "IID";
            this.colArcIID.HeaderText = "IID";
            this.colArcIID.Name = "colArcIID";
            this.colArcIID.ReadOnly = true;
            this.colArcIID.Visible = false;
            this.colArcIID.Width = 5;
            // 
            // colArcStartDate
            // 
            this.colArcStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colArcStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colArcStartDate.HeaderText = "Session Start @";
            this.colArcStartDate.Name = "colArcStartDate";
            this.colArcStartDate.ReadOnly = true;
            this.colArcStartDate.Width = 150;
            // 
            // colArcEndDate
            // 
            this.colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colArcEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colArcEndDate.HeaderText = "Session End @";
            this.colArcEndDate.Name = "colArcEndDate";
            this.colArcEndDate.ReadOnly = true;
            this.colArcEndDate.Width = 150;
            // 
            // cellArchivedGrossTotal
            // 
            this.cellArchivedGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.cellArchivedGrossTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.cellArchivedGrossTotal.HeaderText = "Gross Total";
            this.cellArchivedGrossTotal.Name = "cellArchivedGrossTotal";
            this.cellArchivedGrossTotal.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            this.sessionViewBindingSource.DataSource = typeof(DTRMNS.SessionView);
            // 
            // expArchivedSessions
            // 
            this.expArchivedSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expArchivedSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expArchivedSessions.Caption = "Archived Sessions";
            this.expArchivedSessions.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expArchivedSessions.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expArchivedSessions.CaptionForeColor = System.Drawing.Color.White;
            this.expArchivedSessions.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expArchivedSessions.ColourFixed = System.Drawing.Color.Salmon;
            this.expArchivedSessions.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expArchivedSessions.Dock = System.Windows.Forms.DockStyle.Right;
            this.expArchivedSessions.ExpandableControl = this.pnlArchivedSessions;
            this.expArchivedSessions.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expArchivedSessions.Expanded = true;
            this.expArchivedSessions.Fixed = false;
            this.expArchivedSessions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.expArchivedSessions.Location = new System.Drawing.Point(470, 0);
            this.expArchivedSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expArchivedSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expArchivedSessions.LockButtonVisible = false;
            this.expArchivedSessions.MinimumSize = new System.Drawing.Size(5, 5);
            this.expArchivedSessions.Name = "expArchivedSessions";
            this.expArchivedSessions.Size = new System.Drawing.Size(30, 690);
            this.expArchivedSessions.TabIndex = 11;
            // 
            // pnlArchivedSessions
            // 
            this.pnlArchivedSessions.Controls.Add(this.dgvArchive);
            this.pnlArchivedSessions.Controls.Add(this.pnlArchiveControl);
            this.pnlArchivedSessions.Controls.Add(this.expArchivedSessions);
            this.pnlArchivedSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlArchivedSessions.Location = new System.Drawing.Point(0, 0);
            this.pnlArchivedSessions.MaximumSize = new System.Drawing.Size(600, 0);
            this.pnlArchivedSessions.MinimumSize = new System.Drawing.Size(500, 0);
            this.pnlArchivedSessions.Name = "pnlArchivedSessions";
            this.pnlArchivedSessions.Size = new System.Drawing.Size(500, 690);
            this.pnlArchivedSessions.TabIndex = 12;
            // 
            // pnlArchiveControl
            // 
            this.pnlArchiveControl.Controls.Add(this.btnLoadSessions);
            this.pnlArchiveControl.Controls.Add(this.btnReloadArchive);
            this.pnlArchiveControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlArchiveControl.Location = new System.Drawing.Point(0, 622);
            this.pnlArchiveControl.Name = "pnlArchiveControl";
            this.pnlArchiveControl.Size = new System.Drawing.Size(470, 68);
            this.pnlArchiveControl.TabIndex = 12;
            // 
            // btnLoadSessions
            // 
            this.btnLoadSessions.Image = global::DTRMNS.Properties.Resources.FolderToDB32;
            this.btnLoadSessions.Location = new System.Drawing.Point(100, 6);
            this.btnLoadSessions.Name = "btnLoadSessions";
            this.btnLoadSessions.Size = new System.Drawing.Size(90, 56);
            this.btnLoadSessions.TabIndex = 5;
            this.btnLoadSessions.Text = "LOAD TO DB";
            this.btnLoadSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadSessions.UseVisualStyleBackColor = true;
            this.btnLoadSessions.Click += new System.EventHandler(this.btnLoadSessions_Click);
            // 
            // pnlSessions
            // 
            this.pnlSessions.Controls.Add(this.dgvDatabase);
            this.pnlSessions.Controls.Add(this.pnlDBControl);
            this.pnlSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSessions.Location = new System.Drawing.Point(500, 0);
            this.pnlSessions.MinimumSize = new System.Drawing.Size(500, 0);
            this.pnlSessions.Name = "pnlSessions";
            this.pnlSessions.Size = new System.Drawing.Size(500, 690);
            this.pnlSessions.TabIndex = 13;
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AllowUserToResizeRows = false;
            this.dgvDatabase.AutoGenerateColumns = false;
            this.dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbIID,
            this.colDBStartDate,
            this.colDBEndDate,
            this.grossSessionTotalDataGridViewTextBoxColumn});
            this.dgvDatabase.DataSource = this.sessionViewBindingSource1;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatabase.Location = new System.Drawing.Point(0, 0);
            this.dgvDatabase.MinimumSize = new System.Drawing.Size(500, 0);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            this.dgvDatabase.RowHeadersWidth = 20;
            this.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabase.Size = new System.Drawing.Size(500, 622);
            this.dgvDatabase.TabIndex = 0;
            // 
            // dbIID
            // 
            this.dbIID.DataPropertyName = "IID";
            this.dbIID.HeaderText = "IID";
            this.dbIID.Name = "dbIID";
            this.dbIID.ReadOnly = true;
            this.dbIID.Visible = false;
            this.dbIID.Width = 5;
            // 
            // colDBStartDate
            // 
            this.colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBStartDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDBStartDate.HeaderText = "Session Start @";
            this.colDBStartDate.Name = "colDBStartDate";
            this.colDBStartDate.ReadOnly = true;
            this.colDBStartDate.Width = 150;
            // 
            // colDBEndDate
            // 
            this.colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBEndDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDBEndDate.HeaderText = "Session End @";
            this.colDBEndDate.Name = "colDBEndDate";
            this.colDBEndDate.ReadOnly = true;
            this.colDBEndDate.Width = 150;
            // 
            // grossSessionTotalDataGridViewTextBoxColumn
            // 
            this.grossSessionTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.grossSessionTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.grossSessionTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            this.grossSessionTotalDataGridViewTextBoxColumn.Name = "grossSessionTotalDataGridViewTextBoxColumn";
            this.grossSessionTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionViewBindingSource1
            // 
            this.sessionViewBindingSource1.DataSource = typeof(DTRMNS.SessionView);
            // 
            // pnlDBControl
            // 
            this.pnlDBControl.Controls.Add(this.btnArchiveSessions);
            this.pnlDBControl.Controls.Add(this.btnClose);
            this.pnlDBControl.Controls.Add(this.btnPrint);
            this.pnlDBControl.Controls.Add(this.btnReloadDatabase);
            this.pnlDBControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDBControl.Location = new System.Drawing.Point(0, 622);
            this.pnlDBControl.Name = "pnlDBControl";
            this.pnlDBControl.Size = new System.Drawing.Size(500, 68);
            this.pnlDBControl.TabIndex = 1;
            // 
            // btnArchiveSessions
            // 
            this.btnArchiveSessions.Image = global::DTRMNS.Properties.Resources.DBToFolder32;
            this.btnArchiveSessions.Location = new System.Drawing.Point(102, 6);
            this.btnArchiveSessions.Name = "btnArchiveSessions";
            this.btnArchiveSessions.Size = new System.Drawing.Size(90, 56);
            this.btnArchiveSessions.TabIndex = 7;
            this.btnArchiveSessions.Text = "ARCHIVE";
            this.btnArchiveSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchiveSessions.UseVisualStyleBackColor = true;
            this.btnArchiveSessions.Click += new System.EventHandler(this.btnArchiveSessions_Click);
            // 
            // btnReloadDatabase
            // 
            this.btnReloadDatabase.Image = global::DTRMNS.Properties.Resources.Refresh_2;
            this.btnReloadDatabase.Location = new System.Drawing.Point(6, 6);
            this.btnReloadDatabase.Name = "btnReloadDatabase";
            this.btnReloadDatabase.Size = new System.Drawing.Size(90, 56);
            this.btnReloadDatabase.TabIndex = 6;
            this.btnReloadDatabase.Text = "RELOAD DB";
            this.btnReloadDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReloadDatabase.UseVisualStyleBackColor = true;
            this.btnReloadDatabase.Click += new System.EventHandler(this.btnReloadDatabase_Click);
            // 
            // frmReportArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 690);
            this.Controls.Add(this.pnlSessions);
            this.Controls.Add(this.pnlArchivedSessions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 39);
            this.Name = "frmReportArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REPORT ARCHIVE";
            this.Load += new System.EventHandler(this.frmReportArchive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).EndInit();
            this.pnlArchivedSessions.ResumeLayout(false);
            this.pnlArchiveControl.ResumeLayout(false);
            this.pnlSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource1)).EndInit();
            this.pnlDBControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReloadArchive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.BindingSource sessionViewBindingSource;
        private PosLibrary.Expander expArchivedSessions;
        private System.Windows.Forms.Panel pnlArchivedSessions;
        private System.Windows.Forms.Panel pnlSessions;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.BindingSource sessionViewBindingSource1;
        private System.Windows.Forms.Button btnReloadDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellArchivedGrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSessionTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlArchiveControl;
        private System.Windows.Forms.Panel pnlDBControl;
        private System.Windows.Forms.Button btnLoadSessions;
        private System.Windows.Forms.Button btnArchiveSessions;
    }
}