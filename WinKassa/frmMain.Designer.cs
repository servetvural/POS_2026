namespace WinKassa {
    partial class frmMain {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 80);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WinKassa.Properties.Resources.RedCross48;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(137, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::WinKassa.Properties.Resources.disli48;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(36, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 80);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalculator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalculator.Location = new System.Drawing.Point(12, 12);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(255, 76);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "START CALCULATOR";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(279, 186);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KASSA CALCULATOR";
            this.Load += new System.EventHandler(this.frmKassaCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCalculator;
    }
}

