namespace DTRMNS {
    partial class frmKitchenDoubleDisplay {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitchenDoubleDisplay));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.ctlKitchenFirst = new DTRMNS.ctlKitchenDisplay();
            this.ctlKitchenSecond = new DTRMNS.ctlKitchenDisplay();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(15, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.ctlKitchenFirst);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.ctlKitchenSecond);
            this.splitMain.Size = new System.Drawing.Size(915, 649);
            this.splitMain.SplitterDistance = 451;
            this.splitMain.SplitterWidth = 25;
            this.splitMain.TabIndex = 1;
            // 
            // ctlKitchenFirst
            // 
            this.ctlKitchenFirst.ChangeDistributionVisible = true;
            this.ctlKitchenFirst.DisplayClock = true;
            this.ctlKitchenFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlKitchenFirst.Location = new System.Drawing.Point(0, 0);
            this.ctlKitchenFirst.Name = "ctlKitchenFirst";
            this.ctlKitchenFirst.Size = new System.Drawing.Size(451, 649);
            this.ctlKitchenFirst.TabIndex = 0;
            // 
            // ctlKitchenSecond
            // 
            this.ctlKitchenSecond.ChangeDistributionVisible = true;
            this.ctlKitchenSecond.DisplayClock = false;
            this.ctlKitchenSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlKitchenSecond.Location = new System.Drawing.Point(0, 0);
            this.ctlKitchenSecond.Name = "ctlKitchenSecond";
            this.ctlKitchenSecond.Size = new System.Drawing.Size(439, 649);
            this.ctlKitchenSecond.TabIndex = 1;
            // 
            // frmKitchenDoubleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(945, 649);
            this.Controls.Add(this.splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKitchenDoubleDisplay";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KITCHEN DISPLAY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKitchenDisplay_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlKitchenDisplay ctlKitchenFirst;
        private System.Windows.Forms.SplitContainer splitMain;
        private ctlKitchenDisplay ctlKitchenSecond;
    }
}