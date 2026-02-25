namespace DTRMNS.Controls {
    partial class ctlBonus {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pBar = new PosLibrary.DRProgressBar();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblCiro = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.AutoSize = true;
            this.pBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBar.CustomFormat = "n0";
            this.pBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar.ForeColor = System.Drawing.Color.Yellow;
            this.pBar.Location = new System.Drawing.Point(20, 0);
            this.pBar.Margin = new System.Windows.Forms.Padding(4);
            this.pBar.Maximum = 100;
            this.pBar.Minimum = 0;
            this.pBar.Name = "pBar";
            this.pBar.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pBar.ShowRemainingValueText = false;
            this.pBar.ShowValueText = false;
            this.pBar.Size = new System.Drawing.Size(160, 20);
            this.pBar.TabIndex = 1;
            this.pBar.Text = "?";
            this.pBar.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pBar.Value = 0;
            this.pBar.Click += new System.EventHandler(this.pBar_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.BackColor = System.Drawing.Color.Transparent;
            this.lblCiro.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCiro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCiro.Location = new System.Drawing.Point(196, 0);
            this.lblCiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblCiro.Size = new System.Drawing.Size(51, 18);
            this.lblCiro.TabIndex = 4;
            this.lblCiro.Text = "0.00";
            this.lblCiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCiro.Click += new System.EventHandler(this.lblCiro_Click);
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lblPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrevious.Location = new System.Drawing.Point(4, 0);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(16, 18);
            this.lblPrevious.TabIndex = 5;
            this.lblPrevious.Text = "0";
            this.lblPrevious.Click += new System.EventHandler(this.lblPrevious_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNext.Location = new System.Drawing.Point(180, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(16, 18);
            this.lblNext.TabIndex = 6;
            this.lblNext.Text = "1";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // ctlBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.lblPrevious);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.Name = "ctlBonus";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size = new System.Drawing.Size(251, 20);
            this.Click += new System.EventHandler(this.ctlBonus_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PosLibrary.DRProgressBar pBar;
        public System.Windows.Forms.Timer tmrMain;
        public System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
    }
}
