namespace WinLayer {
    partial class ctlKitchenOrderItem {
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
            this.lblActive = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.pnlFullScreen = new System.Windows.Forms.Panel();
            this.expMain = new PosLibrary.Expander();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.pnlFullScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActive
            // 
            this.lblActive.BackColor = System.Drawing.Color.White;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblActive.Location = new System.Drawing.Point(0, 0);
            this.lblActive.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(559, 25);
            this.lblActive.TabIndex = 0;
            this.lblActive.Text = "ActiveLabel";
            this.lblActive.Click += new System.EventHandler(this.lblActive_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.White;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetail.Location = new System.Drawing.Point(182, 25);
            this.lblDetail.MinimumSize = new System.Drawing.Size(0, 140);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(310, 200);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "DetailLabel";
            this.lblDetail.Click += new System.EventHandler(this.lblDetail_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBox.Location = new System.Drawing.Point(0, 25);
            this.pBox.MinimumSize = new System.Drawing.Size(140, 140);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(140, 200);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Image = global::WinLayer.Properties.Resources.fullscreen;
            this.btnFullScreen.Location = new System.Drawing.Point(0, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(67, 66);
            this.btnFullScreen.TabIndex = 3;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // pnlFullScreen
            // 
            this.pnlFullScreen.Controls.Add(this.btnFullScreen);
            this.pnlFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFullScreen.Location = new System.Drawing.Point(492, 25);
            this.pnlFullScreen.Name = "pnlFullScreen";
            this.pnlFullScreen.Size = new System.Drawing.Size(67, 200);
            this.pnlFullScreen.TabIndex = 4;
            // 
            // expMain
            // 
            this.expMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expMain.ColourFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expMain.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.expMain.ExpandableControl = this.pBox;
            this.expMain.Expanded = true;
            this.expMain.Fixed = false;
            this.expMain.Location = new System.Drawing.Point(140, 25);
            this.expMain.MinimumSize = new System.Drawing.Size(5, 5);
            this.expMain.Name = "expMain";
            this.expMain.Size = new System.Drawing.Size(42, 200);
            this.expMain.TabIndex = 5;
            this.expMain.Visible = false;
            // 
            // ctlKitchenOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.expMain);
            this.Controls.Add(this.pnlFullScreen);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.lblActive);
            this.DoubleBuffered = true;
            this.Name = "ctlKitchenOrderItem";
            this.Size = new System.Drawing.Size(559, 225);
            this.Load += new System.EventHandler(this.ctlKitchenOrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.pnlFullScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Panel pnlFullScreen;
        private PosLibrary.Expander expMain;
    }
}
