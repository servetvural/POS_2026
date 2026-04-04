using System;
using System.Drawing;
using System.Windows.Forms;

namespace DTRMSimpleBackOffice {
    public partial class frmViewImage : Form {
        private Image img;
        public frmViewImage(Image img) {
            InitializeComponent();
            this.img = img;
        }

        private void frmViewImage_Load(object sender, EventArgs e) {
            pBox.Image = img;
        }
    }
}
