
namespace WinLayer {
    public partial class frmNo : Form {
        public int val;
        bool blnHidden = false;
        public frmNo() {
            InitializeComponent();
        }
        public frmNo(bool blnHidden)
        {
            InitializeComponent();
            this.blnHidden = blnHidden;
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            val = int.Parse(txtVal.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmNo_Load(object sender, EventArgs e) {
             if (blnHidden)
            {
                   txtVal.PasswordChar = '*';
            }
        }
    }
}
