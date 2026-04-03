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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributionList));
            dgv = new System.Windows.Forms.DataGridView();
            iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FlatPrinterList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MenuNameReadOnly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            distributionBindingSource = new System.Windows.Forms.BindingSource(components);
            distributionViewBindingSource = new System.Windows.Forms.BindingSource(components);
            globalTypeViewBindingSource = new System.Windows.Forms.BindingSource(components);
            barMain = new System.Windows.Forms.ToolStrip();
            cmdAdd = new System.Windows.Forms.ToolStripButton();
            cmdEdit = new System.Windows.Forms.ToolStripButton();
            cmdDelete = new System.Windows.Forms.ToolStripButton();
            cmdReload = new System.Windows.Forms.ToolStripButton();
            cmdPrintList = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            btnClose = new System.Windows.Forms.ToolStripButton();
            tsSort = new System.Windows.Forms.ToolStripButton();
            tsMoveUp = new System.Windows.Forms.ToolStripButton();
            tsMoveDown = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            chkAllMenus = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            cmbMenu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)globalTypeViewBindingSource).BeginInit();
            barMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iIDDataGridViewTextBoxColumn, DistributionName, FlatPrinterList, MenuNameReadOnly, DOrder });
            dgv.DataSource = distributionBindingSource;
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
            dgv.Location = new System.Drawing.Point(0, 109);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(1147, 590);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.CellPainting += dgv_CellPainting;
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
            DistributionName.HeaderText = "Distribution Name";
            DistributionName.Name = "DistributionName";
            DistributionName.ReadOnly = true;
            DistributionName.Width = 200;
            // 
            // FlatPrinterList
            // 
            FlatPrinterList.DataPropertyName = "FlatPrinterList";
            FlatPrinterList.HeaderText = "Assigned Printers";
            FlatPrinterList.Name = "FlatPrinterList";
            FlatPrinterList.ReadOnly = true;
            FlatPrinterList.Width = 600;
            // 
            // MenuNameReadOnly
            // 
            MenuNameReadOnly.DataPropertyName = "MenuNameReadOnly";
            MenuNameReadOnly.HeaderText = "Menu";
            MenuNameReadOnly.Name = "MenuNameReadOnly";
            MenuNameReadOnly.ReadOnly = true;
            MenuNameReadOnly.Width = 200;
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
            // distributionBindingSource
            // 
            distributionBindingSource.DataSource = typeof(POSLayer.Models.Distribution);
            // 
            // distributionViewBindingSource
            // 
            distributionViewBindingSource.DataSource = typeof(DistributionView);
            // 
            // globalTypeViewBindingSource
            // 
            globalTypeViewBindingSource.DataSource = typeof(DistributionView);
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmdAdd, cmdEdit, cmdDelete, cmdReload, cmdPrintList, btnExportAsJson, btnImportFromJson, btnClose, tsSort, tsMoveUp, tsMoveDown });
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
            cmdEdit.AutoSize = false;
            cmdEdit.Image = Properties.Resources.MatReport_32;
            cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdEdit.Name = "cmdEdit";
            cmdEdit.Size = new System.Drawing.Size(60, 51);
            cmdEdit.Text = "Edit";
            cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdEdit.Click += btnEdit_Click;
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
            cmdDelete.Click += btnDelete_Click;
            // 
            // cmdReload
            // 
            cmdReload.AutoSize = false;
            cmdReload.Image = Properties.Resources.Refresh_2;
            cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdReload.Name = "cmdReload";
            cmdReload.Size = new System.Drawing.Size(60, 51);
            cmdReload.Text = "Reload";
            cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdReload.Click += btnReload_Click;
            // 
            // cmdPrintList
            // 
            cmdPrintList.AutoSize = false;
            cmdPrintList.Image = Properties.Resources.Printer32;
            cmdPrintList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdPrintList.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdPrintList.Name = "cmdPrintList";
            cmdPrintList.Size = new System.Drawing.Size(60, 51);
            cmdPrintList.Text = "Print List";
            cmdPrintList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdPrintList.Click += btnPrintList_Click;
            // 
            // btnExportAsJson
            // 
            btnExportAsJson.AutoSize = false;
            btnExportAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportAsJson.Name = "btnExportAsJson";
            btnExportAsJson.Size = new System.Drawing.Size(80, 51);
            btnExportAsJson.Text = "JSON Export";
            btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportAsJson.Click += btnExportAsJson_Click;
            // 
            // btnImportFromJson
            // 
            btnImportFromJson.AutoSize = false;
            btnImportFromJson.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportFromJson.Name = "btnImportFromJson";
            btnImportFromJson.Size = new System.Drawing.Size(80, 51);
            btnImportFromJson.Text = "JSON Import";
            btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportFromJson.Click += btnImportFromJson_Click;
            // 
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.AutoSize = false;
            btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(60, 51);
            btnClose.Text = "toolStripButton1";
            btnClose.Click += btnClose_Click;
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
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Window;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(chkAllMenus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbMenu);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1147, 55);
            panel1.TabIndex = 46;
            // 
            // chkAllMenus
            // 
            chkAllMenus.AutoSize = true;
            chkAllMenus.Font = new System.Drawing.Font("Segoe UI", 11F);
            chkAllMenus.Location = new System.Drawing.Point(467, 15);
            chkAllMenus.Name = "chkAllMenus";
            chkAllMenus.Size = new System.Drawing.Size(93, 24);
            chkAllMenus.TabIndex = 2;
            chkAllMenus.Text = "All Menus";
            chkAllMenus.UseVisualStyleBackColor = true;
            chkAllMenus.CheckedChanged += chkAllMenus_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // cmbMenu
            // 
            cmbMenu.DisplayMember = "IID";
            cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new System.Drawing.Point(79, 12);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new System.Drawing.Size(346, 28);
            cmbMenu.TabIndex = 0;
            cmbMenu.ValueMember = "IID";
            cmbMenu.SelectionChangeCommitted += cmbMenu_SelectionChangeCommitted;
            // 
            // frmDistributionList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1147, 699);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Controls.Add(barMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmDistributionList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Distributions";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmDistributionList_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)globalTypeViewBindingSource).EndInit();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton tsSort;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistributionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatPrinterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuNameReadOnly;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAllMenus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
    }
}