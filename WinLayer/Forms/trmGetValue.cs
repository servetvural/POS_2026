using System.ComponentModel;   
using POSLayer.Library;

namespace WinLayer {
	/// <summary>
	/// Summary description for frmGetValue.
	/// </summary>
	public class TrmGetValue : System.Windows.Forms.Form
	{
		private Button button3;
		private Button btnClear;
		private Button btnClose;
		private Button button107;
		private Button button93;
		private Button button94;
		private Button button95;
		private Button button75;
		private Button button86;
		private Button button89;
		private Button button57;
		private Button button58;
        private Button button61;
        private System.Windows.Forms.TextBox txtAmount;
        private Button button1;
        private Button btnOk;
      //public float ReturnValue;
      private string ItemPrice;
      private float fHolding;
      private Button btnAdd;
        private readonly NumberModes NumberMode;
        private readonly bool blnPasscode;
        private Panel pnlMain;
      /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float ReturnValue { get; set; }

        public TrmGetValue(NumberModes NumberMode)
		{
			InitializeComponent();
         ItemPrice = "";
         this.NumberMode = NumberMode;
      }
        public TrmGetValue(NumberModes NumberMode, Color color) {
            InitializeComponent();
            ItemPrice = "";
            this.NumberMode = NumberMode;
            pnlMain.BackColor = color;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public TrmGetValue(NumberModes NumberMode, bool blnPasscode) {
            InitializeComponent();
            ItemPrice = "";
            this.NumberMode = NumberMode;
            this.blnPasscode = blnPasscode;
            if (blnPasscode) {
                txtAmount.PasswordChar = '*';
                txtAmount.Clear();
            }
        }
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrmGetValue));
            this.button3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.button93 = new System.Windows.Forms.Button();
            this.button94 = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(230, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 119;
            this.button3.Text = "000";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnClear
            // 
            this.btnClear.AutoEllipsis = true;
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(14, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 80);
            this.btnClear.TabIndex = 118;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::WinLayer.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(335, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 116;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button107
            // 
            this.button107.AutoEllipsis = true;
            this.button107.BackColor = System.Drawing.Color.Green;
            this.button107.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button107.BackgroundImage")));
            this.button107.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button107.FlatAppearance.BorderSize = 0;
            this.button107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button107.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button107.Location = new System.Drawing.Point(14, 361);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(80, 80);
            this.button107.TabIndex = 108;
            this.button107.Text = "0";
            this.button107.UseVisualStyleBackColor = false;
            this.button107.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button93
            // 
            this.button93.AutoEllipsis = true;
            this.button93.BackColor = System.Drawing.Color.Green;
            this.button93.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button93.BackgroundImage")));
            this.button93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button93.FlatAppearance.BorderSize = 0;
            this.button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button93.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button93.Location = new System.Drawing.Point(230, 272);
            this.button93.Name = "button93";
            this.button93.Size = new System.Drawing.Size(80, 80);
            this.button93.TabIndex = 106;
            this.button93.Text = "3";
            this.button93.UseVisualStyleBackColor = false;
            this.button93.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button94
            // 
            this.button94.AutoEllipsis = true;
            this.button94.BackColor = System.Drawing.Color.Green;
            this.button94.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button94.BackgroundImage")));
            this.button94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button94.FlatAppearance.BorderSize = 0;
            this.button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button94.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button94.Location = new System.Drawing.Point(122, 272);
            this.button94.Name = "button94";
            this.button94.Size = new System.Drawing.Size(80, 80);
            this.button94.TabIndex = 105;
            this.button94.Text = "2";
            this.button94.UseVisualStyleBackColor = false;
            this.button94.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button95
            // 
            this.button95.AutoEllipsis = true;
            this.button95.BackColor = System.Drawing.Color.Green;
            this.button95.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button95.BackgroundImage")));
            this.button95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button95.FlatAppearance.BorderSize = 0;
            this.button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button95.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button95.Location = new System.Drawing.Point(14, 272);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(80, 80);
            this.button95.TabIndex = 104;
            this.button95.Text = "1";
            this.button95.UseVisualStyleBackColor = false;
            this.button95.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button75
            // 
            this.button75.AutoEllipsis = true;
            this.button75.BackColor = System.Drawing.Color.Green;
            this.button75.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button75.BackgroundImage")));
            this.button75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button75.FlatAppearance.BorderSize = 0;
            this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button75.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button75.Location = new System.Drawing.Point(230, 183);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(80, 80);
            this.button75.TabIndex = 102;
            this.button75.Text = "6";
            this.button75.UseVisualStyleBackColor = false;
            this.button75.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button86
            // 
            this.button86.AutoEllipsis = true;
            this.button86.BackColor = System.Drawing.Color.Green;
            this.button86.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button86.BackgroundImage")));
            this.button86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button86.FlatAppearance.BorderSize = 0;
            this.button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button86.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button86.Location = new System.Drawing.Point(122, 183);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(80, 80);
            this.button86.TabIndex = 101;
            this.button86.Text = "5";
            this.button86.UseVisualStyleBackColor = false;
            this.button86.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button89
            // 
            this.button89.AutoEllipsis = true;
            this.button89.BackColor = System.Drawing.Color.Green;
            this.button89.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button89.BackgroundImage")));
            this.button89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button89.FlatAppearance.BorderSize = 0;
            this.button89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button89.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button89.Location = new System.Drawing.Point(14, 183);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(80, 80);
            this.button89.TabIndex = 100;
            this.button89.Text = "4";
            this.button89.UseVisualStyleBackColor = false;
            this.button89.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button57
            // 
            this.button57.AutoEllipsis = true;
            this.button57.BackColor = System.Drawing.Color.Green;
            this.button57.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button57.BackgroundImage")));
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button57.Location = new System.Drawing.Point(230, 94);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(80, 80);
            this.button57.TabIndex = 98;
            this.button57.Text = "9";
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button58
            // 
            this.button58.AutoEllipsis = true;
            this.button58.BackColor = System.Drawing.Color.Green;
            this.button58.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button58.BackgroundImage")));
            this.button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button58.FlatAppearance.BorderSize = 0;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button58.Location = new System.Drawing.Point(122, 94);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(80, 80);
            this.button58.TabIndex = 97;
            this.button58.Text = "8";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button61
            // 
            this.button61.AutoEllipsis = true;
            this.button61.BackColor = System.Drawing.Color.Green;
            this.button61.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button61.BackgroundImage")));
            this.button61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button61.FlatAppearance.BorderSize = 0;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button61.Location = new System.Drawing.Point(14, 94);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(80, 80);
            this.button61.TabIndex = 96;
            this.button61.Text = "7";
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.KeyHandle);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAmount.Location = new System.Drawing.Point(14, 13);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(296, 56);
            this.txtAmount.TabIndex = 20;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.WordWrap = false;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(122, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 122;
            this.button1.Text = "00";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnOk
            // 
            this.btnOk.AutoEllipsis = true;
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.BackgroundImage = global::WinLayer.Properties.Resources.okay;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOk.Location = new System.Drawing.Point(230, 455);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 80);
            this.btnOk.TabIndex = 123;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(330, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 167);
            this.btnAdd.TabIndex = 124;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.button89);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Controls.Add(this.button86);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.button75);
            this.pnlMain.Controls.Add(this.button58);
            this.pnlMain.Controls.Add(this.button57);
            this.pnlMain.Controls.Add(this.button95);
            this.pnlMain.Controls.Add(this.button61);
            this.pnlMain.Controls.Add(this.button94);
            this.pnlMain.Controls.Add(this.button93);
            this.pnlMain.Controls.Add(this.button107);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.button3);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(433, 550);
            this.pnlMain.TabIndex = 125;
            // 
            // trmGetValue
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(453, 570);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trmGetValue";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FrmGetValue_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

      }
		#endregion

        private void KeyHandle(object sender, System.EventArgs e) {
            //OLD SOLUTION
            //////			string key = ((Button)sender).Text.Trim().ToLower();
            //////			if (key != "") {
            //////				txtAmount.Focus();
            //////				SendKeys.Send("{" + key + "}");				
            //////			}

            string key = ((Button)sender).Text.Trim().ToLower();
            ItemPrice += key;
            try {
                float value = float.Parse(ItemPrice, System.Globalization.NumberStyles.Any);
                if (NumberMode == NumberModes.FloatMode) {
                    value = value / 100;
                    txtAmount.Text = value.ToString("f");
                } else
                    txtAmount.Text = value.ToString();
            } catch  {
            }
        }

		private void BtnClear_Click(object sender, System.EventArgs e) {
            ItemPrice = "";
            //float value = 0f;
            //if (NumberMode == NumberModes.FloatMode) {
            //    txtAmount.Text = value.ToString("f");
            //} else
            //    txtAmount.Text = value.ToString();
			txtAmount.Clear();
		}

		private void BtnClose_Click(object sender, System.EventArgs e) {
			//this.Result = null;
         this.DialogResult = DialogResult.Cancel;
         this.Close();
		}

		private void BtnDiscount_Click(object sender, System.EventArgs e) {
////			float val = 0f;
////			try {
////				val = float.Parse(txtAmount.Text);
////				if (val == 0.0)
////					return;
////			} catch {
////				txtAmount.Clear();
////				txtAmount.Focus();
////				return;
////			}
////         ReturnValue = val * -1;
////         this.DialogResult = DialogResult.OK;
////         Close();
		}

		private void BtnAddition_Click(object sender, System.EventArgs e) {
			float val = 0f;
			try {
				val = float.Parse(txtAmount.Text);
				if (val == 0.0)
					return;
			} catch {
				txtAmount.Clear();
				txtAmount.Focus();
				return;
			}
         ReturnValue = val;
         this.DialogResult = DialogResult.OK;
         Close();
		}

		private void BtnRefund_Click(object sender, System.EventArgs e) {
////			float val = 0f;
////			try {
////				val = float.Parse(txtAmount.Text);
////				if (val == 0.0)
////					return;
////			} catch {
////				txtAmount.Clear();
////				txtAmount.Focus();
////				return;
////			}
////         this.ReturnValue = val * -1;
////         this.DialogResult = DialogResult.OK;
////         this.Close();
		}

      private void BtnOk_Click(object sender, EventArgs e)
      {
         float val = 0f;
         try {
            val = float.Parse(txtAmount.Text, System.Globalization.NumberStyles.Any);
            //if (val == 0)
            //   return;
         }
         catch {
            txtAmount.Clear();
            txtAmount.Focus();
            return;
         }
         this.ReturnValue = val;
         this.DialogResult = DialogResult.OK;
         this.Close();
      }

        private void BtnAdd_Click(object sender, EventArgs e) {
            try {
                if (NumberMode == NumberModes.FloatMode) {
                    fHolding += float.Parse(ItemPrice) / 100;
                    txtAmount.Text = fHolding.ToString("f");
                } else {
                    fHolding += float.Parse(ItemPrice);
                    txtAmount.Text = fHolding.ToString();
                }
                
                ItemPrice = "";
            } catch { }
        }

        private void FrmGetValue_Load(object sender, EventArgs e) {
            if (!blnPasscode) {
                if (NumberMode == NumberModes.FloatMode)
                    txtAmount.Text = "0.00";
                else
                    txtAmount.Text = "0";
            }
        }

		
	}
}
