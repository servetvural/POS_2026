using POSLayer.Views;

namespace DTRMNS {
    partial class frmTaxReport {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxReport));
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.dgvPercent = new System.Windows.Forms.DataGridView();
            this.dgvSum = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArcEmailAsCsv = new System.Windows.Forms.Button();
            this.btnArcExportToCsv = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDailyStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDailyEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNoTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netTaxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaily
            // 
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AllowUserToDeleteRows = false;
            this.dgvDaily.AutoGenerateColumns = false;
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDailyStartDate,
            this.colDailyEndDate,
            this.taxPercentDataGridViewTextBoxColumn,
            this.totalNoTaxDataGridViewTextBoxColumn,
            this.netTaxValueDataGridViewTextBoxColumn,
            this.grossTotalDataGridViewTextBoxColumn});
            this.dgvDaily.DataSource = this.taxSummaryBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDaily.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDaily.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDaily.Location = new System.Drawing.Point(11, 6);
            this.dgvDaily.MultiSelect = false;
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.ReadOnly = true;
            this.dgvDaily.RowHeadersWidth = 20;
            this.dgvDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaily.Size = new System.Drawing.Size(817, 438);
            this.dgvDaily.TabIndex = 0;
            // 
            // dgvPercent
            // 
            this.dgvPercent.AllowUserToAddRows = false;
            this.dgvPercent.AllowUserToDeleteRows = false;
            this.dgvPercent.AutoGenerateColumns = false;
            this.dgvPercent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.dataGridViewTextBoxColumn3,
            this.Payment,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvPercent.DataSource = this.taxSummaryBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPercent.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPercent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPercent.Location = new System.Drawing.Point(11, 450);
            this.dgvPercent.MultiSelect = false;
            this.dgvPercent.Name = "dgvPercent";
            this.dgvPercent.ReadOnly = true;
            this.dgvPercent.RowHeadersWidth = 20;
            this.dgvPercent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPercent.Size = new System.Drawing.Size(408, 151);
            this.dgvPercent.TabIndex = 1;
            // 
            // dgvSum
            // 
            this.dgvSum.AllowUserToAddRows = false;
            this.dgvSum.AllowUserToDeleteRows = false;
            this.dgvSum.AutoGenerateColumns = false;
            this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvSum.DataSource = this.taxSummaryBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSum.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSum.Location = new System.Drawing.Point(425, 450);
            this.dgvSum.MultiSelect = false;
            this.dgvSum.Name = "dgvSum";
            this.dgvSum.ReadOnly = true;
            this.dgvSum.RowHeadersWidth = 20;
            this.dgvSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSum.Size = new System.Drawing.Size(403, 92);
            this.dgvSum.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnArcEmailAsCsv);
            this.panel1.Controls.Add(this.btnArcExportToCsv);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(425, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 53);
            this.panel1.TabIndex = 71;
            // 
            // btnArcEmailAsCsv
            // 
            this.btnArcEmailAsCsv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcEmailAsCsv.Image = global::DTRMNS.Properties.Resources.mektup2__32;
            this.btnArcEmailAsCsv.Location = new System.Drawing.Point(150, 10);
            this.btnArcEmailAsCsv.Name = "btnArcEmailAsCsv";
            this.btnArcEmailAsCsv.Size = new System.Drawing.Size(96, 36);
            this.btnArcEmailAsCsv.TabIndex = 8;
            this.btnArcEmailAsCsv.Text = "  Email";
            this.btnArcEmailAsCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArcEmailAsCsv.UseVisualStyleBackColor = true;
            this.btnArcEmailAsCsv.Click += new System.EventHandler(this.btnArcEmailAsCsv_Click);
            // 
            // btnArcExportToCsv
            // 
            this.btnArcExportToCsv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcExportToCsv.Image = global::DTRMNS.Properties.Resources.Export32;
            this.btnArcExportToCsv.Location = new System.Drawing.Point(14, 10);
            this.btnArcExportToCsv.Name = "btnArcExportToCsv";
            this.btnArcExportToCsv.Size = new System.Drawing.Size(130, 36);
            this.btnArcExportToCsv.TabIndex = 7;
            this.btnArcExportToCsv.Text = "SpreadSheet";
            this.btnArcExportToCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArcExportToCsv.UseVisualStyleBackColor = true;
            this.btnArcExportToCsv.Click += new System.EventHandler(this.btnArcExportToCsv_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(252, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(70, 36);
            this.btnReload.TabIndex = 72;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 2;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 2;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 2;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 2;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            this.Payment.HeaderText = "P";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 40;
            // 
            // taxSummaryBindingSource
            // 
            this.taxSummaryBindingSource.DataSource = typeof(TaxSummary);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TaxPercent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "TaxPercent";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalNoTax";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "TotalNoTax";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NetTaxValue";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.HeaderText = "NetTaxValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GrossTotal";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn6.HeaderText = "GrossTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // colDailyStartDate
            // 
            this.colDailyStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.colDailyStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDailyStartDate.HeaderText = "StartDate";
            this.colDailyStartDate.Name = "colDailyStartDate";
            this.colDailyStartDate.ReadOnly = true;
            this.colDailyStartDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colDailyStartDate.Width = 150;
            // 
            // colDailyEndDate
            // 
            this.colDailyEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "F";
            this.colDailyEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDailyEndDate.HeaderText = "EndDate";
            this.colDailyEndDate.Name = "colDailyEndDate";
            this.colDailyEndDate.ReadOnly = true;
            this.colDailyEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colDailyEndDate.Width = 150;
            // 
            // taxPercentDataGridViewTextBoxColumn
            // 
            this.taxPercentDataGridViewTextBoxColumn.DataPropertyName = "TaxPercent";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.taxPercentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.taxPercentDataGridViewTextBoxColumn.HeaderText = "TaxPercent";
            this.taxPercentDataGridViewTextBoxColumn.Name = "taxPercentDataGridViewTextBoxColumn";
            this.taxPercentDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxPercentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taxPercentDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalNoTaxDataGridViewTextBoxColumn
            // 
            this.totalNoTaxDataGridViewTextBoxColumn.DataPropertyName = "TotalNoTax";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalNoTaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalNoTaxDataGridViewTextBoxColumn.HeaderText = "TotalNoTax";
            this.totalNoTaxDataGridViewTextBoxColumn.Name = "totalNoTaxDataGridViewTextBoxColumn";
            this.totalNoTaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalNoTaxDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalNoTaxDataGridViewTextBoxColumn.Width = 80;
            // 
            // netTaxValueDataGridViewTextBoxColumn
            // 
            this.netTaxValueDataGridViewTextBoxColumn.DataPropertyName = "NetTaxValue";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.netTaxValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.netTaxValueDataGridViewTextBoxColumn.HeaderText = "NetTaxValue";
            this.netTaxValueDataGridViewTextBoxColumn.Name = "netTaxValueDataGridViewTextBoxColumn";
            this.netTaxValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.netTaxValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.netTaxValueDataGridViewTextBoxColumn.Width = 80;
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            this.grossTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.grossTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.grossTotalDataGridViewTextBoxColumn.HeaderText = "GrossTotal";
            this.grossTotalDataGridViewTextBoxColumn.Name = "grossTotalDataGridViewTextBoxColumn";
            this.grossTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossTotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grossTotalDataGridViewTextBoxColumn.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Payment";
            this.dataGridViewTextBoxColumn1.HeaderText = "P";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TotalNoTax";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn10.HeaderText = "TotalNoTax";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NetTaxValue";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn11.HeaderText = "NetTaxValue";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GrossTotal";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn12.HeaderText = "GrossTotal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // frmTaxReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSum);
            this.Controls.Add(this.dgvPercent);
            this.Controls.Add(this.dgvDaily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaxReport";
            this.Text = "TAX  REPORT";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTaxReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaily;
        private System.Windows.Forms.BindingSource taxSummaryBindingSource;
        private System.Windows.Forms.DataGridView dgvPercent;
        private System.Windows.Forms.DataGridView dgvSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnArcEmailAsCsv;
        private System.Windows.Forms.Button btnArcExportToCsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDailyStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDailyEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNoTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netTaxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}