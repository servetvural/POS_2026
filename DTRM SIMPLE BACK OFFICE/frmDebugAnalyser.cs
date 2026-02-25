using System;
using System.Windows.Forms;
using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmDebugAnalyser : Form {
        private DTRMNS.DTRMSimpleBusiness bslayer;

        public frmDebugAnalyser(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmDebugAnalyser_Load(object sender, EventArgs e) {
            btnLoadAllDebug_Click(null, null);
        }

        private void btnLoadAllDebug_Click(object sender, EventArgs e) {
            dgvDebug.DataSource = bslayer.GetAllDebug(OrderByTypes.Descending);
        }

        private void btnAscending_Click(object sender, EventArgs e) {
            dgvDebug.DataSource = bslayer.GetAllDebug(OrderByTypes.Ascending);
        }

        private void btnDescending_Click(object sender, EventArgs e) {
            dgvDebug.DataSource = bslayer.GetAllDebug(OrderByTypes.Descending);
        }

        private void btnDeleteSelectedDebugs_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvDebug.SelectedRows.Count; i++)
                bslayer.DeleteDebug(dgvDebug.SelectedRows[i].Cells["colNumber"].Value.ToString());
            btnLoadAllDebug_Click(null, null);
        }

        private void dgvDebug_SelectionChanged(object sender, EventArgs e) {
            if (dgvDebug.SelectedRows.Count == 0) return;

            Debug debug = bslayer.GetDebug(dgvDebug.SelectedRows[0].Cells["colNumber"].Value.ToString());
            //Debug debug = (Debug)dgvDebug.SelectedRows[0].DataBoundItem;
            txtDebugDetails.Text = debug.DebugNo + "\r\n" +
                debug.EventDateTime.ToString("dd/mm/yyyy HH:mm:ss:sss") + "\r\n" +
                debug.Data;
        }

        private void btnClearAllDebugInformation_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will delete all debug information!", "Clear Debug Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                bslayer.ClearAllDebugInfo();
                btnLoadAllDebug_Click(null, null);
            }
        }
    }
}
