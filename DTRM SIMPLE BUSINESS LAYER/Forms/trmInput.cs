using System;
using System.Drawing;
using System.Windows.Forms;


namespace DTRMNS {
   public partial class trmInput : Form {
      public string input;
      public trmInput() {
         InitializeComponent();
      }
      public trmInput(string input) {
          InitializeComponent();
          this.input = input;
      }
      public trmInput(string input, string message) {
          InitializeComponent();
          this.input = input;
          lblMessage.Text = message;
      }
      private void frmInput_Load(object sender, EventArgs e) {
          txtInput.Text = input;
          txtInput.SelectAll();
      }
      private void btnClose_Click(object sender, EventArgs e)
      {
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (txtInput.Text.Trim().Length > 0) {
            input = txtInput.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
         }
      }

      private void txtInput_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
            btnOK_Click(sender, EventArgs.Empty);
      }

      private void btnKeyboard_Click(object sender, EventArgs e) {
           
          //keyboard.FloatingLocation = new Point(0,this.Location.Y + this.Size.Height);
          //keyboard.ShowKeyboard(this, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Floating);
      }

     
   }
}