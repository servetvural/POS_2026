using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinLayer.Forms {
    public partial class frmInputForm : Form {
        public string InputValue;

        public frmInputForm() {
            InitializeComponent();
        }
        public frmInputForm(string InitialValue) {
            InitializeComponent();
            txtInput.Text = InitialValue;
        }
        public frmInputForm(string InitialValue, int MaximumLength) {
            InitializeComponent();
            if (InitialValue.Length > 14)
                txtInput.Text = InitialValue.Substring(0, 14);
            else
                txtInput.Text = InitialValue;
            txtInput.MaxLength = MaximumLength;
        }
        private void frmInputForm_Load(object sender, EventArgs e) {
            txtInput.SelectAll();
            txtInput.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (txtInput.Text.Trim().Length == 0)
                return;
            InputValue = txtInput.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
