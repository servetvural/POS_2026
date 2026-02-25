using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmEntitySelector : Form {
        private DTRMSimpleBusiness bslayer;
        private string MenuIID;
        public string SelectedEntiyIID;
        public frmEntitySelector(DTRMSimpleBusiness bslayer, string MenuIID) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.MenuIID = MenuIID;
        }

        private void frmEntitySelector_Load(object sender, EventArgs e) {
            LoadEntityList();
        }

        private void LoadEntityList() {
            try {
                dgvEntity.DataSource = bslayer.GetDataTable("Select * from Entity where ParentMenuIID = '" + MenuIID + "' order by displayorder");
            } catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (dgvEntity.SelectedRows.Count > 0) {

                SelectedEntiyIID = dgvEntity.SelectedRows[0].Cells[0].Value.ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }
}
