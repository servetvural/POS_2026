namespace DTRMNS {
    partial class frmStockItem {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConversion = new PosLibrary.IntegerTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbQuantityType = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.txtUsedQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.btnSet0 = new System.Windows.Forms.Button();
            this.btnSetCustom = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtImageFile = new System.Windows.Forms.TextBox();
            this.btnLoadImageFromDatabase = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnLoadImageFromDirectory = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnMinusQty = new System.Windows.Forms.Button();
            this.btnPlusQty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(410, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStockName
            // 
            this.txtStockName.AcceptsReturn = true;
            this.txtStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtStockName.Location = new System.Drawing.Point(134, 12);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(224, 35);
            this.txtStockName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "STOCK ITEM NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "QUANTITY TYPE";
            // 
            // txtConversion
            // 
            this.txtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtConversion.Increment = 1;
            this.txtConversion.Location = new System.Drawing.Point(134, 169);
            this.txtConversion.MaxValue = 51000;
            this.txtConversion.MinValue = 0;
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(80, 35);
            this.txtConversion.TabIndex = 3;
            this.txtConversion.Text = "0";
            this.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConversion.Value = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "CONVERSION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ORDER TYPE";
            // 
            // cmbQuantityType
            // 
            this.cmbQuantityType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbQuantityType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbQuantityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbQuantityType.FormattingEnabled = true;
            this.cmbQuantityType.Items.AddRange(new object[] {
            "None",
            "Piece",
            "Kilo",
            "Gram",
            "Litre",
            "Mililitre",
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
            "Halves",
            "Barista_Scoop",
            "Splash",
            "Sprinkle",
            "Sachet",
            "Can"});
            this.cmbQuantityType.Location = new System.Drawing.Point(134, 62);
            this.cmbQuantityType.MaxDropDownItems = 10;
            this.cmbQuantityType.Name = "cmbQuantityType";
            this.cmbQuantityType.Size = new System.Drawing.Size(224, 37);
            this.cmbQuantityType.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DisplayMember = "SupplierName";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Piece",
            "Kilo",
            "Gram",
            "Litre",
            "Centitlitre",
            "Pack",
            "Box"});
            this.cmbSupplier.Location = new System.Drawing.Point(134, 283);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(224, 37);
            this.cmbSupplier.TabIndex = 5;
            this.cmbSupplier.ValueMember = "IID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "SUPPLIER";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "None",
            "Piece",
            "Kilo",
            "Gram",
            "Litre",
            "Mililitre",
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
            "Sprig"});
            this.cmbOrderType.Location = new System.Drawing.Point(134, 116);
            this.cmbOrderType.MaxDropDownItems = 10;
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(224, 37);
            this.cmbOrderType.TabIndex = 2;
            // 
            // txtUsedQuantity
            // 
            this.txtUsedQuantity.AcceptsReturn = true;
            this.txtUsedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUsedQuantity.Location = new System.Drawing.Point(134, 239);
            this.txtUsedQuantity.Name = "txtUsedQuantity";
            this.txtUsedQuantity.ReadOnly = true;
            this.txtUsedQuantity.Size = new System.Drawing.Size(80, 29);
            this.txtUsedQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "USED QUANTITY";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsed.Location = new System.Drawing.Point(220, 242);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(40, 24);
            this.lblUsed.TabIndex = 41;
            this.lblUsed.Text = "000";
            // 
            // btnSet0
            // 
            this.btnSet0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSet0.Location = new System.Drawing.Point(410, 273);
            this.btnSet0.Name = "btnSet0";
            this.btnSet0.Size = new System.Drawing.Size(94, 47);
            this.btnSet0.TabIndex = 44;
            this.btnSet0.Text = "Set  0";
            this.btnSet0.UseVisualStyleBackColor = true;
            this.btnSet0.Click += new System.EventHandler(this.btnSet0_Click);
            // 
            // btnSetCustom
            // 
            this.btnSetCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSetCustom.Location = new System.Drawing.Point(546, 273);
            this.btnSetCustom.Name = "btnSetCustom";
            this.btnSetCustom.Size = new System.Drawing.Size(94, 47);
            this.btnSetCustom.TabIndex = 45;
            this.btnSetCustom.Text = "Set  ?";
            this.btnSetCustom.UseVisualStyleBackColor = true;
            this.btnSetCustom.Click += new System.EventHandler(this.btnSetCustom_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(407, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 109;
            this.label18.Text = "Image File Name";
            // 
            // txtImageFile
            // 
            this.txtImageFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImageFile.Location = new System.Drawing.Point(410, 209);
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.ReadOnly = true;
            this.txtImageFile.Size = new System.Drawing.Size(230, 23);
            this.txtImageFile.TabIndex = 108;
            // 
            // btnLoadImageFromDatabase
            // 
            this.btnLoadImageFromDatabase.Image = global::DTRMNS.Properties.Resources.DBSource32;
            this.btnLoadImageFromDatabase.Location = new System.Drawing.Point(592, 131);
            this.btnLoadImageFromDatabase.Name = "btnLoadImageFromDatabase";
            this.btnLoadImageFromDatabase.Size = new System.Drawing.Size(48, 48);
            this.btnLoadImageFromDatabase.TabIndex = 107;
            this.btnLoadImageFromDatabase.UseVisualStyleBackColor = true;
            this.btnLoadImageFromDatabase.Click += new System.EventHandler(this.btnLoadImageFromDatabase_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Image = global::DTRMNS.Properties.Resources.Cancel;
            this.btnDeleteImage.Location = new System.Drawing.Point(592, 69);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteImage.TabIndex = 106;
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnLoadImageFromDirectory
            // 
            this.btnLoadImageFromDirectory.Image = global::DTRMNS.Properties.Resources.FolderOpen_32;
            this.btnLoadImageFromDirectory.Location = new System.Drawing.Point(592, 12);
            this.btnLoadImageFromDirectory.Name = "btnLoadImageFromDirectory";
            this.btnLoadImageFromDirectory.Size = new System.Drawing.Size(48, 48);
            this.btnLoadImageFromDirectory.TabIndex = 105;
            this.btnLoadImageFromDirectory.UseVisualStyleBackColor = true;
            this.btnLoadImageFromDirectory.Click += new System.EventHandler(this.btnLoadImageFromDirectory_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(410, 12);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(176, 168);
            this.pBox.TabIndex = 103;
            this.pBox.TabStop = false;
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.Image = global::DTRMNS.Properties.Resources.eksi321;
            this.btnMinusQty.Location = new System.Drawing.Point(289, 169);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(69, 35);
            this.btnMinusQty.TabIndex = 43;
            this.btnMinusQty.UseVisualStyleBackColor = true;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnPlusQty
            // 
            this.btnPlusQty.Image = global::DTRMNS.Properties.Resources.AddGreen;
            this.btnPlusQty.Location = new System.Drawing.Point(223, 169);
            this.btnPlusQty.Name = "btnPlusQty";
            this.btnPlusQty.Size = new System.Drawing.Size(60, 35);
            this.btnPlusQty.TabIndex = 42;
            this.btnPlusQty.UseVisualStyleBackColor = true;
            this.btnPlusQty.Click += new System.EventHandler(this.btnPlusQty_Click);
            // 
            // frmStockItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(671, 416);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtImageFile);
            this.Controls.Add(this.btnLoadImageFromDatabase);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnLoadImageFromDirectory);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.btnSetCustom);
            this.Controls.Add(this.btnSet0);
            this.Controls.Add(this.btnMinusQty);
            this.Controls.Add(this.btnPlusQty);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.txtUsedQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbQuantityType);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STOCK ITEM";
            this.Load += new System.EventHandler(this.frmStockItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PosLibrary.IntegerTextBox txtConversion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbQuantityType;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.TextBox txtUsedQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.Button btnMinusQty;
        private System.Windows.Forms.Button btnPlusQty;
        private System.Windows.Forms.Button btnSet0;
        private System.Windows.Forms.Button btnSetCustom;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnLoadImageFromDirectory;
        private System.Windows.Forms.Button btnLoadImageFromDatabase;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtImageFile;
    }
}