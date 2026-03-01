namespace DTRMNS {
    partial class ctlHoldButtonExtendable {
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
            pnlTop = new System.Windows.Forms.Panel();
            lblPrice = new System.Windows.Forms.Label();
            lblItems = new System.Windows.Forms.Label();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblPrice);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(117, 37);
            pnlTop.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            lblPrice.Location = new System.Drawing.Point(0, 0);
            lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(117, 37);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "900.50";
            lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPrice.Click += lblPrice_Click;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Dock = System.Windows.Forms.DockStyle.Fill;
            lblItems.Location = new System.Drawing.Point(0, 37);
            lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItems.Name = "lblItems";
            lblItems.Size = new System.Drawing.Size(0, 15);
            lblItems.TabIndex = 1;
            lblItems.Click += lblItems_Click;
            // 
            // ctlHoldButtonExtendable
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(lblItems);
            Controls.Add(pnlTop);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(116, 57);
            Name = "ctlHoldButtonExtendable";
            Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            Size = new System.Drawing.Size(117, 60);
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItems;
    }
}
