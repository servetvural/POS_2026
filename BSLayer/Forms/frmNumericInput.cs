using System;
using System.Windows.Forms;

namespace BSLayer {
    public partial class frmNumericInput : Form{
        public int SelectedValue;
        public frmNumericInput() {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e) {
            SelectedValue = int.Parse(((Button) sender).Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
