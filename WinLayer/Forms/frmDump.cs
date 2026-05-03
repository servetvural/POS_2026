using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer {
    public partial class frmDump : Form {
        IRepository<Order> repoOrder;

        public frmDump() {
            InitializeComponent();
            repoOrder = ServiceHelper.GetRepository<Order>();
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

        private async void btnDeleteOrders_Click(object sender, EventArgs e) {
            for (int i=0; i < dgvIrrelevantOrders.SelectedRows.Count; i++) {
                Order order= dgvIrrelevantOrders.SelectedRows[i].DataBoundItem as Order;
                await repoOrder.Delete(order.IID);
            }
            LoadOrders();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            //this.DialogResult = DialogResult.Cancel;
            Close();

        }

        private async void btnDeleteErrorOrders_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvErrorOrders.SelectedRows.Count; i++) {
                Order order = dgvErrorOrders.SelectedRows[i].DataBoundItem as Order;
                await repoOrder.Delete(order.IID);
            }
            LoadOrders();
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadOrders();
        }
    }
}
