using System;
using System.ComponentModel;
using System.Windows.Forms;
using PosLibrary;

using DTRMNS;
using System.IO;

namespace DTRMSimpleAdaptor {
    public partial class frmOrderView : Form {
        private DTRMSimpleBusiness bslayer;
        private string SessionIID;
        private SessionData sessionData;

        public frmOrderView(DTRMSimpleBusiness bslayer, string SessionIID) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.SessionIID = SessionIID;
        }

        private void FrmOrderView_Load(object sender, EventArgs e) {
            LoadOrders();
        }

        private void LoadOrders() {
            sessionData = bslayer.GetSessionDataDynamic(SessionIID);

            dgv.DataSource = bslayer.GetAllOrdersForSession(SessionIID);
            dgv.Sort(colOrderDate, ListSortDirection.Ascending);


            for (int i = 0; i < dgv.Rows.Count; i++) {
                Order order = bslayer.GetOrder(dgv.Rows[i].Cells[0].Value.ToString());
                dgv.Rows[i].Cells["colOrderItems"].Value = order.GetAllOrderItemsText();
                dgv.Rows[i].Height = order.items.Count * 15 + 7;
            }
            lblOrderTotal.Text = bslayer.GetSessionOrderSum(SessionIID).ToString("c2");
        }


        private void BtnDBExportToCsv_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.Generate(true, true)) {
                string filename = "OrderList_for_Session_" + sessionData.SessionStartDateTime.ToString("yyyyMMdd_HHmmss") + ".csv";
                if (exporter.Export(Path.Combine("CustomReports",filename)))
                    MessageBox.Show("File saved CustomReports directory on memory stick as " + filename);
                else
                    MessageBox.Show("Failed to save report");

            }
        }

        private void BtnDeleteOrders_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgv.SelectedRows.Count; i++)
			{
                bslayer.DeleteOrder(dgv.SelectedRows[i].Cells["IID"].Value.ToString());
			}
            LoadOrders();
            
        }

    }
}
