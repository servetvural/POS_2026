using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmDistributionSelector : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        public List<Distribution> selectedDistributions;
        private List<Distribution> existingList;

        public frmDistributionSelector(PosConfig configAsService, DTRMSimpleBusiness bslayer,bool blnMultiSelect, List<Distribution> existingList) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            selectedDistributions = new List<Distribution>();
            dgv.MultiSelect = blnMultiSelect;
            this.existingList = existingList;
        }

        private void frmDistributionSelector_Load(object sender, EventArgs e) {
            LoadDistributions();

        }

        private async Task LoadDistributions() {
            dgv.DataSource = await bslayer.GetDistributionList(config.ActiveMenuIID);
                //bslayer.GetDataTable("Select * from Distribution Where ParentMenuIID ='" + bslayer.config.ActiveMenuIID + "'");
            if (existingList != null) {
                for (int i = 0; i < dgv.Rows.Count; i++) {
                    string IID = dgv.Rows[i].Cells["colIID"].Value.ToString();
                    if (existingList.Find(x => x.IID == IID) != null)
                        dgv.Rows[i].Selected = true;
                }
                //remove unnecessarily selected first row selection
                if (dgv.Rows.Count > 0) {
                    string firstRowIID = dgv.Rows[0].Cells["colIID"].Value.ToString();
                    if (existingList.Find(x => x.IID == firstRowIID) == null)
                        dgv.Rows[0].Selected = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            selectedDistributions.Clear();
            for(int i=0; i < dgv.SelectedRows.Count; i++) {
                string IID = dgv.SelectedRows[i].Cells["colIID"].Value.ToString();
                selectedDistributions.Add(bslayer.GetDistribution(IID).Result);
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnSave_Click(null, null);
        }
    }
}
