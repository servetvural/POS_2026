namespace DTRMNS {
    partial class frmStaffIncomeEditor {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBonusType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipIncome = new PosLibrary.DoubleTextBox();
            this.txtHours = new PosLibrary.DoubleTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShort = new PosLibrary.DoubleTextBox();
            this.btnChooseEmployee = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.chkNoShort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Employee";
            // 
            // cmbBonusType
            // 
            this.cmbBonusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBonusType.FormattingEnabled = true;
            this.cmbBonusType.Items.AddRange(new object[] {
            "No Tip",
            "Half Tip",
            "Full Tip"});
            this.cmbBonusType.Location = new System.Drawing.Point(144, 136);
            this.cmbBonusType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBonusType.Name = "cmbBonusType";
            this.cmbBonusType.Size = new System.Drawing.Size(181, 32);
            this.cmbBonusType.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tip Type";
            // 
            // btnSave
            // 
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(187, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 47);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(30, 293);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 47);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bahsis";
            // 
            // txtTipIncome
            // 
            this.txtTipIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipIncome.CustomFormat = "N2";
            this.txtTipIncome.CustomUICulture = "en-US";
            this.txtTipIncome.Increment = 1D;
            this.txtTipIncome.Location = new System.Drawing.Point(144, 190);
            this.txtTipIncome.MaxValue = 100000D;
            this.txtTipIncome.MinValue = -100000D;
            this.txtTipIncome.Name = "txtTipIncome";
            this.txtTipIncome.Size = new System.Drawing.Size(100, 29);
            this.txtTipIncome.TabIndex = 62;
            this.txtTipIncome.Text = "0.00";
            this.txtTipIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipIncome.Value = 0D;
            this.txtTipIncome.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // txtHours
            // 
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.CustomFormat = "N0";
            this.txtHours.CustomUICulture = "en-US";
            this.txtHours.Increment = 1D;
            this.txtHours.Location = new System.Drawing.Point(144, 28);
            this.txtHours.MaxValue = 100000D;
            this.txtHours.MinValue = -100000D;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 29);
            this.txtHours.TabIndex = 62;
            this.txtHours.Text = "0";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHours.Value = 0D;
            this.txtHours.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Short";
            // 
            // txtShort
            // 
            this.txtShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShort.CustomFormat = "N2";
            this.txtShort.CustomUICulture = "en-US";
            this.txtShort.Increment = 1D;
            this.txtShort.Location = new System.Drawing.Point(144, 235);
            this.txtShort.MaxValue = 100000D;
            this.txtShort.MinValue = -100000D;
            this.txtShort.Name = "txtShort";
            this.txtShort.Size = new System.Drawing.Size(100, 29);
            this.txtShort.TabIndex = 62;
            this.txtShort.Text = "0.00";
            this.txtShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShort.Value = 0D;
            this.txtShort.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // btnChooseEmployee
            // 
            this.btnChooseEmployee.Location = new System.Drawing.Point(329, 79);
            this.btnChooseEmployee.Name = "btnChooseEmployee";
            this.btnChooseEmployee.Size = new System.Drawing.Size(64, 32);
            this.btnChooseEmployee.TabIndex = 63;
            this.btnChooseEmployee.Text = "....";
            this.btnChooseEmployee.UseVisualStyleBackColor = true;
            this.btnChooseEmployee.Click += new System.EventHandler(this.btnChooseEmployee_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmployee.Location = new System.Drawing.Point(144, 82);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(181, 29);
            this.txtEmployee.TabIndex = 64;
            // 
            // chkNoShort
            // 
            this.chkNoShort.AutoSize = true;
            this.chkNoShort.Enabled = false;
            this.chkNoShort.Location = new System.Drawing.Point(270, 236);
            this.chkNoShort.Name = "chkNoShort";
            this.chkNoShort.Size = new System.Drawing.Size(103, 28);
            this.chkNoShort.TabIndex = 65;
            this.chkNoShort.Text = "No Short";
            this.chkNoShort.UseVisualStyleBackColor = true;
            this.chkNoShort.CheckedChanged += new System.EventHandler(this.chkNoShort_CheckedChanged);
            // 
            // frmStaffIncomeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 381);
            this.Controls.Add(this.chkNoShort);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.btnChooseEmployee);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtShort);
            this.Controls.Add(this.txtTipIncome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbBonusType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaffIncomeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STAFF ";
            this.Load += new System.EventHandler(this.frmStaffIncomeEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBonusType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private PosLibrary.DoubleTextBox txtTipIncome;
        private PosLibrary.DoubleTextBox txtHours;
        private System.Windows.Forms.Label label5;
        private PosLibrary.DoubleTextBox txtShort;
        private System.Windows.Forms.Button btnChooseEmployee;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.CheckBox chkNoShort;
    }
}