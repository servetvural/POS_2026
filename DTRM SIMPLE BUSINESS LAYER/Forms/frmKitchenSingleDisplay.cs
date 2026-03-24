using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {
    public partial class frmKitchenSingleDisplay : Form
    {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        private bool blnForSpecificDistribution;

        public frmKitchenSingleDisplay()
        {
            InitializeComponent();
        }
        public frmKitchenSingleDisplay(PosConfig configAsService, DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
        }
        private async void frmKitchenDisplay_Load(object sender, EventArgs e)
        {
            if (!blnForSpecificDistribution)
            {
                ctlKitchen.Initiate(await bslayer.GetFirstDisplayTypeList(), true);
                ctlKitchen.DisplayClock = config.Show_Clock_in_Kitchen;
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
            ctlKitchen.Initiate( theDistributionList, CloseVisible);
            //ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChangeWithoutSaving;
            //ctlKitchen.LoadAll();

        }



        private async void CtlKitchen_DisplayTypeWillBeChange()
        {
           // if (await ServiceHelper.GetService<frmDistributionSelector>().ShowDialog() == DialogResult.OK) {
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(bslayer.sp, true,await bslayer.GetFirstDisplayTypeList());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Distribution> theList = frm.selectedDistributions;
                if (theList.Count > 0)
                {
                    config.Default_Distribution_Terminal_Type_List = bslayer.GetCommaSeperatedDistributionIIDListForDatabase(theList);
                    UF.SaveConfig(config);
                    ctlKitchen.DistributionChanged(await bslayer.GetFirstDisplayTypeList());
                }
            }
        }

        private void ctlKitchen_Load(object sender, EventArgs e)
        {

        }
    }
}
