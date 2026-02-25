using System;
using System.Drawing;
using System.Windows.Forms;


namespace DTRMNS.Controls {
    public partial class ctlBonus : UserControl {
        private DTRMSimpleBusiness bslayer;
        private bool blnUpdating;


        public Font ControlFont {  get { return Font; } set { lblPrevious.Font = lblNext.Font = lblCiro.Font  = value; } }

       // public Font ProgressBarFont { get { return pBar.Font; } set { pBar.Font = value; } }
        public Color ControlBackColor {  get { return BackColor;  } set { lblPrevious.BackColor = lblNext.BackColor = lblCiro.BackColor =  BackColor = value; } }
        public Color ControlForeColor { get { return ForeColor; } set { pBar.ForeColor = lblPrevious.ForeColor = lblNext.ForeColor = lblCiro.ForeColor =  ForeColor = value; } }

       // public Color ProgressBarForeColor { get { return pBar.ForeColor; } set{ pBar.ForeColor = value; } } 

        public bool EnableAutoUpdate { get { return tmrMain.Enabled; } set { tmrMain.Enabled = value; } }

      //  public Size ProgressBarSize { get { return pBar.Size; } set { pBar.Size = value; } }

        public PosLibrary.DRProgressBar ProgressBar { get { return pBar; } }

        public int ProgressBarWidth {  get { return pBar.Width; }  set { pBar.Width = value; } }

        public ctlBonus() {
            InitializeComponent();
        }

        public void Activate(DTRMSimpleBusiness bslayer) {
            this.bslayer = bslayer;

            bslayer.SetSuitableBonus();

           
        }



        public void UpdateBonusDisplay() {
            blnUpdating = true;
            if (bslayer != null && bslayer.currentBonusScheme != null) {
                float ciro = bslayer.GetCurrentSessionXSum();
                //int previousBarrierNumber = bslayer.currentBonusScheme.GetPassedBarrierNumber(ciro);
                //int previousBarrierValue = bslayer.currentBonusScheme.GetPassedBarrierNumber(ciro);

                //int nextBarrierNumber = bslayer.currentBonusScheme.GetNextBarrierNumber(ciro);
                //int nextBarrierValue = bslayer.currentBonusScheme.GetNextBarrierValue(ciro);

                BonusStatus status = bslayer.currentBonusScheme.GetBonusStatus(ciro);


                if (bslayer.config.Display_Session_Total_On_Bonus_Bar)
                    lblCiro.Text = status.Ciro.ToString("C2");
                else
                    lblCiro.Text = "";
                lblPrevious.Text = status.PreviousBarrierNumber.ToString();
                lblNext.Text = status.NextBarrierNumber.ToString();
                pBar.Maximum = status.Difference;

                if (bslayer.config.Display_Progress_On_Bonus_Bar)
                    pBar.Value = status.AchievedDifference;
                pBar.ShowRemainingValueText = bslayer.config.Display_Remaining_Balance_On_Bonus_Bar;
                pBar.Visible = lblNext.Visible = bslayer.config.Display_Progress_Bar_On_Bonus_Bar;

                
            }
            else {
                lblPrevious.Text = lblNext.Text = "?";
                pBar.Maximum = 100;
                pBar.Value = 0;
            }
            blnUpdating = false;
        }

        private void tmrMain_Tick(object sender, EventArgs e) {
            if (!blnUpdating && bslayer != null)
                UpdateBonusDisplay();
        }

        private void ctlBonus_Click(object sender, EventArgs e) {
            if (!blnUpdating && bslayer != null) {
                bslayer.config = UF.GetConfig();
                UpdateBonusDisplay();
            }
        }

        private void pBar_Click(object sender, EventArgs e) {
            bslayer.config= UF.GetConfig();
            UpdateBonusDisplay();
        }

        private void lblPrevious_Click(object sender, EventArgs e) {
            bslayer.config = UF.GetConfig();
            UpdateBonusDisplay();
        }

        private void lblNext_Click(object sender, EventArgs e) {
            bslayer.config = UF.GetConfig();
            UpdateBonusDisplay();
        }

        private void lblCiro_Click(object sender, EventArgs e) {
            bslayer.config = UF.GetConfig();
            UpdateBonusDisplay();
        }
    }
}
