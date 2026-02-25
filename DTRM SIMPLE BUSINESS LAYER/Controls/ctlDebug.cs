using System;
using System.Windows.Forms;
using System.IO;

namespace DTRMNS {
    public partial class ctlDebug : UserControl {
        private DTRMSimpleBusiness bslayer;

        private string layoutFilename = "DebugLayout.xml";
        public ctlDebug() {
            InitializeComponent();
        }

        public void Initialize(ref DTRMSimpleBusiness bslayer) {
            this.bslayer = bslayer;

            if (File.Exists(layoutFilename))
                docMngr.LoadLayout(layoutFilename);
        }

        private void btnLoadAttachedOrder_Click(object sender, EventArgs e) {
            if (bslayer != null) {
                bslayer.OrderUnloaded += CheckAttachedOrder;
                bslayer.OrderLoaded += CheckLoadAttachedOrder;
                bslayer.ImmediateDebugOccured += Bslayer_ImmediateDebugOccured;
                if (bslayer.AttachedOrder == null)
                    UnloadAttachedOrder();
                

                if (bslayer.AttachedOrder != null) {
                    UnloadAttachedOrder();
                    dgvAttachedOrderItems.DataSource = bslayer.AttachedOrder.items;
                    
                }
            }
        }

        private void Bslayer_ImmediateDebugOccured(string str) {
            //throw new NotImplementedException();
            if (!spltAttachedOrderText.Expanded)
                spltAttachedOrderText.Expanded = true;
            txtAttachedOrderView.Text += str + "\r\n";
        }

        private void dgvAttachedOrderItems_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (bslayer.AttachedOrder ==null) {
                UnloadAttachedOrder();
                return;
            }
            txtAttachedOrderView.Text = dgvAttachedOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dgvOrderItems_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if (bslayer.AttachedOrder == null) {
                e.Cancel = true;
                UnloadAttachedOrder();
            }
        }

        private void CheckAttachedOrder() {
            if (bslayer.AttachedOrder == null)
                UnloadAttachedOrder();
        }

        private void CheckLoadAttachedOrder() {
            if (bslayer.AttachedOrder != null)
                dgvAttachedOrderItems.DataSource = bslayer.AttachedOrder.items;
        }

        public void UnloadAttachedOrder() {
            dgvAttachedOrderItems.DataSource = null;
        }

        private void btnLoadKitchenOrders_Click(object sender, EventArgs e) {
            if (bslayer != null) {
                dgvKitchenOrders.DataSource = null;
                dgvKitchenOrders.DataSource = bslayer.GetAllKitchenOrders();
            }
        }

        private void dgvKitchenOrders_SelectionChanged(object sender, EventArgs e) {
            if (dgvKitchenOrders.SelectedRows.Count > 0) {
                dgvKitchenOrderItems.DataSource = null;
                dgvKitchenOrderItems.DataSource = bslayer.GetKitchenOrderItems(dgvKitchenOrders.SelectedRows[0].Cells["colKitchenOrderIID"].Value.ToString());
            }
        }

        private void docMngr_BarDock(object sender, EventArgs e) {
            docMngr.SaveLayout(layoutFilename);
        }
    }
}
