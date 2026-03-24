using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmKitchenDoubleDisplay : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        public frmKitchenDoubleDisplay(PosConfig configAsService, DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
        }
        public frmKitchenDoubleDisplay(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private async void frmKitchenDisplay_Load(object sender, EventArgs e) {
            ctlKitchenFirst.Initiate(await bslayer.GetFirstDisplayTypeList(),false);
            ctlKitchenFirst.DisplayTypeWillBeChange += CtlKitchenFirst_DisplayTypeWillBeChange;
            ctlKitchenFirst.DisplayClock = config.Show_Clock_in_Kitchen;
            ctlKitchenFirst.BonusControl.Visible = false;
            ctlKitchenFirst.OrderDeleted += CtlKitchenFirst_OrderDeleted;
            ctlKitchenFirst.LoadAll();

            ctlKitchenSecond.Initiate(await bslayer.GetSecondDisplayTypeList(),true);
            ctlKitchenSecond.DisplayTypeWillBeChange += CtlKitchenSecond_DisplayTypeWillBeChange;
            ctlKitchenSecond.OrderDeleted += CtlKitchenSecond_OrderDeleted;
            if (config.Display_Session_Bonus) {
                ctlKitchenSecond.BonusControl.Activate();
                ctlKitchenSecond.BonusControl.Visible = true;
                ctlKitchenSecond.BonusControl.UpdateBonusDisplay();
            }
            ctlKitchenSecond.LoadAll();


            if (config.OrderPad_Orientation == POSLayer.Library.OrientationTypes.Portrait) {
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
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(bslayer.sp, true, await bslayer.GetFirstDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK) {
                List<Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0) {
                    config.Default_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(config);
                    ctlKitchenFirst.DistributionChanged(await bslayer.GetFirstDisplayTypeList());
                }
            }
        }

        private async void CtlKitchenSecond_DisplayTypeWillBeChange() {
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(bslayer.sp, true,await bslayer.GetSecondDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK) {
                List<POSLayer.Models.Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0) {
                    config.Secondary_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(config);
                    ctlKitchenSecond.DistributionChanged(await bslayer.GetSecondDisplayTypeList());

                }
            }
        }
    }
}
