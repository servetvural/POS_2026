namespace DTRM_Stock_Handler {
    partial class frmStockHandler {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockHandler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnect,
            this.mnuDisconnect,
            this.mnuStockUsage,
            this.mnuStockList,
            this.mnuConfig,
            this.tsClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 40);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuConnect
            // 
            this.mnuConnect.Image = global::DTRM_Stock_Handler.Properties.Resources.DisconnectedLocal32;
            this.mnuConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuConnect.Name = "mnuConnect";
            this.mnuConnect.Size = new System.Drawing.Size(96, 36);
            this.mnuConnect.Text = "Connect";
            this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
            // 
            // mnuDisconnect
            // 
            this.mnuDisconnect.Image = global::DTRM_Stock_Handler.Properties.Resources.ConnectedLocal32;
            this.mnuDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDisconnect.Name = "mnuDisconnect";
            this.mnuDisconnect.Size = new System.Drawing.Size(110, 36);
            this.mnuDisconnect.Text = "Disconnect";
            this.mnuDisconnect.Visible = false;
            this.mnuDisconnect.Click += new System.EventHandler(this.mnuDisconnect_Click);
            // 
            // mnuStockUsage
            // 
            this.mnuStockUsage.Enabled = false;
            this.mnuStockUsage.Image = global::DTRM_Stock_Handler.Properties.Resources.CalculatorNice32;
            this.mnuStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuStockUsage.Name = "mnuStockUsage";
            this.mnuStockUsage.Size = new System.Drawing.Size(123, 36);
            this.mnuStockUsage.Text = "Shopping List";
            this.mnuStockUsage.Click += new System.EventHandler(this.mnuStockUsage_Click);
            // 
            // mnuStockList
            // 
            this.mnuStockList.Enabled = false;
            this.mnuStockList.Image = global::DTRM_Stock_Handler.Properties.Resources.DataSync32;
            this.mnuStockList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuStockList.Name = "mnuStockList";
            this.mnuStockList.Size = new System.Drawing.Size(101, 36);
            this.mnuStockList.Text = "Stock List";
            this.mnuStockList.Click += new System.EventHandler(this.mnuStockList_Click);
            // 
            // mnuConfig
            // 
            this.mnuConfig.Image = global::DTRM_Stock_Handler.Properties.Resources.Gear;
            this.mnuConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(93, 36);
            this.mnuConfig.Text = "Settings";
            this.mnuConfig.Click += new System.EventHandler(this.mnuConfig_Click);
            // 
            // tsClose
            // 
            this.tsClose.Image = global::DTRM_Stock_Handler.Properties.Resources.cross_red_2_32;
            this.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(86, 36);
            this.tsClose.Text = "CLOSE";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 17);
            this.lblStatus.Text = "DISCONNECTED";
            // 
            // frmStockHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 752);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmStockHandler";
            this.Text = "DTRM STOCK HANDLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockHandler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStockList;
        private System.Windows.Forms.ToolStripMenuItem mnuStockUsage;
        private System.Windows.Forms.ToolStripMenuItem mnuConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuDisconnect;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem tsClose;
    }
}

