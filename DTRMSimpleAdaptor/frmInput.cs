using System;
using System.Windows.Forms;

namespace DTRMSimpleAdaptor {
    public partial class frmInput : Form {
        public string ReturnValue = "";

        public frmInput() {
            InitializeComponent();
        }

        public frmInput(string customCaption, bool blnShowAsPasswordBox) {
            InitializeComponent();
            this.Text = customCaption;
            if (!blnShowAsPasswordBox)
                txtDisplay.PasswordChar = (char)0;
        }

        private void frmInput_Load(object sender, EventArgs e) {

        }

        private void KeyHandle_Click(object sender, EventArgs e) {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            txtDisplay.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (txtDisplay.Text.Length > 0) {
                ReturnValue = txtDisplay.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
