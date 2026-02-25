namespace DTRMNS {
    partial class ctlKitchenOrder {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblReference = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnPrintWithDetails = new System.Windows.Forms.Button();
            this.btnPrintAsReceipt = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.pnlColor.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.pnlPayment);
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlColor.Location = new System.Drawing.Point(431, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(26, 193);
            this.pnlColor.TabIndex = 1;
            this.pnlColor.Click += new System.EventHandler(this.PnlColor_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.MinimumSize = new System.Drawing.Size(100, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(431, 61);
            this.pnlMain.TabIndex = 3;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.BackColor = System.Drawing.Color.Transparent;
            this.lblReference.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.ForeColor = System.Drawing.Color.Red;
            this.lblReference.Location = new System.Drawing.Point(0, 0);
            this.lblReference.MinimumSize = new System.Drawing.Size(120, 0);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(120, 20);
            this.lblReference.TabIndex = 0;
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblTime);
            this.pnlBottom.Controls.Add(this.lblReference);
            this.pnlBottom.Controls.Add(this.pBar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 161);
            this.pnlBottom.MinimumSize = new System.Drawing.Size(0, 32);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(431, 32);
            this.pnlBottom.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(120, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(311, 22);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar.Location = new System.Drawing.Point(0, 22);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(431, 10);
            this.pBar.TabIndex = 7;
            this.pBar.Value = 50;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnFullScreen);
            this.pnlButtons.Controls.Add(this.btnPrintWithDetails);
            this.pnlButtons.Controls.Add(this.btnPrintAsReceipt);
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(431, 100);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Image = global::DTRMNS.Properties.Resources.fullscreen;
            this.btnFullScreen.Location = new System.Drawing.Point(240, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(80, 100);
            this.btnFullScreen.TabIndex = 10;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Visible = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnPrintWithDetails
            // 
            this.btnPrintWithDetails.BackColor = System.Drawing.Color.White;
            this.btnPrintWithDetails.BackgroundImage = global::DTRMNS.Properties.Resources.chef64;
            this.btnPrintWithDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintWithDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrintWithDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintWithDetails.FlatAppearance.BorderSize = 0;
            this.btnPrintWithDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintWithDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrintWithDetails.ForeColor = System.Drawing.Color.White;
            this.btnPrintWithDetails.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrintWithDetails.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPrintWithDetails.Location = new System.Drawing.Point(160, 0);
            this.btnPrintWithDetails.Name = "btnPrintWithDetails";
            this.btnPrintWithDetails.Size = new System.Drawing.Size(80, 100);
            this.btnPrintWithDetails.TabIndex = 9;
            this.btnPrintWithDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintWithDetails.UseVisualStyleBackColor = false;
            this.btnPrintWithDetails.Click += new System.EventHandler(this.BtnPrintWithDetails_Click);
            // 
            // btnPrintAsReceipt
            // 
            this.btnPrintAsReceipt.BackColor = System.Drawing.Color.White;
            this.btnPrintAsReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintAsReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrintAsReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintAsReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintAsReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAsReceipt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrintAsReceipt.ForeColor = System.Drawing.Color.Red;
            this.btnPrintAsReceipt.Image = global::DTRMNS.Properties.Resources.Print;
            this.btnPrintAsReceipt.Location = new System.Drawing.Point(80, 0);
            this.btnPrintAsReceipt.Name = "btnPrintAsReceipt";
            this.btnPrintAsReceipt.Size = new System.Drawing.Size(80, 100);
            this.btnPrintAsReceipt.TabIndex = 8;
            this.btnPrintAsReceipt.Text = "RCPT";
            this.btnPrintAsReceipt.UseVisualStyleBackColor = false;
            this.btnPrintAsReceipt.Click += new System.EventHandler(this.BtnPrintAsReceipt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DTRMNS.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 100);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnDone
            // 
            this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDone.BackColor = System.Drawing.Color.Black;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Image = global::DTRMNS.Properties.Resources.right32;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDone.Location = new System.Drawing.Point(457, 0);
            this.btnDone.MinimumSize = new System.Drawing.Size(55, 60);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(55, 193);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "1";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.Red;
            this.pnlPayment.BackgroundImage = global::DTRMNS.Properties.Resources.card64;
            this.pnlPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPayment.Location = new System.Drawing.Point(0, 0);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(26, 26);
            this.pnlPayment.TabIndex = 0;
            this.pnlPayment.Visible = false;
            // 
            // ctlKitchenOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.btnDone);
            this.DoubleBuffered = true;
            this.Name = "ctlKitchenOrder";
            this.Size = new System.Drawing.Size(512, 193);
            this.Load += new System.EventHandler(this.CtlKitchenOrder_Load);
            this.pnlColor.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintAsReceipt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPrintWithDetails;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Panel pnlPayment;
    }
}
