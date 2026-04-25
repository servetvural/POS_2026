namespace BSLayer {
   public partial class trmInput {
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
          this.txtInput = new System.Windows.Forms.TextBox();
          this.panel1 = new System.Windows.Forms.Panel();
          this.lblMessage = new System.Windows.Forms.Label();
          this.btnKeyboard = new System.Windows.Forms.Button();
          this.btnOK = new System.Windows.Forms.Button();
          this.btnClose = new System.Windows.Forms.Button();
          this.panel1.SuspendLayout();
          this.SuspendLayout();
          // 
          // txtInput
          // 
          this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.txtInput.Location = new System.Drawing.Point(15, 18);
          this.txtInput.Name = "txtInput";
          this.txtInput.Size = new System.Drawing.Size(585, 22);
          this.txtInput.TabIndex = 0;
          this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.Color.Black;
          this.panel1.Controls.Add(this.lblMessage);
          this.panel1.Controls.Add(this.btnKeyboard);
          this.panel1.Controls.Add(this.txtInput);
          this.panel1.Controls.Add(this.btnOK);
          this.panel1.Controls.Add(this.btnClose);
          this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel1.Location = new System.Drawing.Point(10, 10);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(619, 155);
          this.panel1.TabIndex = 3;
          // 
          // lblMessage
          // 
          this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
          this.lblMessage.ForeColor = System.Drawing.Color.White;
          this.lblMessage.Location = new System.Drawing.Point(140, 58);
          this.lblMessage.Name = "lblMessage";
          this.lblMessage.Size = new System.Drawing.Size(221, 81);
          this.lblMessage.TabIndex = 29;
          // 
          // btnKeyboard
          // 
          this.btnKeyboard.AutoEllipsis = true;
          this.btnKeyboard.BackColor = System.Drawing.Color.Black;
          this.btnKeyboard.BackgroundImage = global::BSLayer.Properties.Resources.Keyboard96_60;
          this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
          this.btnKeyboard.FlatAppearance.BorderSize = 0;
          this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnKeyboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
          this.btnKeyboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
          this.btnKeyboard.Location = new System.Drawing.Point(27, 72);
          this.btnKeyboard.Name = "btnKeyboard";
          this.btnKeyboard.Size = new System.Drawing.Size(96, 60);
          this.btnKeyboard.TabIndex = 28;
          this.btnKeyboard.UseVisualStyleBackColor = false;
          this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
          // 
          // btnOK
          // 
          this.btnOK.AutoEllipsis = true;
          this.btnOK.BackColor = System.Drawing.Color.Black;
          this.btnOK.BackgroundImage = global::BSLayer.Properties.Resources.okay;
          this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
          this.btnOK.FlatAppearance.BorderSize = 0;
          this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnOK.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
          this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
          this.btnOK.Location = new System.Drawing.Point(520, 60);
          this.btnOK.Name = "btnOK";
          this.btnOK.Size = new System.Drawing.Size(80, 80);
          this.btnOK.TabIndex = 2;
          this.btnOK.TabStop = false;
          this.btnOK.UseVisualStyleBackColor = false;
          this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
          // 
          // btnClose
          // 
          this.btnClose.AutoEllipsis = true;
          this.btnClose.BackColor = System.Drawing.Color.Black;
          this.btnClose.BackgroundImage = global::BSLayer.Properties.Resources.CLOSEBig;
          this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.btnClose.FlatAppearance.BorderSize = 0;
          this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
          this.btnClose.ForeColor = System.Drawing.Color.White;
          this.btnClose.Location = new System.Drawing.Point(373, 60);
          this.btnClose.Name = "btnClose";
          this.btnClose.Size = new System.Drawing.Size(80, 80);
          this.btnClose.TabIndex = 1;
          this.btnClose.TabStop = false;
          this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.btnClose.UseVisualStyleBackColor = false;
          this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
          // 
          // trmInput
          // 
          this.ClientSize = new System.Drawing.Size(639, 175);
          this.ControlBox = false;
          this.Controls.Add(this.panel1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Name = "trmInput";
          this.Padding = new System.Windows.Forms.Padding(10);
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "   INPUT DIALOG";
          this.Load += new System.EventHandler(this.frmInput_Load);
          this.panel1.ResumeLayout(false);
          this.panel1.PerformLayout();
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox txtInput;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnKeyboard;
      private System.Windows.Forms.Label lblMessage;
   }
}