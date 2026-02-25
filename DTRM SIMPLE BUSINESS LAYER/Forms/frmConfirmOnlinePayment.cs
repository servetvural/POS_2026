using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmConfirmOnlinePayment : Form {

        public bool Confirmed = false;
        public frmConfirmOnlinePayment() {
            InitializeComponent();
        }

        private void frmConfirmCardPayment_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Confirmed = false;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (txtCode.Text.Trim().Length == 6) {
                this.DialogResult = DialogResult.OK;
                Confirmed = true;
                Close();
            }
        }

        
        private void ctlAlphaNumeric1_OutputOccured(string str) {
            if (txtCode.Text.Trim().Length < 6) {
                txtCode.Text += str;
            }
        }

        private void ctlAlphaNumeric1_BackspaceClicked() {
            txtCode.Text =  txtCode.Text.Trim();
            if (txtCode.Text.Length > 0) {
                txtCode.Text = txtCode.Text.Substring(0, txtCode.Text.Length-1);
            }
            //txtCode.Focus();
            //SendKeys.Send("\b");
           // SendKeys.Send("{BACKSPACE}");
        }

        private void ctlAlphaNumeric1_EnterClicked() {
            btnOk_Click(null, null);
        }
    }
}
