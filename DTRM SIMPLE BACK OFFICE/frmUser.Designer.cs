namespace POSOffice {
    partial class frmUser {
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
            txtUserName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbAccessLevels = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtPassword = new PosLibrary.IntegerTextBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label8.ForeColor = System.Drawing.SystemColors.ControlText;
            label8.Location = new System.Drawing.Point(34, 40);
            label8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 13);
            label8.TabIndex = 64;
            label8.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtUserName.Location = new System.Drawing.Point(111, 31);
            txtUserName.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(206, 26);
            txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(34, 99);
            label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 68;
            label1.Text = "Password";
            // 
            // cmbAccessLevels
            // 
            cmbAccessLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAccessLevels.Font = new System.Drawing.Font("Arial", 12F);
            cmbAccessLevels.FormattingEnabled = true;
            cmbAccessLevels.Items.AddRange(new object[] { "User", "Manager", "SuperUser", "TechnicalSupport" });
            cmbAccessLevels.Location = new System.Drawing.Point(111, 168);
            cmbAccessLevels.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            cmbAccessLevels.Name = "cmbAccessLevels";
            cmbAccessLevels.Size = new System.Drawing.Size(206, 26);
            cmbAccessLevels.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(34, 177);
            label7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 13);
            label7.TabIndex = 67;
            label7.Text = "User Type";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(224, 240);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(93, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(107, 240);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(93, 45);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            txtPassword.Increment = 1;
            txtPassword.Location = new System.Drawing.Point(111, 88);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.MaxValue = 10000;
            txtPassword.MinValue = -10000;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(206, 29);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "0";
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtPassword.Value = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(113, 123);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 69;
            label2.Text = "(Numbers Only)";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 309);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(cmbAccessLevels);
            Controls.Add(label7);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "User Details";
            Load += frmSingleUser_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccessLevels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private PosLibrary.IntegerTextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}