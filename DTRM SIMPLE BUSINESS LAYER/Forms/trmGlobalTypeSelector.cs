using System;
using System.Windows.Forms;

using POSLayer.Models;

namespace DTRMNS {
   partial class trmDistributionSelector : Form {
      private DTRMSimpleBusiness bslayer;
      public Distribution SelectedDistribution;
       public string MenuIID;
      public trmDistributionSelector() {
         InitializeComponent();
      }
      public trmDistributionSelector(DTRMSimpleBusiness bslayer, string MenuIID) {
         InitializeComponent();
         this.bslayer = bslayer;
         this.MenuIID = MenuIID;
         LoadDistributions();
      }

      private void LoadDistributions() {
         dgv.DataSource = bslayer.GetAllDistributionsForMenu(MenuIID);
      }
      private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         SelectedDistribution = bslayer.GetDistribution(dgv.Rows[e.RowIndex].Cells[0].Value.ToString()).Result;
         //this.DialogResult = DialogResult.OK;
         //this.Close();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         SelectedDistribution = null;
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

     
   }
}