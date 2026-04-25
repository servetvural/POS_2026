namespace WinLayer.Controls {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pBar = new PosLibrary.DRProgressBar();
            tmrMain = new System.Windows.Forms.Timer(components);
            lblCiro = new System.Windows.Forms.Label();
            lblPrevious = new System.Windows.Forms.Label();
            lblNext = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // pBar
            // 
            pBar.AutoSize = true;
            pBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pBar.CustomFormat = "N0";
            pBar.Dock = System.Windows.Forms.DockStyle.Fill;
            pBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            pBar.ForeColor = System.Drawing.Color.White;
            pBar.Location = new System.Drawing.Point(20, 0);
            pBar.Margin = new System.Windows.Forms.Padding(4);
            pBar.Maximum = 100;
            pBar.Minimum = 0;
            pBar.Name = "pBar";
            pBar.ProgressColour = System.Drawing.Color.Green;
            pBar.ShowRemainingValueText = false;
            pBar.ShowValueText = false;
            pBar.Size = new System.Drawing.Size(160, 20);
            pBar.TabIndex = 1;
            pBar.Text = "?";
            pBar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            pBar.Value = 0;
            pBar.Click += pBar_Click;
            // 
            // tmrMain
            // 
            tmrMain.Interval = 10000;
            tmrMain.Tick += tmrMain_Tick;
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.BackColor = System.Drawing.Color.Transparent;
            lblCiro.Dock = System.Windows.Forms.DockStyle.Right;
            lblCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            lblCiro.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCiro.Location = new System.Drawing.Point(196, 0);
            lblCiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCiro.Name = "lblCiro";
            lblCiro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            lblCiro.Size = new System.Drawing.Size(51, 18);
            lblCiro.TabIndex = 4;
            lblCiro.Text = "0.00";
            lblCiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblCiro.Click += lblCiro_Click;
            // 
            // lblPrevious
            // 
            lblPrevious.AutoSize = true;
            lblPrevious.BackColor = System.Drawing.Color.Transparent;
            lblPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            lblPrevious.Location = new System.Drawing.Point(4, 0);
            lblPrevious.Name = "lblPrevious";
            lblPrevious.Size = new System.Drawing.Size(16, 18);
            lblPrevious.TabIndex = 5;
            lblPrevious.Text = "0";
            lblPrevious.Click += lblPrevious_Click;
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.Dock = System.Windows.Forms.DockStyle.Right;
            lblNext.Location = new System.Drawing.Point(180, 0);
            lblNext.Name = "lblNext";
            lblNext.Size = new System.Drawing.Size(16, 18);
            lblNext.TabIndex = 6;
            lblNext.Text = "1";
            lblNext.Click += lblNext_Click;
            // 
            // ctlBonus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(pBar);
            Controls.Add(lblNext);
            Controls.Add(lblCiro);
            Controls.Add(lblPrevious);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(100, 20);
            Name = "ctlBonus";
            Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Size = new System.Drawing.Size(251, 20);
            Click += ctlBonus_Click;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public PosLibrary.DRProgressBar pBar;
        public System.Windows.Forms.Timer tmrMain;
        public System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
    }
}
