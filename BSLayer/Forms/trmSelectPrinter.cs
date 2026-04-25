using System.Windows.Forms;
using System.Collections.Generic;

using POSLayer.Models;

namespace BSLayer {
	/// <summary>
	/// Summary description for frmSelectPrinter.
	/// </summary>
	public class trmSelectPrinter : System.Windows.Forms.Form
	{
        private System.Windows.Forms.ListView lvwPrinters;
		private System.Windows.Forms.ImageList ilMain;
		private Button btnClose;

      public string ReturnValue;
      private Panel panel1;

     // public string SelectedPrinterIID;

      private System.ComponentModel.IContainer components;


		public trmSelectPrinter() {			
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trmSelectPrinter));
            this.lvwPrinters = new System.Windows.Forms.ListView();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPrinters
            // 
            this.lvwPrinters.BackColor = System.Drawing.Color.Black;
            this.lvwPrinters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPrinters.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPrinters.ForeColor = System.Drawing.Color.White;
            this.lvwPrinters.HideSelection = false;
            this.lvwPrinters.LargeImageList = this.ilMain;
            this.lvwPrinters.Location = new System.Drawing.Point(10, 90);
            this.lvwPrinters.MultiSelect = false;
            this.lvwPrinters.Name = "lvwPrinters";
            this.lvwPrinters.Size = new System.Drawing.Size(530, 300);
            this.lvwPrinters.StateImageList = this.ilMain;
            this.lvwPrinters.TabIndex = 8;
            this.lvwPrinters.UseCompatibleStateImageBehavior = false;
            this.lvwPrinters.Click += new System.EventHandler(this.lvwPrinters_Click);
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "");
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::BSLayer.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(445, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 70);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(530, 80);
            this.panel1.TabIndex = 9;
            // 
            // trmSelectPrinter
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lvwPrinters);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trmSelectPrinter";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SELECT PRINTER";
            this.Load += new System.EventHandler(this.frmSelectPrinter_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

      }
		#endregion

        private async void LoadPrinters() {
            List<Printer> PrinterList = await DTRMSimpleBusiness.Instance.GetReceiptPrinterList();

            ListViewItem lvi;
            Printer printer;
            for (int i = 0; i < PrinterList.Count; i++) {
                printer = (Printer)PrinterList[i];
                string[] plist = { printer.ApplicationName, printer.IID };
                lvi = new ListViewItem(plist, 0);
                lvwPrinters.Items.Add(lvi);
            }
            //}
        }

		private void lvwPrinters_Click(object sender, System.EventArgs e) {
			if (lvwPrinters.SelectedIndices.Count > 0) {
				ListViewItem lvi = lvwPrinters.SelectedItems[0];
            this.ReturnValue = lvi.SubItems[1].Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
			}
		}		

		private void frmSelectPrinter_Load(object sender, System.EventArgs e) {
			LoadPrinters();
		}

		private void btnClose_Click(object sender, System.EventArgs e) {
         //this.ReturnValue = null;
         this.DialogResult = DialogResult.Cancel;
         this.Close();
		}
	}
}
