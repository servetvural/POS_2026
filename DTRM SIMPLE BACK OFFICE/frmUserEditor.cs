using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmUserEditor : Form {
        private DTRMSimpleBusiness bslayer;
        
        
        public frmUserEditor() {
            InitializeComponent();
        }
        public frmUserEditor(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private void frmUserEditor_Load(object sender, EventArgs e) {
            LoadUsers();
        }

        private void LoadUsers() {
            DataTable dt =  bslayer.db.GetDataTable("Select * from Users where AccessLevel < " + (int)bslayer.LoggedUser.AccessLevel + " order by AccessLevel desc");
            dgv.DataSource = UF.StringifyEnumInDataTable(dt, "AccessLevel", "AccessLevelAsString", typeof(AccessLevels));
        }
        //private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
        //    for (int i = 0; i < dgv.Rows.Count; i++) {
        //        dgv.Rows[i].Cells["colAccessLevelAsString"].Value = (AccessLevels)int.Parse(dgv.Rows[i].Cells["colAccessLevel"].Value.ToString());
        //    }
        //}

        private void btnAddUser_Click(object sender, System.EventArgs e) {
            frmSingleUser frm = new frmSingleUser(bslayer, new User());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }
        private void btnEditUser_Click(object sender, System.EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                User user = bslayer.GetUser(GetUserIID());
                frmSingleUser frm = new frmSingleUser(bslayer, user);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadUsers();
            }
        }
        private void btnDeleteUser_Click(object sender, System.EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                bslayer.DeleteUser(GetUserIID());
                LoadUsers();
            }
        }
        
        private string GetUserIID() {
            if (dgv.SelectedRows.Count > 0)
                return dgv.SelectedRows[0].Cells[0].Value.ToString();
            else
                return "";
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEditUser_Click(null, null);
        }
    }
}
