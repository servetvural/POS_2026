namespace DTRMNS {
    partial class frmKitchenSingleDisplay {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitchenSingleDisplay));
            ctlKitchen = new ctlKitchenDisplay();
            SuspendLayout();
            // 
            // ctlKitchen
            // 
            ctlKitchen.ChangeDistributionVisible = true;
            ctlKitchen.DisplayClock = true;
            ctlKitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            ctlKitchen.Location = new System.Drawing.Point(0, 0);
            ctlKitchen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            ctlKitchen.Name = "ctlKitchen";
            ctlKitchen.Size = new System.Drawing.Size(1102, 749);
            ctlKitchen.TabIndex = 0;
            ctlKitchen.Load += ctlKitchen_Load;
            // 
            // frmKitchenSingleDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1102, 749);
            Controls.Add(ctlKitchen);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmKitchenSingleDisplay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SINGLE DISPLAY";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmKitchenDisplay_Load;
            ResumeLayout(false);

        }

        #endregion

        private ctlKitchenDisplay ctlKitchen;
    }
}