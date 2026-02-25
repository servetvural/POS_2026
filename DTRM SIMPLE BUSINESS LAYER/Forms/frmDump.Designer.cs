namespace DTRMNS {
    partial class frmDump {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDump));
            this.dgvIrrelevantOrders = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvErrorOrders = new System.Windows.Forms.DataGridView();
            this.colErrorIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeleteErrorOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockedClientIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenOrderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedExVatValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargeTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIrrelevantOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIrrelevantOrders
            // 
            this.dgvIrrelevantOrders.AllowUserToAddRows = false;
            this.dgvIrrelevantOrders.AllowUserToDeleteRows = false;
            this.dgvIrrelevantOrders.AutoGenerateColumns = false;
            this.dgvIrrelevantOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvIrrelevantOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIrrelevantOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIID,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderTypeNameDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.paymentMethodNameDataGridViewTextBoxColumn,
            this.sessionIIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.lockedClientIPDataGridViewTextBoxColumn,
            this.moneyPaidDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.paymentFlagDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.kitchenOrderNoDataGridViewTextBoxColumn,
            this.calculatedValueDataGridViewTextBoxColumn,
            this.calculatedVatDataGridViewTextBoxColumn,
            this.calculatedExVatValueDataGridViewTextBoxColumn,
            this.serviceChargeDataGridViewTextBoxColumn,
            this.serviceChargeTaxDataGridViewTextBoxColumn});
            this.dgvIrrelevantOrders.DataSource = this.ordersViewBindingSource;
            this.dgvIrrelevantOrders.Location = new System.Drawing.Point(9, 25);
            this.dgvIrrelevantOrders.Name = "dgvIrrelevantOrders";
            this.dgvIrrelevantOrders.ReadOnly = true;
            this.dgvIrrelevantOrders.RowHeadersWidth = 25;
            this.dgvIrrelevantOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIrrelevantOrders.Size = new System.Drawing.Size(838, 159);
            this.dgvIrrelevantOrders.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(686, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 54);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE DUMP";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvErrorOrders
            // 
            this.dgvErrorOrders.AllowUserToAddRows = false;
            this.dgvErrorOrders.AllowUserToDeleteRows = false;
            this.dgvErrorOrders.AutoGenerateColumns = false;
            this.dgvErrorOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvErrorOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colErrorIID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dgvErrorOrders.DataSource = this.ordersViewBindingSource;
            this.dgvErrorOrders.Location = new System.Drawing.Point(9, 224);
            this.dgvErrorOrders.Name = "dgvErrorOrders";
            this.dgvErrorOrders.ReadOnly = true;
            this.dgvErrorOrders.RowHeadersWidth = 25;
            this.dgvErrorOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrorOrders.Size = new System.Drawing.Size(838, 161);
            this.dgvErrorOrders.TabIndex = 4;
            // 
            // colErrorIID
            // 
            this.colErrorIID.DataPropertyName = "IID";
            this.colErrorIID.HeaderText = "IID";
            this.colErrorIID.Name = "colErrorIID";
            this.colErrorIID.ReadOnly = true;
            this.colErrorIID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderTypeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Payment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentMethodName";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentMethodName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SessionIID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SessionIID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StatusName";
            this.dataGridViewTextBoxColumn8.HeaderText = "StatusName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LockedClientIP";
            this.dataGridViewTextBoxColumn9.HeaderText = "LockedClientIP";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MoneyPaid";
            this.dataGridViewTextBoxColumn10.HeaderText = "MoneyPaid";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn11.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ItemCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "ItemCount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PaymentFlag";
            this.dataGridViewTextBoxColumn13.HeaderText = "PaymentFlag";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Reference";
            this.dataGridViewTextBoxColumn14.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "KitchenOrderNo";
            this.dataGridViewTextBoxColumn15.HeaderText = "KitchenOrderNo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CalculatedValue";
            this.dataGridViewTextBoxColumn16.HeaderText = "CalculatedValue";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CalculatedVat";
            this.dataGridViewTextBoxColumn17.HeaderText = "CalculatedVat";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CalculatedExVatValue";
            this.dataGridViewTextBoxColumn18.HeaderText = "CalculatedExVatValue";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ServiceCharge";
            this.dataGridViewTextBoxColumn19.HeaderText = "ServiceCharge";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ServiceChargeTax";
            this.dataGridViewTextBoxColumn20.HeaderText = "ServiceChargeTax";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataSource = typeof(DTRMNS.OrdersView);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::DTRMNS.Properties.Resources.Refresh_2;
            this.btnReload.Location = new System.Drawing.Point(9, 400);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(152, 54);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "RELOAD ALL";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDeleteErrorOrders
            // 
            this.btnDeleteErrorOrders.Image = global::DTRMNS.Properties.Resources.Recycle_Bin;
            this.btnDeleteErrorOrders.Location = new System.Drawing.Point(853, 224);
            this.btnDeleteErrorOrders.Name = "btnDeleteErrorOrders";
            this.btnDeleteErrorOrders.Size = new System.Drawing.Size(114, 161);
            this.btnDeleteErrorOrders.TabIndex = 3;
            this.btnDeleteErrorOrders.Text = "\r\nDELETE \r\nERROR SESSION \r\nORDERS";
            this.btnDeleteErrorOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteErrorOrders.UseVisualStyleBackColor = true;
            this.btnDeleteErrorOrders.Click += new System.EventHandler(this.btnDeleteErrorOrders_Click);
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Image = global::DTRMNS.Properties.Resources.Recycle_Bin;
            this.btnDeleteOrders.Location = new System.Drawing.Point(853, 25);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(114, 159);
            this.btnDeleteOrders.TabIndex = 1;
            this.btnDeleteOrders.Text = "\r\nDELETE \r\nOUT OF SESSION \r\nORDERS";
            this.btnDeleteOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            this.btnDeleteOrders.Click += new System.EventHandler(this.btnDeleteOrders_Click);
            // 
            // colIID
            // 
            this.colIID.DataPropertyName = "IID";
            this.colIID.HeaderText = "IID";
            this.colIID.Name = "colIID";
            this.colIID.ReadOnly = true;
            this.colIID.Visible = false;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 140;
            // 
            // orderTypeNameDataGridViewTextBoxColumn
            // 
            this.orderTypeNameDataGridViewTextBoxColumn.DataPropertyName = "OrderTypeName";
            this.orderTypeNameDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.orderTypeNameDataGridViewTextBoxColumn.Name = "orderTypeNameDataGridViewTextBoxColumn";
            this.orderTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodNameDataGridViewTextBoxColumn
            // 
            this.paymentMethodNameDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethodName";
            this.paymentMethodNameDataGridViewTextBoxColumn.HeaderText = "PaymentMethodName";
            this.paymentMethodNameDataGridViewTextBoxColumn.Name = "paymentMethodNameDataGridViewTextBoxColumn";
            this.paymentMethodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionIIDDataGridViewTextBoxColumn
            // 
            this.sessionIIDDataGridViewTextBoxColumn.DataPropertyName = "SessionIID";
            this.sessionIIDDataGridViewTextBoxColumn.HeaderText = "SessionIID";
            this.sessionIIDDataGridViewTextBoxColumn.Name = "sessionIIDDataGridViewTextBoxColumn";
            this.sessionIIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            this.statusNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lockedClientIPDataGridViewTextBoxColumn
            // 
            this.lockedClientIPDataGridViewTextBoxColumn.DataPropertyName = "LockedClientIP";
            this.lockedClientIPDataGridViewTextBoxColumn.HeaderText = "LockedClientIP";
            this.lockedClientIPDataGridViewTextBoxColumn.Name = "lockedClientIPDataGridViewTextBoxColumn";
            this.lockedClientIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyPaidDataGridViewTextBoxColumn
            // 
            this.moneyPaidDataGridViewTextBoxColumn.DataPropertyName = "MoneyPaid";
            this.moneyPaidDataGridViewTextBoxColumn.HeaderText = "MoneyPaid";
            this.moneyPaidDataGridViewTextBoxColumn.Name = "moneyPaidDataGridViewTextBoxColumn";
            this.moneyPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            this.itemCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentFlagDataGridViewTextBoxColumn
            // 
            this.paymentFlagDataGridViewTextBoxColumn.DataPropertyName = "PaymentFlag";
            this.paymentFlagDataGridViewTextBoxColumn.HeaderText = "PaymentFlag";
            this.paymentFlagDataGridViewTextBoxColumn.Name = "paymentFlagDataGridViewTextBoxColumn";
            this.paymentFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitchenOrderNoDataGridViewTextBoxColumn
            // 
            this.kitchenOrderNoDataGridViewTextBoxColumn.DataPropertyName = "KitchenOrderNo";
            this.kitchenOrderNoDataGridViewTextBoxColumn.HeaderText = "KitchenOrderNo";
            this.kitchenOrderNoDataGridViewTextBoxColumn.Name = "kitchenOrderNoDataGridViewTextBoxColumn";
            this.kitchenOrderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculatedValueDataGridViewTextBoxColumn
            // 
            this.calculatedValueDataGridViewTextBoxColumn.DataPropertyName = "CalculatedValue";
            this.calculatedValueDataGridViewTextBoxColumn.HeaderText = "CalculatedValue";
            this.calculatedValueDataGridViewTextBoxColumn.Name = "calculatedValueDataGridViewTextBoxColumn";
            this.calculatedValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculatedVatDataGridViewTextBoxColumn
            // 
            this.calculatedVatDataGridViewTextBoxColumn.DataPropertyName = "CalculatedVat";
            this.calculatedVatDataGridViewTextBoxColumn.HeaderText = "CalculatedVat";
            this.calculatedVatDataGridViewTextBoxColumn.Name = "calculatedVatDataGridViewTextBoxColumn";
            this.calculatedVatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculatedExVatValueDataGridViewTextBoxColumn
            // 
            this.calculatedExVatValueDataGridViewTextBoxColumn.DataPropertyName = "CalculatedExVatValue";
            this.calculatedExVatValueDataGridViewTextBoxColumn.HeaderText = "CalculatedExVatValue";
            this.calculatedExVatValueDataGridViewTextBoxColumn.Name = "calculatedExVatValueDataGridViewTextBoxColumn";
            this.calculatedExVatValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceChargeDataGridViewTextBoxColumn
            // 
            this.serviceChargeDataGridViewTextBoxColumn.DataPropertyName = "ServiceCharge";
            this.serviceChargeDataGridViewTextBoxColumn.HeaderText = "ServiceCharge";
            this.serviceChargeDataGridViewTextBoxColumn.Name = "serviceChargeDataGridViewTextBoxColumn";
            this.serviceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceChargeTaxDataGridViewTextBoxColumn
            // 
            this.serviceChargeTaxDataGridViewTextBoxColumn.DataPropertyName = "ServiceChargeTax";
            this.serviceChargeTaxDataGridViewTextBoxColumn.HeaderText = "ServiceChargeTax";
            this.serviceChargeTaxDataGridViewTextBoxColumn.Name = "serviceChargeTaxDataGridViewTextBoxColumn";
            this.serviceChargeTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "OUT OF SESSION DUMP ORDERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "THIS SESSION DUMP ORDERS";
            // 
            // frmDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvErrorOrders);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDeleteErrorOrders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.dgvIrrelevantOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DUMP";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDump_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIrrelevantOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIrrelevantOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockedClientIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchenOrderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedExVatValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargeTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteErrorOrders;
        private System.Windows.Forms.DataGridView dgvErrorOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}