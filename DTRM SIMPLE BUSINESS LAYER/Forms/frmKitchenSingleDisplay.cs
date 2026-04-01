using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMNS {
    public partial class frmKitchenSingleDisplay : Form
    {
        PosConfig config;
        IRepository<Distribution> repoDistribution;

        private DTRMSimpleBusiness bslayer;
        private bool blnForSpecificDistribution;

        Distribution distribution;
        public frmKitchenSingleDisplay()
        {
            InitializeComponent();
        }
        public frmKitchenSingleDisplay(PosConfig configAsService,IRepository<Distribution> _repoDistribution, DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            config = configAsService;
            repoDistribution = _repoDistribution;

            this.bslayer = bslayer;
        }
       
        public  frmKitchenSingleDisplay(PosConfig configAsService, IRepository<Distribution> _repoDistribution, DTRMSimpleBusiness bslayer, Distribution _distribution, bool CloseVisible, bool FullScreen)
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

            distribution =_distribution;
            ctlKitchen.Initiate( distribution, CloseVisible);

        }

        private async void frmKitchenDisplay_Load(object sender, EventArgs e)
        {
            if (!blnForSpecificDistribution)
            {
                ctlKitchen.Initiate(await repoDistribution.Get(config.Default_Distribution_IID), true);
                ctlKitchen.DisplayClock = config.Show_Clock_in_Kitchen;
                ctlKitchen.DisplayTypeWillBeChange += CtlKitchen_DisplayTypeWillBeChange;
                ctlKitchen.LoadAll();
            }
        }


        private async void CtlKitchen_DisplayTypeWillBeChange()
        {
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(bslayer.sp, true, await repoDistribution.Get(config.Default_Distribution_IID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                config.Default_Distribution_IID  = frm.distribution.IID;
                UF.SaveConfig(config);
                ctlKitchen.DistributionChanged(frm.distribution);                
            }
        }

        private void ctlKitchen_Load(object sender, EventArgs e)
        {

        }
    }
}
