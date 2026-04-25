namespace BSLayer {
    partial class frmStringInput {
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
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txt = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(429, 74);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(84, 45);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(321, 74);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(84, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txt
            // 
            txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            txt.Location = new System.Drawing.Point(21, 22);
            txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt.Name = "txt";
            txt.Size = new System.Drawing.Size(492, 29);
            txt.TabIndex = 0;
            // 
            // frmStringInput
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(536, 148);
            ControlBox = false;
            Controls.Add(txt);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmStringInput";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "String Input";
            Load += frmIntegerInput_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txt;
    }
}