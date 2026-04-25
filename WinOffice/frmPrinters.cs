using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;
using POSLayer.Models;
using POSLayer.Library;
using WinLayer.Library;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Repository.IRepository;
using WinLayer;

namespace WinOffice
{
    public partial class frmPrinters : Form
    {
        PosConfig config;
        IRepository<Printer> repoPrinter;
        private bool blnasModal;

        private BindingSource _printerSource = new BindingSource();
        public frmPrinters()
        {
            InitializeComponent();
        }
        public frmPrinters(PosConfig configAsService, IRepository<Printer> _repoPrinter, bool asModal = false)
        {
            InitializeComponent();
            config = configAsService;
            repoPrinter = _repoPrinter;
            this.blnasModal = asModal;
            if (asModal)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
        }

        private async void frmPrinters_Load(object sender, EventArgs e)
        {
            await LoadPrinters();
        }

        private async Task LoadPrinters()
        {

            _printerSource.DataSource = await repoPrinter.GetAllAsync();
            dgv.DataSource = _printerSource;


            //try
            //{
            //    cmbDeliveryPrinter.DataSource = bslayer.GetAllPrinters();
            //    ApplicationPrinter ap = await bslayer.GetPrinterForOrderType(OrderTypes.Delivery);
            //    if (ap != null)
            //        cmbDeliveryPrinter.SelectedValue = ap.IID;
            //} catch { }

            //try
            //{
            //    cmbTakeAwayPrinter.DataSource = await bslayer.GetAllPrinters();
            //    ApplicationPrinter ap = await bslayer.GetPrinterForOrderType(OrderTypes.TakeAway);
            //    if (ap != null)
            //        cmbTakeAwayPrinter.SelectedValue = ap.IID;
            //} catch { }

            //try
            //{
            //    cmbCashDrawerPrinter.DataSource = bslayer.GetAllPrinters();
            //    if (config.DtPrinterCashDrawerIID != null && config.DtPrinterCashDrawerIID != "")
            //    {
            //        ApplicationPrinter ap = await bslayer.GetPrinterForClient(config.DtPrinterCashDrawerIID);
            //        if (ap != null)
            //            cmbCashDrawerPrinter.SelectedValue = ap.IID;
            //    }
            //} catch { }

            //try
            //{
            //    cmbLocalReceiptPrinter.DataSource = bslayer.GetAllPrinters();
            //    if (config.DTClientLocalReceiptPrinterIID != null && config.DTClientLocalReceiptPrinterIID != "")
            //    {
            //        ApplicationPrinter ap = await bslayer.GetPrinterForClient(config.DTClientLocalReceiptPrinterIID);
            //        if (ap != null)
            //            cmbLocalReceiptPrinter.SelectedValue = ap.IID;
            //    }
            //} catch { }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            frmPrinterDetails frm = ActivatorUtilities.CreateInstance<frmPrinterDetails>(ServiceHelper.Services, new Printer());
            if (frm.ShowDialog() == DialogResult.OK)
                await LoadPrinters();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmPrinterDetails frm = ActivatorUtilities.CreateInstance<frmPrinterDetails>(ServiceHelper.Services, (Printer)dgv.SelectedRows[0].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadPrinters();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("You are about to delete Printer from the system", "Delete Printer", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    await repoPrinter.Delete(((Printer)dgv.SelectedRows[0].DataBoundItem).IID);
                    await LoadPrinters();
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }


        private async void chkAllPrinters_Click(object sender, EventArgs e)
        {
            await LoadPrinters();
        }

        private async void btnPrintTestPage_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string PrinterIID = dgv.SelectedRows[0].Cells["colPrinterIID"].Value.ToString();
                Printer printer = await repoPrinter.GetByField("LocalTerminal", config.Terminal_Name);
                if (printer == null)
                {
                    MessageBox.Show("Configuration Eror: Printer Null");
                    return;
                }
                string str = "===========================================\r\n" +
                    printer.ApplicationName + "\r\n" +
                    printer.NetworkName + "\r\n" + "SUCCESS" + "\r\n" +
                    "===========================================";


                PrintHandler pHand = ActivatorUtilities.CreateInstance<PrintHandler>(ServiceHelper.Services, str, printer.NetworkName);
                pHand.PrintNow();

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(dgv);
            if (exporter.Generate(true, true))
                exporter.ExportToFile();
        }

        private async void btnExportAsJson_Click(object sender, EventArgs e)
        {
            List<Printer> printerList = await repoPrinter.GetAllAsync();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "Printer List.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        var jsonString = JsonConvert.SerializeObject(printerList, Formatting.Indented);
                        if (POSLayer.Library.UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Printer List");
                        else
                            MessageBox.Show("Failed to Save Printer List");
                    }
                }
            }
        }

        private async void btnImportFromJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                // sfd.FileName = "Printer List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = POSLayer.Library.UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            List<Printer> printerList = JsonConvert.DeserializeObject<List<Printer>>(content);
                            foreach (Printer printer in printerList)
                            {
                                await repoPrinter.Save(printer);
                            }

                            MessageBox.Show("Saved Printer List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Printer List");
                        }
                        LoadPrinters();
                    }
                }
            }
        }

        private async void tsSort_Click(object sender, EventArgs e)
        {
            await repoPrinter.Sort();
            await LoadPrinters();
        }

        private async void tsMoveUp_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoPrinter.MoveUp((Printer)dgv.SelectedRows[0].DataBoundItem);
                await LoadPrinters();
            }
        }

        private async void tsMoveDown_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoPrinter.MoveDown((Printer)dgv.SelectedRows[0].DataBoundItem);
                await LoadPrinters();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadPrinters();
        }
    }
}
