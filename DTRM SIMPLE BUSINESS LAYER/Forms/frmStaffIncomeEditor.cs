using PosLibrary;
using DTRMNS.Forms;
using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmStaffIncomeEditor : Form {
        private DTRMSimpleBusiness bslayer;
        public StaffIncome staff;

        public frmStaffIncomeEditor(DTRMSimpleBusiness bslayer, StaffIncome staff) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.staff = staff;
        }

        private void frmStaffIncomeEditor_Load(object sender, EventArgs e) {
            LoadStaff();
        }

        private void LoadStaff() {
           // cmbEmployee.DataSource = bslayer.GetAllEmployeeList();
            cmbBonusType.SelectedIndex= 0;

            if (staff != null) {
                txtHours.Value = staff.hours;

                cmbBonusType.SelectedIndex = (int)staff.bonusType;
                if (staff.employee != null) {
                    txtEmployee.Text = staff.name;
                   // cmbEmployee.SelectedValue = staff.employee.IID;
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
           // staff.employee = bslayer.GetEmployee(cmbEmployee.SelectedValue.ToString());
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
            frmEmployeeSelector frm = new frmEmployeeSelector(bslayer);
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
