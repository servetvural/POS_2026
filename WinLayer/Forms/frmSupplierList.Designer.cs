using POSLayer.Models;

namespace WinLayer {
    partial class frmSupplierList {
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierList));
            dgv = new DataGridView();
            supplierBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnSelect = new Button();
            btnClose = new Button();
            btnSave = new Button();
            barMain = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnReload = new ToolStripButton();
            btnExportAsJson = new ToolStripButton();
            btnImportFromJson = new ToolStripButton();
            tsSort = new ToolStripButton();
            tsMoveUp = new ToolStripButton();
            tsMoveDown = new ToolStripButton();
            btnClose2 = new ToolStripButton();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Prefix = new DataGridViewTextBoxColumn();
            telDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            email1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            whatsupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DOrder = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            panel1.SuspendLayout();
            barMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { supplierNameDataGridViewTextBoxColumn, Prefix, telDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, email1DataGridViewTextBoxColumn, whatsupDataGridViewTextBoxColumn, DOrder });
            dgv.DataSource = supplierBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.FromArgb(208, 215, 229);
            dgv.Location = new Point(0, 54);
            dgv.Margin = new Padding(4, 3, 4, 3);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(987, 359);
            dgv.TabIndex = 6;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Supplier);
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 413);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(987, 81);
            panel1.TabIndex = 45;
            // 
            // btnSelect
            // 
            btnSelect.Dock = DockStyle.Right;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSelect.ForeColor = SystemColors.ControlText;
            btnSelect.Image = Properties.Resources.tickgreen;
            btnSelect.Location = new Point(537, 12);
            btnSelect.Margin = new Padding(4, 3, 20, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(146, 57);
            btnSelect.TabIndex = 44;
            btnSelect.Text = "SELECT";
            btnSelect.TextAlign = ContentAlignment.MiddleRight;
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.Location = new Point(683, 12);
            btnClose.Margin = new Padding(4, 3, 20, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 57);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSave.Image = Properties.Resources.save32;
            btnSave.Location = new Point(829, 12);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 57);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnReload, btnExportAsJson, btnImportFromJson, tsSort, tsMoveUp, tsMoveDown, btnClose2 });
            barMain.Location = new Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new Size(987, 54);
            barMain.TabIndex = 54;
            barMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.arti32;
            btnAdd.ImageScaling = ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 51);
            btnAdd.Text = "ADD  NEW";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.MatReport_32;
            btnEdit.ImageScaling = ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(53, 51);
            btnEdit.Text = "   EDIT   ";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.eksi32;
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(68, 51);
            btnDelete.Text = "   DELETE   ";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Refresh_2;
            btnReload.ImageScaling = ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(70, 51);
            btnReload.Text = "   RELOAD  ";
            btnReload.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
            // 
            // btnExportAsJson
            // 
            btnExportAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportAsJson.ImageScaling = ToolStripItemImageScaling.None;
            btnExportAsJson.ImageTransparentColor = Color.Magenta;
            btnExportAsJson.Name = "btnExportAsJson";
            btnExportAsJson.Size = new Size(75, 51);
            btnExportAsJson.Text = "JSON Export";
            btnExportAsJson.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExportAsJson.Click += btnExportAsJson_Click;
            // 
            // btnImportFromJson
            // 
            btnImportFromJson.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportFromJson.ImageScaling = ToolStripItemImageScaling.None;
            btnImportFromJson.ImageTransparentColor = Color.Magenta;
            btnImportFromJson.Name = "btnImportFromJson";
            btnImportFromJson.Size = new Size(78, 51);
            btnImportFromJson.Text = "JSON Import";
            btnImportFromJson.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImportFromJson.Click += btnImportFromJson_Click;
            // 
            // tsSort
            // 
            tsSort.AutoSize = false;
            tsSort.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsSort.Image = Properties.Resources.updown;
            tsSort.ImageScaling = ToolStripItemImageScaling.None;
            tsSort.ImageTransparentColor = Color.Magenta;
            tsSort.Name = "tsSort";
            tsSort.Size = new Size(60, 51);
            tsSort.Text = "toolStripButton1";
            tsSort.Click += tsSort_Click;
            // 
            // tsMoveUp
            // 
            tsMoveUp.AutoSize = false;
            tsMoveUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsMoveUp.Image = Properties.Resources.up2;
            tsMoveUp.ImageScaling = ToolStripItemImageScaling.None;
            tsMoveUp.ImageTransparentColor = Color.Magenta;
            tsMoveUp.Name = "tsMoveUp";
            tsMoveUp.Size = new Size(60, 51);
            tsMoveUp.Text = "toolStripButton1";
            tsMoveUp.Click += tsMoveUp_Click;
            // 
            // tsMoveDown
            // 
            tsMoveDown.AutoSize = false;
            tsMoveDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsMoveDown.Image = Properties.Resources.down2;
            tsMoveDown.ImageScaling = ToolStripItemImageScaling.None;
            tsMoveDown.ImageTransparentColor = Color.Magenta;
            tsMoveDown.Name = "tsMoveDown";
            tsMoveDown.Size = new Size(60, 51);
            tsMoveDown.Text = "toolStripButton1";
            tsMoveDown.Click += tsMoveDown_Click;
            // 
            // btnClose2
            // 
            btnClose2.Alignment = ToolStripItemAlignment.Right;
            btnClose2.AutoSize = false;
            btnClose2.Image = Properties.Resources.Cancel;
            btnClose2.ImageScaling = ToolStripItemImageScaling.None;
            btnClose2.ImageTransparentColor = Color.Magenta;
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(60, 51);
            btnClose2.Text = "Close";
            btnClose2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClose2.Click += btnClose_Click;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            supplierNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Prefix
            // 
            Prefix.DataPropertyName = "Prefix";
            Prefix.HeaderText = "Prefix";
            Prefix.Name = "Prefix";
            Prefix.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            telDataGridViewTextBoxColumn.HeaderText = "Tel";
            telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            telDataGridViewTextBoxColumn.ReadOnly = true;
            telDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // email1DataGridViewTextBoxColumn
            // 
            email1DataGridViewTextBoxColumn.DataPropertyName = "Email1";
            email1DataGridViewTextBoxColumn.HeaderText = "Email1";
            email1DataGridViewTextBoxColumn.Name = "email1DataGridViewTextBoxColumn";
            email1DataGridViewTextBoxColumn.ReadOnly = true;
            email1DataGridViewTextBoxColumn.Width = 200;
            // 
            // whatsupDataGridViewTextBoxColumn
            // 
            whatsupDataGridViewTextBoxColumn.DataPropertyName = "Whatsup";
            whatsupDataGridViewTextBoxColumn.HeaderText = "Whatsup";
            whatsupDataGridViewTextBoxColumn.Name = "whatsupDataGridViewTextBoxColumn";
            whatsupDataGridViewTextBoxColumn.ReadOnly = true;
            whatsupDataGridViewTextBoxColumn.Width = 130;
            // 
            // DOrder
            // 
            DOrder.DataPropertyName = "DOrder";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DOrder.DefaultCellStyle = dataGridViewCellStyle1;
            DOrder.HeaderText = "DOrder";
            DOrder.Name = "DOrder";
            DOrder.ReadOnly = true;
            DOrder.Width = 70;
            // 
            // frmSupplierList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 494);
            Controls.Add(dgv);
            Controls.Add(barMain);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSupplierList";
            Text = "SUPPLIERS";
            Load += frmSupplierList_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            panel1.ResumeLayout(false);
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
        private System.Windows.Forms.ToolStripButton tsSort;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.ToolStripButton btnClose2;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Prefix;
        private DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn email1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whatsupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DOrder;
    }
}