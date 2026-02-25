using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmKitchenSingleDisplay : Form {
        private DTRMSimpleBusiness bslayer;
        private bool blnForSpecificDistribution;

        public frmKitchenSingleDisplay() {
            InitializeComponent();
        }
        public frmKitchenSingleDisplay(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private void frmKitchenDisplay_Load(object sender, EventArgs e) {
            if (!blnForSpecificDistribution) {
                ctlKitchen.Initiate(bslayer, bslayer.GetFirstDisplayTypeList(), true);
                ctlKitchen.DisplayClock = bslayer.config.Show_Clock_in_Kitchen;
                ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChange;
                ctlKitchen.LoadAll();
            }
        }
        public frmKitchenSingleDisplay(DTRMSimpleBusiness bslayer, string DistributionIID, bool CloseVisible, bool FullScreen) {
            InitializeComponent();
            this.bslayer = bslayer;
            if (FullScreen) {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            blnForSpecificDistribution = true;
            ctlKitchen.ChangeDistributionVisible = false;

            List<Distribution> theDistributionList = new List<Distribution>();
            theDistributionList.Add(bslayer.GetDistribution(DistributionIID));
            ctlKitchen.Initiate(bslayer, theDistributionList, CloseVisible);
            //ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChangeWithoutSaving;
            //ctlKitchen.LoadAll();
            
        }



        private void CtlKitchen_DisplayTypeWillBeChange() {
            frmDistributionSelector frm = new frmDistributionSelector(bslayer, true,bslayer.GetFirstDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK) {
                List<Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0) {
                    bslayer.config.Default_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(bslayer.config);
                    ctlKitchen.DistributionChanged(bslayer.GetFirstDisplayTypeList());
                }
            }           
        }
        

    }
}
