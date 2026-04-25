using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;

namespace WinLayer {
    public partial class ctlKitchenOrderItem : UserControl {
        public KitchenOrderItem korderitem;
        public Label ActiveLabel {  get { return lblActive; }  }
        public PictureBox PBox {  get { return pBox; } }
        public Label DetailLabel {  get { return lblDetail; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowFullScreen { get { return pnlFullScreen.Visible; } set { pnlFullScreen.Visible = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowExpander { get { return expMain.Visible; } set { expMain.Visible = value; } }
        public ctlKitchenOrderItem() {
            InitializeComponent();              
        }
        private void ctlKitchenOrderItem_Load(object sender, EventArgs e) {

        }

        private void lblDetail_Click(object sender, EventArgs e) {
            this.OnClick(null);
        }

        private void pBox_Click(object sender, EventArgs e) {
            this.OnClick(null);
        }

        private void lblActive_Click(object sender, EventArgs e) {
            this.OnClick(null);
        }

        private void btnFullScreen_Click(object sender, EventArgs e) {
            if (ServiceHelper.Services != null && BSLayer.Instance != null && korderitem != null) {
                frmKitchenOrderFullScreen frm = ActivatorUtilities.CreateInstance < frmKitchenOrderFullScreen>(ServiceHelper.Services, korderitem);
                frm.Show();
            }
        }
    }
}
