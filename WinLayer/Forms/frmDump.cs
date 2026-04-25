namespace WinLayer {
    public partial class frmDump : Form {

        public frmDump() {
            InitializeComponent();
        }

        private void frmDump_Load(object sender, EventArgs e) {
            LoadOrders();
        }

        private void LoadOrders() {
            dgvIrrelevantOrders.DataSource = null;
            dgvErrorOrders.DataSource = null;

            dgvIrrelevantOrders.DataSource =  BSLayer.Instance.GetIrrelevantUnpaidOrdersDB();
            btnDeleteOrders.Visible = dgvIrrelevantOrders.Rows.Count > 0;

            dgvErrorOrders.DataSource =  BSLayer.Instance.GetRelevantUnpaidCreatedOrNewOrdersDB();
            btnDeleteErrorOrders.Visible = dgvErrorOrders.Rows.Count > 0;
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e) {
            for (int i=0; i < dgvIrrelevantOrders.SelectedRows.Count; i++) {
                 BSLayer.Instance.DeleteOrder(dgvIrrelevantOrders.SelectedRows[i].Cells["colIID"].Value.ToString());

            }
            LoadOrders();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            //this.DialogResult = DialogResult.Cancel;
            Close();

        }

        private void btnDeleteErrorOrders_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvErrorOrders.SelectedRows.Count; i++) {

                 BSLayer.Instance.DeleteOrder(dgvErrorOrders.SelectedRows[i].Cells["colErrorIID"].Value.ToString());

            }
            LoadOrders();
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadOrders();
        }
    }
}
