using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class ctlKitchenOrderItem : UserControl {
        public DTRMSimpleBusiness bslayer;
        public KitchenOrderItem korderitem;
        public Label ActiveLabel {  get { return lblActive; }  }
        public PictureBox PBox {  get { return pBox; } }
        public Label DetailLabel {  get { return lblDetail; } }

        public bool ShowFullScreen { get { return pnlFullScreen.Visible; } set { pnlFullScreen.Visible = value; } }
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
            if (bslayer != null && korderitem != null) {
                frmKitchenOrderFullScreen frm = new frmKitchenOrderFullScreen(bslayer, korderitem);
                frm.Show();
            }
        }
    }
}
