using System.Windows.Forms;

namespace WinLayer
{
    public partial class DoubleTextBox : TextBox {
        public DoubleTextBox() {
            InitializeComponent();
            this.ReValidate();
        }
    }
}
