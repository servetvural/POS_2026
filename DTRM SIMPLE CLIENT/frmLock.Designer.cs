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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLock));
            this.pnlAlign = new System.Windows.Forms.Panel();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn8 = new System.Windows.Forms.Button();
            this.lblNotify = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogon = new System.Windows.Forms.Button();
            this.pnlAlign.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlign
            // 
            this.pnlAlign.Controls.Add(this.LogoBox);
            this.pnlAlign.Controls.Add(this.txtUserPassword);
            this.pnlAlign.Controls.Add(this.btnExit);
            this.pnlAlign.Controls.Add(this.lblSaat);
            this.pnlAlign.Controls.Add(this.panel1);
            this.pnlAlign.Controls.Add(this.btnLogon);
            this.pnlAlign.Location = new System.Drawing.Point(150, 0);
            this.pnlAlign.Name = "pnlAlign";
            this.pnlAlign.Size = new System.Drawing.Size(724, 742);
            this.pnlAlign.TabIndex = 100;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.Black;
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.White;
            this.txtUserPassword.Location = new System.Drawing.Point(207, 144);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.ReadOnly = true;
            this.txtUserPassword.Size = new System.Drawing.Size(330, 43);
            this.txtUserPassword.TabIndex = 98;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaat
            // 
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(190, 702);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(362, 36);
            this.lblSaat.TabIndex = 97;
            this.lblSaat.Text = "00:00:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblNotify);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.pBar);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Location = new System.Drawing.Point(190, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 496);
            this.panel1.TabIndex = 0;
            // 
            // btn8
            // 
            this.btn8.AutoEllipsis = true;
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(132, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 2;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.KeyHandle);
            // 
            // lblNotify
            // 
            this.lblNotify.ForeColor = System.Drawing.Color.White;
            this.lblNotify.Location = new System.Drawing.Point(16, 455);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(331, 17);
            this.lblNotify.TabIndex = 93;
            this.lblNotify.Text = "LOGIN  YOUR  KEY";
            // 
            // btn2
            // 
            this.btn2.AutoEllipsis = true;
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(132, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 8;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.KeyHandle);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(17, 475);
            this.pBar.MarqueeAnimationSpeed = 30;
            this.pBar.Maximum = 10;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(328, 12);
            this.pBar.TabIndex = 92;
            this.pBar.Text = "progressBarX1";
            // 
            // btn3
            // 
            this.btn3.AutoEllipsis = true;
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(245, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 9;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn6
            // 
            this.btn6.AutoEllipsis = true;
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(245, 116);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn7
            // 
            this.btn7.AutoEllipsis = true;
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(17, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 1;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn0
            // 
            this.btn0.AutoEllipsis = true;
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(17, 340);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 100);
            this.btn0.TabIndex = 10;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn9
            // 
            this.btn9.AutoEllipsis = true;
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(245, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 3;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn1
            // 
            this.btn1.AutoEllipsis = true;
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(17, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 7;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn5
            // 
            this.btn5.AutoEllipsis = true;
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(132, 116);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 5;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btn4
            // 
            this.btn4.AutoEllipsis = true;
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(17, 116);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.KeyHandle);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.TmrSaat_Tick);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::DTRMClientNS.Properties.Resources.Logo;
            this.LogoBox.Location = new System.Drawing.Point(342, 22);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(48, 48);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 88;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click);
            this.LogoBox.DoubleClick += new System.EventHandler(this.LogoBox_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.AutoEllipsis = true;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImage = global::DTRMClientNS.Properties.Resources.LOGOUT;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(16, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 128);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "LOGOUT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoEllipsis = true;
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.BackgroundImage = global::DTRMClientNS.Properties.Resources.shadow;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(245, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 100);
            this.btnClear.TabIndex = 11;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.AutoEllipsis = true;
            this.btnLogon.BackColor = System.Drawing.Color.Black;
            this.btnLogon.BackgroundImage = global::DTRMClientNS.Properties.Resources.LOGIN;
            this.btnLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogon.FlatAppearance.BorderSize = 0;
            this.btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(580, 529);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(128, 128);
            this.btnLogon.TabIndex = 1;
            this.btnLogon.TabStop = false;
            this.btnLogon.Text = "LOGON";
            this.btnLogon.UseVisualStyleBackColor = false;
            this.btnLogon.Click += new System.EventHandler(this.BtnLogon_Click);
            // 
            // FrmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAlign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLock_Load);
            this.Shown += new System.EventHandler(this.FrmLock_Shown);
            this.pnlAlign.ResumeLayout(false);
            this.pnlAlign.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ProgressBar pBar;
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