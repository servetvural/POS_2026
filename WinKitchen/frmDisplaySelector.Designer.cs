namespace WinKitchen {
    partial class frmDisplaySelector {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplaySelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(28, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 80);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(301, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WinKitchen.Properties.Resources.RedCross48;
            this.btnClose.Location = new System.Drawing.Point(205, 0);
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
            this.btnSettings.Image = global::WinKitchen.Properties.Resources.disli48;
            this.btnSettings.Location = new System.Drawing.Point(109, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 80);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.DarkRed;
            this.btnDouble.FlatAppearance.BorderSize = 0;
            this.btnDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDouble.ForeColor = System.Drawing.Color.White;
            this.btnDouble.Image = global::WinKitchen.Properties.Resources.chef64_128;
            this.btnDouble.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDouble.Location = new System.Drawing.Point(329, 25);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(189, 104);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "DOUBLE  DISPLAY";
            this.btnDouble.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.BackColor = System.Drawing.Color.DarkRed;
            this.btnSingle.FlatAppearance.BorderSize = 0;
            this.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSingle.ForeColor = System.Drawing.Color.White;
            this.btnSingle.Image = global::WinKitchen.Properties.Resources.chef64;
            this.btnSingle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSingle.Location = new System.Drawing.Point(28, 25);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(189, 104);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "SINGLE  DISPLAY";
            this.btnSingle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSingle.UseVisualStyleBackColor = false;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // frmDisplaySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(546, 247);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnSingle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisplaySelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISPLAY SELECTION";
            this.Load += new System.EventHandler(this.frmDisplaySelector_Load);
            this.Shown += new System.EventHandler(this.frmDisplaySelector_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSettings;
    }
}