namespace WinLayer {
    partial class frmPurchase {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new IntegerTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewConversion = new IntegerTextBox();
            this.btnOKNewConversion = new System.Windows.Forms.Button();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.btnAddToStock = new System.Windows.Forms.Button();
            this.btnMinusQty = new System.Windows.Forms.Button();
            this.btnPlusQty = new System.Windows.Forms.Button();
            this.btnMinusNewQty = new System.Windows.Forms.Button();
            this.btnPlusNewQty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(461, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ITEM";
            // 
            // txtStockItemName
            // 
            this.txtStockItemName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStockItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStockItemName.Location = new System.Drawing.Point(72, 15);
            this.txtStockItemName.Name = "txtStockItemName";
            this.txtStockItemName.ReadOnly = true;
            this.txtStockItemName.Size = new System.Drawing.Size(351, 26);
            this.txtStockItemName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "QTY";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtQuantity.Increment = 1;
            this.txtQuantity.Location = new System.Drawing.Point(72, 56);
            this.txtQuantity.MaxValue = 10000;
            this.txtQuantity.MinValue = -50;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 35);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Value = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(309, 56);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 39);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "PURCHASE";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "SIZE";
            // 
            // txtConversion
            // 
            this.txtConversion.BackColor = System.Drawing.SystemColors.Window;
            this.txtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtConversion.Location = new System.Drawing.Point(72, 107);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.Size = new System.Drawing.Size(80, 35);
            this.txtConversion.TabIndex = 26;
            this.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "NEW SIZE";
            // 
            // txtNewConversion
            // 
            this.txtNewConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNewConversion.Increment = 50;
            this.txtNewConversion.Location = new System.Drawing.Point(72, 158);
            this.txtNewConversion.MaxValue = 10000;
            this.txtNewConversion.MinValue = 1;
            this.txtNewConversion.Name = "txtNewConversion";
            this.txtNewConversion.Size = new System.Drawing.Size(80, 35);
            this.txtNewConversion.TabIndex = 26;
            this.txtNewConversion.Text = "1";
            this.txtNewConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewConversion.Value = 1;
            // 
            // btnOKNewConversion
            // 
            this.btnOKNewConversion.Location = new System.Drawing.Point(309, 155);
            this.btnOKNewConversion.Name = "btnOKNewConversion";
            this.btnOKNewConversion.Size = new System.Drawing.Size(114, 39);
            this.btnOKNewConversion.TabIndex = 28;
            this.btnOKNewConversion.Text = "PURCHASE with New Size";
            this.btnOKNewConversion.UseVisualStyleBackColor = true;
            this.btnOKNewConversion.Click += new System.EventHandler(this.btnOKNewConversion_Click);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(163, 122);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(31, 13);
            this.lblOrderType.TabIndex = 29;
            this.lblOrderType.Text = "none";
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.Location = new System.Drawing.Point(461, 56);
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.Size = new System.Drawing.Size(114, 39);
            this.btnAddToStock.TabIndex = 30;
            this.btnAddToStock.Text = "ADD TO STOCK";
            this.btnAddToStock.UseVisualStyleBackColor = true;
            this.btnAddToStock.Click += new System.EventHandler(this.btnAddToStock_Click);
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.Image = global::WinLayer.Properties.Resources.eksi321;
            this.btnMinusQty.Location = new System.Drawing.Point(219, 56);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(60, 35);
            this.btnMinusQty.TabIndex = 32;
            this.btnMinusQty.UseVisualStyleBackColor = true;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnPlusQty
            // 
            this.btnPlusQty.Image = global::WinLayer.Properties.Resources.AddGreen;
            this.btnPlusQty.Location = new System.Drawing.Point(153, 56);
            this.btnPlusQty.Name = "btnPlusQty";
            this.btnPlusQty.Size = new System.Drawing.Size(60, 35);
            this.btnPlusQty.TabIndex = 31;
            this.btnPlusQty.UseVisualStyleBackColor = true;
            this.btnPlusQty.Click += new System.EventHandler(this.btnPlusQty_Click);
            // 
            // btnMinusNewQty
            // 
            this.btnMinusNewQty.Image = global::WinLayer.Properties.Resources.eksi321;
            this.btnMinusNewQty.Location = new System.Drawing.Point(219, 157);
            this.btnMinusNewQty.Name = "btnMinusNewQty";
            this.btnMinusNewQty.Size = new System.Drawing.Size(60, 35);
            this.btnMinusNewQty.TabIndex = 34;
            this.btnMinusNewQty.UseVisualStyleBackColor = true;
            this.btnMinusNewQty.Click += new System.EventHandler(this.btnMinusNewQty_Click);
            // 
            // btnPlusNewQty
            // 
            this.btnPlusNewQty.Image = global::WinLayer.Properties.Resources.AddGreen;
            this.btnPlusNewQty.Location = new System.Drawing.Point(153, 157);
            this.btnPlusNewQty.Name = "btnPlusNewQty";
            this.btnPlusNewQty.Size = new System.Drawing.Size(60, 35);
            this.btnPlusNewQty.TabIndex = 33;
            this.btnPlusNewQty.UseVisualStyleBackColor = true;
            this.btnPlusNewQty.Click += new System.EventHandler(this.btnPlusNewQty_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinusNewQty);
            this.Controls.Add(this.btnPlusNewQty);
            this.Controls.Add(this.btnMinusQty);
            this.Controls.Add(this.btnPlusQty);
            this.Controls.Add(this.btnAddToStock);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOKNewConversion);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockItemName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNewConversion);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PURCHASE ITEM";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockItemName;
        private System.Windows.Forms.Label label2;
        private IntegerTextBox txtQuantity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Button btnOKNewConversion;
        private System.Windows.Forms.Label label5;
        private IntegerTextBox txtNewConversion;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.Button btnPlusQty;
        private System.Windows.Forms.Button btnMinusQty;
        private System.Windows.Forms.Button btnMinusNewQty;
        private System.Windows.Forms.Button btnPlusNewQty;
    }
}