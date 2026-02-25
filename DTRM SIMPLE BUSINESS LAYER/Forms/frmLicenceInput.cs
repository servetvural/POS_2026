using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmLicenceInput : Form {
        public string inputData;

        public frmLicenceInput(string Message = "", string Caption="LICENCE REGISTRATION") {
            InitializeComponent();
            this.Text = Caption;
            lblMessage.Text = Message;
        }

        private void frmLicenceInput_Load(object sender, EventArgs e) {
            
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (txtInput.Text.Trim().Length > 0) {
                inputData = txtInput.Text.Trim();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
