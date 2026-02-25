using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmMenuSelector : Form {
        private DTRMSimpleBusiness bslayer;
        public string SelectedMenuIID;


        public frmMenuSelector(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmMenuSelector_Load(object sender, EventArgs e) {
            LoadMenuList();
        }

        private void LoadMenuList() {
            dgv.DataSource = bslayer.GetMenuList();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) {
            SelectedMenuIID = dgv.SelectedRows[0].Cells["colIID"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
