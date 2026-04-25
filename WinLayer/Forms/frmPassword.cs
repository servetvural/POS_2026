using System;
using System.Windows.Forms;

namespace WinLayer {
    public partial class frmPassword : Form {
        public string Password;

        public frmPassword() {
            InitializeComponent();
        }
        public frmPassword(string msg) {
            InitializeComponent();
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
            }
        }
    }
}
