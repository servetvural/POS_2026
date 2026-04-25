using System.Windows.Forms;
using System;
using System.Globalization;
using System.ComponentModel;

namespace WinLayer {
    partial class DoubleTextBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public event EventHandler ValueChanged;
        protected void OnValueChanged(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ValueChanged != null)
                this.ValueChanged(this, e);
        }
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // DoubleTextBox
            // 
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Leave += new System.EventHandler(this.DoubleTextBox_Leave);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoubleTextBox_KeyDown);
            this.ResumeLayout(false);

        }


        private void DoubleTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                e.Handled = true;
        }

        private void DoubleTextBox_Leave(object sender, EventArgs e) {
            CultureInfo cinfo = null; // CultureInfo.CurrentUICulture;
            if (CustomUICulture == "")
                cinfo = CultureInfo.CurrentUICulture;
            else
               cinfo =  CultureInfo.GetCultureInfo(CustomUICulture);

            try {
                if (double.TryParse(Text, NumberStyles.Any, cinfo, out double testValue)) {
                    Value = testValue;

                    //Now value is a valid value
                    Text = Value.ToString(CustomFormat, cinfo);
                }
                else
                    Text = Value.ToString(CustomFormat, cinfo);
            }
            catch {
                Value = 0;
                Text = Value.ToString(CustomFormat, cinfo);
            }
        }

        public void IncrementValue() {
            Value += Increment;
            Text = Value.ToString();
        }
        public void DecrementValue() {
            Value -= Increment;
            Text = Value.ToString();
        }
        #endregion

        public double Increment { get; set; } = 1;
        public double MinValue { get; set; } = -100000;
        public double MaxValue { get; set; } = 100000;
        private double _Value = 0;
        public double Value {
            get { return _Value; }

            set {
                try {
                    if (value < MinValue) {
                        _Value = MinValue;
                    }
                    else {
                        if (value > MaxValue)
                            _Value = MaxValue;
                        else {
                            _Value = value;
                            if (this.ValueChanged != null)
                                this.ValueChanged(this, null);
                        }
                    }
                    if (CustomUICulture == "")
                        Text = _Value.ToString(CustomFormat, CultureInfo.CurrentUICulture);
                    else
                        Text = Value.ToString(CustomFormat, CultureInfo.GetCultureInfo(CustomUICulture));
                }
                catch (Exception ex) {
                    string str = ex.Message;
                    _Value = 0;
                    Text = _Value.ToString();
                }
                Refresh();
            }
        }

        public string CustomUICulture { get; set; } = CultureInfo.CurrentUICulture.Name;

        [DescriptionAttribute("2.00 = \"N2\", $ 2.00 = \"c2\", 10% = 0\" % \", 12.23 % = 0.00\" % \"")]
        /// <summary>
        /// 2.00 = "N2", $ 2.00 = "c2", 10% = 0"%", 12.23 % = 0.00" %"
        /// </summary>        
        public string CustomFormat { get; set; } = "N2";

        public void ReValidate() {
            DoubleTextBox_Leave(null, null);
        }
    }
}
