using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

using POSWinFormLayer;

namespace DTRMNS {
    public partial class frmKitchenOrderFullScreen : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        private KitchenOrderItem korderitem;
        public frmKitchenOrderFullScreen(PosConfig configAsService, DTRMSimpleBusiness bslayer, KitchenOrderItem korderitem) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            this.korderitem = korderitem;
        }

        private void frmKitchenOrderFullScreen_Load(object sender, EventArgs e) {
            ctlkoi.PBox.Width = this.Width / 2;
            LoadKitchenOrderItem();
        }

        private async void LoadKitchenOrderItem() {
            GenericImage prepImage =await bslayer.GetEntityButtonPrepImage(korderitem.EntityButtonIID);
            if (prepImage != null) {
                ctlkoi.PBox.Visible = true;
                ctlkoi.ActiveLabel.Text = korderitem.ItemText;                
                this.Text = korderitem.ItemText;
                ctlkoi.DetailLabel.Visible = true;
                ctlkoi.PBox.BackgroundImage = prepImage.DisplayImage.ToImage();
                ctlkoi.DetailLabel.Text = prepImage.ExtraText;
                ctlkoi.DetailLabel.Font = new Font("Arial", (float)config.Display_Kitchen_FullScreen_Font_Size, FontStyle.Regular);
                ctlkoi.ShowFullScreen = false;
                ctlkoi.ShowExpander = config.Display_Kitchen_FullScreen_on_Display;
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
                ctlkoi.PBox.Width = this.Width / 2;
            } 
            else {
                this.WindowState = FormWindowState.Maximized;
                ctlkoi.PBox.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
