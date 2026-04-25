namespace BSLayer {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlColor = new System.Windows.Forms.Panel();
            pnlPayment = new System.Windows.Forms.Panel();
            pnlMain = new System.Windows.Forms.Panel();
            tmrMain = new System.Windows.Forms.Timer(components);
            lblReference = new System.Windows.Forms.Label();
            pnlBottom = new System.Windows.Forms.Panel();
            lblTime = new System.Windows.Forms.Label();
            pBar = new System.Windows.Forms.ProgressBar();
            pnlButtons = new System.Windows.Forms.Panel();
            btnFullScreen = new System.Windows.Forms.Button();
            btnPrintWithDetails = new System.Windows.Forms.Button();
            btnPrintAsReceipt = new System.Windows.Forms.Button();
            btnPrint = new System.Windows.Forms.Button();
            btnDone = new System.Windows.Forms.Button();
            pnlColor.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlColor
            // 
            pnlColor.Controls.Add(pnlPayment);
            pnlColor.Dock = System.Windows.Forms.DockStyle.Right;
            pnlColor.Location = new System.Drawing.Point(503, 0);
            pnlColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new System.Drawing.Size(30, 223);
            pnlColor.TabIndex = 1;
            pnlColor.Click += PnlColor_Click;
            // 
            // pnlPayment
            // 
            pnlPayment.BackColor = System.Drawing.Color.Red;
            pnlPayment.BackgroundImage = Properties.Resources.card64;
            pnlPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPayment.Dock = System.Windows.Forms.DockStyle.Top;
            pnlPayment.Location = new System.Drawing.Point(0, 0);
            pnlPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Size = new System.Drawing.Size(30, 30);
            pnlPayment.TabIndex = 0;
            pnlPayment.Visible = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoSize = true;
            pnlMain.BackColor = System.Drawing.Color.White;
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 115);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlMain.MinimumSize = new System.Drawing.Size(117, 69);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(503, 71);
            pnlMain.TabIndex = 3;
            // 
            // tmrMain
            // 
            tmrMain.Enabled = true;
            tmrMain.Interval = 1000;
            tmrMain.Tick += TmrMain_Tick;
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.BackColor = System.Drawing.Color.Transparent;
            lblReference.Dock = System.Windows.Forms.DockStyle.Left;
            lblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblReference.ForeColor = System.Drawing.Color.Red;
            lblReference.Location = new System.Drawing.Point(0, 0);
            lblReference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReference.MinimumSize = new System.Drawing.Size(140, 0);
            lblReference.Name = "lblReference";
            lblReference.Size = new System.Drawing.Size(140, 20);
            lblReference.TabIndex = 0;
            lblReference.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = System.Drawing.Color.White;
            pnlBottom.Controls.Add(lblTime);
            pnlBottom.Controls.Add(lblReference);
            pnlBottom.Controls.Add(pBar);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Location = new System.Drawing.Point(0, 186);
            pnlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBottom.MinimumSize = new System.Drawing.Size(0, 37);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(503, 37);
            pnlBottom.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.BackColor = System.Drawing.Color.White;
            lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTime.Location = new System.Drawing.Point(140, 0);
            lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(363, 25);
            lblTime.TabIndex = 6;
            lblTime.Text = "00";
            lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBar
            // 
            pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            pBar.Location = new System.Drawing.Point(0, 25);
            pBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pBar.Name = "pBar";
            pBar.Size = new System.Drawing.Size(503, 12);
            pBar.TabIndex = 7;
            pBar.Value = 50;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = System.Drawing.Color.White;
            pnlButtons.Controls.Add(btnFullScreen);
            pnlButtons.Controls.Add(btnPrintWithDetails);
            pnlButtons.Controls.Add(btnPrintAsReceipt);
            pnlButtons.Controls.Add(btnPrint);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            pnlButtons.Location = new System.Drawing.Point(0, 0);
            pnlButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new System.Drawing.Size(503, 115);
            pnlButtons.TabIndex = 5;
            // 
            // btnFullScreen
            // 
            btnFullScreen.Dock = System.Windows.Forms.DockStyle.Left;
            btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFullScreen.ForeColor = System.Drawing.Color.White;
            btnFullScreen.Image = Properties.Resources.fullscreen;
            btnFullScreen.Location = new System.Drawing.Point(279, 0);
            btnFullScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new System.Drawing.Size(93, 115);
            btnFullScreen.TabIndex = 10;
            btnFullScreen.UseVisualStyleBackColor = true;
            btnFullScreen.Visible = false;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // btnPrintWithDetails
            // 
            btnPrintWithDetails.BackColor = System.Drawing.Color.White;
            btnPrintWithDetails.BackgroundImage = Properties.Resources.chef64;
            btnPrintWithDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnPrintWithDetails.Dock = System.Windows.Forms.DockStyle.Left;
            btnPrintWithDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnPrintWithDetails.FlatAppearance.BorderSize = 0;
            btnPrintWithDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrintWithDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnPrintWithDetails.ForeColor = System.Drawing.Color.White;
            btnPrintWithDetails.Image = Properties.Resources.Print32;
            btnPrintWithDetails.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnPrintWithDetails.Location = new System.Drawing.Point(186, 0);
            btnPrintWithDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrintWithDetails.Name = "btnPrintWithDetails";
            btnPrintWithDetails.Size = new System.Drawing.Size(93, 115);
            btnPrintWithDetails.TabIndex = 9;
            btnPrintWithDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrintWithDetails.UseVisualStyleBackColor = false;
            btnPrintWithDetails.Click += BtnPrintWithDetails_Click;
            // 
            // btnPrintAsReceipt
            // 
            btnPrintAsReceipt.BackColor = System.Drawing.Color.White;
            btnPrintAsReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnPrintAsReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            btnPrintAsReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnPrintAsReceipt.FlatAppearance.BorderSize = 0;
            btnPrintAsReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrintAsReceipt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnPrintAsReceipt.ForeColor = System.Drawing.Color.Red;
            btnPrintAsReceipt.Image = Properties.Resources.Print;
            btnPrintAsReceipt.Location = new System.Drawing.Point(93, 0);
            btnPrintAsReceipt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrintAsReceipt.Name = "btnPrintAsReceipt";
            btnPrintAsReceipt.Size = new System.Drawing.Size(93, 115);
            btnPrintAsReceipt.TabIndex = 8;
            btnPrintAsReceipt.Text = "RCPT";
            btnPrintAsReceipt.UseVisualStyleBackColor = false;
            btnPrintAsReceipt.Click += BtnPrintAsReceipt_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.Color.White;
            btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnPrint.ForeColor = System.Drawing.Color.White;
            btnPrint.Image = Properties.Resources.Print;
            btnPrint.Location = new System.Drawing.Point(0, 0);
            btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(93, 115);
            btnPrint.TabIndex = 7;
            btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnDone
            // 
            btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnDone.BackColor = System.Drawing.Color.Black;
            btnDone.Dock = System.Windows.Forms.DockStyle.Right;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            btnDone.ForeColor = System.Drawing.Color.White;
            btnDone.Image = Properties.Resources.right32;
            btnDone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDone.Location = new System.Drawing.Point(533, 0);
            btnDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDone.MinimumSize = new System.Drawing.Size(64, 69);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(64, 223);
            btnDone.TabIndex = 0;
            btnDone.Text = "1";
            btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += BtnDone_Click;
            // 
            // ctlKitchenOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            Controls.Add(pnlButtons);
            Controls.Add(pnlColor);
            Controls.Add(btnDone);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ctlKitchenOrder";
            Size = new System.Drawing.Size(597, 223);
            Load += CtlKitchenOrder_Load;
            pnlColor.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
