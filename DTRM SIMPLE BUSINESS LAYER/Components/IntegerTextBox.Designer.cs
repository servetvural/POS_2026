using System.Windows.Forms;
using System;

namespace DTRMNS {
    partial class IntegerTextBox {
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
            components = new System.ComponentModel.Container();
            this.TextChanged += new System.EventHandler(this.IntegerTextBox_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntegerTextBox_KeyDown);
        }
        private void IntegerTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                e.Handled = true;
        }

        private void IntegerTextBox_TextChanged(object sender, EventArgs e) {
            try {
                if (int.TryParse(Text, out int testValue)) {
                    Value = testValue;

                    //Now value is a valid value
                    Text = Value.ToString();
                }
                else
                    Text = Value.ToString();
            }
            catch {
                Value = 0;
                Text = Value.ToString();
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

        public int Increment { get; set; } = 1;
        public int MinValue { get; set; } = -10000;
        public int MaxValue { get; set; } = 10000;
        private int _Value = 0;
        public int Value {
            get { return _Value; }

            set {
                try {
                    if (value < MinValue) {
                        _Value = MinValue;
                    }
                    else {
                        if (value > MaxValue)
                            _Value = MaxValue;
                        else
                            _Value = value;
                    }
                    Text = _Value.ToString();
                }
                catch {
                    _Value = 0;
                    Text = _Value.ToString();
                }

            }
        }

    }
}
