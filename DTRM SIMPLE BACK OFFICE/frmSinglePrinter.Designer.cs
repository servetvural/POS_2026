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
            txtApplicationName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbNetworkName = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            chkAdminOnly = new System.Windows.Forms.CheckBox();
            chkDeliveryPrinter = new System.Windows.Forms.CheckBox();
            chkTakeAwayPrinter = new System.Windows.Forms.CheckBox();
            cmbPrinterVisibility = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtLocalTerminal = new System.Windows.Forms.TextBox();
            btnSetThis = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(36, 37);
            label8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 16);
            label8.TabIndex = 52;
            label8.Text = "Application Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(36, 241);
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
            cmbFunctionalPrinterType.Location = new System.Drawing.Point(230, 236);
            cmbFunctionalPrinterType.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            cmbFunctionalPrinterType.Name = "cmbFunctionalPrinterType";
            cmbFunctionalPrinterType.Size = new System.Drawing.Size(206, 26);
            cmbFunctionalPrinterType.TabIndex = 56;
            // 
            // txtApplicationName
            // 
            txtApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtApplicationName.Location = new System.Drawing.Point(230, 31);
            txtApplicationName.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            txtApplicationName.Name = "txtApplicationName";
            txtApplicationName.Size = new System.Drawing.Size(206, 26);
            txtApplicationName.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(36, 164);
            label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 16);
            label1.TabIndex = 60;
            label1.Text = "Network Name";
            // 
            // cmbNetworkName
            // 
            cmbNetworkName.Font = new System.Drawing.Font("Arial", 12F);
            cmbNetworkName.FormattingEnabled = true;
            cmbNetworkName.Location = new System.Drawing.Point(36, 184);
            cmbNetworkName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbNetworkName.Name = "cmbNetworkName";
            cmbNetworkName.Size = new System.Drawing.Size(400, 26);
            cmbNetworkName.TabIndex = 61;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(343, 412);
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
            btnCancel.Location = new System.Drawing.Point(230, 412);
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
            chkAdminOnly.Location = new System.Drawing.Point(230, 367);
            chkAdminOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkAdminOnly.Name = "chkAdminOnly";
            chkAdminOnly.Size = new System.Drawing.Size(183, 19);
            chkAdminOnly.TabIndex = 138;
            chkAdminOnly.Text = "Only Visible to Administrators";
            chkAdminOnly.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryPrinter
            // 
            chkDeliveryPrinter.AutoSize = true;
            chkDeliveryPrinter.Location = new System.Drawing.Point(230, 289);
            chkDeliveryPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkDeliveryPrinter.Name = "chkDeliveryPrinter";
            chkDeliveryPrinter.Size = new System.Drawing.Size(161, 19);
            chkDeliveryPrinter.TabIndex = 139;
            chkDeliveryPrinter.Text = "Assign AS Delivery Printer";
            chkDeliveryPrinter.UseVisualStyleBackColor = true;
            // 
            // chkTakeAwayPrinter
            // 
            chkTakeAwayPrinter.AutoSize = true;
            chkTakeAwayPrinter.Location = new System.Drawing.Point(230, 329);
            chkTakeAwayPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTakeAwayPrinter.Name = "chkTakeAwayPrinter";
            chkTakeAwayPrinter.Size = new System.Drawing.Size(177, 19);
            chkTakeAwayPrinter.TabIndex = 140;
            chkTakeAwayPrinter.Text = "Assign AS Take-Away Printer";
            chkTakeAwayPrinter.UseVisualStyleBackColor = true;
            // 
            // cmbPrinterVisibility
            // 
            cmbPrinterVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPrinterVisibility.Font = new System.Drawing.Font("Arial", 12F);
            cmbPrinterVisibility.FormattingEnabled = true;
            cmbPrinterVisibility.Items.AddRange(new object[] { "Local", "Global" });
            cmbPrinterVisibility.Location = new System.Drawing.Point(230, 74);
            cmbPrinterVisibility.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            cmbPrinterVisibility.Name = "cmbPrinterVisibility";
            cmbPrinterVisibility.Size = new System.Drawing.Size(206, 26);
            cmbPrinterVisibility.TabIndex = 143;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(36, 79);
            label2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 16);
            label2.TabIndex = 144;
            label2.Text = "Printer Visibility";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(36, 121);
            label3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 16);
            label3.TabIndex = 145;
            label3.Text = "Local Terminal";
            // 
            // txtLocalTerminal
            // 
            txtLocalTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtLocalTerminal.Location = new System.Drawing.Point(230, 115);
            txtLocalTerminal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            txtLocalTerminal.Name = "txtLocalTerminal";
            txtLocalTerminal.Size = new System.Drawing.Size(206, 26);
            txtLocalTerminal.TabIndex = 146;
            // 
            // btnSetThis
            // 
            btnSetThis.Location = new System.Drawing.Point(142, 115);
            btnSetThis.Name = "btnSetThis";
            btnSetThis.Size = new System.Drawing.Size(75, 26);
            btnSetThis.TabIndex = 147;
            btnSetThis.Text = "Set This";
            btnSetThis.UseVisualStyleBackColor = true;
            btnSetThis.Click += btnSetThis_Click;
            // 
            // frmSinglePrinter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 494);
            ControlBox = false;
            Controls.Add(btnSetThis);
            Controls.Add(label3);
            Controls.Add(txtLocalTerminal);
            Controls.Add(cmbPrinterVisibility);
            Controls.Add(label2);
            Controls.Add(chkTakeAwayPrinter);
            Controls.Add(chkDeliveryPrinter);
            Controls.Add(chkAdminOnly);
            Controls.Add(label8);
            Controls.Add(txtApplicationName);
            Controls.Add(cmbNetworkName);
            Controls.Add(label1);
            Controls.Add(cmbFunctionalPrinterType);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmSinglePrinter";
            Padding = new System.Windows.Forms.Padding(12);
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
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNetworkName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAdminOnly;
        private System.Windows.Forms.CheckBox chkDeliveryPrinter;
        private System.Windows.Forms.CheckBox chkTakeAwayPrinter;
        private System.Windows.Forms.ComboBox cmbPrinterVisibility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalTerminal;
        private System.Windows.Forms.Button btnSetThis;
    }
}