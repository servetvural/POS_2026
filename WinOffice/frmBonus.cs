using System;
using System.Windows.Forms;
using WinLayer;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinOffice {
    public partial class frmBonus : Form {
        IRepository<Bonus> repoBonus;
        private Bonus bonus;

        private int[] vals = new int[21];          

        public frmBonus( Bonus bonus) {
            InitializeComponent();
            repoBonus = ServiceHelper.GetRepository<Bonus>();

            this.bonus = bonus;
        }

        private void frmBonus_Load(object sender, EventArgs e) {
            LoadBonus();
        }

        private void LoadBonus() {
            if (bonus != null) {
                txtPlanName.Text = bonus.PlanName;
                txtPlanDescription.Text = bonus.PlanDescription;
                txt0.Value = bonus.Barrier0;
                txt1.Value = bonus.Barrier1;
                txt2.Value = bonus.Barrier2;
                txt3.Value = bonus.Barrier3;
                txt4.Value = bonus.Barrier4;
                txt5.Value = bonus.Barrier5;
                txt6.Value = bonus.Barrier6;
                txt7.Value = bonus.Barrier7;
                txt8.Value = bonus.Barrier8;
                txt9.Value = bonus.Barrier9;
                txt10.Value = bonus.Barrier10;
                txt11.Value = bonus.Barrier11;
                txt12.Value = bonus.Barrier12;
                txt13.Value = bonus.Barrier13;
                txt14.Value = bonus.Barrier14;
                txt15.Value = bonus.Barrier15;
                txt16.Value = bonus.Barrier16;
                txt17.Value = bonus.Barrier17;
                txt18.Value = bonus.Barrier18;
                txt19.Value = bonus.Barrier19;
                txt20.Value = bonus.Barrier20;

                txtStepValue.Value = (decimal)bonus.StepValue;
                txtHalfStepValue.Value = (decimal)bonus.HalfStepValue;

                chkMonday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Monday);
                
                chkTuesday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Tuesday);
                chkWednesday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Wednesday);
                chkThursday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Thursday);
                chkFriday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Friday);
                chkSaturday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Saturday);
                chkSunday.Checked = UF.IsBitSet((int)bonus.DaysAvailable, (int)WeekDays.Sunday);

                lblTest.Text = UF.GetBonusDaysAsString((int)bonus.DaysAvailable);


                cmbStartTimeHour.SelectedIndex = bonus.StartTime.Hours;
                cmbStartTimeMinute.Text = bonus.StartTime.Minutes.ToString("D2");
                cmbEndTimeHour.SelectedIndex = bonus.EndTime.Hours;
                cmbEndTimeMinute.Text = bonus.EndTime.Minutes.ToString("D2");


                cmbBonusHideStartTimeHour.SelectedIndex = bonus.BonusHiddenStartTime.Hours;
                cmbBonusHideStartTimeMinute.Text = bonus.BonusHiddenStartTime.Minutes.ToString("D2");

                cmbBonusHideEndTimeHour.SelectedIndex = bonus.BonusHiddenEndTime.Hours;
                cmbBonusHideEndTimeMinute.Text = bonus.BonusHiddenEndTime.Minutes.ToString("D2");

                //rbDayTime.Checked = DRNumeric.IsBitSet((int)bonus.TimesAvailable, (int)DayPeriods.DayTime);
                //rbNightTime.Checked = DRNumeric.IsBitSet((int)bonus.TimesAvailable, (int)DayPeriods.NightTime);
                //rbAnyTime.Checked = DRNumeric.IsBitSet((int)bonus.TimesAvailable, (int)DayPeriods.AnyTime);

                LoadVals();
            }
        }

        

        private void LoadVals() {
            if (vals == null)
                vals = new int[21];

            vals[0] = bonus.Barrier0;
            vals[1] = bonus.Barrier1;
            vals[2] = bonus.Barrier2;
            vals[3] = bonus.Barrier3;
            vals[4] = bonus.Barrier4;
            vals[5] = bonus.Barrier5;
            vals[6] = bonus.Barrier6;
            vals[7] = bonus.Barrier7;
            vals[8] = bonus.Barrier8;
            vals[9] = bonus.Barrier9;
            vals[10] = bonus.Barrier10;
            vals[11] = bonus.Barrier11;
            vals[12] = bonus.Barrier12;
            vals[13] = bonus.Barrier13;
            vals[14] = bonus.Barrier14;
            vals[15] = bonus.Barrier15;
            vals[16] = bonus.Barrier16;
            vals[17] = bonus.Barrier17;
            vals[18] = bonus.Barrier18;
            vals[19] = bonus.Barrier19;
            vals[20] = bonus.Barrier20;

        }


        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (txtPlanName.Text.Length > 0) {
                bonus.PlanName = txtPlanName.Text;
                bonus.PlanDescription = txtPlanDescription.Text;
                bonus.Barrier0 = txt0.Value;
                bonus.Barrier1 = txt1.Value;
                bonus.Barrier2 = txt2.Value;
                bonus.Barrier3 = txt3.Value;
                bonus.Barrier4 = txt4.Value;
                bonus.Barrier5 = txt5.Value;
                bonus.Barrier6 = txt6.Value;
                bonus.Barrier7 = txt7.Value;
                bonus.Barrier8 = txt8.Value;
                bonus.Barrier9 = txt9.Value;
                bonus.Barrier10 = txt10.Value;
                bonus.Barrier11 = txt11.Value;
                bonus.Barrier12 = txt12.Value;
                bonus.Barrier13 = txt13.Value;
                bonus.Barrier14 = txt14.Value;
                bonus.Barrier15 = txt15.Value;
                bonus.Barrier16 = txt16.Value;
                bonus.Barrier17 = txt17.Value;
                bonus.Barrier18 = txt18.Value;
                bonus.Barrier19 = txt19.Value;
                bonus.Barrier20 = txt20.Value;

                bonus.StepValue = (float)txtStepValue.Value;
                bonus.HalfStepValue = (float)txtHalfStepValue.Value;

                int whichday = 0;
                if (chkMonday.Checked) whichday= UF.SetBit(whichday, (int)WeekDays.Monday);
                if (chkTuesday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Tuesday);
                if (chkWednesday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Wednesday);
                if (chkThursday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Thursday);
                if (chkFriday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Friday);
                if (chkSaturday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Saturday);
                if (chkSunday.Checked) whichday = UF.SetBit(whichday, (int)WeekDays.Sunday);
                bonus.DaysAvailable = (WeekDays)whichday;


                bonus.StartTime = new TimeSpan(int.Parse(cmbStartTimeHour.Text), int.Parse(cmbStartTimeMinute.Text), 0);
                bonus.EndTime = new TimeSpan(int.Parse(cmbEndTimeHour.Text), int.Parse(cmbEndTimeMinute.Text), 0);

                bonus.BonusHiddenStartTime = new TimeSpan(int.Parse(cmbBonusHideStartTimeHour.Text), int.Parse(cmbBonusHideStartTimeMinute.Text), 0);
                bonus.BonusHiddenEndTime = new TimeSpan(int.Parse(cmbBonusHideEndTimeHour.Text), int.Parse(cmbBonusHideEndTimeMinute.Text), 0);

                //int whichtime = 0;
                //if (rbDayTime.Checked) whichtime = DRNumeric.SetBit(whichtime, (int)DayPeriods.DayTime);
                //if (rbNightTime.Checked) whichtime = DRNumeric.SetBit(whichtime, (int)DayPeriods.NightTime);
                //if (rbAnyTime.Checked) whichtime = DRNumeric.SetBit(whichtime, (int)DayPeriods.AnyTime);
                //bonus.TimesAvailable = (DayPeriods)whichtime;

                int lastindex = 0;

                //Load barrier values to array to iterate
                LoadVals();

                //iterate ve sonuncu indexi bul (yani sifirdan buyuk son value nun indexi)
                for (int i = 20; i >= 0; i--) {
                    if (vals[i] > 0) {
                        lastindex = i;
                        break;
                    }
                }

                //Hepsi sifirsa olmaz
                for (int i = 20; i >= 0; i--) {
                    if (vals[i] > 0)
                        break;
                }

                //en azindan 1nci 1 den buyuk olmali
                int test = 0;
                for (int i = 0; i < 21; i++)
                    test += vals[i];
                if (test == 0) {
                    MessageBox.Show("At least one of the values should be bigger than 0");
                    return;
                }

                //en son value dan geri sayarak gelirsek index=0 ile index=lastindex arasi 0 value item olamaz
                for (int i = lastindex - 1; i > 0; i--) {
                    if (vals[i] == 0) {
                        MessageBox.Show("Values must increase step by step up till last item");
                        return;
                    }
                }

                //0 dan baslayip ileri sayarsak her bir value bir oncekinden buyuk olmali eger kucukse olmaz
                for (int i = 1; i <= lastindex; i++) {
                    if (vals[i - 1] >= vals[i]) {
                        MessageBox.Show("Values must increase constantly");

                        return;
                    }
                }

                //0 dan baslayip ileri sayarsak her bir value bir oncekinden buyuk olmali eger sonuncu value degilse



                if (await repoBonus.Save(bonus) != null) {                    

                    this.DialogResult = DialogResult.OK;
                    Close();
                }


            }
        }

        private void btnAddLinear_Click(object sender, EventArgs e) {
            frmIntegerInput frm = new frmIntegerInput();
            if (frm.ShowDialog() == DialogResult.OK) {
                if (frm.val > 0) {
                    int val = txt1.Value;
                    txt2.Value = val + (frm.val * 1);
                    txt3.Value = val + (frm.val * 2);
                    txt4.Value = val + (frm.val * 3);
                    txt5.Value = val + (frm.val * 4);
                    txt6.Value = val + (frm.val * 5);
                    txt7.Value = val + (frm.val * 6);
                    txt8.Value = val + (frm.val * 7);
                    txt9.Value = val + (frm.val * 8);
                    txt10.Value = val + (frm.val * 9);
                    txt11.Value = val + (frm.val * 10);
                    txt12.Value = val + (frm.val * 11);
                    txt13.Value = val + (frm.val * 12);
                    txt14.Value = val + (frm.val * 13);
                    txt15.Value = val + (frm.val * 14);
                    txt16.Value = val + (frm.val * 15);
                    txt17.Value = val + (frm.val * 16);
                    txt18.Value = val + (frm.val * 17);
                    txt19.Value = val + (frm.val * 18);
                    txt20.Value = val + (frm.val * 19);
                }
            }
        }

        private void chkEveryday_CheckedChanged(object sender, EventArgs e) {
            if (chkEveryday.Checked) {
                chkMonday.Checked = chkTuesday.Checked =
                chkWednesday.Checked = chkThursday.Checked =
                chkFriday.Checked = chkSaturday.Checked =
                chkSunday.Checked = true;
            }
        }

        private void chkNotAvailable_CheckedChanged(object sender, EventArgs e) {
            if (chkNotAvailable.Checked) {
                chkMonday.Checked = chkTuesday.Checked =
                chkWednesday.Checked = chkThursday.Checked =
                chkFriday.Checked = chkSaturday.Checked =
                chkSunday.Checked = false;
            }
        }

        private void btnNowTest_Click(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(int.Parse(cmbNowHour.Text), int.Parse(cmbNowMinute.Text), 0);
            if (!bonus.WithinRange(ts))
                lblNowTest.Text = "not in bonus scheme";
            else if (bonus.WithinInvisibleRange(ts))
            {
                lblNowTest.Text = "invisible";
            } else
            {
                lblNowTest.Text = "VISIBLE";
            }

            //remove this line 24 / 3 / 2024
            BSLayer.Instance.SetSuitableBonus();
        }
    }
}
