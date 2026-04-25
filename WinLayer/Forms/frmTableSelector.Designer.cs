namespace WinLayer {
    partial class frmTableSelector {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.pnlGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::WinLayer.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(952, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 50;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTables
            // 
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(100, 65);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(928, 715);
            this.pnlTables.TabIndex = 2;
            // 
            // pnlGroups
            // 
            this.pnlGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGroups.Location = new System.Drawing.Point(0, 65);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlGroups.Size = new System.Drawing.Size(100, 715);
            this.pnlGroups.TabIndex = 3;
            // 
            // frmTableSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 780);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.pnlGroups);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTableSelector";
            this.Load += new System.EventHandler(this.frmTableSelector_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel pnlGroups;
    }
}