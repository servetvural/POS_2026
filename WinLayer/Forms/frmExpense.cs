using POSLayer.Library;

using PosLibrary;

using System;
using System.Windows.Forms;

namespace WinLayer.Forms
{
    public partial class frmExpense : Form
    {
        public Expense expense;

        public frmExpense(Expense expense)
        {
            InitializeComponent();
            this.expense = expense;
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            LoadExpense();
        }

        private void LoadExpense()
        {
            if (expense != null)
            {
                cmbExpense.Text = expense.Description;
                txtAmount.Value = expense.Amount;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            expense.Description = cmbExpense.Text;
            expense.Amount = txtAmount.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            DoubleTextBox nud = (DoubleTextBox)sender;
            frmMoneyInput frm = new frmMoneyInput(nud.Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                nud.Value = frm.Value;
            }
        }


    }
}
