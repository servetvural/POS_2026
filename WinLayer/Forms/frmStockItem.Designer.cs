namespace WinLayer {
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
        private void InitializeComponent()
        {
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtStockName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtConversion = new PosLibrary.IntegerTextBox();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            cmbQuantityType = new System.Windows.Forms.ComboBox();
            cmbSupplier = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cmbOrderType = new System.Windows.Forms.ComboBox();
            txtUsedQuantity = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            lblUsed = new System.Windows.Forms.Label();
            btnSet0 = new System.Windows.Forms.Button();
            btnSetCustom = new System.Windows.Forms.Button();
            label18 = new System.Windows.Forms.Label();
            txtImageFile = new System.Windows.Forms.TextBox();
            btnLoadImageFromDatabase = new System.Windows.Forms.Button();
            btnDeleteImage = new System.Windows.Forms.Button();
            btnLoadImageFromDirectory = new System.Windows.Forms.Button();
            pBox = new System.Windows.Forms.PictureBox();
            btnMinusQty = new System.Windows.Forms.Button();
            btnPlusQty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(637, 398);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(110, 58);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(478, 398);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 58);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStockName
            // 
            txtStockName.AcceptsReturn = true;
            txtStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtStockName.Location = new System.Drawing.Point(156, 14);
            txtStockName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new System.Drawing.Size(261, 35);
            txtStockName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 31);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 15);
            label1.TabIndex = 16;
            label1.Text = "STOCK ITEM NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 89);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 26;
            label2.Text = "QUANTITY TYPE";
            // 
            // txtConversion
            // 
            txtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtConversion.Increment = 1;
            txtConversion.Location = new System.Drawing.Point(156, 195);
            txtConversion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtConversion.MaxValue = 51000;
            txtConversion.MinValue = 0;
            txtConversion.Name = "txtConversion";
            txtConversion.Size = new System.Drawing.Size(93, 35);
            txtConversion.TabIndex = 3;
            txtConversion.Text = "0";
            txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtConversion.Value = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(55, 208);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(80, 15);
            label8.TabIndex = 31;
            label8.Text = "CONVERSION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(55, 151);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(74, 15);
            label10.TabIndex = 27;
            label10.Text = "ORDER TYPE";
            // 
            // cmbQuantityType
            // 
            cmbQuantityType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbQuantityType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cmbQuantityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbQuantityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            cmbQuantityType.FormattingEnabled = true;
            cmbQuantityType.Items.AddRange(new object[] { "None", "Piece", "Kilo", "Gram", "Litre", "Mililitre", "Pack", "Box", "Bottle", "Crate", "Slice", "Dash", "Pinch", "Bar Spoon", "Leaf", "Wheel", "Handful", "Quarter", "Drops", "Halves", "Barista_Scoop", "Splash", "Sprinkle", "Sachet", "Can" });
            cmbQuantityType.Location = new System.Drawing.Point(156, 72);
            cmbQuantityType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbQuantityType.MaxDropDownItems = 10;
            cmbQuantityType.Name = "cmbQuantityType";
            cmbQuantityType.Size = new System.Drawing.Size(261, 37);
            cmbQuantityType.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "Piece", "Kilo", "Gram", "Litre", "Centitlitre", "Pack", "Box" });
            cmbSupplier.Location = new System.Drawing.Point(156, 327);
            cmbSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(261, 37);
            cmbSupplier.TabIndex = 5;
            cmbSupplier.ValueMember = "IID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(75, 344);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 36;
            label3.Text = "SUPPLIER";
            // 
            // cmbOrderType
            // 
            cmbOrderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbOrderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Items.AddRange(new object[] { "None", "Piece", "Kilo", "Gram", "Litre", "Mililitre", "Pack", "Box", "Bottle", "Crate", "Slice", "Dash", "Pinch", "Bar Spoon", "Leaf", "Wheel", "Handful", "Quarter", "Drops", "Sprig" });
            cmbOrderType.Location = new System.Drawing.Point(156, 134);
            cmbOrderType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbOrderType.MaxDropDownItems = 10;
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new System.Drawing.Size(261, 37);
            cmbOrderType.TabIndex = 2;
            // 
            // txtUsedQuantity
            // 
            txtUsedQuantity.AcceptsReturn = true;
            txtUsedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            txtUsedQuantity.Location = new System.Drawing.Point(156, 276);
            txtUsedQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsedQuantity.Name = "txtUsedQuantity";
            txtUsedQuantity.ReadOnly = true;
            txtUsedQuantity.Size = new System.Drawing.Size(93, 29);
            txtUsedQuantity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(34, 288);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 15);
            label4.TabIndex = 40;
            label4.Text = "USED QUANTITY";
            // 
            // lblUsed
            // 
            lblUsed.AutoSize = true;
            lblUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            lblUsed.Location = new System.Drawing.Point(257, 279);
            lblUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsed.Name = "lblUsed";
            lblUsed.Size = new System.Drawing.Size(40, 24);
            lblUsed.TabIndex = 41;
            lblUsed.Text = "000";
            // 
            // btnSet0
            // 
            btnSet0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            btnSet0.Location = new System.Drawing.Point(478, 315);
            btnSet0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSet0.Name = "btnSet0";
            btnSet0.Size = new System.Drawing.Size(110, 54);
            btnSet0.TabIndex = 44;
            btnSet0.Text = "Set  0";
            btnSet0.UseVisualStyleBackColor = true;
            btnSet0.Click += btnSet0_Click;
            // 
            // btnSetCustom
            // 
            btnSetCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            btnSetCustom.Location = new System.Drawing.Point(637, 315);
            btnSetCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSetCustom.Name = "btnSetCustom";
            btnSetCustom.Size = new System.Drawing.Size(110, 54);
            btnSetCustom.TabIndex = 45;
            btnSetCustom.Text = "Set  ?";
            btnSetCustom.UseVisualStyleBackColor = true;
            btnSetCustom.Click += btnSetCustom_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(475, 223);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(96, 15);
            label18.TabIndex = 109;
            label18.Text = "Image File Name";
            // 
            // txtImageFile
            // 
            txtImageFile.BackColor = System.Drawing.SystemColors.Window;
            txtImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txtImageFile.Location = new System.Drawing.Point(478, 241);
            txtImageFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.ReadOnly = true;
            txtImageFile.Size = new System.Drawing.Size(268, 23);
            txtImageFile.TabIndex = 108;
            // 
            // btnLoadImageFromDatabase
            // 
            btnLoadImageFromDatabase.Image = Properties.Resources.DBSource32;
            btnLoadImageFromDatabase.Location = new System.Drawing.Point(691, 151);
            btnLoadImageFromDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadImageFromDatabase.Name = "btnLoadImageFromDatabase";
            btnLoadImageFromDatabase.Size = new System.Drawing.Size(56, 55);
            btnLoadImageFromDatabase.TabIndex = 107;
            btnLoadImageFromDatabase.UseVisualStyleBackColor = true;
            btnLoadImageFromDatabase.Click += btnLoadImageFromDatabase_Click;
            // 
            // btnDeleteImage
            // 
            btnDeleteImage.Image = Properties.Resources.Cancel;
            btnDeleteImage.Location = new System.Drawing.Point(691, 80);
            btnDeleteImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteImage.Name = "btnDeleteImage";
            btnDeleteImage.Size = new System.Drawing.Size(56, 55);
            btnDeleteImage.TabIndex = 106;
            btnDeleteImage.UseVisualStyleBackColor = true;
            btnDeleteImage.Click += btnDeleteImage_Click;
            // 
            // btnLoadImageFromDirectory
            // 
            btnLoadImageFromDirectory.Image = Properties.Resources.FolderOpen_32;
            btnLoadImageFromDirectory.Location = new System.Drawing.Point(691, 14);
            btnLoadImageFromDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadImageFromDirectory.Name = "btnLoadImageFromDirectory";
            btnLoadImageFromDirectory.Size = new System.Drawing.Size(56, 55);
            btnLoadImageFromDirectory.TabIndex = 105;
            btnLoadImageFromDirectory.UseVisualStyleBackColor = true;
            btnLoadImageFromDirectory.Click += btnLoadImageFromDirectory_Click;
            // 
            // pBox
            // 
            pBox.BackColor = System.Drawing.Color.White;
            pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pBox.Location = new System.Drawing.Point(478, 14);
            pBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pBox.Name = "pBox";
            pBox.Size = new System.Drawing.Size(205, 194);
            pBox.TabIndex = 103;
            pBox.TabStop = false;
            // 
            // btnMinusQty
            // 
            btnMinusQty.Image = Properties.Resources.eksi321;
            btnMinusQty.Location = new System.Drawing.Point(337, 195);
            btnMinusQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMinusQty.Name = "btnMinusQty";
            btnMinusQty.Size = new System.Drawing.Size(80, 40);
            btnMinusQty.TabIndex = 43;
            btnMinusQty.UseVisualStyleBackColor = true;
            btnMinusQty.Click += btnMinusQty_Click;
            // 
            // btnPlusQty
            // 
            btnPlusQty.Image = Properties.Resources.AddGreen;
            btnPlusQty.Location = new System.Drawing.Point(260, 195);
            btnPlusQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPlusQty.Name = "btnPlusQty";
            btnPlusQty.Size = new System.Drawing.Size(70, 40);
            btnPlusQty.TabIndex = 42;
            btnPlusQty.UseVisualStyleBackColor = true;
            btnPlusQty.Click += btnPlusQty_Click;
            // 
            // frmStockItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(779, 486);
            ControlBox = false;
            Controls.Add(label18);
            Controls.Add(txtImageFile);
            Controls.Add(btnLoadImageFromDatabase);
            Controls.Add(btnDeleteImage);
            Controls.Add(btnLoadImageFromDirectory);
            Controls.Add(pBox);
            Controls.Add(btnSetCustom);
            Controls.Add(btnSet0);
            Controls.Add(btnMinusQty);
            Controls.Add(btnPlusQty);
            Controls.Add(lblUsed);
            Controls.Add(txtUsedQuantity);
            Controls.Add(label4);
            Controls.Add(cmbOrderType);
            Controls.Add(cmbSupplier);
            Controls.Add(label3);
            Controls.Add(cmbQuantityType);
            Controls.Add(txtConversion);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtStockName);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmStockItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "STOCK ITEM";
            Load += frmStockItem_Load;
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

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