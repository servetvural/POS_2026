using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmIntegerInput : Form {
        public int val;
        public frmIntegerInput() {
            InitializeComponent();
        }
        public frmIntegerInput(int initialValue) {
            InitializeComponent();
            val = initialValue;
        }

        private void frmIntegerInput_Load(object sender, EventArgs e) {
            txtVal.Value = val;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            val = txtVal.Value;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtVal_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(null, null);
        }
    }
}
