using POSLayer.Models;

namespace BSLayer {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierList));
            dgv = new System.Windows.Forms.DataGridView();
            colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            email1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            email2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            whatsupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            btnSelect = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            barMain = new System.Windows.Forms.ToolStrip();
            btnAdd = new System.Windows.Forms.ToolStripButton();
            btnEdit = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            btnReload = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            tsSort = new System.Windows.Forms.ToolStripButton();
            tsMoveUp = new System.Windows.Forms.ToolStripButton();
            tsMoveDown = new System.Windows.Forms.ToolStripButton();
            btnClose2 = new System.Windows.Forms.ToolStripButton();
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
            dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIID, supplierNameDataGridViewTextBoxColumn, telDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, email1DataGridViewTextBoxColumn, email2DataGridViewTextBoxColumn, whatsupDataGridViewTextBoxColumn, DOrder });
            dgv.DataSource = supplierBindingSource;
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
            dgv.Size = new System.Drawing.Size(987, 359);
            dgv.TabIndex = 6;
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
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            supplierNameDataGridViewTextBoxColumn.Width = 200;
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
            // email2DataGridViewTextBoxColumn
            // 
            email2DataGridViewTextBoxColumn.DataPropertyName = "Email2";
            email2DataGridViewTextBoxColumn.HeaderText = "Email2";
            email2DataGridViewTextBoxColumn.Name = "email2DataGridViewTextBoxColumn";
            email2DataGridViewTextBoxColumn.ReadOnly = true;
            email2DataGridViewTextBoxColumn.Width = 200;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DOrder.DefaultCellStyle = dataGridViewCellStyle1;
            DOrder.HeaderText = "DOrder";
            DOrder.Name = "DOrder";
            DOrder.ReadOnly = true;
            DOrder.Width = 70;
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
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 413);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(987, 81);
            panel1.TabIndex = 45;
            // 
            // btnSelect
            // 
            btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSelect.Image = Properties.Resources.tickgreen;
            btnSelect.Location = new System.Drawing.Point(537, 12);
            btnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(146, 57);
            btnSelect.TabIndex = 44;
            btnSelect.Text = "SELECT";
            btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.Location = new System.Drawing.Point(683, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(146, 57);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Image = Properties.Resources.save32;
            btnSave.Location = new System.Drawing.Point(829, 12);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(146, 57);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnReload, btnExportAsJson, btnImportFromJson, tsSort, tsMoveUp, tsMoveDown, btnClose2 });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(987, 54);
            barMain.TabIndex = 54;
            barMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.arti32;
            btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(67, 51);
            btnAdd.Text = "ADD  NEW";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.MatReport_32;
            btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(53, 51);
            btnEdit.Text = "   EDIT   ";
            btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.eksi32;
            btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(68, 51);
            btnDelete.Text = "   DELETE   ";
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Refresh_2;
            btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(70, 51);
            btnReload.Text = "   RELOAD  ";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
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
            // btnClose2
            // 
            btnClose2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose2.AutoSize = false;
            btnClose2.Image = Properties.Resources.Cancel;
            btnClose2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClose2.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new System.Drawing.Size(60, 51);
            btnClose2.Text = "Close";
            btnClose2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose2.Click += btnClose_Click;
            // 
            // frmSupplierList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(987, 494);
            Controls.Add(dgv);
            Controls.Add(barMain);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatsupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOrder;
        private System.Windows.Forms.ToolStripButton btnClose2;
    }
}