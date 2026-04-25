using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using POSLayer.Models;
using POSLayer.Library;
using POSLayer.Repository.IRepository;

namespace POSOffice {
    public partial class frmPrinterDetails : Form
    {
        PosConfig config;
        IRepository<Printer> repoPrinter;
        public Printer printer;
        public frmPrinterDetails(PosConfig configAsService, IRepository<Printer> _repoPrinter, Printer printer)
        {
            InitializeComponent();
            config = configAsService;
            repoPrinter = _repoPrinter;
            this.printer = printer;
        }
        private void frmPrinterEditor_Load(object sender, EventArgs e)
        {
            LoadLocalPrinters();
            PrinterToUI();
        }
        private void PrinterToUI()
        {
            txtApplicationName.Text = printer.ApplicationName;
            cmbPrinterVisibility.SelectedIndex = (int)printer.PrinterVisibility;
            txtLocalTerminal.Text = printer.LocalTerminal;
            cmbNetworkName.Text = printer.NetworkName;
            cmbFunctionalPrinterType.SelectedIndex = (int)printer.PrinterType;
            chkDeliveryPrinter.Checked = printer.DeliveryPrinter;
            chkTakeAwayPrinter.Checked = printer.TakeAwayPrinter;
            chkAdminOnly.Checked = printer.AdminOnly;
        }
        private void LoadLocalPrinters()
        {
            cmbNetworkName.Items.Clear();
            try
            {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    cmbNetworkName.Items.Add(PrinterSettings.InstalledPrinters[i]);
            } catch
            {
            }
        }
        private void btnSetThis_Click(object sender, EventArgs e)
        {
            printer.LocalTerminal = txtLocalTerminal.Text = config.Terminal_Name;
            config.TerminalReceiptPrinterIID = printer.IID;

            UF.SaveConfig(config);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtApplicationName.Text.Trim().Length == 0)
                return;

            printer.ApplicationName = txtApplicationName.Text.Trim();
            printer.PrinterVisibility = (PrinterVisibilityTypes)cmbPrinterVisibility.SelectedIndex;
            printer.LocalTerminal = txtLocalTerminal.Text.Trim();
            printer.NetworkName = cmbNetworkName.Text;
            printer.PrinterType = (PrinterTypes)cmbFunctionalPrinterType.SelectedIndex;       
            printer.DeliveryPrinter = chkDeliveryPrinter.Checked;
            printer.TakeAwayPrinter = chkTakeAwayPrinter.Checked;
            printer.AdminOnly = chkAdminOnly.Checked;

            if (await repoPrinter.Save(printer) != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

       
    }
}