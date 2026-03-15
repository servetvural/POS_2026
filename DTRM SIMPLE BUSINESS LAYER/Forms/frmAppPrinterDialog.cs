using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DTRMNS;

using POSLayer.Models;

namespace DTRMNS {
    public partial class frmAppPrinterDialog : Form {
        private DTRMSimpleBusiness bslayer;
        public string SelectedPrinterIID="";
        public ApplicationPrinter SelectedApplicationPrinter;
        public string SelectedPrinterNetworkName="";

        public frmAppPrinterDialog() {
            InitializeComponent();
        }
        public frmAppPrinterDialog(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmAppPrinterDialog_Load(object sender, EventArgs e) {
            LoadPrinters();
        }


        private void LoadPrinters() {
            List<ApplicationPrinter> PrinterList = bslayer.GetReceiptPrinterList().Result;

            ListViewItem lvi;
            ApplicationPrinter ap;
            for (int i = 0; i < PrinterList.Count; i++) {
                ap = (ApplicationPrinter)PrinterList[i];
                string[] plist = { ap.ApplicationName, ap.IID };
                lvi = new ListViewItem(plist, 0);
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
                this.SelectedApplicationPrinter =await bslayer.GetPrinterForClient(SelectedPrinterIID);
                this.SelectedPrinterNetworkName = SelectedApplicationPrinter.NetworkName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
