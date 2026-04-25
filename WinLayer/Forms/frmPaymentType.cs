using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;

namespace WinLayer {
    public partial class frmPaymentType : Form {

        public PaymentMethods SelectedPaymentMethod;
        public frmPaymentType() {
            InitializeComponent();
        }
        

        private void frmPaymentType_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            SelectedPaymentMethod = PaymentMethods.NotPaid;
            Close();
        }

        private void btnCash_Click(object sender, EventArgs e) {
            SelectedPaymentMethod = PaymentMethods.Cash;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCard_Click(object sender, EventArgs e) {
            SelectedPaymentMethod = PaymentMethods.Card;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOnline_Click(object sender, EventArgs e) {
            SelectedPaymentMethod = PaymentMethods.Online;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
