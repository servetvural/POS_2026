using POSLayer.Library;
using PosLibrary;

namespace WinLayer.Controls {
    public partial class ctlAlphaNumeric : UserControl {

        public event Delegate_String OutputOccured;
        public event GenericFunctionCallAsync BackspaceClicked;
        public event GenericFunctionCallAsync EnterClicked;
        public async Task OnOutputOccured(string str) {
            if (OutputOccured != null) {
                OutputOccured(str);
            }
        }
        public async Task OnBackspaceClicked() {
            if (BackspaceClicked != null) {
                await BackspaceClicked();
            }
        }

        public async Task OnEnterClicked() {
            if (EnterClicked != null) {
                await EnterClicked();
            }
        }

        public ctlAlphaNumeric() {
            InitializeComponent();
        }

        private void Key_Click(object sender, EventArgs e) {
            if (OutputOccured != null)
                OutputOccured(((Button)sender).Text);
        }

        private void btnBackspace_Click(object sender, EventArgs e) {
            if (BackspaceClicked != null)
                BackspaceClicked();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            if (EnterClicked != null)
                EnterClicked();
        }
    }
}
