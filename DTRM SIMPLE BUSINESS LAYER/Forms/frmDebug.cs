using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmDebug : Form {
        private DTRMSimpleBusiness bslayer;
        public frmDebug(ref DTRMSimpleBusiness bslayer) {
            InitializeComponent();

            this.bslayer = bslayer;
        }

        private void btnInitialize_Click(object sender, EventArgs e) {
            dbgControl.Initialize(ref bslayer);
        }
    }
}
