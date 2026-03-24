using POSLayer.Views;

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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributionList));
            dgv = new System.Windows.Forms.DataGridView();
            distributionViewBindingSource = new System.Windows.Forms.BindingSource(components);
            distributionBindingSource = new System.Windows.Forms.BindingSource(components);
            globalTypeViewBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            barMain = new System.Windows.Forms.ToolStrip();
            cmdAdd = new System.Windows.Forms.ToolStripButton();
            cmdEdit = new System.Windows.Forms.ToolStripButton();
            cmdDelete = new System.Windows.Forms.ToolStripButton();
            cmdReload = new System.Windows.Forms.ToolStripButton();
            cmdPrintList = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrinterNetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)globalTypeViewBindingSource).BeginInit();
            panel1.SuspendLayout();
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
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iIDDataGridViewTextBoxColumn, DistributionName, PrinterName, PrinterNetworkName, MenuName });
            dgv.DataSource = distributionViewBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(0, 54);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(1147, 564);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.CellPainting += dgv_CellPainting;
            // 
            // distributionViewBindingSource
            // 
            distributionViewBindingSource.DataSource = typeof(DistributionView);
            // 
            // distributionBindingSource
            // 
            distributionBindingSource.DataSource = typeof(POSLayer.Models.Distribution);
            // 
            // globalTypeViewBindingSource
            // 
            globalTypeViewBindingSource.DataSource = typeof(DistributionView);
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Location = new System.Drawing.Point(989, 12);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(146, 57);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Location = new System.Drawing.Point(843, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(146, 57);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 618);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(1147, 81);
            panel1.TabIndex = 44;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmdAdd, cmdEdit, cmdDelete, cmdReload, cmdPrintList, btnExportAsJson, btnImportFromJson });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(1147, 54);
            barMain.TabIndex = 45;
            barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            cmdAdd.Image = Properties.Resources.arti32;
            cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new System.Drawing.Size(60, 51);
            cmdAdd.Text = "Add New";
            cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdAdd.Click += btnAdd_Click;
            // 
            // cmdEdit
            // 
            cmdEdit.Image = Properties.Resources.MatReport_32;
            cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdEdit.Name = "cmdEdit";
            cmdEdit.Size = new System.Drawing.Size(36, 51);
            cmdEdit.Text = "Edit";
            cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdEdit.Click += btnEdit_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Image = Properties.Resources.eksi32;
            cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new System.Drawing.Size(44, 51);
            cmdDelete.Text = "Delete";
            cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdDelete.Click += btnDelete_Click;
            // 
            // cmdReload
            // 
            cmdReload.Image = Properties.Resources.Reload_32;
            cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdReload.Name = "cmdReload";
            cmdReload.Size = new System.Drawing.Size(47, 51);
            cmdReload.Text = "Reload";
            cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdReload.Click += btnReload_Click;
            // 
            // cmdPrintList
            // 
            cmdPrintList.Image = Properties.Resources.Printer32;
            cmdPrintList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdPrintList.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdPrintList.Name = "cmdPrintList";
            cmdPrintList.Size = new System.Drawing.Size(57, 51);
            cmdPrintList.Text = "Print List";
            cmdPrintList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdPrintList.Click += btnPrintList_Click;
            // 
            // btnExportAsJson
            // 
            btnExportAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportAsJson.Name = "btnExportAsJson";
            btnExportAsJson.Size = new System.Drawing.Size(75, 51);
            btnExportAsJson.Text = "JSON Export";
            btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportAsJson.Click += btnExportAsJson_Click;
            // 
            // btnImportFromJson
            // 
            btnImportFromJson.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportFromJson.Name = "btnImportFromJson";
            btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            btnImportFromJson.Text = "JSON Import";
            btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportFromJson.Click += btnImportFromJson_Click;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            iIDDataGridViewTextBoxColumn.ReadOnly = true;
            iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // DistributionName
            // 
            DistributionName.DataPropertyName = "DistributionName";
            DistributionName.HeaderText = "Name";
            DistributionName.Name = "DistributionName";
            DistributionName.ReadOnly = true;
            DistributionName.Width = 200;
            // 
            // PrinterName
            // 
            PrinterName.DataPropertyName = "PrinterName";
            PrinterName.HeaderText = "PrinterName";
            PrinterName.Name = "PrinterName";
            PrinterName.ReadOnly = true;
            PrinterName.Width = 200;
            // 
            // PrinterNetworkName
            // 
            PrinterNetworkName.DataPropertyName = "PrinterNetworkName";
            PrinterNetworkName.HeaderText = "PrinterNetworkName";
            PrinterNetworkName.Name = "PrinterNetworkName";
            PrinterNetworkName.ReadOnly = true;
            PrinterNetworkName.Width = 350;
            // 
            // MenuName
            // 
            MenuName.DataPropertyName = "MenuName";
            MenuName.HeaderText = "MenuName";
            MenuName.Name = "MenuName";
            MenuName.ReadOnly = true;
            MenuName.Width = 250;
            // 
            // frmDistributionList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1147, 699);
            Controls.Add(dgv);
            Controls.Add(barMain);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmDistributionList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Distributions";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmDistributionList_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)globalTypeViewBindingSource).EndInit();
            panel1.ResumeLayout(false);
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource globalTypeViewBindingSource;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.ToolStripButton cmdPrintList;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
        private System.Windows.Forms.BindingSource distributionViewBindingSource;
        private System.Windows.Forms.BindingSource distributionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistributionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
    }
}