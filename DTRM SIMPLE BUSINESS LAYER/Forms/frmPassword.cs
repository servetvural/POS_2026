using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmPassword : Form {
        public DTRMSimpleBusiness bslayer;
        public string Password;

        public frmPassword() {
            InitializeComponent();
        }
        public frmPassword(string msg) {
            InitializeComponent();
            bslayer = DTRMSimpleBusiness.Instance;
            lblMessage.Text = msg;
        }
        private void frmPassword_Load(object sender, EventArgs e) {

        }

        private void KeyHandle_Click(object sender, EventArgs e) {
            txtPassword.Text += ((Button)sender).Text;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            txtPassword.Clear();
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtPassword.Text.Length > 0) {
                Password = txtPassword.Text;
                this.DialogResult = DialogResult.OK;
                Close();
                //if (bslayer == null)
                //    bslayer = new DTRMSimpleBusiness(UF.GetConfig());
                //else
                //     DTRMSimpleBusiness.Instance.config = UF.GetConfig();

                //if ( DTRMSimpleBusiness.Instance.DoStartThings()) {
                //    this.DialogResult = DialogResult.OK;
                //    Close();
                //}
                //else {
                //    MessageBox.Show("Failed to Connect");
                //}
            }
        }
    }
}
