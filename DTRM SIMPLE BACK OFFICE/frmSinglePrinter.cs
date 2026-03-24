using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using DTRMNS;

using POSLayer.Models;
using POSLayer.Library;

namespace DTRMSimpleBackOffice {
    public partial class frmSinglePrinter : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        public Printer printer;
        public frmSinglePrinter(PosConfig configAsService, DTRMSimpleBusiness bslayer, Printer printer) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            this.printer= printer;
        }
        private void frmPrinterEditor_Load(object sender, EventArgs e) {
            LoadLocalPrinters();
            PrinterToUI();
        }
        private void PrinterToUI() {
            txtSpecialName.Text = printer.ApplicationName;
            cmbFunctionalPrinterType.SelectedIndex = (int)printer.PrinterType;
            cmbNetworkName.Text = printer.NetworkName;
            chkAdminOnly.Checked = printer.AdminOnly;
            chkDeliveryPrinter.Checked = printer.DeliveryPrinter;
            chkTakeAwayPrinter.Checked = printer.TakeAwayPrinter;
            if (printer.ClientIID != null) 
                lblExistingClientIID.Text = printer.ClientIID;
        }
        private void LoadLocalPrinters() {
            cmbNetworkName.Items.Clear();
            try {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    cmbNetworkName.Items.Add(PrinterSettings.InstalledPrinters[i]);
            } catch {
            }
        }
 

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (txtSpecialName.Text.Trim().Length == 0)
                return;

            printer.ApplicationName = txtSpecialName.Text.Trim();
            printer.PrinterType = (PrinterTypes)cmbFunctionalPrinterType.SelectedIndex;
            printer.NetworkName = cmbNetworkName.Text;
            printer.AdminOnly = chkAdminOnly.Checked;
            printer.DeliveryPrinter = chkDeliveryPrinter.Checked;
            printer.TakeAwayPrinter = chkTakeAwayPrinter.Checked;
            if (chkSetForThisTerminal.Checked)
                printer.ClientIID = config.Terminal_Name;

            if (await bslayer.SavePrinter(printer)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }           
        }


        
    }
}