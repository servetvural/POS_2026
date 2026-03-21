using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    partial class frmKassaCalculator {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKassaCalculator));
            this.cmbController = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbManagedBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBonus = new System.Windows.Forms.ComboBox();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBahsisTotal = new System.Windows.Forms.Button();
            this.btnShortCash = new System.Windows.Forms.Button();
            this.txtAfterSaleAmount = new PosLibrary.DoubleTextBox();
            this.txtBonusTotal = new PosLibrary.DoubleTextBox();
            this.txtHowManyBonus = new PosLibrary.DoubleTextBox();
            this.txtRateTotal = new PosLibrary.DoubleTextBox();
            this.txtExpensesTotal = new PosLibrary.DoubleTextBox();
            this.txtGrandTotal = new PosLibrary.DoubleTextBox();
            this.txtStepTwoTotal = new PosLibrary.DoubleTextBox();
            this.txtShortAmount = new PosLibrary.DoubleTextBox();
            this.txtExtraAmount = new PosLibrary.DoubleTextBox();
            this.txtPinTerminalTotal = new PosLibrary.DoubleTextBox();
            this.txtPinKassaTotal = new PosLibrary.DoubleTextBox();
            this.txtBahsisTotal = new PosLibrary.DoubleTextBox();
            this.txtXAmount = new PosLibrary.DoubleTextBox();
            this.cmbXType = new System.Windows.Forms.ComboBox();
            this.lblBahsisDifference = new System.Windows.Forms.Label();
            this.lblShortDifference = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDuplicate = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdReload = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.cmdClose = new System.Windows.Forms.ToolStripButton();
            this.cmdCalculate = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.colExpenseIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAddExpense = new System.Windows.Forms.ToolStripButton();
            this.tsEditExpense = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteExpense = new System.Windows.Forms.ToolStripButton();
            this.tsReloadExpense = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIncomeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.barMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbController
            // 
            this.cmbController.DisplayMember = "EmployeeName";
            this.cmbController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbController.FormattingEnabled = true;
            this.cmbController.Location = new System.Drawing.Point(357, 6);
            this.cmbController.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbController.Name = "cmbController";
            this.cmbController.Size = new System.Drawing.Size(130, 28);
            this.cmbController.TabIndex = 1;
            this.cmbController.ValueMember = "IID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(521, 10);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 20);
            this.lblDate.TabIndex = 51;
            this.lblDate.Text = "Show Todays Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Controller";
            // 
            // cmbManagedBy
            // 
            this.cmbManagedBy.DisplayMember = "EmployeeName";
            this.cmbManagedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManagedBy.FormattingEnabled = true;
            this.cmbManagedBy.Location = new System.Drawing.Point(106, 6);
            this.cmbManagedBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbManagedBy.Name = "cmbManagedBy";
            this.cmbManagedBy.Size = new System.Drawing.Size(113, 28);
            this.cmbManagedBy.TabIndex = 0;
            this.cmbManagedBy.ValueMember = "IID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Managed By";
            // 
            // cmbBonus
            // 
            this.cmbBonus.DataSource = this.bonusBindingSource;
            this.cmbBonus.DisplayMember = "PlanName";
            this.cmbBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBonus.FormattingEnabled = true;
            this.cmbBonus.Location = new System.Drawing.Point(357, 42);
            this.cmbBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBonus.Name = "cmbBonus";
            this.cmbBonus.Size = new System.Drawing.Size(332, 28);
            this.cmbBonus.TabIndex = 2;
            this.cmbBonus.ValueMember = "IID";
            this.cmbBonus.SelectionChangeCommitted += new System.EventHandler(this.cmbBonus_SelectionChangeCommitted);
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataSource = typeof(Bonus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tip Scheme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Pin Kassa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Pin Terminal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "After Sale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Reserve";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Expenses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tip Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Required Cash";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(518, 138);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Extra Cash";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(468, 169);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Cash To Envelope";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIID,
            this.hoursDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rateIncomeDataGridViewTextBoxColumn,
            this.bonusTypeDataGridViewTextBoxColumn,
            this.bonusIncomeDataGridViewTextBoxColumn,
            this.tipIncomeDataGridViewTextBoxColumn,
            this.shortAmount,
            this.incomeTotalDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.staffIncomeBindingSource;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 64);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 10;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployee.RowTemplate.Height = 35;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.ShowCellErrors = false;
            this.dgvEmployee.ShowRowErrors = false;
            this.dgvEmployee.Size = new System.Drawing.Size(761, 187);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // colIID
            // 
            this.colIID.DataPropertyName = "IID";
            this.colIID.HeaderText = "IID";
            this.colIID.Name = "colIID";
            this.colIID.ReadOnly = true;
            this.colIID.Visible = false;
            this.colIID.Width = 5;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.hoursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // rateIncomeDataGridViewTextBoxColumn
            // 
            this.rateIncomeDataGridViewTextBoxColumn.DataPropertyName = "rateIncome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.rateIncomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rateIncomeDataGridViewTextBoxColumn.HeaderText = "Reserve";
            this.rateIncomeDataGridViewTextBoxColumn.Name = "rateIncomeDataGridViewTextBoxColumn";
            this.rateIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateIncomeDataGridViewTextBoxColumn.Width = 90;
            // 
            // bonusTypeDataGridViewTextBoxColumn
            // 
            this.bonusTypeDataGridViewTextBoxColumn.DataPropertyName = "bonusType";
            this.bonusTypeDataGridViewTextBoxColumn.HeaderText = "Tip Type";
            this.bonusTypeDataGridViewTextBoxColumn.Name = "bonusTypeDataGridViewTextBoxColumn";
            this.bonusTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusIncomeDataGridViewTextBoxColumn
            // 
            this.bonusIncomeDataGridViewTextBoxColumn.DataPropertyName = "bonusIncome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.bonusIncomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bonusIncomeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.bonusIncomeDataGridViewTextBoxColumn.Name = "bonusIncomeDataGridViewTextBoxColumn";
            this.bonusIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusIncomeDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipIncomeDataGridViewTextBoxColumn
            // 
            this.tipIncomeDataGridViewTextBoxColumn.DataPropertyName = "tipIncome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.tipIncomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipIncomeDataGridViewTextBoxColumn.HeaderText = "Bahsis";
            this.tipIncomeDataGridViewTextBoxColumn.Name = "tipIncomeDataGridViewTextBoxColumn";
            this.tipIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipIncomeDataGridViewTextBoxColumn.Width = 80;
            // 
            // shortAmount
            // 
            this.shortAmount.DataPropertyName = "shortAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.shortAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.shortAmount.HeaderText = "Short";
            this.shortAmount.Name = "shortAmount";
            this.shortAmount.ReadOnly = true;
            this.shortAmount.Width = 70;
            // 
            // incomeTotalDataGridViewTextBoxColumn
            // 
            this.incomeTotalDataGridViewTextBoxColumn.DataPropertyName = "IncomeTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.incomeTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.incomeTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.incomeTotalDataGridViewTextBoxColumn.Name = "incomeTotalDataGridViewTextBoxColumn";
            this.incomeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffIncomeBindingSource
            // 
            this.staffIncomeBindingSource.DataSource = typeof(StaffIncome);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBahsisTotal);
            this.panel1.Controls.Add(this.btnShortCash);
            this.panel1.Controls.Add(this.txtAfterSaleAmount);
            this.panel1.Controls.Add(this.txtBonusTotal);
            this.panel1.Controls.Add(this.txtHowManyBonus);
            this.panel1.Controls.Add(this.txtRateTotal);
            this.panel1.Controls.Add(this.txtExpensesTotal);
            this.panel1.Controls.Add(this.txtGrandTotal);
            this.panel1.Controls.Add(this.txtStepTwoTotal);
            this.panel1.Controls.Add(this.txtShortAmount);
            this.panel1.Controls.Add(this.txtExtraAmount);
            this.panel1.Controls.Add(this.txtPinTerminalTotal);
            this.panel1.Controls.Add(this.txtPinKassaTotal);
            this.panel1.Controls.Add(this.txtBahsisTotal);
            this.panel1.Controls.Add(this.txtXAmount);
            this.panel1.Controls.Add(this.cmbXType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbManagedBy);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblBahsisDifference);
            this.panel1.Controls.Add(this.lblShortDifference);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmbBonus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cmbController);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 204);
            this.panel1.TabIndex = 60;
            // 
            // btnBahsisTotal
            // 
            this.btnBahsisTotal.Location = new System.Drawing.Point(22, 103);
            this.btnBahsisTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBahsisTotal.Name = "btnBahsisTotal";
            this.btnBahsisTotal.Size = new System.Drawing.Size(112, 28);
            this.btnBahsisTotal.TabIndex = 62;
            this.btnBahsisTotal.Text = "Bahsis Total";
            this.btnBahsisTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBahsisTotal.UseVisualStyleBackColor = true;
            this.btnBahsisTotal.Click += new System.EventHandler(this.btnBahsisTotal_Click);
            // 
            // btnShortCash
            // 
            this.btnShortCash.Location = new System.Drawing.Point(495, 104);
            this.btnShortCash.Margin = new System.Windows.Forms.Padding(2);
            this.btnShortCash.Name = "btnShortCash";
            this.btnShortCash.Size = new System.Drawing.Size(104, 28);
            this.btnShortCash.TabIndex = 61;
            this.btnShortCash.Text = "Short Cash";
            this.btnShortCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShortCash.UseVisualStyleBackColor = true;
            this.btnShortCash.Click += new System.EventHandler(this.btnShortCash_Click);
            // 
            // txtAfterSaleAmount
            // 
            this.txtAfterSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAfterSaleAmount.CustomFormat = "N2";
            this.txtAfterSaleAmount.CustomUICulture = "en-US";
            this.txtAfterSaleAmount.Increment = 1D;
            this.txtAfterSaleAmount.Location = new System.Drawing.Point(137, 73);
            this.txtAfterSaleAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAfterSaleAmount.MaxValue = 100000D;
            this.txtAfterSaleAmount.MinValue = -100000D;
            this.txtAfterSaleAmount.Name = "txtAfterSaleAmount";
            this.txtAfterSaleAmount.Size = new System.Drawing.Size(82, 26);
            this.txtAfterSaleAmount.TabIndex = 60;
            this.txtAfterSaleAmount.Text = "0.00";
            this.txtAfterSaleAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAfterSaleAmount.Value = 0D;
            this.txtAfterSaleAmount.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtAfterSaleAmount.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtBonusTotal
            // 
            this.txtBonusTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonusTotal.CustomFormat = "N2";
            this.txtBonusTotal.CustomUICulture = "en-US";
            this.txtBonusTotal.Enabled = false;
            this.txtBonusTotal.Increment = 1D;
            this.txtBonusTotal.Location = new System.Drawing.Point(357, 168);
            this.txtBonusTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtBonusTotal.MaxValue = 100000D;
            this.txtBonusTotal.MinValue = -100000D;
            this.txtBonusTotal.Name = "txtBonusTotal";
            this.txtBonusTotal.ReadOnly = true;
            this.txtBonusTotal.Size = new System.Drawing.Size(82, 26);
            this.txtBonusTotal.TabIndex = 60;
            this.txtBonusTotal.Text = "0.00";
            this.txtBonusTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBonusTotal.Value = 0D;
            // 
            // txtHowManyBonus
            // 
            this.txtHowManyBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHowManyBonus.CustomFormat = "N2";
            this.txtHowManyBonus.CustomUICulture = "en-US";
            this.txtHowManyBonus.Enabled = false;
            this.txtHowManyBonus.Increment = 1D;
            this.txtHowManyBonus.Location = new System.Drawing.Point(357, 136);
            this.txtHowManyBonus.Margin = new System.Windows.Forms.Padding(2);
            this.txtHowManyBonus.MaxValue = 100000D;
            this.txtHowManyBonus.MinValue = -100000D;
            this.txtHowManyBonus.Name = "txtHowManyBonus";
            this.txtHowManyBonus.ReadOnly = true;
            this.txtHowManyBonus.Size = new System.Drawing.Size(82, 26);
            this.txtHowManyBonus.TabIndex = 60;
            this.txtHowManyBonus.Text = "0.00";
            this.txtHowManyBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHowManyBonus.Value = 0D;
            // 
            // txtRateTotal
            // 
            this.txtRateTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRateTotal.CustomFormat = "N2";
            this.txtRateTotal.CustomUICulture = "en-US";
            this.txtRateTotal.Enabled = false;
            this.txtRateTotal.Increment = 1D;
            this.txtRateTotal.Location = new System.Drawing.Point(357, 105);
            this.txtRateTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtRateTotal.MaxValue = 100000D;
            this.txtRateTotal.MinValue = -100000D;
            this.txtRateTotal.Name = "txtRateTotal";
            this.txtRateTotal.ReadOnly = true;
            this.txtRateTotal.Size = new System.Drawing.Size(82, 26);
            this.txtRateTotal.TabIndex = 60;
            this.txtRateTotal.Text = "0.00";
            this.txtRateTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateTotal.Value = 0D;
            // 
            // txtExpensesTotal
            // 
            this.txtExpensesTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpensesTotal.CustomFormat = "N2";
            this.txtExpensesTotal.CustomUICulture = "en-US";
            this.txtExpensesTotal.Enabled = false;
            this.txtExpensesTotal.Increment = 1D;
            this.txtExpensesTotal.Location = new System.Drawing.Point(357, 75);
            this.txtExpensesTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpensesTotal.MaxValue = 100000D;
            this.txtExpensesTotal.MinValue = -100000D;
            this.txtExpensesTotal.Name = "txtExpensesTotal";
            this.txtExpensesTotal.ReadOnly = true;
            this.txtExpensesTotal.Size = new System.Drawing.Size(82, 26);
            this.txtExpensesTotal.TabIndex = 60;
            this.txtExpensesTotal.Text = "0.00";
            this.txtExpensesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpensesTotal.Value = 0D;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.CustomFormat = "N2";
            this.txtGrandTotal.CustomUICulture = "en-US";
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Increment = 1D;
            this.txtGrandTotal.Location = new System.Drawing.Point(607, 168);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrandTotal.MaxValue = 100000D;
            this.txtGrandTotal.MinValue = -100000D;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(82, 26);
            this.txtGrandTotal.TabIndex = 60;
            this.txtGrandTotal.Text = "0.00";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrandTotal.Value = 0D;
            // 
            // txtStepTwoTotal
            // 
            this.txtStepTwoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStepTwoTotal.CustomFormat = "N2";
            this.txtStepTwoTotal.CustomUICulture = "en-US";
            this.txtStepTwoTotal.Enabled = false;
            this.txtStepTwoTotal.Increment = 1D;
            this.txtStepTwoTotal.Location = new System.Drawing.Point(607, 75);
            this.txtStepTwoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtStepTwoTotal.MaxValue = 100000D;
            this.txtStepTwoTotal.MinValue = -100000D;
            this.txtStepTwoTotal.Name = "txtStepTwoTotal";
            this.txtStepTwoTotal.ReadOnly = true;
            this.txtStepTwoTotal.Size = new System.Drawing.Size(82, 26);
            this.txtStepTwoTotal.TabIndex = 60;
            this.txtStepTwoTotal.Text = "0.00";
            this.txtStepTwoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStepTwoTotal.Value = 0D;
            // 
            // txtShortAmount
            // 
            this.txtShortAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShortAmount.CustomFormat = "N2";
            this.txtShortAmount.CustomUICulture = "en-US";
            this.txtShortAmount.Increment = 1D;
            this.txtShortAmount.Location = new System.Drawing.Point(607, 105);
            this.txtShortAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtShortAmount.MaxValue = 100000D;
            this.txtShortAmount.MinValue = -100000D;
            this.txtShortAmount.Name = "txtShortAmount";
            this.txtShortAmount.Size = new System.Drawing.Size(82, 26);
            this.txtShortAmount.TabIndex = 60;
            this.txtShortAmount.Text = "0.00";
            this.txtShortAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShortAmount.Value = 0D;
            this.txtShortAmount.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtShortAmount.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtExtraAmount
            // 
            this.txtExtraAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtraAmount.CustomFormat = "N2";
            this.txtExtraAmount.CustomUICulture = "en-US";
            this.txtExtraAmount.Increment = 1D;
            this.txtExtraAmount.Location = new System.Drawing.Point(607, 136);
            this.txtExtraAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraAmount.MaxValue = 100000D;
            this.txtExtraAmount.MinValue = -100000D;
            this.txtExtraAmount.Name = "txtExtraAmount";
            this.txtExtraAmount.Size = new System.Drawing.Size(82, 26);
            this.txtExtraAmount.TabIndex = 60;
            this.txtExtraAmount.Text = "0.00";
            this.txtExtraAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExtraAmount.Value = 0D;
            this.txtExtraAmount.ValueChanged += new System.EventHandler(this.txtExtraAmount_ValueChanged);
            this.txtExtraAmount.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtPinTerminalTotal
            // 
            this.txtPinTerminalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinTerminalTotal.CustomFormat = "N2";
            this.txtPinTerminalTotal.CustomUICulture = "en-US";
            this.txtPinTerminalTotal.Increment = 1D;
            this.txtPinTerminalTotal.Location = new System.Drawing.Point(137, 168);
            this.txtPinTerminalTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPinTerminalTotal.MaxValue = 100000D;
            this.txtPinTerminalTotal.MinValue = -100000D;
            this.txtPinTerminalTotal.Name = "txtPinTerminalTotal";
            this.txtPinTerminalTotal.Size = new System.Drawing.Size(82, 26);
            this.txtPinTerminalTotal.TabIndex = 60;
            this.txtPinTerminalTotal.Text = "0.00";
            this.txtPinTerminalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPinTerminalTotal.Value = 0D;
            this.txtPinTerminalTotal.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtPinTerminalTotal.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtPinKassaTotal
            // 
            this.txtPinKassaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinKassaTotal.CustomFormat = "N2";
            this.txtPinKassaTotal.CustomUICulture = "en-US";
            this.txtPinKassaTotal.Increment = 1D;
            this.txtPinKassaTotal.Location = new System.Drawing.Point(137, 135);
            this.txtPinKassaTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPinKassaTotal.MaxValue = 100000D;
            this.txtPinKassaTotal.MinValue = -100000D;
            this.txtPinKassaTotal.Name = "txtPinKassaTotal";
            this.txtPinKassaTotal.Size = new System.Drawing.Size(82, 26);
            this.txtPinKassaTotal.TabIndex = 60;
            this.txtPinKassaTotal.Text = "0.00";
            this.txtPinKassaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPinKassaTotal.Value = 0D;
            this.txtPinKassaTotal.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtPinKassaTotal.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtBahsisTotal
            // 
            this.txtBahsisTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBahsisTotal.CustomFormat = "N2";
            this.txtBahsisTotal.CustomUICulture = "en-US";
            this.txtBahsisTotal.Increment = 1D;
            this.txtBahsisTotal.Location = new System.Drawing.Point(137, 104);
            this.txtBahsisTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtBahsisTotal.MaxValue = 100000D;
            this.txtBahsisTotal.MinValue = -100000D;
            this.txtBahsisTotal.Name = "txtBahsisTotal";
            this.txtBahsisTotal.Size = new System.Drawing.Size(82, 26);
            this.txtBahsisTotal.TabIndex = 60;
            this.txtBahsisTotal.Text = "0.00";
            this.txtBahsisTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBahsisTotal.Value = 0D;
            this.txtBahsisTotal.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtBahsisTotal.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtXAmount
            // 
            this.txtXAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXAmount.CustomFormat = "N2";
            this.txtXAmount.CustomUICulture = "en-US";
            this.txtXAmount.Increment = 1D;
            this.txtXAmount.Location = new System.Drawing.Point(137, 42);
            this.txtXAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtXAmount.MaxValue = 100000D;
            this.txtXAmount.MinValue = -100000D;
            this.txtXAmount.Name = "txtXAmount";
            this.txtXAmount.Size = new System.Drawing.Size(82, 26);
            this.txtXAmount.TabIndex = 60;
            this.txtXAmount.Text = "0.00";
            this.txtXAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtXAmount.Value = 0D;
            this.txtXAmount.ValueChanged += new System.EventHandler(this.cmdCalculate_Click);
            this.txtXAmount.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // cmbXType
            // 
            this.cmbXType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXType.FormattingEnabled = true;
            this.cmbXType.Items.AddRange(new object[] {
            "Morning X1",
            "Night X2"});
            this.cmbXType.Location = new System.Drawing.Point(9, 41);
            this.cmbXType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbXType.Name = "cmbXType";
            this.cmbXType.Size = new System.Drawing.Size(123, 28);
            this.cmbXType.TabIndex = 58;
            this.cmbXType.SelectedIndexChanged += new System.EventHandler(this.cmbXType_SelectedIndexChanged);
            // 
            // lblBahsisDifference
            // 
            this.lblBahsisDifference.AutoSize = true;
            this.lblBahsisDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBahsisDifference.ForeColor = System.Drawing.Color.Red;
            this.lblBahsisDifference.Location = new System.Drawing.Point(220, 108);
            this.lblBahsisDifference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBahsisDifference.Name = "lblBahsisDifference";
            this.lblBahsisDifference.Size = new System.Drawing.Size(0, 17);
            this.lblBahsisDifference.TabIndex = 53;
            // 
            // lblShortDifference
            // 
            this.lblShortDifference.AutoSize = true;
            this.lblShortDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShortDifference.ForeColor = System.Drawing.Color.Red;
            this.lblShortDifference.Location = new System.Drawing.Point(690, 122);
            this.lblShortDifference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortDifference.Name = "lblShortDifference";
            this.lblShortDifference.Size = new System.Drawing.Size(0, 20);
            this.lblShortDifference.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 138);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 53;
            this.label17.Text = "Tip Count";
            // 
            // barMain
            // 
            this.barMain.AutoSize = false;
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDuplicate,
            this.cmdDelete,
            this.cmdReload,
            this.cmdPrint,
            this.cmdClose,
            this.cmdCalculate});
            this.barMain.Location = new System.Drawing.Point(0, 20);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(761, 44);
            this.barMain.TabIndex = 0;
            this.barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = false;
            this.cmdAdd.Image = global::DTRMNS.Properties.Resources.arti32;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(63, 41);
            this.cmdAdd.Text = "Employee";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoSize = false;
            this.cmdEdit.Image = global::DTRMNS.Properties.Resources.MatReport_32;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(63, 41);
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdDuplicate
            // 
            this.cmdDuplicate.AutoSize = false;
            this.cmdDuplicate.Image = global::DTRMNS.Properties.Resources.duplicateblack32;
            this.cmdDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDuplicate.Name = "cmdDuplicate";
            this.cmdDuplicate.Size = new System.Drawing.Size(63, 41);
            this.cmdDuplicate.Text = "Duplicate";
            this.cmdDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDuplicate.Visible = false;
            this.cmdDuplicate.Click += new System.EventHandler(this.cmdDuplicate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = false;
            this.cmdDelete.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(63, 41);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.AutoSize = false;
            this.cmdReload.Image = global::DTRMNS.Properties.Resources.Reload_32;
            this.cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(63, 41);
            this.cmdReload.Text = "Reload";
            this.cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.AutoSize = false;
            this.cmdPrint.Image = global::DTRMNS.Properties.Resources.Print32;
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(63, 41);
            this.cmdPrint.Text = "Print";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdClose.AutoSize = false;
            this.cmdClose.Image = global::DTRMNS.Properties.Resources.Cancel;
            this.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(63, 41);
            this.cmdClose.Text = "Close";
            this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.AutoSize = false;
            this.cmdCalculate.Image = global::DTRMNS.Properties.Resources.CalculatorNice32;
            this.cmdCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(63, 41);
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 204);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.barMain);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvExpense);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(761, 496);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(761, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SALARIES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvExpense
            // 
            this.dgvExpense.AllowUserToAddRows = false;
            this.dgvExpense.AllowUserToDeleteRows = false;
            this.dgvExpense.AutoGenerateColumns = false;
            this.dgvExpense.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpenseIID,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvExpense.DataSource = this.expenseBindingSource;
            this.dgvExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpense.Location = new System.Drawing.Point(0, 59);
            this.dgvExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.ReadOnly = true;
            this.dgvExpense.RowHeadersWidth = 10;
            this.dgvExpense.RowTemplate.Height = 35;
            this.dgvExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpense.Size = new System.Drawing.Size(761, 171);
            this.dgvExpense.TabIndex = 2;
            this.dgvExpense.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellDoubleClick);
            // 
            // colExpenseIID
            // 
            this.colExpenseIID.DataPropertyName = "IID";
            this.colExpenseIID.HeaderText = "IID";
            this.colExpenseIID.Name = "colExpenseIID";
            this.colExpenseIID.ReadOnly = true;
            this.colExpenseIID.Visible = false;
            this.colExpenseIID.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 120;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(Expense);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddExpense,
            this.tsEditExpense,
            this.tsDeleteExpense,
            this.tsReloadExpense});
            this.toolStrip1.Location = new System.Drawing.Point(0, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAddExpense
            // 
            this.tsAddExpense.AutoSize = false;
            this.tsAddExpense.Image = global::DTRMNS.Properties.Resources.arti32;
            this.tsAddExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddExpense.Name = "tsAddExpense";
            this.tsAddExpense.Size = new System.Drawing.Size(63, 41);
            this.tsAddExpense.Text = "Add New";
            this.tsAddExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddExpense.Click += new System.EventHandler(this.tsAddExpense_Click);
            // 
            // tsEditExpense
            // 
            this.tsEditExpense.AutoSize = false;
            this.tsEditExpense.Image = global::DTRMNS.Properties.Resources.MatReport_32;
            this.tsEditExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditExpense.Name = "tsEditExpense";
            this.tsEditExpense.Size = new System.Drawing.Size(63, 41);
            this.tsEditExpense.Text = "Edit";
            this.tsEditExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEditExpense.Click += new System.EventHandler(this.tsEditExpense_Click);
            // 
            // tsDeleteExpense
            // 
            this.tsDeleteExpense.AutoSize = false;
            this.tsDeleteExpense.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.tsDeleteExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteExpense.Name = "tsDeleteExpense";
            this.tsDeleteExpense.Size = new System.Drawing.Size(63, 41);
            this.tsDeleteExpense.Text = "Delete";
            this.tsDeleteExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsDeleteExpense.Click += new System.EventHandler(this.tsDeleteExpense_Click);
            // 
            // tsReloadExpense
            // 
            this.tsReloadExpense.AutoSize = false;
            this.tsReloadExpense.Image = global::DTRMNS.Properties.Resources.Reload_32;
            this.tsReloadExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReloadExpense.Name = "tsReloadExpense";
            this.tsReloadExpense.Size = new System.Drawing.Size(63, 41);
            this.tsReloadExpense.Text = "Reload";
            this.tsReloadExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReloadExpense.Click += new System.EventHandler(this.tsReloadExpense_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(761, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "EXPENSES";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKassaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKassaCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kassa  Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKassaCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIncomeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbController;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbManagedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBonus;
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.BindingSource staffIncomeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.ToolStripButton cmdPrint;
        private System.Windows.Forms.ToolStripButton cmdClose;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAddExpense;
        private System.Windows.Forms.ToolStripButton tsEditExpense;
        private System.Windows.Forms.ToolStripButton tsDeleteExpense;
        private System.Windows.Forms.ToolStripButton tsReloadExpense;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.ComboBox cmbXType;
        private PosLibrary.DoubleTextBox txtXAmount;
        private PosLibrary.DoubleTextBox txtAfterSaleAmount;
        private PosLibrary.DoubleTextBox txtPinTerminalTotal;
        private PosLibrary.DoubleTextBox txtPinKassaTotal;
        private PosLibrary.DoubleTextBox txtBahsisTotal;
        private PosLibrary.DoubleTextBox txtBonusTotal;
        private PosLibrary.DoubleTextBox txtHowManyBonus;
        private PosLibrary.DoubleTextBox txtRateTotal;
        private PosLibrary.DoubleTextBox txtExpensesTotal;
        private PosLibrary.DoubleTextBox txtGrandTotal;
        private PosLibrary.DoubleTextBox txtStepTwoTotal;
        private PosLibrary.DoubleTextBox txtShortAmount;
        private PosLibrary.DoubleTextBox txtExtraAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton cmdCalculate;
        private System.Windows.Forms.ToolStripButton cmdDuplicate;
        private System.Windows.Forms.Label lblBahsisDifference;
        private System.Windows.Forms.Label lblShortDifference;
        private System.Windows.Forms.Button btnBahsisTotal;
        private System.Windows.Forms.Button btnShortCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeTotalDataGridViewTextBoxColumn;
    }
}