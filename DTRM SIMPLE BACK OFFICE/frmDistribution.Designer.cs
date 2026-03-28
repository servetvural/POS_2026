using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmDistribution {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribution));
            txtPrintableCategoryName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            cmbPrimaryPrinter = new System.Windows.Forms.ComboBox();
            printerBindingSource = new System.Windows.Forms.BindingSource(components);
            cmbMenu = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            btnNewPrinter = new System.Windows.Forms.Button();
            dgv = new System.Windows.Forms.DataGridView();
            distributionPrinterBindingSource = new System.Windows.Forms.BindingSource(components);
            btnDeletePrinter = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnSort = new System.Windows.Forms.Button();
            btnMoveDown = new System.Windows.Forms.Button();
            btnMoveUp = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            intOrder = new System.Windows.Forms.NumericUpDown();
            colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)printerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionPrinterBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intOrder).BeginInit();
            SuspendLayout();
            // 
            // txtPrintableCategoryName
            // 
            txtPrintableCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            txtPrintableCategoryName.Location = new System.Drawing.Point(13, 35);
            txtPrintableCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPrintableCategoryName.Name = "txtPrintableCategoryName";
            txtPrintableCategoryName.Size = new System.Drawing.Size(327, 29);
            txtPrintableCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Distribution Name";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(665, 353);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(132, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(469, 353);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(132, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbPrimaryPrinter
            // 
            cmbPrimaryPrinter.DataSource = printerBindingSource;
            cmbPrimaryPrinter.DisplayMember = "ApplicationName";
            cmbPrimaryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPrimaryPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbPrimaryPrinter.FormattingEnabled = true;
            cmbPrimaryPrinter.Location = new System.Drawing.Point(18, 23);
            cmbPrimaryPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbPrimaryPrinter.Name = "cmbPrimaryPrinter";
            cmbPrimaryPrinter.Size = new System.Drawing.Size(327, 32);
            cmbPrimaryPrinter.TabIndex = 153;
            cmbPrimaryPrinter.ValueMember = "IID";
            // 
            // printerBindingSource
            // 
            printerBindingSource.DataSource = typeof(Printer);
            // 
            // cmbMenu
            // 
            cmbMenu.DisplayMember = "MenuName";
            cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new System.Drawing.Point(378, 35);
            cmbMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new System.Drawing.Size(327, 32);
            cmbMenu.TabIndex = 154;
            cmbMenu.ValueMember = "IID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 9.75F);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(380, 16);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 16);
            label3.TabIndex = 155;
            label3.Text = "Menu";
            // 
            // btnNewPrinter
            // 
            btnNewPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNewPrinter.Image = Properties.Resources.arti32;
            btnNewPrinter.Location = new System.Drawing.Point(363, 20);
            btnNewPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewPrinter.Name = "btnNewPrinter";
            btnNewPrinter.Size = new System.Drawing.Size(132, 37);
            btnNewPrinter.TabIndex = 156;
            btnNewPrinter.Text = "Add Printer";
            btnNewPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNewPrinter.UseVisualStyleBackColor = true;
            btnNewPrinter.Click += btnNewPrinter_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIID, PrinterName, dOrderDataGridViewTextBoxColumn });
            dgv.DataSource = distributionPrinterBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(18, 65);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(766, 164);
            dgv.TabIndex = 157;
            // 
            // distributionPrinterBindingSource
            // 
            distributionPrinterBindingSource.DataSource = typeof(DistributionPrinter);
            // 
            // btnDeletePrinter
            // 
            btnDeletePrinter.Image = Properties.Resources.eksi32;
            btnDeletePrinter.Location = new System.Drawing.Point(673, 20);
            btnDeletePrinter.Name = "btnDeletePrinter";
            btnDeletePrinter.Size = new System.Drawing.Size(46, 37);
            btnDeletePrinter.TabIndex = 158;
            btnDeletePrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDeletePrinter.UseVisualStyleBackColor = true;
            btnDeletePrinter.Click += btnDeletePrinter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSort);
            groupBox1.Controls.Add(btnMoveDown);
            groupBox1.Controls.Add(btnMoveUp);
            groupBox1.Controls.Add(btnNewPrinter);
            groupBox1.Controls.Add(btnDeletePrinter);
            groupBox1.Controls.Add(dgv);
            groupBox1.Controls.Add(cmbPrimaryPrinter);
            groupBox1.Location = new System.Drawing.Point(13, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(798, 246);
            groupBox1.TabIndex = 159;
            groupBox1.TabStop = false;
            groupBox1.Text = "Distribution Printers";
            // 
            // btnSort
            // 
            btnSort.Image = Properties.Resources.updown;
            btnSort.Location = new System.Drawing.Point(502, 20);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(46, 37);
            btnSort.TabIndex = 161;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Image = Properties.Resources.down2;
            btnMoveDown.Location = new System.Drawing.Point(613, 20);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new System.Drawing.Size(46, 37);
            btnMoveDown.TabIndex = 160;
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += btnMoveDown_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Image = Properties.Resources.up2;
            btnMoveUp.Location = new System.Drawing.Point(553, 20);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new System.Drawing.Size(46, 37);
            btnMoveUp.TabIndex = 159;
            btnMoveUp.UseVisualStyleBackColor = true;
            btnMoveUp.Click += btnMoveUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Arial", 9.75F);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(726, 16);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 16);
            label2.TabIndex = 160;
            label2.Text = "Order";
            // 
            // intOrder
            // 
            intOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            intOrder.Location = new System.Drawing.Point(726, 35);
            intOrder.Name = "intOrder";
            intOrder.Size = new System.Drawing.Size(71, 29);
            intOrder.TabIndex = 161;
            intOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            intOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // colIID
            // 
            colIID.DataPropertyName = "IID";
            colIID.HeaderText = "IID";
            colIID.Name = "colIID";
            colIID.ReadOnly = true;
            colIID.Visible = false;
            // 
            // PrinterName
            // 
            PrinterName.DataPropertyName = "PrinterName";
            PrinterName.HeaderText = "PrinterName";
            PrinterName.Name = "PrinterName";
            PrinterName.ReadOnly = true;
            PrinterName.Width = 300;
            // 
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.ReadOnly = true;
            dOrderDataGridViewTextBoxColumn.Width = 70;
            // 
            // frmDistribution
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 419);
            ControlBox = false;
            Controls.Add(intOrder);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(cmbMenu);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(txtPrintableCategoryName);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDistribution";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DISTRIBUTION";
            Load += frmDistribution_Load;
            ((System.ComponentModel.ISupportInitialize)printerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionPrinterBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)intOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrintableCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPrimaryPrinter;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewPrinter;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDeletePrinter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource distributionPrinterBindingSource;
        private System.Windows.Forms.BindingSource printerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
    }
}