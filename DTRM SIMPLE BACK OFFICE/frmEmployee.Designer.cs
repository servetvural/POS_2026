namespace DTRMSimpleBackOffice {
    partial class frmEmployee {
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.NumericUpDown();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeletePrepImage = new System.Windows.Forms.Button();
            this.btnLoadPrepImageFromDirectory = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShortable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 173;
            this.label5.Text = "Rate";
            // 
            // btnSave
            // 
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(309, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(141, 363);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 169;
            this.label1.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmployeeName.Location = new System.Drawing.Point(141, 5);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeName.MaxLength = 50;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(317, 23);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // txtRate
            // 
            this.txtRate.DecimalPlaces = 2;
            this.txtRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtRate.Location = new System.Drawing.Point(141, 281);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(81, 23);
            this.txtRate.TabIndex = 1;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.Value = new decimal(new int[] {
            750,
            0,
            0,
            131072});
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblImageSize.Location = new System.Drawing.Point(396, 204);
            this.lblImageSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(38, 17);
            this.lblImageSize.TabIndex = 178;
            this.lblImageSize.Text = "0 KB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(141, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 17);
            this.label10.TabIndex = 177;
            this.label10.Text = "W : 300px H : 300px | 300K max";
            // 
            // btnDeletePrepImage
            // 
            this.btnDeletePrepImage.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeletePrepImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletePrepImage.Location = new System.Drawing.Point(396, 130);
            this.btnDeletePrepImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePrepImage.Name = "btnDeletePrepImage";
            this.btnDeletePrepImage.Size = new System.Drawing.Size(64, 59);
            this.btnDeletePrepImage.TabIndex = 176;
            this.btnDeletePrepImage.UseVisualStyleBackColor = true;
            this.btnDeletePrepImage.Click += new System.EventHandler(this.btnDeletePrepImage_Click);
            // 
            // btnLoadPrepImageFromDirectory
            // 
            this.btnLoadPrepImageFromDirectory.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderOpen_32;
            this.btnLoadPrepImageFromDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadPrepImageFromDirectory.Location = new System.Drawing.Point(396, 64);
            this.btnLoadPrepImageFromDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPrepImageFromDirectory.Name = "btnLoadPrepImageFromDirectory";
            this.btnLoadPrepImageFromDirectory.Size = new System.Drawing.Size(64, 59);
            this.btnLoadPrepImageFromDirectory.TabIndex = 175;
            this.btnLoadPrepImageFromDirectory.UseVisualStyleBackColor = true;
            this.btnLoadPrepImageFromDirectory.Click += new System.EventHandler(this.btnLoadPrepImageFromDirectory_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBox.Location = new System.Drawing.Point(141, 64);
            this.pBox.Margin = new System.Windows.Forms.Padding(4);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(246, 206);
            this.pBox.TabIndex = 174;
            this.pBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 169;
            this.label2.Text = "Employee Photo";
            // 
            // chkShortable
            // 
            this.chkShortable.AutoSize = true;
            this.chkShortable.Location = new System.Drawing.Point(143, 320);
            this.chkShortable.Name = "chkShortable";
            this.chkShortable.Size = new System.Drawing.Size(88, 21);
            this.chkShortable.TabIndex = 179;
            this.chkShortable.Text = "Shortable";
            this.chkShortable.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 438);
            this.Controls.Add(this.chkShortable);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDeletePrepImage);
            this.Controls.Add(this.btnLoadPrepImageFromDirectory);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EMPLOYEE";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.NumericUpDown txtRate;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeletePrepImage;
        private System.Windows.Forms.Button btnLoadPrepImageFromDirectory;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShortable;
    }
}