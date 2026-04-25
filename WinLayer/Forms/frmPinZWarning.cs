using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLayer {
    public partial class frmPinZWarning : Form {
        bool blnCompare;
        double CardTotal;
       
        public frmPinZWarning() {
            InitializeComponent();
            blnCompare = false;
        }

        public frmPinZWarning(double CardTotal) {
            InitializeComponent();
            this.CardTotal = CardTotal;
            blnCompare = false;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (blnCompare) {
                double enteredAmount = double.Parse(txtCode.Text.Trim(), System.Globalization.NumberStyles.Any);
                if (enteredAmount > 1000)
                    return;

                if (CardTotal == enteredAmount ) {
                    DialogResult = DialogResult.OK;
                    Close();
                } else {
                    MessageBox.Show("Pin Z Amount doesn't Match!!");
                    return;
                }
            } else {
                DialogResult = DialogResult.OK;
                Close();
            }
            
        }

        private async Task ctlNumeric1_BackspaceClicked() {
            txtCode.Text = txtCode.Text.Trim();
            if (txtCode.Text.Length > 0) {
                txtCode.Text = txtCode.Text.Substring(0, txtCode.Text.Length - 1);
            }
        }

        private async Task ctlNumeric1_EnterClicked() {
            btnOk_Click(null, null);
        }

        private void ctlNumeric1_OutputOccured(string str) {
            if (txtCode.Text.Trim().Length < 8) {
                txtCode.Text += str;
            }
        }
    }
}
