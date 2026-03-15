using System;
using System.Windows.Forms;

using POSLayer.Library;

namespace DTRMNS {
   public partial class trmYnc : Form {
      public DialogTypes DialogType;
      public trmYnc() {
         InitializeComponent();
      }
      public trmYnc(string Text, string Caption, DialogTypes DialogType) {
         InitializeComponent();
         this.Text = Caption;
         pnlMain.Text = Text;
         this.DialogType = DialogType;
      }

      private void frmYnc_Load(object sender, EventArgs e) {
         switch (DialogType) {
            case DialogTypes.YesNoCancel:
               btnYes.Text = "YES";
               break;
            case DialogTypes.OkNoCancel:
               btnYes.Text = "OK";
               break;
            default:
               btnYes.Text = "YES";
               break;
         }
      }

      private void btnYes_Click(object sender, EventArgs e)
      {
         switch (DialogType) {
            case DialogTypes.YesNoCancel:
               this.DialogResult = DialogResult.Yes;
               break;
            case DialogTypes.OkNoCancel:
               this.DialogResult = DialogResult.OK;
               break;
            default:
               this.DialogResult = DialogResult.OK;
               break;
         }
         this.Close();
      }

      private void btnNo_Click(object sender, EventArgs e)
      {
         this.DialogResult = DialogResult.No;
         this.Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

      
   }
}