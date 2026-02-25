namespace DTRMNS {
    partial class frmDebug {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebug));
            this.dbgControl = new DTRMNS.ctlDebug();
            this.bar1 = new System.Windows.Forms.ToolStrip();
            this.btnInitialize = new System.Windows.Forms.ToolStripButton();
            this.bar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgControl
            // 
            this.dbgControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dbgControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgControl.Location = new System.Drawing.Point(0, 25);
            this.dbgControl.Name = "dbgControl";
            this.dbgControl.Size = new System.Drawing.Size(927, 393);
            this.dbgControl.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInitialize});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(927, 25);
            this.bar1.TabIndex = 2;
            this.bar1.Text = "toolStrip1";
            // 
            // btnInitialize
            // 
            this.btnInitialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInitialize.Image = ((System.Drawing.Image)(resources.GetObject("btnInitialize.Image")));
            this.btnInitialize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(54, 22);
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 418);
            this.Controls.Add(this.dbgControl);
            this.Controls.Add(this.bar1);
            this.Name = "frmDebug";
            this.Text = "DEBUG WINDOW";
            this.bar1.ResumeLayout(false);
            this.bar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip bar1;
        private System.Windows.Forms.ToolStripButton btnInitialize;
    }
}