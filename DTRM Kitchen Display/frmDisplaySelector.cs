using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTRMNS;

using POSLayer.Library;

namespace DTRM_Kitchen_Display {
    public partial class frmDisplaySelector : Form {
        private DTRMSimpleBusiness bslayer;

        public frmDisplaySelector(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private void frmDisplaySelector_Load(object sender, EventArgs e) {
            
        }

        private void frmDisplaySelector_Shown(object sender, EventArgs e) {
            try {
                if (!UF.IsConfigFileExist()) {
                    if (!AskForConfig(null)) {

                        Close();
                        Application.Exit();
                    }
                }

                bslayer.CustomInitialize( UF.GetConfig());
                if (bslayer != null) {
                    switch (bslayer.config.Kitchen_Monitor_Auto_Display_Type) {
                        case POSLayer.Library.KitchenDisplayTypes.None:
                            break;
                        case POSLayer.Library.KitchenDisplayTypes.Single_Display:
                            btnSingle_Click(null, null);
                            break;
                        case POSLayer.Library.KitchenDisplayTypes.Double_Display:
                        case POSLayer.Library.KitchenDisplayTypes.Triple_Display:
                            btnDouble_Click(null, null);
                            break;
                        default:
                            break;
                    }
                }
            } catch {
                AskForConfig(null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSingle_Click(object sender, EventArgs e) {
            frmKitchenSingleDisplay frm = new frmKitchenSingleDisplay(bslayer);
            frm.Show();
        }

        private void btnDouble_Click(object sender, EventArgs e) {
            frmKitchenDoubleDisplay frm = new frmKitchenDoubleDisplay(bslayer);
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            AskForConfig(bslayer);
        }

        private bool  AskForConfig(DTRMSimpleBusiness testbslayer) {
            frmConfig frm = new frmConfig(testbslayer);
            if (frm.ShowDialog() == DialogResult.OK) {
                bslayer.CustomInitialize(UF.GetConfig());
                return true;
            } else
                return false;

        }

        
    }
}
