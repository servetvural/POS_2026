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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinters));
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colPrinterIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrinterTypeAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.takeAwayPrinterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminOnlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocalReceiptPrinter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDeliveryPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCashDrawerPrinter = new System.Windows.Forms.ComboBox();
            this.cmbTakeAwayPrinter = new System.Windows.Forms.ComboBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.chkAllPrinters = new System.Windows.Forms.ToolStripButton();
            this.btnPrintTestPage = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tsMain.SuspendLayout();
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
            this.colPrinterIID,
            this.applicationNameDataGridViewTextBoxColumn,
            this.networkNameDataGridViewTextBoxColumn,
            this.colPrinterTypeAsString,
            this.deliveryPrinterDataGridViewCheckBoxColumn,
            this.takeAwayPrinterDataGridViewCheckBoxColumn,
            this.adminOnlyDataGridViewCheckBoxColumn,
            this.colClient});
            this.dgv.DataSource = this.applicationPrinterBindingSource;
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
            this.dgv.Size = new System.Drawing.Size(849, 306);
            this.dgv.TabIndex = 6;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // colPrinterIID
            // 
            this.colPrinterIID.DataPropertyName = "IID";
            this.colPrinterIID.HeaderText = "IID";
            this.colPrinterIID.Name = "colPrinterIID";
            this.colPrinterIID.ReadOnly = true;
            this.colPrinterIID.Visible = false;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            this.applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            this.applicationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // networkNameDataGridViewTextBoxColumn
            // 
            this.networkNameDataGridViewTextBoxColumn.DataPropertyName = "NetworkName";
            this.networkNameDataGridViewTextBoxColumn.HeaderText = "NetworkName";
            this.networkNameDataGridViewTextBoxColumn.Name = "networkNameDataGridViewTextBoxColumn";
            this.networkNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.networkNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // colPrinterTypeAsString
            // 
            this.colPrinterTypeAsString.DataPropertyName = "PrinterTypeAsString";
            this.colPrinterTypeAsString.HeaderText = "Printer Type";
            this.colPrinterTypeAsString.Name = "colPrinterTypeAsString";
            this.colPrinterTypeAsString.ReadOnly = true;
            // 
            // deliveryPrinterDataGridViewCheckBoxColumn
            // 
            this.deliveryPrinterDataGridViewCheckBoxColumn.DataPropertyName = "DeliveryPrinter";
            this.deliveryPrinterDataGridViewCheckBoxColumn.HeaderText = "Delivery";
            this.deliveryPrinterDataGridViewCheckBoxColumn.Name = "deliveryPrinterDataGridViewCheckBoxColumn";
            this.deliveryPrinterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // takeAwayPrinterDataGridViewCheckBoxColumn
            // 
            this.takeAwayPrinterDataGridViewCheckBoxColumn.DataPropertyName = "TakeAwayPrinter";
            this.takeAwayPrinterDataGridViewCheckBoxColumn.HeaderText = "TakeAway";
            this.takeAwayPrinterDataGridViewCheckBoxColumn.Name = "takeAwayPrinterDataGridViewCheckBoxColumn";
            this.takeAwayPrinterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // adminOnlyDataGridViewCheckBoxColumn
            // 
            this.adminOnlyDataGridViewCheckBoxColumn.DataPropertyName = "AdminOnly";
            this.adminOnlyDataGridViewCheckBoxColumn.HeaderText = "Admin Only";
            this.adminOnlyDataGridViewCheckBoxColumn.Name = "adminOnlyDataGridViewCheckBoxColumn";
            this.adminOnlyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "ClientIID";
            this.colClient.HeaderText = "ClientIID";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Visible = false;
            // 
            // applicationPrinterBindingSource
            // 
            this.applicationPrinterBindingSource.DataSource = typeof(DTRMNS.ApplicationPrinter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 68);
            this.panel1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbLocalReceiptPrinter);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbDeliveryPrinter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbCashDrawerPrinter);
            this.panel2.Controls.Add(this.cmbTakeAwayPrinter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 144);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 148;
            this.label2.Text = "DELIVERY PRINTER";
            // 
            // cmbLocalReceiptPrinter
            // 
            this.cmbLocalReceiptPrinter.DataSource = this.applicationPrinterBindingSource;
            this.cmbLocalReceiptPrinter.DisplayMember = "ApplicationName";
            this.cmbLocalReceiptPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalReceiptPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbLocalReceiptPrinter.FormattingEnabled = true;
            this.cmbLocalReceiptPrinter.Location = new System.Drawing.Point(257, 98);
            this.cmbLocalReceiptPrinter.Name = "cmbLocalReceiptPrinter";
            this.cmbLocalReceiptPrinter.Size = new System.Drawing.Size(217, 32);
            this.cmbLocalReceiptPrinter.TabIndex = 151;
            this.cmbLocalReceiptPrinter.ValueMember = "IID";
            this.cmbLocalReceiptPrinter.SelectionChangeCommitted += new System.EventHandler(this.cmbLocalReceiptPrinter_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(257, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 149;
            this.label4.Text = "LOCAL RECEIPT PRINTER";
            // 
            // cmbDeliveryPrinter
            // 
            this.cmbDeliveryPrinter.DataSource = this.applicationPrinterBindingSource;
            this.cmbDeliveryPrinter.DisplayMember = "ApplicationName";
            this.cmbDeliveryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbDeliveryPrinter.FormattingEnabled = true;
            this.cmbDeliveryPrinter.Location = new System.Drawing.Point(12, 98);
            this.cmbDeliveryPrinter.Name = "cmbDeliveryPrinter";
            this.cmbDeliveryPrinter.Size = new System.Drawing.Size(217, 32);
            this.cmbDeliveryPrinter.TabIndex = 150;
            this.cmbDeliveryPrinter.ValueMember = "IID";
            this.cmbDeliveryPrinter.SelectionChangeCommitted += new System.EventHandler(this.cmbDeliveryPrinter_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "TAKE-AWAY PRINTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(257, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 145;
            this.label3.Text = "CASH DRAWER PRINTER";
            // 
            // cmbCashDrawerPrinter
            // 
            this.cmbCashDrawerPrinter.DataSource = this.applicationPrinterBindingSource;
            this.cmbCashDrawerPrinter.DisplayMember = "ApplicationName";
            this.cmbCashDrawerPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashDrawerPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbCashDrawerPrinter.FormattingEnabled = true;
            this.cmbCashDrawerPrinter.Location = new System.Drawing.Point(257, 33);
            this.cmbCashDrawerPrinter.Name = "cmbCashDrawerPrinter";
            this.cmbCashDrawerPrinter.Size = new System.Drawing.Size(217, 32);
            this.cmbCashDrawerPrinter.TabIndex = 147;
            this.cmbCashDrawerPrinter.ValueMember = "IID";
            this.cmbCashDrawerPrinter.SelectionChangeCommitted += new System.EventHandler(this.cmbCashDrawerPrinter_SelectionChangeCommitted);
            // 
            // cmbTakeAwayPrinter
            // 
            this.cmbTakeAwayPrinter.DataSource = this.applicationPrinterBindingSource;
            this.cmbTakeAwayPrinter.DisplayMember = "ApplicationName";
            this.cmbTakeAwayPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTakeAwayPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTakeAwayPrinter.FormattingEnabled = true;
            this.cmbTakeAwayPrinter.Location = new System.Drawing.Point(12, 33);
            this.cmbTakeAwayPrinter.Name = "cmbTakeAwayPrinter";
            this.cmbTakeAwayPrinter.Size = new System.Drawing.Size(217, 32);
            this.cmbTakeAwayPrinter.TabIndex = 146;
            this.cmbTakeAwayPrinter.ValueMember = "IID";
            this.cmbTakeAwayPrinter.SelectionChangeCommitted += new System.EventHandler(this.cmbTakeAwayPrinter_SelectionChangeCommitted);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.chkAllPrinters,
            this.btnPrintTestPage,
            this.btnExport,
            this.btnExportAsJson,
            this.btnImportFromJson});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(849, 54);
            this.tsMain.TabIndex = 9;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 51);
            this.btnAdd.Text = "Add New ";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 51);
            this.btnEdit.Text = "   Edit   ";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 51);
            this.btnDelete.Text = "   Delete   ";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkAllPrinters
            // 
            this.chkAllPrinters.CheckOnClick = true;
            this.chkAllPrinters.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkAllPrinters.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkAllPrinters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkAllPrinters.Name = "chkAllPrinters";
            this.chkAllPrinters.Size = new System.Drawing.Size(71, 51);
            this.chkAllPrinters.Text = "All Printers ";
            this.chkAllPrinters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkAllPrinters.CheckedChanged += new System.EventHandler(this.chkAllPrinters_CheckedChanged);
            this.chkAllPrinters.Click += new System.EventHandler(this.chkAllPrinters_Click);
            // 
            // btnPrintTestPage
            // 
            this.btnPrintTestPage.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnPrintTestPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintTestPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintTestPage.Name = "btnPrintTestPage";
            this.btnPrintTestPage.Size = new System.Drawing.Size(63, 51);
            this.btnPrintTestPage.Text = " Print List ";
            this.btnPrintTestPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintTestPage.Click += new System.EventHandler(this.btnPrintTestPage_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::DTRMSimpleBackOffice.Properties.Resources.ToTextFile_32;
            this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(57, 51);
            this.btnExport.Text = "  Export  ";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportAsJson
            // 
            this.btnExportAsJson.Image = global::DTRMSimpleBackOffice.Properties.Resources.SquareArrowRightExpander32;
            this.btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportAsJson.Name = "btnExportAsJson";
            this.btnExportAsJson.Size = new System.Drawing.Size(76, 51);
            this.btnExportAsJson.Text = "JSON Export";
            this.btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportAsJson.Click += new System.EventHandler(this.btnExportAsJson_Click);
            // 
            // btnImportFromJson
            // 
            this.btnImportFromJson.Image = global::DTRMSimpleBackOffice.Properties.Resources.SquareArrowLeftNarrower32;
            this.btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromJson.Name = "btnImportFromJson";
            this.btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            this.btnImportFromJson.Text = "JSON Import";
            this.btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportFromJson.Click += new System.EventHandler(this.btnImportFromJson_Click);
            // 
            // frmPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrinters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOCAL PRINTER  EDITOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrinters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripButton chkAllPrinters;
        private System.Windows.Forms.ToolStripButton btnPrintTestPage;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrinterTypeAsString;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn takeAwayPrinterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminOnlyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
    }
}