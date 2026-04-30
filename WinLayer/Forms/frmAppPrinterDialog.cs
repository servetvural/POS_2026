using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer {
    public partial class frmAppPrinterDialog : Form {
        PosConfig config;
        IRepository<Printer> repoPrinter;

        public string SelectedPrinterIID="";
        public Printer SelectedPrinter;
        public string SelectedPrinterNetworkName="";

        public frmAppPrinterDialog() {
            InitializeComponent();
        }
        public frmAppPrinterDialog(PosConfig configAsService, IRepository<Printer> _repoPrinter) {
            InitializeComponent();
            config = configAsService;
            repoPrinter = _repoPrinter;
        }

        private async void frmAppPrinterDialog_Load(object sender, EventArgs e) {
           await LoadPrinters();
        }


        private async Task LoadPrinters() {
            List<Printer> PrinterList = (await repoPrinter.GetAllAsync()).Where(x => x.PrinterType == PrinterTypes.Receipt && x.LocalTerminal == config.Terminal_Name).ToList();

            ListViewItem lvi;
            for (int i = 0; i < PrinterList.Count; i++) {
                Printer printer = (Printer)PrinterList[i];
                string[] plist = { printer.ApplicationName, printer.IID };
                lvi = new ListViewItem(plist, 0);
                lvi.Tag = printer;
                lvwPrinters.Items.Add(lvi);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnOK_Click(object sender, EventArgs e) {
            if (lvwPrinters.SelectedIndices.Count > 0) {
                ListViewItem lvi = lvwPrinters.SelectedItems[0];
                this.SelectedPrinterIID = lvi.SubItems[1].Text;
                this.SelectedPrinter = (Printer)lvi.Tag;  //await  BSLayer.Instance.GetPrinterForClient(SelectedPrinterIID);
                this.SelectedPrinterNetworkName = SelectedPrinter.NetworkName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
