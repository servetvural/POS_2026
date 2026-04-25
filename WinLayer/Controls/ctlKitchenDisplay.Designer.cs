using WinLayer.Controls;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;

namespace WinLayer {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ctrlBonus = ActivatorUtilities.CreateInstance<ctlBonus>(ServiceHelper.Services);
            lblClock = new System.Windows.Forms.Label();
            btnShrink = new System.Windows.Forms.Button();
            btnReload = new System.Windows.Forms.Button();
            btnStationSelector = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            lblResponse = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            pnlKitchenOrders = new System.Windows.Forms.Panel();
            pnlCompletedOrders = new System.Windows.Forms.Panel();
            tmrMain = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            lblTerminalType = new System.Windows.Forms.Label();
            pnlTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = System.Drawing.Color.Black;
            pnlTop.Controls.Add(panel2);
            pnlTop.Controls.Add(lblClock);
            pnlTop.Controls.Add(btnShrink);
            pnlTop.Controls.Add(btnReload);
            pnlTop.Controls.Add(btnStationSelector);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1009, 78);
            pnlTop.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(ctrlBonus);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(431, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(295, 78);
            panel2.TabIndex = 10;
            // 
            // ctrlBonus
            // 
            ctrlBonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ctrlBonus.BackColor = System.Drawing.Color.Black;
            ctrlBonus.ControlBackColor = System.Drawing.Color.Black;
            ctrlBonus.ControlFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            ctrlBonus.ControlForeColor = System.Drawing.Color.White;
            ctrlBonus.Dock = System.Windows.Forms.DockStyle.Bottom;
            ctrlBonus.EnableAutoUpdate = true;
            ctrlBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            ctrlBonus.ForeColor = System.Drawing.Color.White;
            ctrlBonus.Location = new System.Drawing.Point(0, 53);
            ctrlBonus.Margin = new System.Windows.Forms.Padding(5);
            ctrlBonus.MinimumSize = new System.Drawing.Size(117, 23);
            ctrlBonus.Name = "ctrlBonus";
            ctrlBonus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            ctrlBonus.ProgressBarWidth = 202;
            ctrlBonus.Size = new System.Drawing.Size(295, 25);
            ctrlBonus.TabIndex = 0;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Dock = System.Windows.Forms.DockStyle.Left;
            lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            lblClock.ForeColor = System.Drawing.Color.White;
            lblClock.Location = new System.Drawing.Point(186, 0);
            lblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new System.Drawing.Size(245, 64);
            lblClock.TabIndex = 9;
            lblClock.Text = "00:00:00";
            // 
            // btnShrink
            // 
            btnShrink.BackColor = System.Drawing.Color.Black;
            btnShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnShrink.Dock = System.Windows.Forms.DockStyle.Left;
            btnShrink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnShrink.FlatAppearance.BorderSize = 0;
            btnShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShrink.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnShrink.ForeColor = System.Drawing.Color.White;
            btnShrink.Image = Properties.Resources.Splitin264;
            btnShrink.Location = new System.Drawing.Point(93, 0);
            btnShrink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShrink.Name = "btnShrink";
            btnShrink.Size = new System.Drawing.Size(93, 78);
            btnShrink.TabIndex = 5;
            btnShrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShrink.UseVisualStyleBackColor = false;
            btnShrink.Click += btnShrink_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = System.Drawing.Color.Black;
            btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnReload.ForeColor = System.Drawing.Color.White;
            btnReload.Image = Properties.Resources.Redo64;
            btnReload.Location = new System.Drawing.Point(0, 0);
            btnReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(93, 78);
            btnReload.TabIndex = 0;
            btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnStationSelector
            // 
            btnStationSelector.BackColor = System.Drawing.Color.Black;
            btnStationSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnStationSelector.Dock = System.Windows.Forms.DockStyle.Right;
            btnStationSelector.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnStationSelector.FlatAppearance.BorderSize = 0;
            btnStationSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStationSelector.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnStationSelector.ForeColor = System.Drawing.Color.White;
            btnStationSelector.Image = Properties.Resources.disli48;
            btnStationSelector.Location = new System.Drawing.Point(823, 0);
            btnStationSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStationSelector.Name = "btnStationSelector";
            btnStationSelector.Size = new System.Drawing.Size(93, 78);
            btnStationSelector.TabIndex = 4;
            btnStationSelector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStationSelector.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btnStationSelector.UseVisualStyleBackColor = false;
            btnStationSelector.Click += btnStationSelector_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Black;
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Image = Properties.Resources.Delete;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.Location = new System.Drawing.Point(916, 0);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(93, 78);
            btnClose.TabIndex = 8;
            btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.BackColor = System.Drawing.Color.Black;
            lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblResponse.Dock = System.Windows.Forms.DockStyle.Right;
            lblResponse.Font = new System.Drawing.Font("Segoe UI", 20F);
            lblResponse.ForeColor = System.Drawing.Color.White;
            lblResponse.Location = new System.Drawing.Point(975, 0);
            lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new System.Drawing.Size(34, 39);
            lblResponse.TabIndex = 3;
            lblResponse.Text = "0";
            lblResponse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = System.Drawing.Color.Black;
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 78);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlKitchenOrders);
            splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlCompletedOrders);
            splitContainer1.Size = new System.Drawing.Size(1009, 555);
            splitContainer1.SplitterDistance = 617;
            splitContainer1.SplitterWidth = 35;
            splitContainer1.TabIndex = 2;
            // 
            // pnlKitchenOrders
            // 
            pnlKitchenOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlKitchenOrders.Location = new System.Drawing.Point(0, 0);
            pnlKitchenOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlKitchenOrders.Name = "pnlKitchenOrders";
            pnlKitchenOrders.Size = new System.Drawing.Size(615, 553);
            pnlKitchenOrders.TabIndex = 0;
            // 
            // pnlCompletedOrders
            // 
            pnlCompletedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCompletedOrders.Location = new System.Drawing.Point(0, 0);
            pnlCompletedOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCompletedOrders.Name = "pnlCompletedOrders";
            pnlCompletedOrders.Size = new System.Drawing.Size(355, 553);
            pnlCompletedOrders.TabIndex = 0;
            // 
            // tmrMain
            // 
            tmrMain.Interval = 2000;
            tmrMain.Tick += tmrKitchenOrders_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblTerminalType);
            panel1.Controls.Add(lblResponse);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 633);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1009, 45);
            panel1.TabIndex = 4;
            // 
            // lblTerminalType
            // 
            lblTerminalType.AutoSize = true;
            lblTerminalType.BackColor = System.Drawing.Color.Black;
            lblTerminalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTerminalType.Dock = System.Windows.Forms.DockStyle.Left;
            lblTerminalType.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTerminalType.ForeColor = System.Drawing.Color.White;
            lblTerminalType.Location = new System.Drawing.Point(0, 0);
            lblTerminalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTerminalType.Name = "lblTerminalType";
            lblTerminalType.Size = new System.Drawing.Size(70, 21);
            lblTerminalType.TabIndex = 4;
            lblTerminalType.Text = "Unknown";
            lblTerminalType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ctlKitchenDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(pnlTop);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ctlKitchenDisplay";
            Size = new System.Drawing.Size(1009, 678);
            Load += ctlKitchenDisplay_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

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
