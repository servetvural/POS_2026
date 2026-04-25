using System;
using System.Windows.Forms;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace BSLayer
{
    public partial class frmKitchenSingleDisplay : Form
    {
        PosConfig config;
        IRepository<Distribution> repoDistribution;


        private bool blnForSpecificDistribution;
        Distribution distribution;

        public frmKitchenSingleDisplay()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoDistribution = ServiceHelper.GetService<IRepository<Distribution>>();

        }

        public frmKitchenSingleDisplay(Distribution _distribution, bool CloseVisible, bool FullScreen)
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoDistribution = ServiceHelper.GetService<IRepository<Distribution>>();

            if (FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            blnForSpecificDistribution = true;
            ctlKitchen.ChangeDistributionVisible = false;

            distribution = _distribution;
            ctlKitchen.Initiate(distribution, CloseVisible);

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
            frmDistributionSelector frm = new frmDistributionSelector(await repoDistribution.Get(config.Default_Distribution_IID), config.ActiveMenuIID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                config.Default_Distribution_IID = frm.distribution.IID;
                UF.SaveConfig(config);
                ctlKitchen.DistributionChanged(frm.distribution);
            }
        }

        private void ctlKitchen_Load(object sender, EventArgs e)
        {

        }
    }
}
