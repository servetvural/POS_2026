namespace WinOffice {
    partial class frmSalon {
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
            txtGroupHeight = new WinLayer.IntegerTextBox();
            label3 = new System.Windows.Forms.Label();
            txtGroupWidth = new WinLayer.IntegerTextBox();
            label2 = new System.Windows.Forms.Label();
            txtGroupName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnHeightMinus = new System.Windows.Forms.Button();
            btnHeightPlus = new System.Windows.Forms.Button();
            btnWidthMinus = new System.Windows.Forms.Button();
            btnWidthPlus = new System.Windows.Forms.Button();
            btnSalonColor = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtGroupHeight
            // 
            txtGroupHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtGroupHeight.Increment = 50;
            txtGroupHeight.Location = new System.Drawing.Point(29, 219);
            txtGroupHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGroupHeight.MaxValue = 1200;
            txtGroupHeight.MinValue = 100;
            txtGroupHeight.Name = "txtGroupHeight";
            txtGroupHeight.Size = new System.Drawing.Size(93, 35);
            txtGroupHeight.TabIndex = 42;
            txtGroupHeight.Text = "100";
            txtGroupHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtGroupHeight.Value = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 201);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 15);
            label3.TabIndex = 41;
            label3.Text = "Salon Area Height";
            // 
            // txtGroupWidth
            // 
            txtGroupWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtGroupWidth.Increment = 50;
            txtGroupWidth.Location = new System.Drawing.Point(29, 148);
            txtGroupWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGroupWidth.MaxValue = 1200;
            txtGroupWidth.MinValue = 100;
            txtGroupWidth.Name = "txtGroupWidth";
            txtGroupWidth.Size = new System.Drawing.Size(93, 35);
            txtGroupWidth.TabIndex = 40;
            txtGroupWidth.Text = "100";
            txtGroupWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtGroupWidth.Value = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 129);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 15);
            label2.TabIndex = 39;
            label2.Text = "Salon Area Width";
            // 
            // txtGroupName
            // 
            txtGroupName.AcceptsReturn = true;
            txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtGroupName.Location = new System.Drawing.Point(29, 37);
            txtGroupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGroupName.MaxLength = 49;
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new System.Drawing.Size(249, 26);
            txtGroupName.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 15);
            label1.TabIndex = 37;
            label1.Text = "Salon/Room/Floor Name";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(186, 295);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(93, 45);
            btnSave.TabIndex = 48;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(29, 295);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(93, 45);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnHeightMinus
            // 
            btnHeightMinus.Image = Properties.Resources.eksi32;
            btnHeightMinus.Location = new System.Drawing.Point(209, 219);
            btnHeightMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeightMinus.Name = "btnHeightMinus";
            btnHeightMinus.Size = new System.Drawing.Size(70, 40);
            btnHeightMinus.TabIndex = 46;
            btnHeightMinus.UseVisualStyleBackColor = true;
            btnHeightMinus.Click += btnHeightMinus_Click;
            // 
            // btnHeightPlus
            // 
            btnHeightPlus.Image = Properties.Resources.arti32;
            btnHeightPlus.Location = new System.Drawing.Point(132, 219);
            btnHeightPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeightPlus.Name = "btnHeightPlus";
            btnHeightPlus.Size = new System.Drawing.Size(70, 40);
            btnHeightPlus.TabIndex = 45;
            btnHeightPlus.UseVisualStyleBackColor = true;
            btnHeightPlus.Click += btnHeightPlus_Click;
            // 
            // btnWidthMinus
            // 
            btnWidthMinus.Image = Properties.Resources.eksi32;
            btnWidthMinus.Location = new System.Drawing.Point(209, 148);
            btnWidthMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnWidthMinus.Name = "btnWidthMinus";
            btnWidthMinus.Size = new System.Drawing.Size(70, 40);
            btnWidthMinus.TabIndex = 44;
            btnWidthMinus.UseVisualStyleBackColor = true;
            btnWidthMinus.Click += btnWidthMinus_Click;
            // 
            // btnWidthPlus
            // 
            btnWidthPlus.Image = Properties.Resources.arti32;
            btnWidthPlus.Location = new System.Drawing.Point(132, 148);
            btnWidthPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnWidthPlus.Name = "btnWidthPlus";
            btnWidthPlus.Size = new System.Drawing.Size(70, 40);
            btnWidthPlus.TabIndex = 43;
            btnWidthPlus.UseVisualStyleBackColor = true;
            btnWidthPlus.Click += btnWidthPlus_Click;
            // 
            // btnSalonColor
            // 
            btnSalonColor.BackColor = System.Drawing.SystemColors.Control;
            btnSalonColor.FlatAppearance.BorderSize = 0;
            btnSalonColor.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSalonColor.Location = new System.Drawing.Point(29, 80);
            btnSalonColor.Name = "btnSalonColor";
            btnSalonColor.Size = new System.Drawing.Size(93, 36);
            btnSalonColor.TabIndex = 49;
            btnSalonColor.TabStop = false;
            btnSalonColor.Text = "Back Colour";
            btnSalonColor.UseVisualStyleBackColor = true;
            btnSalonColor.Click += btnSalonColor_Click;
            // 
            // frmSalon
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(323, 379);
            ControlBox = false;
            Controls.Add(btnSalonColor);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnHeightMinus);
            Controls.Add(btnHeightPlus);
            Controls.Add(btnWidthMinus);
            Controls.Add(btnWidthPlus);
            Controls.Add(txtGroupHeight);
            Controls.Add(label3);
            Controls.Add(txtGroupWidth);
            Controls.Add(label2);
            Controls.Add(txtGroupName);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmSalon";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Salon / Floor";
            Load += frmTableGroup_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeightMinus;
        private System.Windows.Forms.Button btnHeightPlus;
        private System.Windows.Forms.Button btnWidthMinus;
        private System.Windows.Forms.Button btnWidthPlus;
        private WinLayer.IntegerTextBox txtGroupHeight;
        private System.Windows.Forms.Label label3;
        private WinLayer.IntegerTextBox txtGroupWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSalonColor;
    }
}