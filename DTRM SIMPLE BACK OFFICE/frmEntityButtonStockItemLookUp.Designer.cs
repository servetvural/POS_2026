namespace DTRM {
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
            this.incQuantity = new DevComponents.Editors.IntegerInput();
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
            this.txtDisplayOrder = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkFreeItem = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.incQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // incQuantity
            // 
            // 
            // 
            // 
            this.incQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.incQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.incQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.incQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.incQuantity.Location = new System.Drawing.Point(118, 130);
            this.incQuantity.MaxValue = 10000;
            this.incQuantity.MinValue = 0;
            this.incQuantity.Name = "incQuantity";
            this.incQuantity.ShowUpDown = true;
            this.incQuantity.Size = new System.Drawing.Size(80, 35);
            this.incQuantity.TabIndex = 1;
            this.incQuantity.Value = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "QUANTITY";
            // 
            // lblQuantityType
            // 
            this.lblQuantityType.AutoSize = true;
            this.lblQuantityType.Location = new System.Drawing.Point(204, 152);
            this.lblQuantityType.Name = "lblQuantityType";
            this.lblQuantityType.Size = new System.Drawing.Size(35, 13);
            this.lblQuantityType.TabIndex = 38;
            this.lblQuantityType.Text = "TYPE";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(118, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
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
            this.txtEntityButton.Size = new System.Drawing.Size(272, 35);
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
            this.cmbStockItem.Size = new System.Drawing.Size(198, 37);
            this.cmbStockItem.TabIndex = 0;
            this.cmbStockItem.ValueMember = "IID";
            this.cmbStockItem.SelectionChangeCommitted += new System.EventHandler(this.cmbStockItem_SelectionChangeCommitted);
            this.cmbStockItem.SelectedValueChanged += new System.EventHandler(this.cmbStockItem_SelectedValueChanged);
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.Export32;
            this.btnAddStockItem.Location = new System.Drawing.Point(340, 70);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(50, 41);
            this.btnAddStockItem.TabIndex = 45;
            this.btnAddStockItem.UseVisualStyleBackColor = true;
            this.btnAddStockItem.Click += new System.EventHandler(this.btnAddStockItem_Click);
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMinusQty.Location = new System.Drawing.Point(330, 130);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(60, 35);
            this.btnMinusQty.TabIndex = 47;
            this.btnMinusQty.UseVisualStyleBackColor = true;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnPlusQty
            // 
            this.btnPlusQty.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusQty.Location = new System.Drawing.Point(256, 130);
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
            this.txtDisplayOrder.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDisplayOrder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDisplayOrder.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDisplayOrder.Location = new System.Drawing.Point(118, 238);
            this.txtDisplayOrder.MaxValue = 10000;
            this.txtDisplayOrder.MinValue = 0;
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.ShowUpDown = true;
            this.txtDisplayOrder.Size = new System.Drawing.Size(80, 35);
            this.txtDisplayOrder.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "DISPLAY ORDER";
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.Border.Class = "TextBoxBorder";
            this.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(118, 183);
            this.txtComment.MaxLength = 255;
            this.txtComment.Name = "txtComment";
            this.txtComment.PreventEnterBeep = true;
            this.txtComment.Size = new System.Drawing.Size(409, 35);
            this.txtComment.TabIndex = 50;
            // 
            // chkFreeItem
            // 
            this.chkFreeItem.AutoSize = true;
            // 
            // 
            // 
            this.chkFreeItem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFreeItem.Location = new System.Drawing.Point(443, 35);
            this.chkFreeItem.Name = "chkFreeItem";
            this.chkFreeItem.Size = new System.Drawing.Size(84, 15);
            this.chkFreeItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFreeItem.TabIndex = 51;
            this.chkFreeItem.Text = "FREE  ITEM";
            this.chkFreeItem.TextColor = System.Drawing.SystemColors.ControlText;
            this.chkFreeItem.CheckedChanged += new System.EventHandler(this.chkFreeItem_CheckedChanged);
            // 
            // frmEntityButtonStockItemLookUp
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(555, 359);
            this.ControlBox = false;
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
            this.Controls.Add(this.incQuantity);
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
            ((System.ComponentModel.ISupportInitialize)(this.incQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.Editors.IntegerInput incQuantity;
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
        private DevComponents.Editors.IntegerInput txtDisplayOrder;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComment;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFreeItem;
    }
}