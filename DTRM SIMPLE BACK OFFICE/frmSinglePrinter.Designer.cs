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
        private void InitializeComponent()
        {
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cmbFunctionalPrinterType = new System.Windows.Forms.ComboBox();
            txtSpecialName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbNetworkName = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            chkAdminOnly = new System.Windows.Forms.CheckBox();
            chkDeliveryPrinter = new System.Windows.Forms.CheckBox();
            chkTakeAwayPrinter = new System.Windows.Forms.CheckBox();
            chkSetForThisTerminal = new System.Windows.Forms.CheckBox();
            lblExistingClientIID = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(36, 37);
            label8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(130, 16);
            label8.TabIndex = 52;
            label8.Text = "Printer Special Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(306, 37);
            label7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(140, 16);
            label7.TabIndex = 57;
            label7.Text = "Functional Printer Type";
            // 
            // cmbFunctionalPrinterType
            // 
            cmbFunctionalPrinterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFunctionalPrinterType.Font = new System.Drawing.Font("Arial", 12F);
            cmbFunctionalPrinterType.FormattingEnabled = true;
            cmbFunctionalPrinterType.Items.AddRange(new object[] { "Unknown", "Kitchen Printer", "Receipt Printer", "Mutant Printer" });
            cmbFunctionalPrinterType.Location = new System.Drawing.Point(306, 58);
            cmbFunctionalPrinterType.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            cmbFunctionalPrinterType.Name = "cmbFunctionalPrinterType";
            cmbFunctionalPrinterType.Size = new System.Drawing.Size(206, 26);
            cmbFunctionalPrinterType.TabIndex = 56;
            // 
            // txtSpecialName
            // 
            txtSpecialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtSpecialName.Location = new System.Drawing.Point(36, 57);
            txtSpecialName.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            txtSpecialName.Name = "txtSpecialName";
            txtSpecialName.Size = new System.Drawing.Size(206, 26);
            txtSpecialName.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(36, 118);
            label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 16);
            label1.TabIndex = 60;
            label1.Text = "Mapped Local Printer";
            // 
            // cmbNetworkName
            // 
            cmbNetworkName.Font = new System.Drawing.Font("Arial", 12F);
            cmbNetworkName.FormattingEnabled = true;
            cmbNetworkName.Location = new System.Drawing.Point(36, 141);
            cmbNetworkName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbNetworkName.Name = "cmbNetworkName";
            cmbNetworkName.Size = new System.Drawing.Size(475, 26);
            cmbNetworkName.TabIndex = 61;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(419, 283);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(93, 45);
            btnSave.TabIndex = 64;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(306, 283);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(93, 45);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // chkAdminOnly
            // 
            chkAdminOnly.AutoSize = true;
            chkAdminOnly.Location = new System.Drawing.Point(36, 232);
            chkAdminOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkAdminOnly.Name = "chkAdminOnly";
            chkAdminOnly.Size = new System.Drawing.Size(118, 19);
            chkAdminOnly.TabIndex = 138;
            chkAdminOnly.Text = "Admin View Only";
            chkAdminOnly.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryPrinter
            // 
            chkDeliveryPrinter.AutoSize = true;
            chkDeliveryPrinter.Location = new System.Drawing.Point(36, 270);
            chkDeliveryPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkDeliveryPrinter.Name = "chkDeliveryPrinter";
            chkDeliveryPrinter.Size = new System.Drawing.Size(106, 19);
            chkDeliveryPrinter.TabIndex = 139;
            chkDeliveryPrinter.Text = "Delivery Printer";
            chkDeliveryPrinter.UseVisualStyleBackColor = true;
            // 
            // chkTakeAwayPrinter
            // 
            chkTakeAwayPrinter.AutoSize = true;
            chkTakeAwayPrinter.Location = new System.Drawing.Point(36, 308);
            chkTakeAwayPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTakeAwayPrinter.Name = "chkTakeAwayPrinter";
            chkTakeAwayPrinter.Size = new System.Drawing.Size(120, 19);
            chkTakeAwayPrinter.TabIndex = 140;
            chkTakeAwayPrinter.Text = "Take Away Printer";
            chkTakeAwayPrinter.UseVisualStyleBackColor = true;
            // 
            // chkSetForThisTerminal
            // 
            chkSetForThisTerminal.AutoSize = true;
            chkSetForThisTerminal.ForeColor = System.Drawing.Color.Red;
            chkSetForThisTerminal.Location = new System.Drawing.Point(36, 193);
            chkSetForThisTerminal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkSetForThisTerminal.Name = "chkSetForThisTerminal";
            chkSetForThisTerminal.Size = new System.Drawing.Size(199, 19);
            chkSetForThisTerminal.TabIndex = 141;
            chkSetForThisTerminal.Text = "Set This Printer For This Terminal";
            chkSetForThisTerminal.UseVisualStyleBackColor = true;
            // 
            // lblExistingClientIID
            // 
            lblExistingClientIID.ForeColor = System.Drawing.Color.Blue;
            lblExistingClientIID.Location = new System.Drawing.Point(255, 189);
            lblExistingClientIID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExistingClientIID.Name = "lblExistingClientIID";
            lblExistingClientIID.Size = new System.Drawing.Size(257, 27);
            lblExistingClientIID.TabIndex = 142;
            lblExistingClientIID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSinglePrinter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(548, 375);
            ControlBox = false;
            Controls.Add(lblExistingClientIID);
            Controls.Add(chkSetForThisTerminal);
            Controls.Add(chkTakeAwayPrinter);
            Controls.Add(chkDeliveryPrinter);
            Controls.Add(chkAdminOnly);
            Controls.Add(label8);
            Controls.Add(txtSpecialName);
            Controls.Add(cmbNetworkName);
            Controls.Add(label1);
            Controls.Add(cmbFunctionalPrinterType);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmSinglePrinter";
            Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PRINTER EDITOR";
            Load += frmPrinterEditor_Load;
            ResumeLayout(false);
            PerformLayout();

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