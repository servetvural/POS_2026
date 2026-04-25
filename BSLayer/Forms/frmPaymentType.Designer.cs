namespace BSLayer {
    partial class frmPaymentType {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentType));
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCard
            // 
            this.btnCard.AutoEllipsis = true;
            this.btnCard.BackColor = System.Drawing.SystemColors.Control;
            this.btnCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard.BackgroundImage")));
            this.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCard.Image = global::BSLayer.Properties.Resources.card64;
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCard.Location = new System.Drawing.Point(223, 29);
            this.btnCard.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(130, 85);
            this.btnCard.TabIndex = 124;
            this.btnCard.Text = "ANY CARD";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.AutoEllipsis = true;
            this.btnCash.BackColor = System.Drawing.SystemColors.Control;
            this.btnCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash.BackgroundImage")));
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCash.Image = global::BSLayer.Properties.Resources.cash;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.Location = new System.Drawing.Point(26, 29);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(130, 85);
            this.btnCash.TabIndex = 122;
            this.btnCash.Text = "CASH";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.AutoEllipsis = true;
            this.btnOnline.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnline.BackgroundImage")));
            this.btnOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOnline.Image = global::BSLayer.Properties.Resources.web;
            this.btnOnline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnline.Location = new System.Drawing.Point(415, 29);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(130, 85);
            this.btnOnline.TabIndex = 123;
            this.btnOnline.Text = "ONLINE";
            this.btnOnline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Image = global::BSLayer.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(26, 159);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(519, 85);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 276);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnOnline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPaymentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PAYMENT TYPE";
            this.Load += new System.EventHandler(this.frmPaymentType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnCancel;
    }
}