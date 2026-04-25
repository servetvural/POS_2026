using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace BSLayer
{
    public partial class frmDistributionSelector : Form
    {
        PosConfig config;
        IRepository<Distribution> repoDistribution;

        public Distribution distribution;

        string menuIID;

        private BindingSource _distributionSource = new BindingSource();
        public frmDistributionSelector(Distribution _distribution, string _menuIID)
        {
            InitializeComponent();
            repoDistribution = ServiceHelper.GetService<IRepository<Distribution>>();

            distribution = _distribution;
            menuIID = _menuIID;
        }

        private async void frmDistributionSelector_Load(object sender, EventArgs e)
        {
            await LoadDistributions();
        }

        private async Task LoadDistributions()
        {
            _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID", menuIID)).ToBindingList();
            dgv.DataSource = _distributionSource;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Skip the 'new row' placeholder at the bottom if it exists
                if (row.IsNewRow)
                    continue;

                if (row.DataBoundItem == distribution)
                {
                    dgv.ClearSelection();
                    row.Selected = true;

                    // Optional: Scroll the row into view
                    dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //   selectedDistributions = dgv.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Distribution).ToList();
            if (distribution == null)
            {
                MessageBox.Show("Please select a distribution plan.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                distribution = _distributionSource.Current as Distribution;                 
            } else
                distribution = null;
        }
    }
}
