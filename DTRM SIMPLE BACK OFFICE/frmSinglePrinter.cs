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
        private DTRMSimpleBusiness bslayer;
        public ApplicationPrinter ap;
        public frmSinglePrinter(DTRMSimpleBusiness bslayer, ApplicationPrinter ap) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.ap= ap;
        }
        private void frmPrinterEditor_Load(object sender, EventArgs e) {
            LoadLocalPrinters();
            PrinterToUI();
        }
        private void PrinterToUI() {
            txtSpecialName.Text = ap.ApplicationName;
            cmbFunctionalPrinterType.SelectedIndex = (int)ap.PrinterType;
            cmbNetworkName.Text = ap.NetworkName;
            chkAdminOnly.Checked = ap.AdminOnly;
            chkDeliveryPrinter.Checked = ap.DeliveryPrinter;
            chkTakeAwayPrinter.Checked = ap.TakeAwayPrinter;
            if (ap.ClientIID != null) 
                lblExistingClientIID.Text = ap.ClientIID;
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

            ap.ApplicationName = txtSpecialName.Text.Trim();
            ap.PrinterType = (PrinterTypes)cmbFunctionalPrinterType.SelectedIndex;
            ap.NetworkName = cmbNetworkName.Text;
            ap.AdminOnly = chkAdminOnly.Checked;
            ap.DeliveryPrinter = chkDeliveryPrinter.Checked;
            ap.TakeAwayPrinter = chkTakeAwayPrinter.Checked;
            if (chkSetForThisTerminal.Checked)
                ap.ClientIID = bslayer.config.Terminal_Name;

            if (await bslayer.SavePrinter(ap)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }           
        }


        
    }
}