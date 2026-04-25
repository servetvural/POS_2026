using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BSLayer {

    /// <summary>
    /// Define it in form 
    /// private frmSimpleProgress frmProg;
    /// 
    /// Call its creation in backgroundworker progress changed event.
    ///  if (frmProg == null) {
    ///            frmProg = new frmSimpleProgress(ref bgLoader);
    ///            frmProg.Show();
    ///            
    ///  }
    ///  Increment it in progress changed event
    ///   try {
    ///         if (frmProg != null) {
    ///             frmProg.ChangeMaximum(pBar.Maximum);
    ///             frmProg.SetValue(e.ProgressPercentage);
    ///         }
    ///     } catch(Exception ex) {
    ///         MessageBox.Show("Error " + ex.Message);
    ///     }
    ///     
    /// Destroy it in Workcompleted event
    ///  try {
    ///         frmProg.Close();
    ///         frmProg = null;
    ///     } catch (Exception ex) {
    ///         MessageBox.Show("Error " + ex.Message);
    ///     }
    /// </summary>
public partial class frmSimpleProgress : Form {
        private BackgroundWorker bg;
        public frmSimpleProgress(ref BackgroundWorker bg) {
            InitializeComponent();
            this.bg = bg;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            bg.CancelAsync();
            
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void SetValue(int progress) {
            if (progress > pBar.Maximum)
                pBar.Maximum = progress + (int)Math.Ceiling((progress) * 1.2);

            pBar.Value = progress;
        }

        public void Increment(int progress) {
            if (pBar.Value + progress > pBar.Maximum)
                pBar.Maximum = pBar.Value + progress + (int)Math.Ceiling((pBar.Value + progress) * 1.2);

            pBar.Value += progress;

        }
        public void ChangeMaximum(int newMaximum) {
            if (newMaximum > pBar.Maximum)
                pBar.Maximum = newMaximum;
        }

    }
}
