using System.ComponentModel;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;


namespace WinLayer.Controls {
    public partial class ctlBonus : UserControl {
        PosConfig config;
        IRepository<Session> repoSession;

        private bool blnUpdating;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ControlFont {  get { return Font; } set { lblPrevious.Font = lblNext.Font = lblCiro.Font  = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ControlBackColor {  get { return BackColor;  } set { lblPrevious.BackColor = lblNext.BackColor = lblCiro.BackColor =  BackColor = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ControlForeColor { get { return ForeColor; } set { pBar.ForeColor = lblPrevious.ForeColor = lblNext.ForeColor = lblCiro.ForeColor =  ForeColor = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool EnableAutoUpdate { get { return tmrMain.Enabled; } set { tmrMain.Enabled = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public PosLibrary.DRProgressBar ProgressBar { get { return pBar; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ProgressBarWidth {  get { return pBar.Width; }  set { pBar.Width = value; } }

        public ctlBonus( ) {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
        }

        public void Activate() {           

             BSLayer.Instance.SetSuitableBonus();              
        }

        public async Task UpdateBonusDisplay() {
            blnUpdating = true;
            if (ServiceHelper.Services != null && BSLayer.Instance != null &&  BSLayer.Instance.shop.Bonus != null) {
                double ciro = await repoSession.GetSessionOrderTotal(BSLayer.Instance.shop.CurrentSessionIID);

                BonusStatus status =  BSLayer.Instance.shop.Bonus.GetBonusStatus(ciro);


                if (config.Display_Session_Total_On_Bonus_Bar)
                    lblCiro.Text = status.Ciro.ToString("C2");
                else
                    lblCiro.Text = "";
                lblPrevious.Text = status.PreviousBarrierNumber.ToString();
                lblNext.Text = status.NextBarrierNumber.ToString();
                pBar.Maximum = status.Difference == 0 ? status.AchievedDifference : status.Difference;

                if (config.Display_Progress_On_Bonus_Bar)
                    pBar.Value = status.AchievedDifference;
                pBar.ShowRemainingValueText = config.Display_Remaining_Balance_On_Bonus_Bar;
                pBar.Visible = lblNext.Visible = config.Display_Progress_Bar_On_Bonus_Bar;                 
            }
            else {
                lblPrevious.Text = lblNext.Text = "?";
                pBar.Maximum = 100;
                pBar.Value = 0;
            }
            blnUpdating = false;
        }

        private async void tmrMain_Tick(object sender, EventArgs e) {

            // Try to get the instance safely
            var business = BSLayer.Instance;

            if (business != null && !blnUpdating)
            {
                await UpdateBonusDisplay();
            }
        }

        private async void ctlBonus_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
               await  UpdateBonusDisplay();
            }
        }

        private async void pBar_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
                await UpdateBonusDisplay();
            }
        }

        private async void lblPrevious_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
                await UpdateBonusDisplay();
            }
        }

        private async void lblNext_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
                await UpdateBonusDisplay();
            }
        }

        private async void lblCiro_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
                await UpdateBonusDisplay();
            }
        }
    }
}
