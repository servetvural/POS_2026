using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using WinLayer;

namespace WinKassa {
    public partial class frmMain : Form {
       
        public frmMain() {
            InitializeComponent();
        }

        private void frmKassaCalculator_Load(object sender, EventArgs e) {
            try {
                if (!UF.IsConfigFileExist()) {
                    if (!AskForConfig()) {

                        Close();
                        Application.Exit();
                    }
                }

                //bslayer.CustomInitialize( UF.GetConfig());
                //if (bslayer != null) {
                   
                //}
            } catch {
                AskForConfig();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnSettings_Click(object sender, EventArgs e) {
            AskForConfig();
        }

        private bool AskForConfig( ) {
            frmConfig frm = new frmConfig();
            if (frm.ShowDialog() == DialogResult.OK) {
               // bslayer.CustomInitialize(UF.GetConfig());
                return true;
            } else
                return false;

        }

        private void btnCalculator_Click(object sender, EventArgs e) {
            frmKassaCalculator frm = ActivatorUtilities.CreateInstance < frmKassaCalculator>(ServiceHelper.Services);
            frm.Show();
        }
    }
}
