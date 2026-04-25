namespace WinLayer {
    partial class frmPassword {
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPassword.Location = new System.Drawing.Point(13, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 35);
            this.txtPassword.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(266, 35);
            this.lblMessage.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(13, 447);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(260, 48);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(193, 357);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 80);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(103, 357);
            this.button11.Margin = new System.Windows.Forms.Padding(5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 80);
            this.button11.TabIndex = 23;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(13, 357);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 80);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(193, 267);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 21;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(103, 267);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 20;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(13, 267);
            this.button9.Margin = new System.Windows.Forms.Padding(5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 19;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(193, 177);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 18;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(103, 177);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(13, 177);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 16;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(193, 87);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 15;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(103, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 14;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(13, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 13;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.KeyHandle_Click);
            // 
            // frmPassword
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(291, 507);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADMIN  LOGIN";
            this.Load += new System.EventHandler(this.frmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}