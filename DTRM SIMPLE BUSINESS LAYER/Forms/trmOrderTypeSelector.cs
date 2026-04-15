using System.Windows.Forms;

using POSLayer.Library;

namespace DTRMNS {
	/// <summary>
	/// Summary description for frmOrderTypeSelector.
	/// </summary>
	public class trmOrderTypeSelector : System.Windows.Forms.Form
	{
        private Button btnClose;
		private Button btnDelivery;
		private Button btnTakeAway;
		private Button btnInHouse;
      public OrderTypes ReturnValue;
      private Panel panel1;
      /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public trmOrderTypeSelector()
		{
				InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trmOrderTypeSelector));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnInHouse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(346, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 70);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.AutoEllipsis = true;
            this.btnDelivery.BackColor = System.Drawing.Color.Green;
            this.btnDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelivery.BackgroundImage")));
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(246, 16);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(80, 80);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "DELIVERY";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.AutoEllipsis = true;
            this.btnTakeAway.BackColor = System.Drawing.Color.Green;
            this.btnTakeAway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTakeAway.BackgroundImage")));
            this.btnTakeAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Location = new System.Drawing.Point(128, 16);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(86, 80);
            this.btnTakeAway.TabIndex = 1;
            this.btnTakeAway.Text = "TAKE-AWAY";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnInHouse
            // 
            this.btnInHouse.AutoEllipsis = true;
            this.btnInHouse.BackColor = System.Drawing.Color.Green;
            this.btnInHouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInHouse.BackgroundImage")));
            this.btnInHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInHouse.FlatAppearance.BorderSize = 0;
            this.btnInHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHouse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHouse.ForeColor = System.Drawing.Color.White;
            this.btnInHouse.Location = new System.Drawing.Point(16, 16);
            this.btnInHouse.Name = "btnInHouse";
            this.btnInHouse.Size = new System.Drawing.Size(80, 80);
            this.btnInHouse.TabIndex = 0;
            this.btnInHouse.Text = "IN - HOUSE";
            this.btnInHouse.UseVisualStyleBackColor = false;
            this.btnInHouse.Click += new System.EventHandler(this.btnInHouse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnInHouse);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnTakeAway);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 111);
            this.panel1.TabIndex = 5;
            // 
            // trmOrderTypeSelector
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 131);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trmOrderTypeSelector";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "    SELECT THE ORDER TYPE ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

      }
		#endregion

		private void btnInHouse_Click(object sender, System.EventArgs e) {
         ReturnValue = OrderTypes.Sitin;
         this.DialogResult = DialogResult.OK;
         Close();
		}

		private void btnTakeAway_Click(object sender, System.EventArgs e) {
         ReturnValue = OrderTypes.TakeAway;
         this.DialogResult = DialogResult.OK;
         Close();
		}

		private void btnDelivery_Click(object sender, System.EventArgs e) {
         ReturnValue = OrderTypes.Delivery;
         this.DialogResult = DialogResult.OK;
         Close();
		}

		
		private void btnClose_Click(object sender, System.EventArgs e) {
         //ReturnValue = null;
         this.DialogResult = DialogResult.Cancel;
         Close();
		}
	}
}
