using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PosLibrary;

using Newtonsoft;
using DTRMNS;
using Newtonsoft.Json;

namespace DTRMSimpleBackOffice {
    public partial class frmPrinters : Form {
        private DTRMSimpleBusiness bslayer;
        private bool blnasModal;
        public frmPrinters() {
            InitializeComponent();
        }
        public frmPrinters(DTRMSimpleBusiness bslayer, bool asModal = false) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.blnasModal = asModal;
            if (asModal) {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
        }
        
        private void frmPrinters_Load(object sender, EventArgs e) {            
            LoadPrinters();
        }

        private void LoadPrinters() {
            dgv.Columns["colClient"].Visible = chkAllPrinters.Checked;
            if (chkAllPrinters.Checked)
                dgv.DataSource = UF.StringifyEnumInDataTable(bslayer.GetSystemPrinterListDB(), "PrinterType", "PrinterTypeAsString", typeof(PrinterTypes));
            else
                dgv.DataSource = UF.StringifyEnumInDataTable(bslayer.GetPrinterListDB(), "PrinterType", "PrinterTypeAsString", typeof(PrinterTypes));

            try {
                cmbDeliveryPrinter.DataSource = bslayer.GetPrinterListDB();
                ApplicationPrinter ap = bslayer.GetPrinterForOrderType(OrderTypes.Delivery);
                if (ap != null)
                    cmbDeliveryPrinter.SelectedValue = ap.IID;
            }
            catch { }

            try {
                cmbTakeAwayPrinter.DataSource = bslayer.GetPrinterListDB();
                ApplicationPrinter ap = bslayer.GetPrinterForOrderType(OrderTypes.TakeAwayB);
                if (ap != null)
                    cmbTakeAwayPrinter.SelectedValue = ap.IID;
            }
            catch { }

            try {
                cmbCashDrawerPrinter.DataSource = bslayer.GetPrinterListDB();
                if (bslayer.config.DtPrinterCashDrawerIID != null && bslayer.config.DtPrinterCashDrawerIID != "") {
                    ApplicationPrinter ap = bslayer.GetPrinterForClient(bslayer.config.DtPrinterCashDrawerIID);
                    if (ap != null)
                        cmbCashDrawerPrinter.SelectedValue = ap.IID;
                }
            }
            catch { }

            try {
                cmbLocalReceiptPrinter.DataSource = bslayer.GetPrinterListDB();
                if (bslayer.config.DTClientLocalReceiptPrinterIID != null && bslayer.config.DTClientLocalReceiptPrinterIID != "") {
                    ApplicationPrinter ap = bslayer.GetPrinterForClient(bslayer.config.DTClientLocalReceiptPrinterIID);
                    if (ap != null)
                        cmbLocalReceiptPrinter.SelectedValue = ap.IID;
                }
            }
            catch { }
        }
        //private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
        //    for (int i = 0; i < dgv.Rows.Count; i++) {
        //        dgv.Rows[i].Cells["colPrinterTypeAsString"].Value = (PrinterTypes)int.Parse(dgv.Rows[i].Cells["colPrinterType"].Value.ToString());
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e) {
            frmSinglePrinter frm = new frmSinglePrinter(bslayer, new ApplicationPrinter());
            if (frm.ShowDialog() == DialogResult.OK)
                LoadPrinters();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                string PrinterIID = dgv.SelectedRows[0].Cells["colPrinterIID"].Value.ToString();
                ApplicationPrinter ap = bslayer.GetPrinter(PrinterIID);

                frmSinglePrinter frm = new frmSinglePrinter(bslayer, ap);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadPrinters();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                bslayer.DeletePrinter(dgv.SelectedRows[0].Cells["colPrinterIID"].Value.ToString());
                LoadPrinters();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }




        private void cmbTakeAwayPrinter_SelectionChangeCommitted(object sender, EventArgs e) {
            bslayer.SaveUniquePrinter(cmbTakeAwayPrinter.SelectedValue.ToString(), OrderTypes.TakeAwayB);
        }

        private void cmbDeliveryPrinter_SelectionChangeCommitted(object sender, EventArgs e) {
            bslayer.SaveUniquePrinter(cmbDeliveryPrinter.SelectedValue.ToString(), OrderTypes.Delivery);
        }

        private void cmbCashDrawerPrinter_SelectionChangeCommitted(object sender, EventArgs e) {
            bslayer.config.DtPrinterCashDrawerIID = cmbCashDrawerPrinter.SelectedValue.ToString();
        }

        private void cmbLocalReceiptPrinter_SelectionChangeCommitted(object sender, EventArgs e) {
            bslayer.config.DTClientLocalReceiptPrinterIID = cmbLocalReceiptPrinter.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                bslayer.SaveUniquePrinter(cmbTakeAwayPrinter.SelectedValue.ToString(), OrderTypes.TakeAwayB);
                bslayer.SaveUniquePrinter(cmbDeliveryPrinter.SelectedValue.ToString(), OrderTypes.Delivery);
                bslayer.config.DtPrinterCashDrawerIID = cmbCashDrawerPrinter.SelectedValue.ToString();
                bslayer.config.DTClientLocalReceiptPrinterIID = cmbLocalReceiptPrinter.SelectedValue.ToString();
            } catch { }
            UF.SaveConfig(bslayer.config);
            if (blnasModal) {
                this.DialogResult = DialogResult.OK;
                Close();
            }
                
        }

        private void chkAllPrinters_Click(object sender, EventArgs e) {
            LoadPrinters();
        }

        private void btnPrintTestPage_Click(object sender, EventArgs e) {
            if (dgv.SelectedRows.Count > 0) {
                string PrinterIID = dgv.SelectedRows[0].Cells["colPrinterIID"].Value.ToString();
                ApplicationPrinter ap = bslayer.GetPrinterForClient(PrinterIID);
                if (ap == null) {
                    MessageBox.Show("Configuration Eror: Printer Null");
                    return;
                }
                string str = "===========================================\r\n" +
                    ap.ApplicationName + "\r\n" +
                    ap.NetworkName + "\r\n" + "SUCCESS" + "\r\n" + 
                    "===========================================";


                PrintHandler pHand = new PrintHandler(bslayer, str, ap.NetworkName);
                pHand.PrintNow();

            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.Generate(true, true))
                exporter.ExportToFile();
        }

        private void chkAllPrinters_CheckedChanged(object sender, EventArgs e) {
            chkAllPrinters.Image = chkAllPrinters.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
        }

        private void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<ApplicationPrinter> printerList = bslayer.GetAllPrinters();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Printer List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(printerList, Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Printer List");
                        else
                            MessageBox.Show("Failed to Save Printer List");
                    }
                }
            }
        }

        private void btnImportFromJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
               // sfd.FileName = "Printer List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            List<ApplicationPrinter> printerList = JsonConvert.DeserializeObject<List<ApplicationPrinter>>(content);    
                            foreach (ApplicationPrinter printer in printerList)
                            {
                                bslayer.SavePrinter(printer);
                            }
                            
                            MessageBox.Show("Saved Printer List");                             
                        }  else
                        {
                            MessageBox.Show("Failed to Get Printer List");
                        }
                        LoadPrinters();
                    }
                }
            }
        }
    }
}
