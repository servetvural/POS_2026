namespace DTRMNS {
    partial class frmImageDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsCenter = new System.Windows.Forms.ToolStripButton();
            this.tsNormal = new System.Windows.Forms.ToolStripButton();
            this.tsStrech = new System.Windows.Forms.ToolStripButton();
            this.tsAutoSize = new System.Windows.Forms.ToolStripButton();
            this.tsZoom = new System.Windows.Forms.ToolStripButton();
            this.tsDrawBorders = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(399, 70);
            this.panel1.TabIndex = 47;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(264, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 25);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(399, 239);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 48;
            this.pBox.TabStop = false;
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCenter,
            this.tsNormal,
            this.tsStrech,
            this.tsAutoSize,
            this.tsZoom,
            this.tsDrawBorders});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(399, 25);
            this.tsMain.TabIndex = 49;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsCenter
            // 
            this.tsCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsCenter.Image")));
            this.tsCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCenter.Name = "tsCenter";
            this.tsCenter.Size = new System.Drawing.Size(46, 22);
            this.tsCenter.Text = "Center";
            this.tsCenter.Click += new System.EventHandler(this.tsCenter_Click);
            // 
            // tsNormal
            // 
            this.tsNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNormal.Image = ((System.Drawing.Image)(resources.GetObject("tsNormal.Image")));
            this.tsNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNormal.Name = "tsNormal";
            this.tsNormal.Size = new System.Drawing.Size(51, 22);
            this.tsNormal.Text = "Normal";
            this.tsNormal.Click += new System.EventHandler(this.tsNormal_Click);
            // 
            // tsStrech
            // 
            this.tsStrech.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStrech.Image = ((System.Drawing.Image)(resources.GetObject("tsStrech.Image")));
            this.tsStrech.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStrech.Name = "tsStrech";
            this.tsStrech.Size = new System.Drawing.Size(44, 22);
            this.tsStrech.Text = "Strech";
            this.tsStrech.Click += new System.EventHandler(this.tsStrech_Click);
            // 
            // tsAutoSize
            // 
            this.tsAutoSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAutoSize.Image = ((System.Drawing.Image)(resources.GetObject("tsAutoSize.Image")));
            this.tsAutoSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAutoSize.Name = "tsAutoSize";
            this.tsAutoSize.Size = new System.Drawing.Size(57, 22);
            this.tsAutoSize.Text = "AutoSize";
            this.tsAutoSize.Click += new System.EventHandler(this.tsAutoSize_Click);
            // 
            // tsZoom
            // 
            this.tsZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsZoom.Image = ((System.Drawing.Image)(resources.GetObject("tsZoom.Image")));
            this.tsZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoom.Name = "tsZoom";
            this.tsZoom.Size = new System.Drawing.Size(43, 22);
            this.tsZoom.Text = "Zoom";
            this.tsZoom.Click += new System.EventHandler(this.tsZoom_Click);
            // 
            // tsDrawBorders
            // 
            this.tsDrawBorders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDrawBorders.Image = ((System.Drawing.Image)(resources.GetObject("tsDrawBorders.Image")));
            this.tsDrawBorders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDrawBorders.Name = "tsDrawBorders";
            this.tsDrawBorders.Size = new System.Drawing.Size(83, 22);
            this.tsDrawBorders.Text = "Draw_Borders";
            this.tsDrawBorders.Click += new System.EventHandler(this.tsDrawBorders_Click);
            // 
            // frmImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 334);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(415, 373);
            this.Name = "frmImageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IMAGE";
            this.Load += new System.EventHandler(this.frmImageDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsCenter;
        private System.Windows.Forms.ToolStripButton tsNormal;
        private System.Windows.Forms.ToolStripButton tsStrech;
        private System.Windows.Forms.ToolStripButton tsAutoSize;
        private System.Windows.Forms.ToolStripButton tsZoom;
        private System.Windows.Forms.ToolStripButton tsDrawBorders;
    }
}