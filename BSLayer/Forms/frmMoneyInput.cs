using System;
using System.Threading;
using System.Windows.Forms;

namespace BSLayer {
    enum MathActions { None, Add, Subtract , Multiply, Divide}
    public partial class frmMoneyInput : Form {
        public double Value;
        private double Register;
        private MathActions mathRegister = MathActions.None;
        bool blnMathActionRenewed = true;

        string dot;
        public frmMoneyInput() {
            InitializeComponent();
        }

        public frmMoneyInput(double givenValue) {
            InitializeComponent();
            this.Value = givenValue;
        }

        private void frmInput_Load(object sender, EventArgs e) {
           dot = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).ToString();
            btnDot.Text = dot;

            txtDisplay.Text = Value.ToString();
        }
        private bool HasDot() {
            return txtDisplay.Text.Contains(dot);
        }

        private void KeyHandle_Click(object sender, EventArgs e) {
            if (txtDisplay.Text.Trim() == "0") {
                txtDisplay.Text = ((Button)sender).Text;
                
            } else {
                if (blnMathActionRenewed)
                    txtDisplay.Text = ((Button)sender).Text;
                else 
                    txtDisplay.Text += ((Button)sender).Text;
            }
            blnMathActionRenewed= false;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Clear();
        }
        private void Clear() {
            //Value = 0;
            Register= 0;
            mathRegister= MathActions.None;
            blnMathActionRenewed = false;
            txtDisplay.Text = "0";
            //txtDisplay.Text = Value.ToString("N2");
        }

        private void btnOK_Click(object sender, EventArgs e) {
            try {
                if (txtDisplay.Text.Length > 0) {
                    Value = Convert.ToDouble(txtDisplay.Text);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            } catch { 
                Clear();
                txtDisplay.Text = Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                mathRegister = MathActions.Divide;
                return;
            } else {
                if (DoEquals()) {
                    mathRegister = MathActions.Divide;
                    blnMathActionRenewed = true;
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                mathRegister = MathActions.Multiply;
                return;
            } else {
                if (DoEquals()) {
                    mathRegister = MathActions.Multiply;
                    blnMathActionRenewed = true;
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                mathRegister = MathActions.Subtract;
                return;
            } else {
                if (DoEquals()) {
                    mathRegister = MathActions.Subtract;
                    blnMathActionRenewed = true;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                mathRegister = MathActions.Add;
                return;
            } else {
                if (DoEquals()) {
                    mathRegister = MathActions.Add;
                    blnMathActionRenewed = true;
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e) {
            DoEquals();
            blnMathActionRenewed = true;
        }

        private bool DoEquals() { 
            try {
                double display = Convert.ToDouble(txtDisplay.Text);
                //value valid

                //identify pending math operator
                switch (mathRegister) {
                    case MathActions.None:
                        Register = display;
                        return true;
                    case MathActions.Add:
                        Register = Register + display;
                        break;
                    case MathActions.Subtract:
                        Register = Register - display;
                        break;
                    case MathActions.Multiply:
                        Register = Register * display;
                        break;
                    case MathActions.Divide:
                        if (display== 0) {
                            //Register = Register;
                        } else {
                            Register = Register / display;
                        }                        
                        break;
                }
                
                txtDisplay.Text = Register.ToString(HasFraction(Register)?"N2":"N0");
                mathRegister = MathActions.None;
                blnMathActionRenewed = false;
                return true;
            } catch {
                return false;
            }
        }

        private void btnDot_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                txtDisplay.Text = "0" + dot;
            } else {
                if (txtDisplay.Text.Contains(dot))
                    return;
                txtDisplay.Text += dot;
            }
            blnMathActionRenewed = false;
        }

        private void btnSifir_Click(object sender, EventArgs e) {
            if (blnMathActionRenewed) {
                if (txtDisplay.Text == "0")
                    return;
                //if (txtDisplay.Text.Contains(".")) {
                    txtDisplay.Text = "0";
               // }
            } else {
                if (txtDisplay.Text == "0")
                    return;
                if (txtDisplay.Text.Contains(".") || Convert.ToDecimal(txtDisplay.Text) > 0) {
                    txtDisplay.Text += "0";
                }
            }
            blnMathActionRenewed = false;

        }

        private void btnBack_Click(object sender, EventArgs e) {
            if (txtDisplay.Text.Length > 0) {
                txtDisplay.Text = txtDisplay.Text.Substring(0,txtDisplay.Text.Length - 1);
               
            }
        }

        private bool HasFraction(double val) {
            return (val - ((int)val) > 0);
        }
    }
}
