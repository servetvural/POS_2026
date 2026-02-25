namespace DTRMSimpleBackOffice {
    partial class frmDistributionList {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributionList));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentMenuIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterNetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdReload = new System.Windows.Forms.ToolStripButton();
            this.cmdPrintList = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalTypeViewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.barMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.globalTypeNameDataGridViewTextBoxColumn,
            this.ShortNameDataGridViewTextBoxColumn,
            this.parentMenuIIDDataGridViewTextBoxColumn,
            this.displayOrderDataGridViewTextBoxColumn,
            this.PrinterNetworkName,
            this.catalogNameDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.globalTypeViewBindingSource;
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
            this.dgv.Location = new System.Drawing.Point(0, 54);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(843, 432);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // globalTypeNameDataGridViewTextBoxColumn
            // 
            this.globalTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DistributionName";
            this.globalTypeNameDataGridViewTextBoxColumn.HeaderText = "Distribution Type";
            this.globalTypeNameDataGridViewTextBoxColumn.Name = "globalTypeNameDataGridViewTextBoxColumn";
            this.globalTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.globalTypeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ShortNameDataGridViewTextBoxColumn
            // 
            this.ShortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.ShortNameDataGridViewTextBoxColumn.HeaderText = "Short Name";
            this.ShortNameDataGridViewTextBoxColumn.Name = "ShortNameDataGridViewTextBoxColumn";
            this.ShortNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentMenuIIDDataGridViewTextBoxColumn
            // 
            this.parentMenuIIDDataGridViewTextBoxColumn.DataPropertyName = "ParentMenuIID";
            this.parentMenuIIDDataGridViewTextBoxColumn.HeaderText = "ParentMenuIID";
            this.parentMenuIIDDataGridViewTextBoxColumn.Name = "parentMenuIIDDataGridViewTextBoxColumn";
            this.parentMenuIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentMenuIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // displayOrderDataGridViewTextBoxColumn
            // 
            this.displayOrderDataGridViewTextBoxColumn.DataPropertyName = "DisplayOrder";
            this.displayOrderDataGridViewTextBoxColumn.HeaderText = "DisplayOrder";
            this.displayOrderDataGridViewTextBoxColumn.Name = "displayOrderDataGridViewTextBoxColumn";
            this.displayOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // PrinterNetworkName
            // 
            this.PrinterNetworkName.DataPropertyName = "PrinterNetworkName";
            this.PrinterNetworkName.HeaderText = "Printer Name";
            this.PrinterNetworkName.Name = "PrinterNetworkName";
            this.PrinterNetworkName.ReadOnly = true;
            this.PrinterNetworkName.Width = 250;
            // 
            // catalogNameDataGridViewTextBoxColumn
            // 
            this.catalogNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName";
            this.catalogNameDataGridViewTextBoxColumn.HeaderText = "MenuName";
            this.catalogNameDataGridViewTextBoxColumn.Name = "catalogNameDataGridViewTextBoxColumn";
            this.catalogNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.catalogNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // globalTypeViewBindingSource
            // 
            this.globalTypeViewBindingSource.DataSource = typeof(DTRMNS.DistributionView);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.Location = new System.Drawing.Point(708, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(583, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(843, 70);
            this.panel1.TabIndex = 44;
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDelete,
            this.cmdReload,
            this.cmdPrintList});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(843, 54);
            this.barMain.TabIndex = 45;
            this.barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(60, 51);
            this.cmdAdd.Text = "Add New";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(36, 51);
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(44, 51);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Reload_32;
            this.cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(47, 51);
            this.cmdReload.Text = "Reload";
            this.cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cmdPrintList
            // 
            this.cmdPrintList.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.cmdPrintList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdPrintList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrintList.Name = "cmdPrintList";
            this.cmdPrintList.Size = new System.Drawing.Size(57, 51);
            this.cmdPrintList.Text = "Print List";
            this.cmdPrintList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // frmDistributionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 556);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.barMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDistributionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Distributions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDistributionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalTypeViewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource globalTypeViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn globalTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentMenuIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.ToolStripButton cmdPrintList;
        private System.Windows.Forms.ToolStrip barMain;
    }
}