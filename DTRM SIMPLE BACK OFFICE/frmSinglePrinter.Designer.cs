namespace DTRMSimpleBackOffice {
    partial class frmSinglePrinter {
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFunctionalPrinterType = new System.Windows.Forms.ComboBox();
            this.txtSpecialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNetworkName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAdminOnly = new System.Windows.Forms.CheckBox();
            this.chkDeliveryPrinter = new System.Windows.Forms.CheckBox();
            this.chkTakeAwayPrinter = new System.Windows.Forms.CheckBox();
            this.chkSetForThisTerminal = new System.Windows.Forms.CheckBox();
            this.lblExistingClientIID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Printer Special Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Functional Printer Type";
            // 
            // cmbFunctionalPrinterType
            // 
            this.cmbFunctionalPrinterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunctionalPrinterType.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbFunctionalPrinterType.FormattingEnabled = true;
            this.cmbFunctionalPrinterType.Items.AddRange(new object[] {
            "Unknown",
            "Kitchen Printer",
            "Receipt Printer",
            "Mutant Printer"});
            this.cmbFunctionalPrinterType.Location = new System.Drawing.Point(262, 50);
            this.cmbFunctionalPrinterType.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.cmbFunctionalPrinterType.Name = "cmbFunctionalPrinterType";
            this.cmbFunctionalPrinterType.Size = new System.Drawing.Size(177, 26);
            this.cmbFunctionalPrinterType.TabIndex = 56;
            // 
            // txtSpecialName
            // 
            this.txtSpecialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSpecialName.Location = new System.Drawing.Point(31, 49);
            this.txtSpecialName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtSpecialName.Name = "txtSpecialName";
            this.txtSpecialName.Size = new System.Drawing.Size(177, 26);
            this.txtSpecialName.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mapped Local Printer";
            // 
            // cmbNetworkName
            // 
            this.cmbNetworkName.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbNetworkName.FormattingEnabled = true;
            this.cmbNetworkName.Location = new System.Drawing.Point(31, 122);
            this.cmbNetworkName.Name = "cmbNetworkName";
            this.cmbNetworkName.Size = new System.Drawing.Size(408, 26);
            this.cmbNetworkName.TabIndex = 61;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkAdminOnly
            // 
            this.chkAdminOnly.AutoSize = true;
            this.chkAdminOnly.Location = new System.Drawing.Point(31, 201);
            this.chkAdminOnly.Name = "chkAdminOnly";
            this.chkAdminOnly.Size = new System.Drawing.Size(105, 17);
            this.chkAdminOnly.TabIndex = 138;
            this.chkAdminOnly.Text = "Admin View Only";
            this.chkAdminOnly.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryPrinter
            // 
            this.chkDeliveryPrinter.AutoSize = true;
            this.chkDeliveryPrinter.Location = new System.Drawing.Point(31, 234);
            this.chkDeliveryPrinter.Name = "chkDeliveryPrinter";
            this.chkDeliveryPrinter.Size = new System.Drawing.Size(97, 17);
            this.chkDeliveryPrinter.TabIndex = 139;
            this.chkDeliveryPrinter.Text = "Delivery Printer";
            this.chkDeliveryPrinter.UseVisualStyleBackColor = true;
            // 
            // chkTakeAwayPrinter
            // 
            this.chkTakeAwayPrinter.AutoSize = true;
            this.chkTakeAwayPrinter.Location = new System.Drawing.Point(31, 267);
            this.chkTakeAwayPrinter.Name = "chkTakeAwayPrinter";
            this.chkTakeAwayPrinter.Size = new System.Drawing.Size(113, 17);
            this.chkTakeAwayPrinter.TabIndex = 140;
            this.chkTakeAwayPrinter.Text = "Take Away Printer";
            this.chkTakeAwayPrinter.UseVisualStyleBackColor = true;
            // 
            // chkSetForThisTerminal
            // 
            this.chkSetForThisTerminal.AutoSize = true;
            this.chkSetForThisTerminal.ForeColor = System.Drawing.Color.Red;
            this.chkSetForThisTerminal.Location = new System.Drawing.Point(31, 167);
            this.chkSetForThisTerminal.Name = "chkSetForThisTerminal";
            this.chkSetForThisTerminal.Size = new System.Drawing.Size(182, 17);
            this.chkSetForThisTerminal.TabIndex = 141;
            this.chkSetForThisTerminal.Text = "Set This Printer For This Terminal";
            this.chkSetForThisTerminal.UseVisualStyleBackColor = true;
            // 
            // lblExistingClientIID
            // 
            this.lblExistingClientIID.ForeColor = System.Drawing.Color.Blue;
            this.lblExistingClientIID.Location = new System.Drawing.Point(219, 164);
            this.lblExistingClientIID.Name = "lblExistingClientIID";
            this.lblExistingClientIID.Size = new System.Drawing.Size(220, 23);
            this.lblExistingClientIID.TabIndex = 142;
            this.lblExistingClientIID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSinglePrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 314);
            this.ControlBox = false;
            this.Controls.Add(this.lblExistingClientIID);
            this.Controls.Add(this.chkSetForThisTerminal);
            this.Controls.Add(this.chkTakeAwayPrinter);
            this.Controls.Add(this.chkDeliveryPrinter);
            this.Controls.Add(this.chkAdminOnly);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSpecialName);
            this.Controls.Add(this.cmbNetworkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFunctionalPrinterType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSinglePrinter";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRINTER EDITOR";
            this.Load += new System.EventHandler(this.frmPrinterEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFunctionalPrinterType;
        private System.Windows.Forms.TextBox txtSpecialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNetworkName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAdminOnly;
        private System.Windows.Forms.CheckBox chkDeliveryPrinter;
        private System.Windows.Forms.CheckBox chkTakeAwayPrinter;
        private System.Windows.Forms.CheckBox chkSetForThisTerminal;
        private System.Windows.Forms.Label lblExistingClientIID;
    }
}