using System.Drawing.Printing;

namespace WinLayer {
    public partial class frmLocalPrinterSelector : Form {
        public string SelectedPrinterNetworkName;

        public frmLocalPrinterSelector() {
            InitializeComponent();
        }

        private void frmLocalPrinterSelector_Load(object sender, EventArgs e) {
            LoadLocalPrinters();
        }

        private void LoadLocalPrinters() {
            cmbPrinters.Items.Clear();
            try {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    cmbPrinters.Items.Add(PrinterSettings.InstalledPrinters[i]);
            } catch {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            if (cmbPrinters.SelectedIndex >= 0 ) {
                SelectedPrinterNetworkName = cmbPrinters.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            } else {
               
            }

        }
    }
}
