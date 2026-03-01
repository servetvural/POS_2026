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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportArchive));
            btnPrint = new System.Windows.Forms.Button();
            btnReloadArchive = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dgvArchive = new System.Windows.Forms.DataGridView();
            colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellArchivedGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionViewBindingSource = new System.Windows.Forms.BindingSource(components);
            expArchivedSessions = new PosLibrary.Expander();
            pnlArchivedSessions = new System.Windows.Forms.Panel();
            pnlArchiveControl = new System.Windows.Forms.Panel();
            btnLoadSessions = new System.Windows.Forms.Button();
            pnlSessions = new System.Windows.Forms.Panel();
            dgvDatabase = new System.Windows.Forms.DataGridView();
            dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grossSessionTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionViewBindingSource1 = new System.Windows.Forms.BindingSource(components);
            pnlDBControl = new System.Windows.Forms.Panel();
            btnArchiveSessions = new System.Windows.Forms.Button();
            btnReloadDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).BeginInit();
            pnlArchivedSessions.SuspendLayout();
            pnlArchiveControl.SuspendLayout();
            pnlSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource1).BeginInit();
            pnlDBControl.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.Print32;
            btnPrint.Location = new System.Drawing.Point(231, 7);
            btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(139, 65);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "PRINT Z REPORTS";
            btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnReloadArchive
            // 
            btnReloadArchive.Image = Properties.Resources.Refresh_2;
            btnReloadArchive.Location = new System.Drawing.Point(4, 7);
            btnReloadArchive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReloadArchive.Name = "btnReloadArchive";
            btnReloadArchive.Size = new System.Drawing.Size(105, 65);
            btnReloadArchive.TabIndex = 4;
            btnReloadArchive.Text = "RELOAD Z";
            btnReloadArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReloadArchive.UseVisualStyleBackColor = true;
            btnReloadArchive.Click += btnReloadArchive_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.Location = new System.Drawing.Point(377, 7);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(107, 65);
            btnClose.TabIndex = 3;
            btnClose.Text = "CLOSE";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle4;
            dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchive.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvArchive.Location = new System.Drawing.Point(0, 0);
            dgvArchive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersWidth = 20;
            dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.Size = new System.Drawing.Size(548, 718);
            dgvArchive.TabIndex = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            colArcStartDate.HeaderText = "Session Start @";
            colArcStartDate.Name = "colArcStartDate";
            colArcStartDate.ReadOnly = true;
            colArcStartDate.Width = 150;
            // 
            // colArcEndDate
            // 
            colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            colArcEndDate.HeaderText = "Session End @";
            colArcEndDate.Name = "colArcEndDate";
            colArcEndDate.ReadOnly = true;
            colArcEndDate.Width = 150;
            // 
            // cellArchivedGrossTotal
            // 
            cellArchivedGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            cellArchivedGrossTotal.DefaultCellStyle = dataGridViewCellStyle3;
            cellArchivedGrossTotal.HeaderText = "Gross Total";
            cellArchivedGrossTotal.Name = "cellArchivedGrossTotal";
            cellArchivedGrossTotal.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            sessionViewBindingSource.DataSource = typeof(SessionView);
            // 
            // expArchivedSessions
            // 
            expArchivedSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expArchivedSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expArchivedSessions.Dock = System.Windows.Forms.DockStyle.Right;
            expArchivedSessions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            expArchivedSessions.Location = new System.Drawing.Point(548, 0);
            expArchivedSessions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expArchivedSessions.MinimumSize = new System.Drawing.Size(6, 5);
            expArchivedSessions.Name = "expArchivedSessions";
            expArchivedSessions.Size = new System.Drawing.Size(35, 796);
            expArchivedSessions.TabIndex = 11;
            // 
            // pnlArchivedSessions
            // 
            pnlArchivedSessions.Controls.Add(dgvArchive);
            pnlArchivedSessions.Controls.Add(pnlArchiveControl);
            pnlArchivedSessions.Controls.Add(expArchivedSessions);
            pnlArchivedSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlArchivedSessions.Location = new System.Drawing.Point(0, 0);
            pnlArchivedSessions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlArchivedSessions.MaximumSize = new System.Drawing.Size(700, 0);
            pnlArchivedSessions.MinimumSize = new System.Drawing.Size(583, 0);
            pnlArchivedSessions.Name = "pnlArchivedSessions";
            pnlArchivedSessions.Size = new System.Drawing.Size(583, 796);
            pnlArchivedSessions.TabIndex = 12;
            // 
            // pnlArchiveControl
            // 
            pnlArchiveControl.Controls.Add(btnLoadSessions);
            pnlArchiveControl.Controls.Add(btnReloadArchive);
            pnlArchiveControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlArchiveControl.Location = new System.Drawing.Point(0, 718);
            pnlArchiveControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlArchiveControl.Name = "pnlArchiveControl";
            pnlArchiveControl.Size = new System.Drawing.Size(548, 78);
            pnlArchiveControl.TabIndex = 12;
            // 
            // btnLoadSessions
            // 
            btnLoadSessions.Image = Properties.Resources.FolderToDB32;
            btnLoadSessions.Location = new System.Drawing.Point(117, 7);
            btnLoadSessions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadSessions.Name = "btnLoadSessions";
            btnLoadSessions.Size = new System.Drawing.Size(105, 65);
            btnLoadSessions.TabIndex = 5;
            btnLoadSessions.Text = "LOAD TO DB";
            btnLoadSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadSessions.UseVisualStyleBackColor = true;
            btnLoadSessions.Click += btnLoadSessions_Click;
            // 
            // pnlSessions
            // 
            pnlSessions.Controls.Add(dgvDatabase);
            pnlSessions.Controls.Add(pnlDBControl);
            pnlSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSessions.Location = new System.Drawing.Point(583, 0);
            pnlSessions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSessions.MinimumSize = new System.Drawing.Size(583, 0);
            pnlSessions.Name = "pnlSessions";
            pnlSessions.Size = new System.Drawing.Size(583, 796);
            pnlSessions.TabIndex = 13;
            // 
            // dgvDatabase
            // 
            dgvDatabase.AllowUserToAddRows = false;
            dgvDatabase.AllowUserToDeleteRows = false;
            dgvDatabase.AllowUserToResizeRows = false;
            dgvDatabase.AutoGenerateColumns = false;
            dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dbIID, colDBStartDate, colDBEndDate, grossSessionTotalDataGridViewTextBoxColumn });
            dgvDatabase.DataSource = sessionViewBindingSource1;
            dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDatabase.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvDatabase.Location = new System.Drawing.Point(0, 0);
            dgvDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvDatabase.MinimumSize = new System.Drawing.Size(583, 0);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.ReadOnly = true;
            dgvDatabase.RowHeadersWidth = 20;
            dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDatabase.Size = new System.Drawing.Size(583, 718);
            dgvDatabase.TabIndex = 0;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBStartDate.DefaultCellStyle = dataGridViewCellStyle5;
            colDBStartDate.HeaderText = "Session Start @";
            colDBStartDate.Name = "colDBStartDate";
            colDBStartDate.ReadOnly = true;
            colDBStartDate.Width = 150;
            // 
            // colDBEndDate
            // 
            colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBEndDate.DefaultCellStyle = dataGridViewCellStyle6;
            colDBEndDate.HeaderText = "Session End @";
            colDBEndDate.Name = "colDBEndDate";
            colDBEndDate.ReadOnly = true;
            colDBEndDate.Width = 150;
            // 
            // grossSessionTotalDataGridViewTextBoxColumn
            // 
            grossSessionTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            grossSessionTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            grossSessionTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            grossSessionTotalDataGridViewTextBoxColumn.Name = "grossSessionTotalDataGridViewTextBoxColumn";
            grossSessionTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionViewBindingSource1
            // 
            sessionViewBindingSource1.DataSource = typeof(SessionView);
            // 
            // pnlDBControl
            // 
            pnlDBControl.Controls.Add(btnArchiveSessions);
            pnlDBControl.Controls.Add(btnClose);
            pnlDBControl.Controls.Add(btnPrint);
            pnlDBControl.Controls.Add(btnReloadDatabase);
            pnlDBControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlDBControl.Location = new System.Drawing.Point(0, 718);
            pnlDBControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDBControl.Name = "pnlDBControl";
            pnlDBControl.Size = new System.Drawing.Size(583, 78);
            pnlDBControl.TabIndex = 1;
            // 
            // btnArchiveSessions
            // 
            btnArchiveSessions.Image = Properties.Resources.DBToFolder32;
            btnArchiveSessions.Location = new System.Drawing.Point(119, 7);
            btnArchiveSessions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnArchiveSessions.Name = "btnArchiveSessions";
            btnArchiveSessions.Size = new System.Drawing.Size(105, 65);
            btnArchiveSessions.TabIndex = 7;
            btnArchiveSessions.Text = "ARCHIVE";
            btnArchiveSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnArchiveSessions.UseVisualStyleBackColor = true;
            btnArchiveSessions.Click += btnArchiveSessions_Click;
            // 
            // btnReloadDatabase
            // 
            btnReloadDatabase.Image = Properties.Resources.Refresh_2;
            btnReloadDatabase.Location = new System.Drawing.Point(7, 7);
            btnReloadDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReloadDatabase.Name = "btnReloadDatabase";
            btnReloadDatabase.Size = new System.Drawing.Size(105, 65);
            btnReloadDatabase.TabIndex = 6;
            btnReloadDatabase.Text = "RELOAD DB";
            btnReloadDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReloadDatabase.UseVisualStyleBackColor = true;
            btnReloadDatabase.Click += btnReloadDatabase_Click;
            // 
            // frmReportArchive
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 796);
            Controls.Add(pnlSessions);
            Controls.Add(pnlArchivedSessions);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1164, 39);
            Name = "frmReportArchive";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "REPORT ARCHIVE";
            Load += frmReportArchive_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).EndInit();
            pnlArchivedSessions.ResumeLayout(false);
            pnlArchiveControl.ResumeLayout(false);
            pnlSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource1).EndInit();
            pnlDBControl.ResumeLayout(false);
            ResumeLayout(false);

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