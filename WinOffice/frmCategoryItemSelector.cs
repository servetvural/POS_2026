using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinLayer;

namespace WinOffice {
    public partial class frmCategoryItemSelector : Form {
        private DataSet ds = new DataSet();
        private string MenuIID;

        public List<string> SelectedEntiyButtonIIDList;
        public frmCategoryItemSelector(string MenuIID) {
            InitializeComponent();
            this.MenuIID = MenuIID;
            SelectedEntiyButtonIIDList = new List<string>();
        }

        private void frmEntityButtonSelector_Load(object sender, EventArgs e) {
            LoadEntityButtonList();
        }

        private void LoadEntityButtonList() {
            try {
                ds.Tables.Add(BSLayer.Instance.GetDataTable("Select IID, EntityButtonName from EntityButton where ParentMenuIID = '" + MenuIID + "' order by ParentEntityIID, DisplayOrder"));

                dgvEntityButton.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                    SelectedEntiyButtonIIDList.Add(dgvEntityButton.SelectedRows[i].Cells[0].Value.ToString());
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void dgvEntityButton_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnSelect_Click(null, null);
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e) {
            ds.Tables[0].DefaultView.RowFilter = string.Format("EntityButtonName LIKE '%{0}%'", txtFilter.Text);

        }
    }
}
