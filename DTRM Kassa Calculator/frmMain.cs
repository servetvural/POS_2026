using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;

namespace DTRM_Kassa_Calculator {
    public partial class frmMain : Form {
        private DTRMSimpleBusiness bslayer;
        public frmMain(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmKassaCalculator_Load(object sender, EventArgs e) {
            try {
                if (!UF.IsConfigFileExist()) {
                    if (!AskForConfig(null)) {

                        Close();
                        Application.Exit();
                    }
                }

                //bslayer.CustomInitialize( UF.GetConfig());
                //if (bslayer != null) {
                   
                //}
            } catch {
                AskForConfig(null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnSettings_Click(object sender, EventArgs e) {
            AskForConfig(bslayer);
        }

        private bool AskForConfig(DTRMSimpleBusiness testbslayer) {
            frmConfig frm = ActivatorUtilities.CreateInstance < frmConfig>(ServiceHelper.Services);
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
