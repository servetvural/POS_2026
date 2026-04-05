using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMNS {
    public partial class frmKitchenDoubleDisplay : Form {
        PosConfig config;
        IRepository<Distribution> repoDistribution;

        private DTRMSimpleBusiness bslayer;
        public frmKitchenDoubleDisplay(PosConfig configAsService, IRepository<Distribution> _repoDistribution) {
            InitializeComponent();
            config = configAsService;
            repoDistribution = _repoDistribution;

            bslayer = DTRMSimpleBusiness.Instance;
        }
        public frmKitchenDoubleDisplay(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private async void frmKitchenDisplay_Load(object sender, EventArgs e) {
            ctlKitchenFirst.Initiate(await repoDistribution.Get(config.Default_Distribution_IID), false);
            ctlKitchenFirst.DisplayTypeWillBeChange += CtlKitchenFirst_DisplayTypeWillBeChange;
            ctlKitchenFirst.DisplayClock = config.Show_Clock_in_Kitchen;
            ctlKitchenFirst.BonusControl.Visible = false;
            ctlKitchenFirst.OrderDeleted += CtlKitchenFirst_OrderDeleted;
            ctlKitchenFirst.LoadAll();

            ctlKitchenSecond.Initiate(await repoDistribution.Get(config.Secondary_Distribution_IID), true);
            ctlKitchenSecond.DisplayTypeWillBeChange += CtlKitchenSecond_DisplayTypeWillBeChange;
            ctlKitchenSecond.OrderDeleted += CtlKitchenSecond_OrderDeleted;
            if (config.Display_Session_Bonus) {
                ctlKitchenSecond.BonusControl.Activate();
                ctlKitchenSecond.BonusControl.Visible = true;
                ctlKitchenSecond.BonusControl.UpdateBonusDisplay();
            }
            ctlKitchenSecond.LoadAll();

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
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(ServiceHelper.Services, true, await repoDistribution.Get(config.Default_Distribution_IID));
            if (frm.ShowDialog() == DialogResult.OK) {
                config.Default_Distribution_IID = frm.distribution.IID;
                UF.SaveConfig(config);
                ctlKitchenFirst.DistributionChanged(frm.distribution);
            }
        }

        private async void CtlKitchenSecond_DisplayTypeWillBeChange() {
            frmDistributionSelector frm = ActivatorUtilities.CreateInstance< frmDistributionSelector>(ServiceHelper.Services, true, await repoDistribution.Get(config.Secondary_Distribution_IID));
            if (frm.ShowDialog() == DialogResult.OK) {
                config.Secondary_Distribution_IID = frm.distribution.IID;
                UF.SaveConfig(config);
                ctlKitchenSecond.DistributionChanged(frm.distribution);
            }
        }
    }
}
