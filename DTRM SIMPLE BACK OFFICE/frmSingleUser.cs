using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmSingleUser : Form {
        

        private DTRMSimpleBusiness bslayer;
        public User user;

        public frmSingleUser() {
            InitializeComponent();
        }
        public frmSingleUser(DTRMSimpleBusiness bslayer, User user) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.user= user;
        }
        private void frmSingleUser_Load(object sender, EventArgs e) {
           // LoadAccessLevels();
            LoadUser();
            
        }
        private void LoadUser() {
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.UserPassword;
            cmbAccessLevels.Text = user.AccessLevel.ToString();
        }

        //private void LoadAccessLevels() {
        //    cmbAccessLevels.Items.Clear();
        //    switch (bslayer.LoggedUser.AccessLevel) {
        //        case AccessLevels.TechnicalSupport:
        //            cmbAccessLevels.Items.Add("TechnicalSupport");
        //            cmbAccessLevels.Items.Add("SuperUser");
        //            cmbAccessLevels.Items.Add("Manager");                    
        //            cmbAccessLevels.Items.Add("User");
        //            break;
        //        case AccessLevels.SuperUser:
        //            cmbAccessLevels.Items.Add("Manager");
        //            cmbAccessLevels.Items.Add("User");
        //            break;
        //        case AccessLevels.Manager:
        //            cmbAccessLevels.Items.Add("User");
        //            break;                
        //        case AccessLevels.User:
        //            cmbAccessLevels.Items.Add("User");
        //            break;
        //    }
        //}
        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtUserName.Text.Trim().Length == 0)
                return;
            if (cmbAccessLevels.Text == "")
                return;

            user.UserName = txtUserName.Text.Trim();
            user.UserPassword = txtPassword.Text.Trim();
            user.AccessLevel = (AccessLevels)Enum.Parse(typeof(AccessLevels), cmbAccessLevels.Text); // (AccessLevels)cmbAccessLevels.SelectedIndex;

            if (bslayer.SaveUser(user)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }           
        }

    }
}
