using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmKitchenDoubleDisplay : Form {
        private DTRMSimpleBusiness bslayer;
        public frmKitchenDoubleDisplay() {
            InitializeComponent();
        }
        public frmKitchenDoubleDisplay(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private async void frmKitchenDisplay_Load(object sender, EventArgs e) {
            ctlKitchenFirst.Initiate(bslayer,await bslayer.GetFirstDisplayTypeList(),false);
            ctlKitchenFirst.DisplayTypeWillBeChange += CtlKitchenFirst_DisplayTypeWillBeChange;
            ctlKitchenFirst.DisplayClock = bslayer.config.Show_Clock_in_Kitchen;
            ctlKitchenFirst.BonusControl.Visible = false;
            ctlKitchenFirst.OrderDeleted += CtlKitchenFirst_OrderDeleted;
            ctlKitchenFirst.LoadAll();

            ctlKitchenSecond.Initiate(bslayer,await bslayer.GetSecondDisplayTypeList(),true);
            ctlKitchenSecond.DisplayTypeWillBeChange += CtlKitchenSecond_DisplayTypeWillBeChange;
            ctlKitchenSecond.OrderDeleted += CtlKitchenSecond_OrderDeleted;
            if (bslayer.config.Display_Session_Bonus) {
                ctlKitchenSecond.BonusControl.Activate(bslayer);
                ctlKitchenSecond.BonusControl.Visible = true;
                ctlKitchenSecond.BonusControl.UpdateBonusDisplay();
            }
            ctlKitchenSecond.LoadAll();


            if (bslayer.config.OrderPad_Orientation == POSLayer.Library.OrientationTypes.Portrait) {
                splitMain.Orientation = Orientation.Horizontal;
            }
        }

        private void CtlKitchenSecond_OrderDeleted(string korderIID) {
            //Tell 1st display to remove OrderDisplay from completed section if it is there without loading all
            ctlKitchenFirst.RemoveCompletedOrderQuitely(korderIID);
        }

        private void CtlKitchenFirst_OrderDeleted(string korderIID) {
            //Tell 2nd display to remove OrderDisplay from completed section if it is there without loading all
            ctlKitchenSecond.RemoveCompletedOrderQuitely(korderIID);
        }

        private async void CtlKitchenFirst_DisplayTypeWillBeChange() {
            frmDistributionSelector frm = new frmDistributionSelector(bslayer, true, await bslayer.GetFirstDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK) {
                List<Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0) {
                    bslayer.config.Default_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(bslayer.config);
                    ctlKitchenFirst.DistributionChanged(await bslayer.GetFirstDisplayTypeList());
                }
            }
        }

        private async void CtlKitchenSecond_DisplayTypeWillBeChange() {
            frmDistributionSelector frm = new frmDistributionSelector(bslayer, true,await bslayer.GetSecondDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK) {
                List<POSLayer.Models.Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0) {
                    bslayer.config.Secondary_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(bslayer.config);
                    ctlKitchenSecond.DistributionChanged(await bslayer.GetSecondDisplayTypeList());

                }
            }
        }
    }
}
