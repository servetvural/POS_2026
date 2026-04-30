namespace WinLayer {
    partial class frmSupplier {
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
            txtSupplierName = new TextBox();
            label1 = new Label();
            txtTel = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtEmail1 = new TextBox();
            label4 = new Label();
            txtEmail2 = new TextBox();
            label5 = new Label();
            txtwhatsup = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtPrefix = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.AcceptsReturn = true;
            txtSupplierName.Location = new Point(136, 21);
            txtSupplierName.Margin = new Padding(4, 3, 4, 3);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(230, 23);
            txtSupplierName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Supplier Name";
            // 
            // txtTel
            // 
            txtTel.AcceptsReturn = true;
            txtTel.Location = new Point(136, 91);
            txtTel.Margin = new Padding(4, 3, 4, 3);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(230, 23);
            txtTel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 4;
            label2.Text = "Tel";
            // 
            // txtAddress
            // 
            txtAddress.AcceptsReturn = true;
            txtAddress.Location = new Point(136, 137);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(230, 92);
            txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // txtEmail1
            // 
            txtEmail1.AcceptsReturn = true;
            txtEmail1.Location = new Point(136, 246);
            txtEmail1.Margin = new Padding(4, 3, 4, 3);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(230, 23);
            txtEmail1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Email 1";
            // 
            // txtEmail2
            // 
            txtEmail2.AcceptsReturn = true;
            txtEmail2.Location = new Point(136, 292);
            txtEmail2.Margin = new Padding(4, 3, 4, 3);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(230, 23);
            txtEmail2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Email 2";
            // 
            // txtwhatsup
            // 
            txtwhatsup.AcceptsReturn = true;
            txtwhatsup.Location = new Point(136, 340);
            txtwhatsup.Margin = new Padding(4, 3, 4, 3);
            txtwhatsup.Name = "txtwhatsup";
            txtwhatsup.Size = new Size(230, 23);
            txtwhatsup.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 344);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Whatsup";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(274, 385);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(136, 385);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 45);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPrefix
            // 
            txtPrefix.AcceptsReturn = true;
            txtPrefix.Location = new Point(136, 57);
            txtPrefix.Margin = new Padding(4, 3, 4, 3);
            txtPrefix.MaxLength = 6;
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(230, 23);
            txtPrefix.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 60);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Prefix";
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 458);
            ControlBox = false;
            Controls.Add(txtPrefix);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtwhatsup);
            Controls.Add(label6);
            Controls.Add(txtEmail2);
            Controls.Add(label5);
            Controls.Add(txtEmail1);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtTel);
            Controls.Add(label2);
            Controls.Add(txtSupplierName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SUPPLIER";
            Load += frmSupplier_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtwhatsup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox txtPrefix;
        private Label label7;
    }
}