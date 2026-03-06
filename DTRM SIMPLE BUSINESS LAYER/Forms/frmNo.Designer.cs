namespace DTRMNS {
    partial class frmNo {
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
            txtVal = new PosLibrary.IntegerTextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtVal
            // 
            txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            txtVal.Increment = 1;
            txtVal.Location = new System.Drawing.Point(14, 14);
            txtVal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVal.MaxValue = 10000;
            txtVal.MinValue = 0;
            txtVal.Name = "txtVal";
            txtVal.Size = new System.Drawing.Size(207, 32);
            txtVal.TabIndex = 0;
            txtVal.Text = "1";
            txtVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtVal.Value = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(128, 80);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(93, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(14, 80);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(93, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmNo
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(244, 154);
            ControlBox = false;
            Controls.Add(txtVal);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmNo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Input";
            Load += frmNo_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PosLibrary.IntegerTextBox txtVal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}