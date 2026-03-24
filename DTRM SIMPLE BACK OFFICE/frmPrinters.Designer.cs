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
            applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            cmbLocalReceiptPrinter = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cmbDeliveryPrinter = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbCashDrawerPrinter = new System.Windows.Forms.ComboBox();
            cmbTakeAwayPrinter = new System.Windows.Forms.ComboBox();
            tsMain = new System.Windows.Forms.ToolStrip();
            btnAdd = new System.Windows.Forms.ToolStripButton();
            btnEdit = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            btnPrintTestPage = new System.Windows.Forms.ToolStripButton();
            btnExport = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            colPrinterIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            networkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrinterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            deliveryPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            takeAwayPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            adminOnlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colPrinterIID, colClient, applicationNameDataGridViewTextBoxColumn, networkNameDataGridViewTextBoxColumn, colPrinterType, deliveryPrinterDataGridViewCheckBoxColumn, takeAwayPrinterDataGridViewCheckBoxColumn, adminOnlyDataGridViewCheckBoxColumn });
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
            dgv.Size = new System.Drawing.Size(990, 362);
            dgv.TabIndex = 6;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // applicationPrinterBindingSource
            // 
            applicationPrinterBindingSource.DataSource = typeof(Printer);
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 582);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(990, 78);
            panel1.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(460, 20);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(93, 45);
            btnSave.TabIndex = 146;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbLocalReceiptPrinter);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbDeliveryPrinter);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbCashDrawerPrinter);
            panel2.Controls.Add(cmbTakeAwayPrinter);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 416);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(990, 166);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Arial", 9.75F);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(15, 91);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 16);
            label2.TabIndex = 148;
            label2.Text = "DELIVERY PRINTER";
            // 
            // cmbLocalReceiptPrinter
            // 
            cmbLocalReceiptPrinter.DataSource = applicationPrinterBindingSource;
            cmbLocalReceiptPrinter.DisplayMember = "ApplicationName";
            cmbLocalReceiptPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLocalReceiptPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbLocalReceiptPrinter.FormattingEnabled = true;
            cmbLocalReceiptPrinter.Location = new System.Drawing.Point(300, 113);
            cmbLocalReceiptPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbLocalReceiptPrinter.Name = "cmbLocalReceiptPrinter";
            cmbLocalReceiptPrinter.Size = new System.Drawing.Size(252, 32);
            cmbLocalReceiptPrinter.TabIndex = 151;
            cmbLocalReceiptPrinter.ValueMember = "IID";
            cmbLocalReceiptPrinter.SelectionChangeCommitted += cmbLocalReceiptPrinter_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 9.75F);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(300, 91);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(167, 16);
            label4.TabIndex = 149;
            label4.Text = "LOCAL RECEIPT PRINTER";
            // 
            // cmbDeliveryPrinter
            // 
            cmbDeliveryPrinter.DataSource = applicationPrinterBindingSource;
            cmbDeliveryPrinter.DisplayMember = "ApplicationName";
            cmbDeliveryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDeliveryPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbDeliveryPrinter.FormattingEnabled = true;
            cmbDeliveryPrinter.Location = new System.Drawing.Point(14, 113);
            cmbDeliveryPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbDeliveryPrinter.Name = "cmbDeliveryPrinter";
            cmbDeliveryPrinter.Size = new System.Drawing.Size(252, 32);
            cmbDeliveryPrinter.TabIndex = 150;
            cmbDeliveryPrinter.ValueMember = "IID";
            cmbDeliveryPrinter.SelectionChangeCommitted += cmbDeliveryPrinter_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Arial", 9.75F);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(15, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 16);
            label1.TabIndex = 144;
            label1.Text = "TAKE-AWAY PRINTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 9.75F);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(300, 16);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 16);
            label3.TabIndex = 145;
            label3.Text = "CASH DRAWER PRINTER";
            // 
            // cmbCashDrawerPrinter
            // 
            cmbCashDrawerPrinter.DataSource = applicationPrinterBindingSource;
            cmbCashDrawerPrinter.DisplayMember = "ApplicationName";
            cmbCashDrawerPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCashDrawerPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbCashDrawerPrinter.FormattingEnabled = true;
            cmbCashDrawerPrinter.Location = new System.Drawing.Point(300, 38);
            cmbCashDrawerPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbCashDrawerPrinter.Name = "cmbCashDrawerPrinter";
            cmbCashDrawerPrinter.Size = new System.Drawing.Size(252, 32);
            cmbCashDrawerPrinter.TabIndex = 147;
            cmbCashDrawerPrinter.ValueMember = "IID";
            cmbCashDrawerPrinter.SelectionChangeCommitted += cmbCashDrawerPrinter_SelectionChangeCommitted;
            // 
            // cmbTakeAwayPrinter
            // 
            cmbTakeAwayPrinter.DataSource = applicationPrinterBindingSource;
            cmbTakeAwayPrinter.DisplayMember = "ApplicationName";
            cmbTakeAwayPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTakeAwayPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbTakeAwayPrinter.FormattingEnabled = true;
            cmbTakeAwayPrinter.Location = new System.Drawing.Point(14, 38);
            cmbTakeAwayPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbTakeAwayPrinter.Name = "cmbTakeAwayPrinter";
            cmbTakeAwayPrinter.Size = new System.Drawing.Size(252, 32);
            cmbTakeAwayPrinter.TabIndex = 146;
            cmbTakeAwayPrinter.ValueMember = "IID";
            cmbTakeAwayPrinter.SelectionChangeCommitted += cmbTakeAwayPrinter_SelectionChangeCommitted;
            // 
            // tsMain
            // 
            tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnPrintTestPage, btnExport, btnExportAsJson, btnImportFromJson });
            tsMain.Location = new System.Drawing.Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new System.Drawing.Size(990, 54);
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
            // colPrinterIID
            // 
            colPrinterIID.DataPropertyName = "IID";
            colPrinterIID.HeaderText = "IID";
            colPrinterIID.Name = "colPrinterIID";
            colPrinterIID.ReadOnly = true;
            colPrinterIID.Visible = false;
            // 
            // colClient
            // 
            colClient.DataPropertyName = "ClientIID";
            colClient.HeaderText = "Client";
            colClient.Name = "colClient";
            colClient.ReadOnly = true;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            applicationNameDataGridViewTextBoxColumn.ReadOnly = true;
            applicationNameDataGridViewTextBoxColumn.Width = 200;
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
            // frmPrinters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(990, 660);
            Controls.Add(dgv);
            Controls.Add(tsMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmPrinters";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "LOCAL PRINTER  EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmPrinters_Load;
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource applicationPrinterBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCashDrawerPrinter;
        private System.Windows.Forms.ComboBox cmbTakeAwayPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocalReceiptPrinter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDeliveryPrinter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnPrintTestPage;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterTypeAsString;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn takeAwayPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminOnlyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterType;
    }
}