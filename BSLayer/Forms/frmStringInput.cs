using System;
using System.Windows.Forms;

namespace BSLayer {
    public partial class frmStringInput : Form {
        public string text;
        public frmStringInput() {
            InitializeComponent();
        }

        public frmStringInput(string Caption, string initialValue)
        {
            InitializeComponent();
            this.Text = Caption;
            text = initialValue;
        }

        public frmStringInput(string initialValue) {
            InitializeComponent();
            text = initialValue;
        }

        private void frmIntegerInput_Load(object sender, EventArgs e) {
            txt.Text = text;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            text = txt.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtVal_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(null, null);
        }
    }
}
