using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;


namespace DTRMNS.Controls {
    public partial class ctlBonus : UserControl {
        PosConfig config;

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
        }

        public void Activate() {           

             DTRMSimpleBusiness.Instance.SetSuitableBonus();              
        }

        public void UpdateBonusDisplay() {
            blnUpdating = true;
            if (ServiceHelper.Services != null && DTRMSimpleBusiness.Instance != null &&  DTRMSimpleBusiness.Instance.currentBonusScheme != null) {
                double ciro =  DTRMSimpleBusiness.Instance.GetCurrentSessionXSum();

                BonusStatus status =  DTRMSimpleBusiness.Instance.currentBonusScheme.GetBonusStatus(ciro);


                if (config.Display_Session_Total_On_Bonus_Bar)
                    lblCiro.Text = status.Ciro.ToString("C2");
                else
                    lblCiro.Text = "";
                lblPrevious.Text = status.PreviousBarrierNumber.ToString();
                lblNext.Text = status.NextBarrierNumber.ToString();
                pBar.Maximum = status.Difference;

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

        private void tmrMain_Tick(object sender, EventArgs e) {

            // Try to get the instance safely
            var business = DTRMSimpleBusiness.Instance;

            if (business != null && !blnUpdating)
            {
                UpdateBonusDisplay();
            }


            //if (!blnUpdating)
            //    UpdateBonusDisplay();
        }

        private void ctlBonus_Click(object sender, EventArgs e) {
            if (!blnUpdating) {
                UpdateBonusDisplay();
            }
        }

        private void pBar_Click(object sender, EventArgs e) {
            UpdateBonusDisplay();
        }

        private void lblPrevious_Click(object sender, EventArgs e) {
            UpdateBonusDisplay();
        }

        private void lblNext_Click(object sender, EventArgs e) {
            UpdateBonusDisplay();
        }

        private void lblCiro_Click(object sender, EventArgs e) {
            UpdateBonusDisplay();
        }
    }
}
