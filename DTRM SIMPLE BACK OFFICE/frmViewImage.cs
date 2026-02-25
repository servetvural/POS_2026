using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
