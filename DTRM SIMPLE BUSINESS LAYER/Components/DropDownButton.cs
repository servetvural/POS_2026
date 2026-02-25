using System.Windows.Forms;

namespace DTRMNS {
    public partial class DropDownButton : Button {
        public DropDownButtonItem[] DropDownItems { get; set; }
        public DropDownButton() {
            InitializeComponent();
        }
    }
}
