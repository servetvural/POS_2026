namespace DTRMClientNS {
    partial class FrmLock {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLock));
            pnlAlign = new System.Windows.Forms.Panel();
            LogoBox = new System.Windows.Forms.PictureBox();
            txtUserPassword = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            lblSaat = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btn8 = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btnLogon = new System.Windows.Forms.Button();
            tmrSaat = new System.Windows.Forms.Timer(components);
            pnlAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAlign
            // 
            pnlAlign.Controls.Add(LogoBox);
            pnlAlign.Controls.Add(txtUserPassword);
            pnlAlign.Controls.Add(btnExit);
            pnlAlign.Controls.Add(lblSaat);
            pnlAlign.Controls.Add(panel1);
            pnlAlign.Controls.Add(btnLogon);
            pnlAlign.Location = new System.Drawing.Point(84, 0);
            pnlAlign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlAlign.Name = "pnlAlign";
            pnlAlign.Size = new System.Drawing.Size(845, 747);
            pnlAlign.TabIndex = 100;
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.Logo;
            LogoBox.Location = new System.Drawing.Point(404, 12);
            LogoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new System.Drawing.Size(56, 55);
            LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            LogoBox.TabIndex = 88;
            LogoBox.TabStop = false;
            LogoBox.DoubleClick += LogoBox_DoubleClick;
            // 
            // txtUserPassword
            // 
            txtUserPassword.BackColor = System.Drawing.Color.Black;
            txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            txtUserPassword.ForeColor = System.Drawing.Color.White;
            txtUserPassword.Location = new System.Drawing.Point(241, 69);
            txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.ReadOnly = true;
            txtUserPassword.Size = new System.Drawing.Size(385, 34);
            txtUserPassword.TabIndex = 98;
            txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.AutoEllipsis = true;
            btnExit.BackColor = System.Drawing.Color.Black;
            btnExit.BackgroundImage = Properties.Resources.LOGOUT;
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(19, 498);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(149, 148);
            btnExit.TabIndex = 2;
            btnExit.Text = "LOGOUT";
            btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // lblSaat
            // 
            lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            lblSaat.ForeColor = System.Drawing.Color.White;
            lblSaat.Location = new System.Drawing.Point(222, 644);
            lblSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new System.Drawing.Size(422, 42);
            lblSaat.TabIndex = 97;
            lblSaat.Text = "00:00:00";
            lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn4);
            panel1.Location = new System.Drawing.Point(222, 109);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(422, 522);
            panel1.TabIndex = 0;
            // 
            // btn8
            // 
            btn8.AutoEllipsis = true;
            btn8.BackColor = System.Drawing.Color.Black;
            btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn8.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn8.ForeColor = System.Drawing.Color.White;
            btn8.Location = new System.Drawing.Point(154, 6);
            btn8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(117, 115);
            btn8.TabIndex = 2;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += KeyHandle;
            // 
            // btnClear
            // 
            btnClear.AutoEllipsis = true;
            btnClear.BackColor = System.Drawing.Color.Maroon;
            btnClear.BackgroundImage = Properties.Resources.shadow;
            btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(286, 392);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(117, 115);
            btnClear.TabIndex = 11;
            btnClear.TabStop = false;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btn2
            // 
            btn2.AutoEllipsis = true;
            btn2.BackColor = System.Drawing.Color.Black;
            btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn2.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn2.ForeColor = System.Drawing.Color.White;
            btn2.Location = new System.Drawing.Point(154, 263);
            btn2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(117, 115);
            btn2.TabIndex = 8;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += KeyHandle;
            // 
            // btn3
            // 
            btn3.AutoEllipsis = true;
            btn3.BackColor = System.Drawing.Color.Black;
            btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn3.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn3.ForeColor = System.Drawing.Color.White;
            btn3.Location = new System.Drawing.Point(286, 263);
            btn3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(117, 115);
            btn3.TabIndex = 9;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += KeyHandle;
            // 
            // btn6
            // 
            btn6.AutoEllipsis = true;
            btn6.BackColor = System.Drawing.Color.Black;
            btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn6.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn6.ForeColor = System.Drawing.Color.White;
            btn6.Location = new System.Drawing.Point(286, 134);
            btn6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(117, 115);
            btn6.TabIndex = 6;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += KeyHandle;
            // 
            // btn7
            // 
            btn7.AutoEllipsis = true;
            btn7.BackColor = System.Drawing.Color.Black;
            btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn7.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn7.ForeColor = System.Drawing.Color.White;
            btn7.Location = new System.Drawing.Point(20, 6);
            btn7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(117, 115);
            btn7.TabIndex = 1;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += KeyHandle;
            // 
            // btn0
            // 
            btn0.AutoEllipsis = true;
            btn0.BackColor = System.Drawing.Color.Black;
            btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn0.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn0.ForeColor = System.Drawing.Color.White;
            btn0.Location = new System.Drawing.Point(20, 392);
            btn0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(117, 115);
            btn0.TabIndex = 10;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += KeyHandle;
            // 
            // btn9
            // 
            btn9.AutoEllipsis = true;
            btn9.BackColor = System.Drawing.Color.Black;
            btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn9.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn9.ForeColor = System.Drawing.Color.White;
            btn9.Location = new System.Drawing.Point(286, 6);
            btn9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(117, 115);
            btn9.TabIndex = 3;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += KeyHandle;
            // 
            // btn1
            // 
            btn1.AutoEllipsis = true;
            btn1.BackColor = System.Drawing.Color.Black;
            btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn1.ForeColor = System.Drawing.Color.White;
            btn1.Location = new System.Drawing.Point(20, 263);
            btn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(117, 115);
            btn1.TabIndex = 7;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += KeyHandle;
            // 
            // btn5
            // 
            btn5.AutoEllipsis = true;
            btn5.BackColor = System.Drawing.Color.Black;
            btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn5.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn5.ForeColor = System.Drawing.Color.White;
            btn5.Location = new System.Drawing.Point(154, 134);
            btn5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(117, 115);
            btn5.TabIndex = 5;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += KeyHandle;
            // 
            // btn4
            // 
            btn4.AutoEllipsis = true;
            btn4.BackColor = System.Drawing.Color.Black;
            btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn4.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            btn4.ForeColor = System.Drawing.Color.White;
            btn4.Location = new System.Drawing.Point(20, 134);
            btn4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(117, 115);
            btn4.TabIndex = 4;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += KeyHandle;
            // 
            // btnLogon
            // 
            btnLogon.AutoEllipsis = true;
            btnLogon.BackColor = System.Drawing.Color.Black;
            btnLogon.BackgroundImage = Properties.Resources.LOGIN;
            btnLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnLogon.FlatAppearance.BorderSize = 0;
            btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            btnLogon.ForeColor = System.Drawing.Color.White;
            btnLogon.Location = new System.Drawing.Point(677, 498);
            btnLogon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogon.Name = "btnLogon";
            btnLogon.Size = new System.Drawing.Size(149, 148);
            btnLogon.TabIndex = 1;
            btnLogon.TabStop = false;
            btnLogon.Text = "LOGON";
            btnLogon.UseVisualStyleBackColor = false;
            btnLogon.Click += BtnLogon_Click;
            // 
            // tmrSaat
            // 
            tmrSaat.Enabled = true;
            tmrSaat.Interval = 1000;
            tmrSaat.Tick += TmrSaat_Tick;
            // 
            // FrmLock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1022, 772);
            ControlBox = false;
            Controls.Add(pnlAlign);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmLock";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FrmLock_Load;
            pnlAlign.ResumeLayout(false);
            pnlAlign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlign;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.Timer tmrSaat;
    }
}