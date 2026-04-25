
namespace WinLayer {
    public partial class frmReplace : Form {
        public string textFind;
        public string textReplace;

        public frmReplace() {
            InitializeComponent();
        }
        public frmReplace(string initialValue) {
            InitializeComponent();
            textFind = initialValue;
        }

        private void frmIntegerInput_Load(object sender, EventArgs e) {
            txtFind.Text = textFind;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (txtFind.Text.Length == 0)
                return;

            textFind = txtFind.Text;
            textReplace = txtReplace.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtReplace_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(null, null);
        }
    }
}
