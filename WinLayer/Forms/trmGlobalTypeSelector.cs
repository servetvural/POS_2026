using System;
using System.Windows.Forms;

using POSLayer.Models;

namespace WinLayer
{
    partial class trmDistributionSelector : Form
    {
        public Distribution SelectedDistribution;
        public string MenuIID;
        public trmDistributionSelector()
        {
            InitializeComponent();
        }
        public trmDistributionSelector(string MenuIID)
        {
            InitializeComponent();
            this.MenuIID = MenuIID;
            LoadDistributions();
        }

        private void LoadDistributions()
        {
            dgv.DataSource = DTRMSimpleBusiness.Instance.GetAllDistributionsForMenu(MenuIID);
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedDistribution = DTRMSimpleBusiness.Instance.GetDistribution(dgv.Rows[e.RowIndex].Cells[0].Value.ToString()).Result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SelectedDistribution = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}