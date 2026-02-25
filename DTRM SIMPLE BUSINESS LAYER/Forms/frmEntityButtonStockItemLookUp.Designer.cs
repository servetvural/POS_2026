namespace DTRMNS {
    partial class frmEntityButtonStockItemLookUp {
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
            this.label10 = new System.Windows.Forms.Label();
            this.lblQuantityType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEntityButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStockItem = new System.Windows.Forms.ComboBox();
            this.btnAddStockItem = new System.Windows.Forms.Button();
            this.btnMinusQty = new System.Windows.Forms.Button();
            this.btnPlusQty = new System.Windows.Forms.Button();
            this.txtDisplayOrder = new PosLibrary.IntegerTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFreeItem = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.incQuantity = new PosLibrary.DoubleTextBox();
            this.cmbUsageAmountType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.incUsageAmount = new PosLibrary.IntegerTextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "STOCK QUANTITY";
            // 
            // lblQuantityType
            // 
            this.lblQuantityType.AutoSize = true;
            this.lblQuantityType.Location = new System.Drawing.Point(222, 202);
            this.lblQuantityType.Name = "lblQuantityType";
            this.lblQuantityType.Size = new System.Drawing.Size(35, 13);
            this.lblQuantityType.TabIndex = 38;
            this.lblQuantityType.Text = "TYPE";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(118, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEntityButton
            // 
            this.txtEntityButton.AcceptsReturn = true;
            this.txtEntityButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEntityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtEntityButton.Location = new System.Drawing.Point(118, 22);
            this.txtEntityButton.Name = "txtEntityButton";
            this.txtEntityButton.ReadOnly = true;
            this.txtEntityButton.Size = new System.Drawing.Size(307, 35);
            this.txtEntityButton.TabIndex = 42;
            this.txtEntityButton.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "ENTITY BUTTON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "STOCK ITEM";
            // 
            // cmbStockItem
            // 
            this.cmbStockItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStockItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStockItem.DisplayMember = "StockName";
            this.cmbStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbStockItem.FormattingEnabled = true;
            this.cmbStockItem.Location = new System.Drawing.Point(118, 73);
            this.cmbStockItem.Name = "cmbStockItem";
            this.cmbStockItem.Size = new System.Drawing.Size(223, 37);
            this.cmbStockItem.TabIndex = 0;
            this.cmbStockItem.ValueMember = "IID";
            this.cmbStockItem.SelectionChangeCommitted += new System.EventHandler(this.cmbStockItem_SelectionChangeCommitted);
            this.cmbStockItem.SelectedValueChanged += new System.EventHandler(this.cmbStockItem_SelectedValueChanged);
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.Image = global::DTRMNS.Properties.Resources.Export32;
            this.btnAddStockItem.Location = new System.Drawing.Point(375, 69);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(50, 41);
            this.btnAddStockItem.TabIndex = 45;
            this.btnAddStockItem.UseVisualStyleBackColor = true;
            this.btnAddStockItem.Click += new System.EventHandler(this.btnAddStockItem_Click);
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.btnMinusQty.Location = new System.Drawing.Point(365, 191);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(60, 35);
            this.btnMinusQty.TabIndex = 47;
            this.btnMinusQty.UseVisualStyleBackColor = true;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnPlusQty
            // 
            this.btnPlusQty.Image = global::DTRMNS.Properties.Resources.arti32;
            this.btnPlusQty.Location = new System.Drawing.Point(271, 191);
            this.btnPlusQty.Name = "btnPlusQty";
            this.btnPlusQty.Size = new System.Drawing.Size(60, 35);
            this.btnPlusQty.TabIndex = 46;
            this.btnPlusQty.UseVisualStyleBackColor = true;
            this.btnPlusQty.Click += new System.EventHandler(this.btnPlusQty_Click);
            // 
            // txtDisplayOrder
            // 
            // 
            // 
            // 
            this.txtDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDisplayOrder.Location = new System.Drawing.Point(118, 308);
            this.txtDisplayOrder.MaxValue = 10000;
            this.txtDisplayOrder.MinValue = 0;
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.Size = new System.Drawing.Size(94, 35);
            this.txtDisplayOrder.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "DISPLAY ORDER";
            // 
            // chkFreeItem
            // 
            this.chkFreeItem.AutoSize = true;
            // 
            // 
            // 
            this.chkFreeItem.Location = new System.Drawing.Point(443, 35);
            this.chkFreeItem.Name = "chkFreeItem";
            this.chkFreeItem.Size = new System.Drawing.Size(84, 15);
            this.chkFreeItem.TabIndex = 53;
            this.chkFreeItem.Text = "FREE  ITEM";
            this.chkFreeItem.CheckedChanged += new System.EventHandler(this.chkFreeItem_CheckedChanged);
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(118, 251);
            this.txtComment.MaxLength = 255;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(409, 35);
            this.txtComment.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "COMMENT";
            // 
            // incQuantity
            // 
            // 
            // 
            // 
            this.incQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.incQuantity.Increment = 0.1D;
            this.incQuantity.Location = new System.Drawing.Point(119, 191);
            this.incQuantity.MaxValue = 10000D;
            this.incQuantity.MinValue = 0.1D;
            this.incQuantity.Name = "incQuantity";
            this.incQuantity.Size = new System.Drawing.Size(94, 35);
            this.incQuantity.TabIndex = 55;
            this.incQuantity.Value = 1D;
            // 
            // cmbUsageAmountType
            // 
            this.cmbUsageAmountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUsageAmountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsageAmountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsageAmountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbUsageAmountType.FormattingEnabled = true;
            this.cmbUsageAmountType.Items.AddRange(new object[] {
            "None",
            "Piece",
            "Kilo",
            "Gram",
            "Litre",
            "ml",
            "Pack",
            "Box",
            "Bottle",
            "Crate",
            "Slice",
            "Dash",
            "Pinch",
            "Bar Spoon",
            "Leaf",
            "Wheel",
            "Handful",
            "Quarter",
            "Drops",
            "Sprig",
            "Halves",
            "Barista_Scoop",
            "Splash",
            "Sprinkle",
            "Sachet",
            "Can"});
            this.cmbUsageAmountType.Location = new System.Drawing.Point(221, 128);
            this.cmbUsageAmountType.MaxDropDownItems = 10;
            this.cmbUsageAmountType.Name = "cmbUsageAmountType";
            this.cmbUsageAmountType.Size = new System.Drawing.Size(204, 37);
            this.cmbUsageAmountType.TabIndex = 56;
            this.cmbUsageAmountType.SelectionChangeCommitted += new System.EventHandler(this.cmbUsageAmountType_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "USAGE AMOUNT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Amount will be shown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Amount will be dropped from the stock";
            // 
            // incUsageAmount
            // 
            // 
            // 
            // 
            this.incUsageAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.incUsageAmount.Location = new System.Drawing.Point(118, 128);
            this.incUsageAmount.MaxValue = 1000;
            this.incUsageAmount.MinValue = 1;
            this.incUsageAmount.Name = "incUsageAmount";
            this.incUsageAmount.Size = new System.Drawing.Size(94, 35);
            this.incUsageAmount.TabIndex = 61;
            this.incUsageAmount.Value = 1;
            this.incUsageAmount.ValueChanged += new System.EventHandler(this.incUsageAmount_ValueChanged);
            // 
            // frmEntityButtonStockItemLookUp
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(658, 425);
            this.ControlBox = false;
            this.Controls.Add(this.incUsageAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUsageAmountType);
            this.Controls.Add(this.incQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFreeItem);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtDisplayOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMinusQty);
            this.Controls.Add(this.btnPlusQty);
            this.Controls.Add(this.btnAddStockItem);
            this.Controls.Add(this.cmbStockItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEntityButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblQuantityType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmEntityButtonStockItemLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STOCK ITEM FOR ENTITY BUTTON";
            this.Load += new System.EventHandler(this.frmEntityButtonStockItemLookUp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntityButtonStockItemLookUp_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblQuantityType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEntityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStockItem;
        private System.Windows.Forms.Button btnAddStockItem;
        private System.Windows.Forms.Button btnMinusQty;
        private System.Windows.Forms.Button btnPlusQty;
        private PosLibrary.IntegerTextBox txtDisplayOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFreeItem;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label4;
        private PosLibrary.DoubleTextBox incQuantity;
        private System.Windows.Forms.ComboBox cmbUsageAmountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private PosLibrary.IntegerTextBox incUsageAmount;
    }
}