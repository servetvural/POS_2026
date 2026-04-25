using PosLibrary;
using BSLayer.Forms;
using System;
using System.Windows.Forms;
using POSLayer.Library;
using Microsoft.Extensions.DependencyInjection;

namespace BSLayer {
    public partial class frmStaffIncomeEditor : Form {
        public StaffIncome staff;

        public frmStaffIncomeEditor( StaffIncome staff) {
            InitializeComponent();
            this.staff = staff;
        }

        private void frmStaffIncomeEditor_Load(object sender, EventArgs e) {
            LoadStaff();
        }

        private void LoadStaff() {
            cmbBonusType.SelectedIndex= 0;

            if (staff != null) {
                txtHours.Value = staff.hours;

                cmbBonusType.SelectedIndex = (int)staff.bonusType;
                if (staff.employee != null) {
                    txtEmployee.Text = staff.name;
                }
                txtTipIncome.Value = staff.tipIncome;
                txtShort.Value = staff.shortAmount;
                chkNoShort.Checked = staff.shortApplicable;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            staff.bonusType = (BonusTypes)cmbBonusType.SelectedIndex;
            staff.hours = (int)txtHours.Value;
            staff.tipIncome = txtTipIncome.Value;
            staff.shortAmount = txtShort.Value;
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void NumericUpDown_Click(object sender, EventArgs e) {
            DoubleTextBox nud = (DoubleTextBox)sender;
            frmMoneyInput frm = new frmMoneyInput(nud.Value);
            if (frm.ShowDialog() == DialogResult.OK) {
                nud.Value = frm.Value;
            }
        }

        private void btnChooseEmployee_Click(object sender, EventArgs e) {
            frmEmployeeSelector frm = ActivatorUtilities.CreateInstance<frmEmployeeSelector>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK) {
                staff.employee = frm.SelectedEmployee;
                txtEmployee.Text = staff.employee.EmployeeName;
                chkNoShort.Checked = !staff.employee.Shortable;
            }
        }

        private void chkNoShort_CheckedChanged(object sender, EventArgs e) {
            txtShort.Enabled = staff.shortApplicable = !chkNoShort.Checked;
            if (!staff.shortApplicable) {
                staff.shortAmount = 0;
            }
        }
    }
}
