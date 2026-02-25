using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class ctlHoldButton : UserControl {
        public event EventHandler ButtonClick;

        public ctlHoldButton() {
            InitializeComponent();
        }

        private void lblPrice_Click(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void lblOrderNumber_Click(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void pBox_Click(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }


        [Description("Price text displayed"), Category("Custom Property")]
        public string PriceText {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        [Description("Price text Font"), Category("Custom Property")]
        public Font PriceTextFont {
            get { return lblPrice.Font; }
            set { lblPrice.Font= value; }
        }

        [Description("Order Number displayed"), Category("Custom Property")]
        public string OrderNumber {
            get { return lblOrderNumber.Text; }
            set { lblOrderNumber.Text = value; }
        }

        [Description("Order Number Font"), Category("Custom Property")]
        public Font OrderNumberFont {
            get { return lblOrderNumber.Font; }
            set { lblOrderNumber.Font = value; }
        }

        [Description("Tick image displayed"), Category("Custom Property")]
        public bool TickVisible {
            get { return pBox.Visible; }
            set { pBox.Visible = value; }
        }

        [Description("Control BackColor"), Category("Custom Property")]
        public Color ControlBackColor {
           // get { return lblOrderNumber.Text; }
            set { lblOrderNumber.BackColor = lblPrice.BackColor = pnlBottom.BackColor= value; }
        }
    }
}
