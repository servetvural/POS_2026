using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmUserList {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserList));
            dgv = new System.Windows.Forms.DataGridView();
            colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            barMain = new System.Windows.Forms.ToolStrip();
            cmdAdd = new System.Windows.Forms.ToolStripButton();
            cmdEdit = new System.Windows.Forms.ToolStripButton();
            cmdDelete = new System.Windows.Forms.ToolStripButton();
            tsSort = new System.Windows.Forms.ToolStripButton();
            tsMoveUp = new System.Windows.Forms.ToolStripButton();
            tsMoveDown = new System.Windows.Forms.ToolStripButton();
            btnClose = new System.Windows.Forms.ToolStripButton();
            btnReload = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            barMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIID, userNameDataGridViewTextBoxColumn, userPasswordDataGridViewTextBoxColumn, colAccessLevel, DOrder });
            dgv.DataSource = userBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(0, 54);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(975, 389);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // colIID
            // 
            colIID.DataPropertyName = "IID";
            colIID.HeaderText = "IID";
            colIID.Name = "colIID";
            colIID.ReadOnly = true;
            colIID.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            userPasswordDataGridViewTextBoxColumn.DataPropertyName = "UserPassword";
            userPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            userPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colAccessLevel
            // 
            colAccessLevel.DataPropertyName = "AccessLevel";
            colAccessLevel.HeaderText = "AccessLevel";
            colAccessLevel.Name = "colAccessLevel";
            colAccessLevel.ReadOnly = true;
            // 
            // DOrder
            // 
            DOrder.DataPropertyName = "DOrder";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DOrder.DefaultCellStyle = dataGridViewCellStyle1;
            DOrder.HeaderText = "DOrder";
            DOrder.Name = "DOrder";
            DOrder.ReadOnly = true;
            DOrder.Width = 70;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmdAdd, cmdEdit, cmdDelete, btnReload, tsSort, tsMoveUp, tsMoveDown, btnClose });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(975, 54);
            barMain.TabIndex = 5;
            barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            cmdAdd.AutoSize = false;
            cmdAdd.Image = Properties.Resources.arti32;
            cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new System.Drawing.Size(60, 51);
            cmdAdd.Text = "Add User";
            cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdAdd.Click += btnAddUser_Click;
            // 
            // cmdEdit
            // 
            cmdEdit.AutoSize = false;
            cmdEdit.Image = Properties.Resources.MatReport_32;
            cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdEdit.Name = "cmdEdit";
            cmdEdit.Size = new System.Drawing.Size(60, 51);
            cmdEdit.Text = "Edit User";
            cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdEdit.Click += btnEditUser_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.AutoSize = false;
            cmdDelete.Image = Properties.Resources.eksi32;
            cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new System.Drawing.Size(60, 51);
            cmdDelete.Text = "Delete";
            cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdDelete.Click += btnDeleteUser_Click;
            // 
            // tsSort
            // 
            tsSort.AutoSize = false;
            tsSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSort.Image = Properties.Resources.updown;
            tsSort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSort.Name = "tsSort";
            tsSort.Size = new System.Drawing.Size(60, 51);
            tsSort.Text = "toolStripButton1";
            tsSort.Click += tsSort_Click;
            // 
            // tsMoveUp
            // 
            tsMoveUp.AutoSize = false;
            tsMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUp.Image = Properties.Resources.up2;
            tsMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUp.Name = "tsMoveUp";
            tsMoveUp.Size = new System.Drawing.Size(60, 51);
            tsMoveUp.Text = "toolStripButton1";
            tsMoveUp.Click += tsMoveUp_Click;
            // 
            // tsMoveDown
            // 
            tsMoveDown.AutoSize = false;
            tsMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDown.Image = Properties.Resources.down2;
            tsMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDown.Name = "tsMoveDown";
            tsMoveDown.Size = new System.Drawing.Size(60, 51);
            tsMoveDown.Text = "toolStripButton1";
            tsMoveDown.Click += tsMoveDown_Click;
            // 
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.AutoSize = false;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(60, 51);
            btnClose.Text = "Close";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.Click += btnClose_Click;
            // 
            // btnReload
            // 
            btnReload.AutoSize = false;
            btnReload.Image = Properties.Resources.Refresh_2;
            btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(60, 51);
            btnReload.Text = "Reload";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmUserList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(975, 443);
            Controls.Add(dgv);
            Controls.Add(barMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmUserList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Users";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmUserEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccessLevelAsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOrder;
        private System.Windows.Forms.ToolStripButton tsSort;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnReload;
    }
}