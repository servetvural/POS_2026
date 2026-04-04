using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
   public partial class trmPrinterSelector : Form {
      public Printer SelectedPrinter;
      private PrinterTypes PrinterType;

      public trmPrinterSelector() {
         InitializeComponent();
      }
      public trmPrinterSelector( PrinterTypes PrinterType) {
         InitializeComponent();
            this.PrinterType = PrinterType;
         LoadPrinters();
      }

      private void LoadPrinters() {
         dgv.DataSource = DTRMSimpleBusiness.Instance.GetPrintersByPrinterType(PrinterType);
      }

      private async void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         SelectedPrinter = await DTRMSimpleBusiness.Instance.GetPrinterForClient(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
         this.DialogResult = DialogResult.OK;
         this.Close();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         SelectedPrinter = null;
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

       private void frmPrinterSelector_Load(object sender, EventArgs e) {

       }
   }
}