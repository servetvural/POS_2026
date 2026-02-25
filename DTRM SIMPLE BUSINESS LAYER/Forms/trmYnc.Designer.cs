namespace DTRMNS {
   partial class trmYnc {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
          this.btnNo = new System.Windows.Forms.Button();
          this.btnCancel = new System.Windows.Forms.Button();
          this.btnYes = new System.Windows.Forms.Button();
            this.panelEx1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel(); 
          this.panel1 = new System.Windows.Forms.Panel();
          this.panel1.SuspendLayout();
          this.SuspendLayout();
          // 
          // btnNo
          // 
          this.btnNo.AutoEllipsis = true;
          this.btnNo.BackColor = System.Drawing.Color.Red;
          this.btnNo.BackgroundImage = global::DTRMNS.Properties.Resources.shadow;
          this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
          this.btnNo.FlatAppearance.BorderSize = 0;
          this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnNo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
          this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
          this.btnNo.Location = new System.Drawing.Point(176, 165);
          this.btnNo.Name = "btnNo";
          this.btnNo.Size = new System.Drawing.Size(80, 80);
          this.btnNo.TabIndex = 2;
          this.btnNo.Text = "NO";
          this.btnNo.UseVisualStyleBackColor = false;
          this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
          // 
          // btnCancel
          // 
          this.btnCancel.AutoEllipsis = true;
          this.btnCancel.BackColor = System.Drawing.Color.Black;
          this.btnCancel.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
          this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.btnCancel.FlatAppearance.BorderSize = 0;
          this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
          this.btnCancel.ForeColor = System.Drawing.Color.White;
          this.btnCancel.Location = new System.Drawing.Point(14, 165);
          this.btnCancel.Name = "btnCancel";
          this.btnCancel.Size = new System.Drawing.Size(80, 80);
          this.btnCancel.TabIndex = 3;
          this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.btnCancel.UseVisualStyleBackColor = false;
          this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
          // 
          // btnYes
          // 
          this.btnYes.AutoEllipsis = true;
          this.btnYes.BackColor = System.Drawing.Color.Black;
          this.btnYes.BackgroundImage = global::DTRMNS.Properties.Resources.okay;
          this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.btnYes.FlatAppearance.BorderSize = 0;
          this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnYes.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
          this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
          this.btnYes.Location = new System.Drawing.Point(299, 165);
          this.btnYes.Name = "btnYes";
          this.btnYes.Size = new System.Drawing.Size(80, 80);
          this.btnYes.TabIndex = 1;
          this.btnYes.UseVisualStyleBackColor = false;
          this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
          // 
          // panelEx1
          // 
          this.panelEx1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.panelEx1.Location = new System.Drawing.Point(12, 14);
          this.panelEx1.Name = "panelEx1";
          this.panelEx1.Size = new System.Drawing.Size(368, 28);
          this.panelEx1.TabIndex = 4;
          this.panelEx1.Text = "CONFIRMATION   REQUIRED";
          // 
          // pnlMain
          // 
          this.pnlMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.pnlMain.Location = new System.Drawing.Point(11, 48);
          this.pnlMain.Name = "pnlMain";
          this.pnlMain.Size = new System.Drawing.Size(368, 100);
          this.pnlMain.TabIndex = 5;
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.Color.Black;
          this.panel1.Controls.Add(this.panelEx1);
          this.panel1.Controls.Add(this.pnlMain);
          this.panel1.Controls.Add(this.btnYes);
          this.panel1.Controls.Add(this.btnCancel);
          this.panel1.Controls.Add(this.btnNo);
          this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel1.Location = new System.Drawing.Point(10, 10);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(393, 257);
          this.panel1.TabIndex = 6;
          // 
          // trmYnc
          // 
          this.BackColor = System.Drawing.SystemColors.Control;
          this.ClientSize = new System.Drawing.Size(413, 277);
          this.ControlBox = false;
          this.Controls.Add(this.panel1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Name = "trmYnc";
          this.Padding = new System.Windows.Forms.Padding(10);
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "CONFIRM";
          this.Load += new System.EventHandler(this.frmYnc_Load);
          this.panel1.ResumeLayout(false);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnYes;
      private System.Windows.Forms.Button btnNo;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Panel panelEx1;
      private System.Windows.Forms.Panel pnlMain;
      private System.Windows.Forms.Panel panel1;
   }
}