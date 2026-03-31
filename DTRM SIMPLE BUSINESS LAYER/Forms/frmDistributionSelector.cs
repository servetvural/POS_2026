using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMNS {
    public partial class frmDistributionSelector : Form {
        PosConfig config;
        IRepository<Distribution> repoDistribution;

        public List<Distribution> selectedDistributions;
        private List<Distribution> existingList;

        string menuIID;

        private BindingSource _distributionSource = new BindingSource();
        public frmDistributionSelector(IRepository<Distribution> _repoDistribution, 
            bool blnMultiSelect, List<Distribution> existingList, string _menuIID)
        {
            InitializeComponent();
            repoDistribution = _repoDistribution;

            selectedDistributions = new List<Distribution>();
            dgv.MultiSelect = blnMultiSelect;
            this.existingList = existingList;
            menuIID = _menuIID;
        }

        private async void frmDistributionSelector_Load(object sender, EventArgs e) {
            await LoadDistributions();
        }

        private async Task LoadDistributions() {
            _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID",menuIID)).ToBindingList();
            dgv.DataSource = _distributionSource;

            if (existingList != null) {
                for (int i = 0; i < dgv.Rows.Count; i++) {
                    string IID = (dgv.Rows[i].DataBoundItem as Distribution).IID;
                    if (existingList.Find(x => x.IID == IID) != null)
                        dgv.Rows[i].Selected = true;
                }
                //remove unnecessarily selected first row selection
                if (dgv.Rows.Count > 0) {
                    string firstRowIID = (dgv.Rows[0].DataBoundItem as Distribution).IID;
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
            selectedDistributions = dgv.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Distribution).ToList();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnSave_Click(null, null);
        }
    }
}
