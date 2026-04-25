namespace WinOffice {
    partial class frmTable {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableCovers = new WinLayer.IntegerTextBox();
            this.txtXLocation = new WinLayer.IntegerTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYLocation = new WinLayer.IntegerTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableHeight = new WinLayer.IntegerTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableWidth = new WinLayer.IntegerTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCoversMinus = new System.Windows.Forms.Button();
            this.btnCoversPlus = new System.Windows.Forms.Button();
            this.btnXMinus = new System.Windows.Forms.Button();
            this.btnXPlus = new System.Windows.Forms.Button();
            this.btnWMInus = new System.Windows.Forms.Button();
            this.btnWPlus = new System.Windows.Forms.Button();
            this.btnYMinus = new System.Windows.Forms.Button();
            this.btnYPlus = new System.Windows.Forms.Button();
            this.btnHMinus = new System.Windows.Forms.Button();
            this.btnHPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.AcceptsReturn = true;
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTableName.Location = new System.Drawing.Point(25, 26);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(214, 26);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTableName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Covers";
            // 
            // txtTableCovers
            // 
            this.txtTableCovers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTableCovers.Increment = 1;
            this.txtTableCovers.Location = new System.Drawing.Point(25, 76);
            this.txtTableCovers.MaxValue = 50;
            this.txtTableCovers.MinValue = 1;
            this.txtTableCovers.Name = "txtTableCovers";
            this.txtTableCovers.Size = new System.Drawing.Size(80, 35);
            this.txtTableCovers.TabIndex = 3;
            this.txtTableCovers.Text = "1";
            this.txtTableCovers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXLocation
            // 
            this.txtXLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtXLocation.Increment = 10;
            this.txtXLocation.Location = new System.Drawing.Point(25, 138);
            this.txtXLocation.MaxValue = 1300;
            this.txtXLocation.MinValue = 1;
            this.txtXLocation.Name = "txtXLocation";
            this.txtXLocation.Size = new System.Drawing.Size(80, 35);
            this.txtXLocation.TabIndex = 5;
            this.txtXLocation.Text = "1";
            this.txtXLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X Location";
            // 
            // txtYLocation
            // 
            this.txtYLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtYLocation.Increment = 10;
            this.txtYLocation.Location = new System.Drawing.Point(25, 206);
            this.txtYLocation.MaxValue = 1000;
            this.txtYLocation.MinValue = 0;
            this.txtYLocation.Name = "txtYLocation";
            this.txtYLocation.Size = new System.Drawing.Size(80, 35);
            this.txtYLocation.TabIndex = 7;
            this.txtYLocation.Text = "1";
            this.txtYLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y Location";
            // 
            // txtTableHeight
            // 
            this.txtTableHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTableHeight.Increment = 10;
            this.txtTableHeight.Location = new System.Drawing.Point(25, 274);
            this.txtTableHeight.MaxValue = 540;
            this.txtTableHeight.MinValue = 40;
            this.txtTableHeight.Name = "txtTableHeight";
            this.txtTableHeight.Size = new System.Drawing.Size(80, 35);
            this.txtTableHeight.TabIndex = 11;
            this.txtTableHeight.Text = "40";
            this.txtTableHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Table Height";
            // 
            // txtTableWidth
            // 
            this.txtTableWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTableWidth.Increment = 10;
            this.txtTableWidth.Location = new System.Drawing.Point(25, 349);
            this.txtTableWidth.MaxValue = 600;
            this.txtTableWidth.MinValue = 40;
            this.txtTableWidth.Name = "txtTableWidth";
            this.txtTableWidth.Size = new System.Drawing.Size(80, 35);
            this.txtTableWidth.TabIndex = 9;
            this.txtTableWidth.Text = "40";
            this.txtTableWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Table Width";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(25, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbShape
            // 
            this.cmbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Items.AddRange(new object[] {
            "Rectangle",
            "Circle"});
            this.cmbShape.Location = new System.Drawing.Point(26, 416);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(213, 21);
            this.cmbShape.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Table Shape";
            // 
            // btnCoversMinus
            // 
            this.btnCoversMinus.Image = global::WinOffice.Properties.Resources.eksi32;
            this.btnCoversMinus.Location = new System.Drawing.Point(179, 76);
            this.btnCoversMinus.Name = "btnCoversMinus";
            this.btnCoversMinus.Size = new System.Drawing.Size(60, 35);
            this.btnCoversMinus.TabIndex = 34;
            this.btnCoversMinus.UseVisualStyleBackColor = true;
            this.btnCoversMinus.Click += new System.EventHandler(this.btnCoversMinus_Click);
            // 
            // btnCoversPlus
            // 
            this.btnCoversPlus.Image = global::WinOffice.Properties.Resources.arti32;
            this.btnCoversPlus.Location = new System.Drawing.Point(113, 76);
            this.btnCoversPlus.Name = "btnCoversPlus";
            this.btnCoversPlus.Size = new System.Drawing.Size(60, 35);
            this.btnCoversPlus.TabIndex = 33;
            this.btnCoversPlus.UseVisualStyleBackColor = true;
            this.btnCoversPlus.Click += new System.EventHandler(this.btnCoversPlus_Click);
            // 
            // btnXMinus
            // 
            this.btnXMinus.Image = global::WinOffice.Properties.Resources.eksi32;
            this.btnXMinus.Location = new System.Drawing.Point(179, 138);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(60, 35);
            this.btnXMinus.TabIndex = 36;
            this.btnXMinus.UseVisualStyleBackColor = true;
            this.btnXMinus.Click += new System.EventHandler(this.btnXMinus_Click);
            // 
            // btnXPlus
            // 
            this.btnXPlus.Image = global::WinOffice.Properties.Resources.arti32;
            this.btnXPlus.Location = new System.Drawing.Point(113, 138);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(60, 35);
            this.btnXPlus.TabIndex = 35;
            this.btnXPlus.UseVisualStyleBackColor = true;
            this.btnXPlus.Click += new System.EventHandler(this.btnXPlus_Click);
            // 
            // btnWMInus
            // 
            this.btnWMInus.Image = global::WinOffice.Properties.Resources.eksi32;
            this.btnWMInus.Location = new System.Drawing.Point(179, 349);
            this.btnWMInus.Name = "btnWMInus";
            this.btnWMInus.Size = new System.Drawing.Size(60, 35);
            this.btnWMInus.TabIndex = 38;
            this.btnWMInus.UseVisualStyleBackColor = true;
            this.btnWMInus.Click += new System.EventHandler(this.btnWMInus_Click);
            // 
            // btnWPlus
            // 
            this.btnWPlus.Image = global::WinOffice.Properties.Resources.arti32;
            this.btnWPlus.Location = new System.Drawing.Point(113, 349);
            this.btnWPlus.Name = "btnWPlus";
            this.btnWPlus.Size = new System.Drawing.Size(60, 35);
            this.btnWPlus.TabIndex = 37;
            this.btnWPlus.UseVisualStyleBackColor = true;
            this.btnWPlus.Click += new System.EventHandler(this.btnWPlus_Click);
            // 
            // btnYMinus
            // 
            this.btnYMinus.Image = global::WinOffice.Properties.Resources.eksi32;
            this.btnYMinus.Location = new System.Drawing.Point(179, 206);
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Size = new System.Drawing.Size(60, 35);
            this.btnYMinus.TabIndex = 40;
            this.btnYMinus.UseVisualStyleBackColor = true;
            this.btnYMinus.Click += new System.EventHandler(this.btnYMinus_Click);
            // 
            // btnYPlus
            // 
            this.btnYPlus.Image = global::WinOffice.Properties.Resources.arti32;
            this.btnYPlus.Location = new System.Drawing.Point(113, 206);
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Size = new System.Drawing.Size(60, 35);
            this.btnYPlus.TabIndex = 39;
            this.btnYPlus.UseVisualStyleBackColor = true;
            this.btnYPlus.Click += new System.EventHandler(this.btnYPlus_Click);
            // 
            // btnHMinus
            // 
            this.btnHMinus.Image = global::WinOffice.Properties.Resources.eksi32;
            this.btnHMinus.Location = new System.Drawing.Point(179, 274);
            this.btnHMinus.Name = "btnHMinus";
            this.btnHMinus.Size = new System.Drawing.Size(60, 35);
            this.btnHMinus.TabIndex = 42;
            this.btnHMinus.UseVisualStyleBackColor = true;
            this.btnHMinus.Click += new System.EventHandler(this.btnHMinus_Click);
            // 
            // btnHPlus
            // 
            this.btnHPlus.Image = global::WinOffice.Properties.Resources.arti32;
            this.btnHPlus.Location = new System.Drawing.Point(113, 274);
            this.btnHPlus.Name = "btnHPlus";
            this.btnHPlus.Size = new System.Drawing.Size(60, 35);
            this.btnHPlus.TabIndex = 41;
            this.btnHPlus.UseVisualStyleBackColor = true;
            this.btnHPlus.Click += new System.EventHandler(this.btnHPlus_Click);
            // 
            // frmTable
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(268, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnHMinus);
            this.Controls.Add(this.btnHPlus);
            this.Controls.Add(this.btnYMinus);
            this.Controls.Add(this.btnYPlus);
            this.Controls.Add(this.btnWMInus);
            this.Controls.Add(this.btnWPlus);
            this.Controls.Add(this.btnXMinus);
            this.Controls.Add(this.btnXPlus);
            this.Controls.Add(this.btnCoversMinus);
            this.Controls.Add(this.btnCoversPlus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbShape);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTableHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableCovers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Table Editor";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private WinLayer.IntegerTextBox txtTableCovers;
        private WinLayer.IntegerTextBox txtXLocation;
        private System.Windows.Forms.Label label3;
        private WinLayer.IntegerTextBox txtYLocation;
        private System.Windows.Forms.Label label4;
        private WinLayer.IntegerTextBox txtTableHeight;
        private System.Windows.Forms.Label label5;
        private WinLayer.IntegerTextBox txtTableWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCoversMinus;
        private System.Windows.Forms.Button btnCoversPlus;
        private System.Windows.Forms.Button btnXMinus;
        private System.Windows.Forms.Button btnXPlus;
        private System.Windows.Forms.Button btnWMInus;
        private System.Windows.Forms.Button btnWPlus;
        private System.Windows.Forms.Button btnYMinus;
        private System.Windows.Forms.Button btnYPlus;
        private System.Windows.Forms.Button btnHMinus;
        private System.Windows.Forms.Button btnHPlus;
    }
}