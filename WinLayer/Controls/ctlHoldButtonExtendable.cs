using System.ComponentModel;

namespace WinLayer {
    public partial class ctlHoldButtonExtendable : UserControl {
        public event EventHandler ButtonClick;

        public ctlHoldButtonExtendable() {
            InitializeComponent();
        }
        public ctlHoldButtonExtendable(int Maximum_Width, int Maximum_Height) {
            InitializeComponent();
            this.MaximumSize = new Size(Maximum_Width , Maximum_Height);
        }
        private void lblPrice_Click(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        private void lblItems_Click(object sender, EventArgs e) {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }


        [Description("Price text displayed"), Category("Custom Property")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PriceText {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }


        [Description("Items text displayed"), Category("Custom Property")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemsText {
            get { return lblItems.Text; }
            set { lblItems.Text = value; }
        }


        [Description("Price text Font"), Category("Custom Property")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font PriceTextFont {
            get { return lblPrice.Font; }
            set { lblPrice.Font= value; }
        }

        [Description("Items text Font"), Category("Custom Property")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ItemsTextFont {
            get { return lblItems.Font; }
            set { lblItems.Font = value; }
        }

        [Description("Control BackColor"), Category("Custom Property")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ControlBackColor {
           // get { return lblOrderNumber.Text; }
            set { lblPrice.BackColor = pnlTop.BackColor= value; }
        }
    }
}
