using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmPrinters {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinters));
            clientBindingSource = new System.Windows.Forms.BindingSource(components);
            dgv = new System.Windows.Forms.DataGridView();
            colPrinterIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrinterVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LocalTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            networkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrinterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            deliveryPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            takeAwayPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            adminOnlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(components);
            tsMain = new System.Windows.Forms.ToolStrip();
            btnAdd = new System.Windows.Forms.ToolStripButton();
            btnEdit = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            btnPrintTestPage = new System.Windows.Forms.ToolStripButton();
            btnExport = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).BeginInit();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colPrinterIID, applicationNameDataGridViewTextBoxColumn, PrinterVisibility, LocalTerminal, networkNameDataGridViewTextBoxColumn, colPrinterType, deliveryPrinterDataGridViewCheckBoxColumn, takeAwayPrinterDataGridViewCheckBoxColumn, adminOnlyDataGridViewCheckBoxColumn });
            dgv.DataSource = applicationPrinterBindingSource;
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
            dgv.Size = new System.Drawing.Size(1283, 606);
            dgv.TabIndex = 6;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // colPrinterIID
            // 
            colPrinterIID.DataPropertyName = "IID";
            colPrinterIID.HeaderText = "IID";
            colPrinterIID.Name = "colPrinterIID";
            colPrinterIID.ReadOnly = true;
            colPrinterIID.Visible = false;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            applicationNameDataGridViewTextBoxColumn.HeaderText = "Application Name";
            applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            applicationNameDataGridViewTextBoxColumn.ReadOnly = true;
            applicationNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // PrinterVisibility
            // 
            PrinterVisibility.DataPropertyName = "PrinterVisibility";
            PrinterVisibility.HeaderText = "Visibility";
            PrinterVisibility.Name = "PrinterVisibility";
            PrinterVisibility.ReadOnly = true;
            // 
            // LocalTerminal
            // 
            LocalTerminal.DataPropertyName = "LocalTerminal";
            LocalTerminal.HeaderText = "LocalTerminal";
            LocalTerminal.Name = "LocalTerminal";
            LocalTerminal.ReadOnly = true;
            LocalTerminal.Width = 120;
            // 
            // networkNameDataGridViewTextBoxColumn
            // 
            networkNameDataGridViewTextBoxColumn.DataPropertyName = "NetworkName";
            networkNameDataGridViewTextBoxColumn.HeaderText = "NetworkName";
            networkNameDataGridViewTextBoxColumn.Name = "networkNameDataGridViewTextBoxColumn";
            networkNameDataGridViewTextBoxColumn.ReadOnly = true;
            networkNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // colPrinterType
            // 
            colPrinterType.DataPropertyName = "PrinterType";
            colPrinterType.HeaderText = "Printer Type";
            colPrinterType.Name = "colPrinterType";
            colPrinterType.ReadOnly = true;
            // 
            // deliveryPrinterDataGridViewCheckBoxColumn
            // 
            deliveryPrinterDataGridViewCheckBoxColumn.DataPropertyName = "DeliveryPrinter";
            deliveryPrinterDataGridViewCheckBoxColumn.HeaderText = "Delivery";
            deliveryPrinterDataGridViewCheckBoxColumn.Name = "deliveryPrinterDataGridViewCheckBoxColumn";
            deliveryPrinterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // takeAwayPrinterDataGridViewCheckBoxColumn
            // 
            takeAwayPrinterDataGridViewCheckBoxColumn.DataPropertyName = "TakeAwayPrinter";
            takeAwayPrinterDataGridViewCheckBoxColumn.HeaderText = "TakeAway";
            takeAwayPrinterDataGridViewCheckBoxColumn.Name = "takeAwayPrinterDataGridViewCheckBoxColumn";
            takeAwayPrinterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // adminOnlyDataGridViewCheckBoxColumn
            // 
            adminOnlyDataGridViewCheckBoxColumn.DataPropertyName = "AdminOnly";
            adminOnlyDataGridViewCheckBoxColumn.HeaderText = "Admin Only";
            adminOnlyDataGridViewCheckBoxColumn.Name = "adminOnlyDataGridViewCheckBoxColumn";
            adminOnlyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // applicationPrinterBindingSource
            // 
            applicationPrinterBindingSource.DataSource = typeof(Printer);
            // 
            // tsMain
            // 
            tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnPrintTestPage, btnExport, btnExportAsJson, btnImportFromJson });
            tsMain.Location = new System.Drawing.Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new System.Drawing.Size(1283, 54);
            tsMain.TabIndex = 9;
            tsMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.arti32;
            btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(63, 51);
            btnAdd.Text = "Add New ";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.MatReport_32;
            btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(49, 51);
            btnEdit.Text = "   Edit   ";
            btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.eksi32;
            btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(62, 51);
            btnDelete.Text = "   Delete   ";
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrintTestPage
            // 
            btnPrintTestPage.Image = Properties.Resources.Printer32;
            btnPrintTestPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPrintTestPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPrintTestPage.Name = "btnPrintTestPage";
            btnPrintTestPage.Size = new System.Drawing.Size(63, 51);
            btnPrintTestPage.Text = " Print List ";
            btnPrintTestPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPrintTestPage.Click += btnPrintTestPage_Click;
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.ToTextFile_32;
            btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(56, 51);
            btnExport.Text = "  Export  ";
            btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExport.Click += btnExport_Click;
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
            // frmPrinters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1283, 660);
            Controls.Add(dgv);
            Controls.Add(tsMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmPrinters";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PRINTER LIST";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmPrinters_Load;
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource applicationPrinterBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnPrintTestPage;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterTypeAsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn takeAwayPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminOnlyDataGridViewCheckBoxColumn;
    }
}