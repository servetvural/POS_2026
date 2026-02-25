namespace DTRMNS {
    partial class ctlKitchenDisplay {
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlBonus = new DTRMNS.Controls.ctlBonus();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnShrink = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnStationSelector = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlKitchenOrders = new System.Windows.Forms.Panel();
            this.pnlCompletedOrders = new System.Windows.Forms.Panel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTerminalType = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Controls.Add(this.lblClock);
            this.pnlTop.Controls.Add(this.btnShrink);
            this.pnlTop.Controls.Add(this.btnReload);
            this.pnlTop.Controls.Add(this.btnStationSelector);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(865, 68);
            this.pnlTop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlBonus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 68);
            this.panel2.TabIndex = 10;
            // 
            // ctrlBonus
            // 
            this.ctrlBonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlBonus.BackColor = System.Drawing.Color.Black;
            this.ctrlBonus.ControlBackColor = System.Drawing.Color.Black;
            this.ctrlBonus.ControlFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ctrlBonus.ControlForeColor = System.Drawing.Color.White;
            this.ctrlBonus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlBonus.EnableAutoUpdate = true;
            this.ctrlBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ctrlBonus.ForeColor = System.Drawing.Color.White;
            this.ctrlBonus.Location = new System.Drawing.Point(0, 46);
            this.ctrlBonus.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlBonus.MinimumSize = new System.Drawing.Size(100, 20);
            this.ctrlBonus.Name = "ctrlBonus";
            this.ctrlBonus.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ctrlBonus.ProgressBarWidth = 162;
            this.ctrlBonus.Size = new System.Drawing.Size(253, 22);
            this.ctrlBonus.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(160, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(245, 64);
            this.lblClock.TabIndex = 9;
            this.lblClock.Text = "00:00:00";
            // 
            // btnShrink
            // 
            this.btnShrink.BackColor = System.Drawing.Color.Black;
            this.btnShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShrink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShrink.FlatAppearance.BorderSize = 0;
            this.btnShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnShrink.ForeColor = System.Drawing.Color.White;
            this.btnShrink.Image = global::DTRMNS.Properties.Resources.Splitin264;
            this.btnShrink.Location = new System.Drawing.Point(80, 0);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(80, 68);
            this.btnShrink.TabIndex = 5;
            this.btnShrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShrink.UseVisualStyleBackColor = false;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Black;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::DTRMNS.Properties.Resources.Redo64;
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 68);
            this.btnReload.TabIndex = 0;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnStationSelector
            // 
            this.btnStationSelector.BackColor = System.Drawing.Color.Black;
            this.btnStationSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStationSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStationSelector.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStationSelector.FlatAppearance.BorderSize = 0;
            this.btnStationSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStationSelector.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnStationSelector.ForeColor = System.Drawing.Color.White;
            this.btnStationSelector.Image = global::DTRMNS.Properties.Resources.disli48;
            this.btnStationSelector.Location = new System.Drawing.Point(705, 0);
            this.btnStationSelector.Name = "btnStationSelector";
            this.btnStationSelector.Size = new System.Drawing.Size(80, 68);
            this.btnStationSelector.TabIndex = 4;
            this.btnStationSelector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStationSelector.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStationSelector.UseVisualStyleBackColor = false;
            this.btnStationSelector.Click += new System.EventHandler(this.btnStationSelector_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DTRMNS.Properties.Resources.Delete;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(785, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 68);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.BackColor = System.Drawing.Color.Black;
            this.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResponse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblResponse.ForeColor = System.Drawing.Color.White;
            this.lblResponse.Location = new System.Drawing.Point(831, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(34, 39);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "0";
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlKitchenOrders);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlCompletedOrders);
            this.splitContainer1.Size = new System.Drawing.Size(865, 481);
            this.splitContainer1.SplitterDistance = 529;
            this.splitContainer1.SplitterWidth = 30;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlKitchenOrders
            // 
            this.pnlKitchenOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKitchenOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlKitchenOrders.Name = "pnlKitchenOrders";
            this.pnlKitchenOrders.Size = new System.Drawing.Size(527, 479);
            this.pnlKitchenOrders.TabIndex = 0;
            // 
            // pnlCompletedOrders
            // 
            this.pnlCompletedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompletedOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlCompletedOrders.Name = "pnlCompletedOrders";
            this.pnlCompletedOrders.Size = new System.Drawing.Size(304, 479);
            this.pnlCompletedOrders.TabIndex = 0;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 2000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrKitchenOrders_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTerminalType);
            this.panel1.Controls.Add(this.lblResponse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 39);
            this.panel1.TabIndex = 4;
            // 
            // lblTerminalType
            // 
            this.lblTerminalType.AutoSize = true;
            this.lblTerminalType.BackColor = System.Drawing.Color.Black;
            this.lblTerminalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerminalType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTerminalType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTerminalType.ForeColor = System.Drawing.Color.White;
            this.lblTerminalType.Location = new System.Drawing.Point(0, 0);
            this.lblTerminalType.Name = "lblTerminalType";
            this.lblTerminalType.Size = new System.Drawing.Size(70, 21);
            this.lblTerminalType.TabIndex = 4;
            this.lblTerminalType.Text = "Unknown";
            this.lblTerminalType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ctlKitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ctlKitchenDisplay";
            this.Size = new System.Drawing.Size(865, 588);
            this.Load += new System.EventHandler(this.ctlKitchenDisplay_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlKitchenOrders;
        private System.Windows.Forms.Panel pnlCompletedOrders;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnStationSelector;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTerminalType;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panel2;
        private Controls.ctlBonus ctrlBonus;
    }
}
