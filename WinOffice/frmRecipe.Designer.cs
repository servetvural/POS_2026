using System.Drawing;
using System.Windows.Forms;

using WinLayer;

namespace WinOffice {
    partial class frmRecipe {
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
            btnSave = new Button();
            btnCancel = new Button();
            txtCategoryItem = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnAddStockItem = new Button();
            txtDisplayOrder = new IntegerTextBox();
            label2 = new Label();
            txtComment = new TextBox();
            label4 = new Label();
            numQuantity = new DoubleTextBox();
            cmbQuantityType = new ComboBox();
            label5 = new Label();
            txtStockItem = new TextBox();
            txtFreeItemText = new TextBox();
            btnDeleteStockItem = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(386, 359);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(138, 359);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCategoryItem
            // 
            txtCategoryItem.AcceptsReturn = true;
            txtCategoryItem.BackColor = SystemColors.ControlLightLight;
            txtCategoryItem.Font = new Font("Microsoft Sans Serif", 18F);
            txtCategoryItem.Location = new Point(136, 25);
            txtCategoryItem.Margin = new Padding(4, 3, 4, 3);
            txtCategoryItem.Name = "txtCategoryItem";
            txtCategoryItem.ReadOnly = true;
            txtCategoryItem.Size = new Size(358, 35);
            txtCategoryItem.TabIndex = 42;
            txtCategoryItem.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(26, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 43;
            label1.Text = "Category Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(26, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 44;
            label3.Text = "Stock Item";
            // 
            // btnAddStockItem
            // 
            btnAddStockItem.Location = new Point(504, 124);
            btnAddStockItem.Margin = new Padding(4, 3, 4, 3);
            btnAddStockItem.Name = "btnAddStockItem";
            btnAddStockItem.Size = new Size(110, 35);
            btnAddStockItem.TabIndex = 45;
            btnAddStockItem.Text = "Add Stock Item";
            btnAddStockItem.UseVisualStyleBackColor = true;
            btnAddStockItem.Click += btnAddStockItem_Click;
            // 
            // txtDisplayOrder
            // 
            txtDisplayOrder.Font = new Font("Microsoft Sans Serif", 18F);
            txtDisplayOrder.Increment = 1;
            txtDisplayOrder.Location = new Point(136, 290);
            txtDisplayOrder.Margin = new Padding(4, 3, 4, 3);
            txtDisplayOrder.MaxValue = 10000;
            txtDisplayOrder.MinValue = 0;
            txtDisplayOrder.Name = "txtDisplayOrder";
            txtDisplayOrder.Size = new Size(109, 35);
            txtDisplayOrder.TabIndex = 50;
            txtDisplayOrder.Text = "0";
            txtDisplayOrder.TextAlign = HorizontalAlignment.Right;
            txtDisplayOrder.Value = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(26, 300);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 51;
            label2.Text = "Display Order";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(136, 235);
            txtComment.Margin = new Padding(4, 3, 4, 3);
            txtComment.MaxLength = 255;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(476, 35);
            txtComment.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(26, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 54;
            label4.Text = "Comment";
            // 
            // numQuantity
            // 
            numQuantity.CustomFormat = "N2";
            numQuantity.CustomUICulture = "en-US";
            numQuantity.Font = new Font("Microsoft Sans Serif", 18F);
            numQuantity.Increment = 0.1D;
            numQuantity.Location = new Point(136, 180);
            numQuantity.Margin = new Padding(4, 3, 4, 3);
            numQuantity.MaxValue = 10000D;
            numQuantity.MinValue = 0.1D;
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(109, 35);
            numQuantity.TabIndex = 55;
            numQuantity.Text = "1.00";
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = 1D;
            // 
            // cmbQuantityType
            // 
            cmbQuantityType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbQuantityType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbQuantityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuantityType.Font = new Font("Microsoft Sans Serif", 18F);
            cmbQuantityType.FormattingEnabled = true;
            cmbQuantityType.Items.AddRange(new object[] { "None", "Piece", "Kilo", "Gram", "Litre", "ml", "Pack", "Box", "Bottle", "Crate", "Slice", "Dash", "Pinch", "Bar Spoon", "Leaf", "Wheel", "Handful", "Quarter", "Drops", "Sprig", "Halves", "Barista_Scoop", "Splash", "Sprinkle", "Sachet", "Can", "Bag" });
            cmbQuantityType.Location = new Point(258, 178);
            cmbQuantityType.Margin = new Padding(4, 3, 4, 3);
            cmbQuantityType.MaxDropDownItems = 10;
            cmbQuantityType.Name = "cmbQuantityType";
            cmbQuantityType.Size = new Size(237, 37);
            cmbQuantityType.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(26, 188);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 57;
            label5.Text = "Quantity";
            // 
            // txtStockItem
            // 
            txtStockItem.AcceptsReturn = true;
            txtStockItem.BackColor = SystemColors.ControlLightLight;
            txtStockItem.Font = new Font("Microsoft Sans Serif", 18F);
            txtStockItem.Location = new Point(136, 124);
            txtStockItem.Margin = new Padding(4, 3, 4, 3);
            txtStockItem.Name = "txtStockItem";
            txtStockItem.ReadOnly = true;
            txtStockItem.Size = new Size(358, 35);
            txtStockItem.TabIndex = 62;
            txtStockItem.TabStop = false;
            // 
            // txtFreeItemText
            // 
            txtFreeItemText.Font = new Font("Segoe UI", 14F);
            txtFreeItemText.Location = new Point(136, 76);
            txtFreeItemText.Name = "txtFreeItemText";
            txtFreeItemText.Size = new Size(360, 32);
            txtFreeItemText.TabIndex = 63;
            // 
            // btnDeleteStockItem
            // 
            btnDeleteStockItem.Location = new Point(622, 124);
            btnDeleteStockItem.Margin = new Padding(4, 3, 4, 3);
            btnDeleteStockItem.Name = "btnDeleteStockItem";
            btnDeleteStockItem.Size = new Size(110, 35);
            btnDeleteStockItem.TabIndex = 64;
            btnDeleteStockItem.Text = "Delete Stock Item";
            btnDeleteStockItem.UseVisualStyleBackColor = true;
            btnDeleteStockItem.Click += btnDeleteStockItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(26, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 65;
            label6.Text = "Item Text";
            // 
            // frmRecipe
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnCancel;
            ClientSize = new Size(768, 447);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(btnDeleteStockItem);
            Controls.Add(txtFreeItemText);
            Controls.Add(txtStockItem);
            Controls.Add(label5);
            Controls.Add(cmbQuantityType);
            Controls.Add(numQuantity);
            Controls.Add(label4);
            Controls.Add(txtComment);
            Controls.Add(txtDisplayOrder);
            Controls.Add(label2);
            Controls.Add(btnAddStockItem);
            Controls.Add(label3);
            Controls.Add(txtCategoryItem);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRecipe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RECIPE ITEM DETAILS";
            Load += frmEntityButtonStockItemLookUp_Load;
            KeyDown += frmEntityButtonStockItemLookUp_KeyDown;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCategoryItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddStockItem;
        private IntegerTextBox txtDisplayOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label4;
        private DoubleTextBox numQuantity;
        private System.Windows.Forms.ComboBox cmbQuantityType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockItem;
        private System.Windows.Forms.TextBox txtFreeItemText;
        private System.Windows.Forms.Button btnDeleteStockItem;
        private System.Windows.Forms.Label label6;
    }
}