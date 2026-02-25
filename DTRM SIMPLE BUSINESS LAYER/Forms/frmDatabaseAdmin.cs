using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;

using DronaxLibrary.DBSpace;

namespace DTRMNS {
    public partial class frmDatabaseAdmin : Form {
        public frmDatabaseAdmin() {
            InitializeComponent();
        }
        private void frmDatabaseAdmin_Load(object sender, EventArgs e) {
            DTRMConfig config = UF.GetConfig();
            if (config != null) {
                txtServerIP.Text = config.Database_Instance;
               // txtDatabaseName.Text = config.Database_Name;
                txtUserName.Text = config.Database_User_Name;
                txtPassword.Text = config.Database_Password;
            }
        }
        //private void chkShowPassword_CheckedChanged(object sender, EventArgs e) {
        //    txtPassword.PasswordChar = chkShowPassword.Checked ? '\0': '*' ;
        //}

        private void btnConnect_Click(object sender, EventArgs e) {
            LoadDatabaseNames();
        }

        private void LoadDatabaseNames() {
            DataTable dt = SQLMaster.GetDatabaseNamesFromServer(txtServerIP.Text.Trim(), txtUserName.Text.Trim(),
                txtPassword.Text.Trim());
            lstDatabase.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) 
                lstDatabase.Items.Add(dt.Rows[i]["name"].ToString());
        }

        
        private void btnDeselectDatabase_Click(object sender, EventArgs e) {
            lstDatabase.ClearSelected();
        }

        
        //private void btnCreateDatabase_Click(object sender, EventArgs e) {
        //    string message = "";
        //    FileInfo finfo = new FileInfo("CreateDatabase.sql");

        //    SQLMaster.CreateDatabaseFromSqlFile(txtServerIP.Text.Trim(), txtUserName.Text.Trim(),
        //        txtPassword.Text.Trim(), txtDatabaseName.Text.Trim(), out message, finfo.FullName);
        //    txtResults.Text = message;           
        //}

      

        private void btnClearResults_Click(object sender, EventArgs e) {
            txtResults.Clear();
        }



    }
}
