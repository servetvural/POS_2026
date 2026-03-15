using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Models;

namespace DTRMNS {
    public partial class frmKitchenSingleDisplay : Form
    {
        private DTRMSimpleBusiness bslayer;
        private bool blnForSpecificDistribution;

        public frmKitchenSingleDisplay()
        {
            InitializeComponent();
        }
        public frmKitchenSingleDisplay(DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private async void frmKitchenDisplay_Load(object sender, EventArgs e)
        {
            if (!blnForSpecificDistribution)
            {
                ctlKitchen.Initiate(bslayer,await bslayer.GetFirstDisplayTypeList(), true);
                ctlKitchen.DisplayClock = bslayer.config.Show_Clock_in_Kitchen;
                ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChange;
                ctlKitchen.LoadAll();
            }
        }
        public  frmKitchenSingleDisplay(DTRMSimpleBusiness bslayer, string DistributionIID, bool CloseVisible, bool FullScreen)
        {
            InitializeComponent();
            this.bslayer = bslayer;
            if (FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            blnForSpecificDistribution = true;
            ctlKitchen.ChangeDistributionVisible = false;

            List<Distribution> theDistributionList = new List<Distribution>();
            theDistributionList.Add(bslayer.GetDistribution(DistributionIID).Result);
            ctlKitchen.Initiate(bslayer, theDistributionList, CloseVisible);
            //ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChangeWithoutSaving;
            //ctlKitchen.LoadAll();

        }



        private async void CtlKitchen_DisplayTypeWillBeChange()
        {
            frmDistributionSelector frm = new frmDistributionSelector(bslayer, true,await bslayer.GetFirstDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0)
                {
                    bslayer.config.Default_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(bslayer.config);
                    ctlKitchen.DistributionChanged(await bslayer.GetFirstDisplayTypeList());
                }
            }
        }

        private void ctlKitchen_Load(object sender, EventArgs e)
        {

        }
    }
}
