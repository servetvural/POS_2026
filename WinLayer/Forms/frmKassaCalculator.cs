using System.ComponentModel;
using System.Data;
using WinLayer.Forms;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary;

namespace WinLayer {
    public partial class frmKassaCalculator : Form {

        PosConfig config;
        IRepository<User> repoUser;
        IRepository<Employee> repoEmployee;
        IRepository<Bonus> repoBonus;    

        private BindingList<StaffIncome> staffIncomes = new BindingList<StaffIncome>();
        private BindingList<Expense> expenses= new BindingList<Expense>();
        private double stepOneTotal;

        bool blnTerminate = false;
        public frmKassaCalculator() {
            InitializeComponent();

            config = ServiceHelper.GetService<PosConfig>();
            repoUser = ServiceHelper.GetService<IRepository<User>>();
            repoEmployee = ServiceHelper.GetService<IRepository<Employee>>();
            repoBonus = ServiceHelper.GetService<IRepository<Bonus>>();

            if (config.IsValid())
            {
                LoginUser();
            }    else
            {
                if (AskForConfig())
                {
                    Environment.Exit(0);
                }
            }
        }

        async Task<bool> LoginUser()
        {
            if (await repoUser.IsDatabaseExist())
            {
                frmPassword frmpswd = ActivatorUtilities.CreateInstance<frmPassword>(ServiceHelper.Services, "Database : " + config.Database_Instance);
                if (frmpswd.ShowDialog() == DialogResult.OK)
                {
                    User user = await repoUser.GetByField("UserPassword", frmpswd.Password);
                    if (user == null)
                    {
                        return false; 
                    }      else
                    {
                        return true;
                    }
                } else
                {
                    MessageBox.Show("Failed to Login");
                    return false;
                }
            } else 
                return false;
        }

        private bool AskForConfig() {
            frmConfig frm = ActivatorUtilities.CreateInstance <frmConfig>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Saved Restart Application");
                return true;
            } else
            {
                MessageBox.Show("Failed Restart Application");
                return false;
            }
        }

        private async void frmKassaCalculator_Load(object sender, EventArgs e) {
            if (blnTerminate)
                Application.Exit();
            await LoadKassa();
        }

        private async Task LoadKassa() {
            lblDate.Text = DateTime.Now.ToString("dd/MMM dddd HH:mm");
            cmbManagedBy.DataSource = await repoEmployee.GetAllAsync();
            cmbController.DataSource = await repoEmployee.GetAllAsync();
            cmbBonus.DataSource = await repoBonus.GetAllAsync();
            cmbXType.SelectedIndex = 0;
        }

        
        private void LoadStaffList() {
            try {
                CalculateBonus();


                txtRateTotal.Value = 0;
                txtBonusTotal.Value = 0;


                foreach (StaffIncome staff in staffIncomes) {
                    staff.Update(txtXAmount.Value, cmbBonus.SelectedItem as Bonus);
                    txtRateTotal.Value += staff.rateIncome;
                    txtBonusTotal.Value += staff.bonusIncome;
                }

                stepOneTotal = txtXAmount.Value - txtPinTerminalTotal.Value + txtAfterSaleAmount.Value;
                txtStepTwoTotal.Value = stepOneTotal - txtExpensesTotal.Value - txtRateTotal.Value - txtBonusTotal.Value;
                txtGrandTotal.Value = txtStepTwoTotal.Value + txtExtraAmount.Value;

                // dgvEmployee.DataSource = null;

                dgvEmployee.Refresh();
                dgvEmployee.DataSource = staffIncomes;

                double shortTotal = Math.Round(staffIncomes.Sum(x => x.shortAmount),2);
                if (txtShortAmount.Value != shortTotal) {
                    txtShortAmount.BackColor = Color.Salmon;
                    lblShortDifference.Text = (txtShortAmount.Value - shortTotal).ToString("N2");
                } else {
                    txtShortAmount.BackColor = SystemColors.Window;
                    lblShortDifference.Text = "";
                }

                double bahsisTotal = Math.Round(staffIncomes.Sum(x => x.tipIncome),2);
                if (txtBahsisTotal.Value != bahsisTotal) {
                    txtBahsisTotal.BackColor = Color.Salmon;
                    lblBahsisDifference.Text = (txtBahsisTotal.Value - bahsisTotal).ToString("N2");
                } else {
                    txtBahsisTotal.BackColor = SystemColors.Window;
                    lblBahsisDifference.Text = "";
                }


                if (dgvEmployee.Rows.Count > 0) {
                    dgvEmployee.Rows[0].Selected = true;
                }
            } catch(Exception ex) {
                string str = ex.Message;
            }
        }


        private void cmdAdd_Click(object sender, EventArgs e) {
            Bonus bonus = cmbBonus.SelectedItem as Bonus;

            frmStaffIncomeEditor frm = ActivatorUtilities.CreateInstance<frmStaffIncomeEditor>(ServiceHelper.Services, new StaffIncome()
            {
                xAmount = txtXAmount.Value,
                bonus = bonus
            });
            if (frm.ShowDialog() == DialogResult.OK) {
                if (staffIncomes.Where(x => x.IID == frm.staff.IID).Any()) {
                    MessageBox.Show("Already in the list");
                } else {
                    staffIncomes.Add(frm.staff);
                }
                LoadStaffList();
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e) {
            try {
                if (dgvEmployee.SelectedRows.Count > 0) {
                    StaffIncome staff = staffIncomes.Where(x => x.IID == dgvEmployee.SelectedRows[0].Cells["colIID"].Value.ToString()).FirstOrDefault();

                    frmStaffIncomeEditor frm = ActivatorUtilities.CreateInstance < frmStaffIncomeEditor>(ServiceHelper.Services, staff);
                    if (frm.ShowDialog() == DialogResult.OK)
                        //staff = frm.staff;
                        LoadStaffList();
                }
            } catch { }
        }

        private void cmdDelete_Click(object sender, EventArgs e) {
            try {
                if (dgvEmployee.SelectedRows.Count > 0) {
                    StaffIncome staff = staffIncomes.Where(x => x.IID == dgvEmployee.SelectedRows[0].Cells["colIID"].Value.ToString()).FirstOrDefault();
                    if (staff != null) {
                        staffIncomes.Remove(staff);
                        LoadStaffList();
                    }
                }
            } catch { }
        }

        private void cmdReload_Click(object sender, EventArgs e) {
            LoadStaffList();
        }

        private void cmdPrint_Click(object sender, EventArgs e) {
            int rightmax = 10;
            frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
            if (fsp.ShowDialog() == DialogResult.OK) {
                List<string> report = new List<string>();

                report.Add("Managed By     : " + cmbManagedBy.Text);
                report.Add("Controlled By  : " + cmbController.Text);
                report.Add("Date           : " + lblDate.Text);
                report.Add("Tips           : " + (cmbBonus.SelectedItem as Bonus).PlanName);
                report.Add("drawline");
                report.Add("REPORT");
                report.Add("drawline");
                report.Add(UF.MaximumString(cmbXType.Text,15, PrintAligns.Near) +  ": " + UF.MaximumString(txtXAmount.Value.ToString("N2"),rightmax, PrintAligns.Far));
                report.Add("After Sale     : " + UF.MaximumString(txtAfterSaleAmount.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("Pin Kassa      : " + UF.MaximumString(txtPinKassaTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("Pin Terminal   : " + UF.MaximumString(txtPinTerminalTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("Pin Difference : " + UF.MaximumString((txtPinTerminalTotal.Value - txtPinKassaTotal.Value).ToString("N2"), rightmax, PrintAligns.Far));                 
                report.Add("Bahsis Total   : " + UF.MaximumString(txtBahsisTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));

                report.Add("newline");
                report.Add("EXPENSES");
                report.Add("drawline");
                foreach (Expense item in expenses) {
                    report.Add(UF.MaximumString(item.Description,17, PrintAligns.Near) + UF.MaximumString(item.Amount.ToString("N2"), rightmax, PrintAligns.Far));
                }
                report.Add("drawline");
                report.Add("Expenses Total : " + UF.MaximumString(txtExpensesTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));


                report.Add("Reserve Total  : " + UF.MaximumString(txtRateTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("Tip Total      : " + UF.MaximumString(txtBonusTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("NR of Tips     : " + UF.MaximumString(txtHowManyBonus.Value.ToString("N0"), rightmax, PrintAligns.Far));               
                report.Add("drawline");
                report.Add("REQUIRED CASH  : " + UF.MaximumString(txtStepTwoTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));

                report.Add("newline");

                report.Add("Short Amount   : " + UF.MaximumString(txtShortAmount.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("Extra Amount   : " + UF.MaximumString(txtExtraAmount.Value.ToString("N2"), rightmax, PrintAligns.Far));

                report.Add("drawline");
                report.Add("GIVEN CASH     : " + UF.MaximumString(txtGrandTotal.Value.ToString("N2"), rightmax, PrintAligns.Far));
                report.Add("drawline");

                report.Add("newline");
                report.Add("STAFF DETAILS");
                report.Add("drawline");
                foreach (StaffIncome item in staffIncomes) {
                    report.Add(item.name + " " + item.hours + " hours " + item.rate.ToString("N2") + " = " + item.rateIncome.ToString("N2"));
                    report.Add(" " + item.bonusType + "  " + item.bonusIncome.ToString("N2") + "  Bahsis " + item.tipIncome.ToString("N2") + "  Short " + item.shortAmount.ToString("N2"));
                    report.Add(" Payment : " + item.IncomeTotal.ToString("N2"));
                    report.Add("drawline");
                    report.Add("newline");
                    report.Add("newline");
                    report.Add("newline");
                    report.Add("newline");
                    report.Add("newline");
                    report.Add("drawline");
                }

                 BSLayer.Instance.PrintKassaReport(report, fsp.SelectedPrinter, 1);
            }
        }
        private void cmdClose_Click(object sender, EventArgs e) {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void txtXAmount_ValueChanged(object sender, EventArgs e) {
            LoadStaffList();
        }
        private void Force_Reload(object sender, EventArgs e) {
            LoadStaffList();
        }


        private void CalculateBonus() {
            try {
                Bonus bonus = cmbBonus.SelectedItem as Bonus;
                txtHowManyBonus.Value = bonus.GetBonusStatus((float)txtXAmount.Value).PreviousBarrierNumber;
            } catch (Exception ex) {
                string str = ex.Message;
            }
        }

        private void cmbBonus_SelectionChangeCommitted(object sender, EventArgs e) {
            LoadStaffList();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            cmdEdit_Click(sender, e);
        }
    

        private void tsAddExpense_Click(object sender, EventArgs e) {
            frmExpense frm = ActivatorUtilities.CreateInstance<frmExpense>(ServiceHelper.Services, new Expense());
            if (frm.ShowDialog() == DialogResult.OK) {
                if (!expenses.Contains(frm.expense)) {
                    expenses.Add(frm.expense);
                }
                LoadExpenseList();
                LoadStaffList();
            }
        }

        private void tsEditExpense_Click(object sender, EventArgs e) {
            if (dgvExpense.SelectedRows.Count > 0) {
                Expense expense = expenses.Where(x => x.IID == dgvExpense.SelectedRows[0].Cells["colExpenseIID"].Value.ToString()).FirstOrDefault();

                frmExpense frm = ActivatorUtilities.CreateInstance< frmExpense>(ServiceHelper.Services, expense);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadExpenseList();
                LoadStaffList();
            }
        }

        private void tsDeleteExpense_Click(object sender, EventArgs e) {
            if (dgvExpense.SelectedRows.Count > 0) {
                Expense expense = expenses.Where(x => x.IID == dgvExpense.SelectedRows[0].Cells["colExpenseIID"].Value.ToString()).FirstOrDefault();
                if (expense != null) {
                    expenses.Remove(expense);
                    LoadExpenseList();
                    LoadStaffList();
                }
            }
        }

        private void tsReloadExpense_Click(object sender, EventArgs e) {
            LoadExpenseList();
            LoadStaffList();
        }

        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            tsEditExpense_Click(sender, e);
        }
        private void LoadExpenseList() {
            txtExpensesTotal.Value = 0;
            foreach (Expense item in expenses) {
                txtExpensesTotal.Value += item.Amount;
            }

            //dgvExpense.DataSource = null;
            dgvExpense.DataSource = expenses;
        }


        private void label4_Click(object sender, EventArgs e) {
            frmMoneyInput frm = new frmMoneyInput(txtXAmount.Value);
            if (frm.ShowDialog() == DialogResult.OK) {
                txtXAmount.Value = frm.Value;
            }
        }

        private void NumericUpDown_Click(object sender, EventArgs e) {
            DoubleTextBox nud = (DoubleTextBox)sender;
            frmMoneyInput frm = new frmMoneyInput(nud.Value);
            if (frm.ShowDialog() == DialogResult.OK) {
                nud.Value = frm.Value;
            }
        }

        private void cmbXType_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void txtExtraAmount_ValueChanged(object sender, EventArgs e) {
            txtGrandTotal.Value = txtStepTwoTotal.Value + txtExtraAmount.Value;
        }

        private void cmdCalculate_Click(object sender, EventArgs e) {
            LoadStaffList();
        }

        private void cmdDuplicate_Click(object sender, EventArgs e) {
            try {
                if (dgvEmployee.SelectedRows.Count > 0) {
                    StaffIncome staff = staffIncomes.Where(x => x.IID == dgvEmployee.SelectedRows[0].Cells["colIID"].Value.ToString()).FirstOrDefault();

                    StaffIncome newStaff = new StaffIncome {
                        bonus = staff.bonus,
                        bonusType = staff.bonusType,
                        hours = staff.hours,
                        tipIncome = staff.tipIncome,
                        /* shortAmount = staff.shortAmount,*/
                        xAmount = staff.xAmount
                    };

                    frmStaffIncomeEditor frm = ActivatorUtilities.CreateInstance < frmStaffIncomeEditor>(ServiceHelper.Services, newStaff);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        if (staffIncomes.Where(x => x.IID == frm.staff.IID).Any()) {
                            MessageBox.Show("Already in the list");
                        } else {
                            staffIncomes.Add(frm.staff);
                        }
                        LoadStaffList();
                    }
                }
            } catch { }

        }

        private void btnBahsisTotal_Click(object sender, EventArgs e) {
            DistributeBahsis();            
        }

        private void DistributeBahsis() {
            foreach (StaffIncome item in staffIncomes) {
                item.tipIncome = txtBahsisTotal.Value / staffIncomes.Count();
            }
            LoadStaffList();
        }

        private void btnShortCash_Click(object sender, EventArgs e) {
            DistributeShort();
        }
        private void DistributeShort() {
            int shortableCount = staffIncomes.Where(x => x.shortApplicable).Count();
            foreach (StaffIncome item in staffIncomes) {
                if (item.shortApplicable) {
                    item.shortAmount= txtShortAmount.Value / shortableCount;
                }
            }
            LoadStaffList();
        }
    }
}
