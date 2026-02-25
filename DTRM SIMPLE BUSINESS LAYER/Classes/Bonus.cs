using System;
using System.Data;
using PosLibrary;

namespace DTRMNS {
    public class Bonus {
        public string IID { get; set; } = ShortGuid.NewGuid().ToString();
        public string PlanName { get; set; } = "";
        public string PlanDescription { get; set; } = "";

        public float StepValue { get; set; }
        public float HalfStepValue { get; set; }

        public int Barrier0 { get; set; }
        public int Barrier1 { get; set; }
        public int Barrier2 { get; set; }
        public int Barrier3 { get; set; }
        public int Barrier4 { get; set; }
        public int Barrier5 { get; set; }
        public int Barrier6 { get; set; }
        public int Barrier7 { get; set; }
        public int Barrier8 { get; set; }
        public int Barrier9 { get; set; }
        public int Barrier10 { get; set; }
        public int Barrier11{ get; set; }
        public int Barrier12 { get; set; }
        public int Barrier13 { get; set; }
        public int Barrier14 { get; set; }
        public int Barrier15 { get; set; }
        public int Barrier16 { get; set; }
        public int Barrier17 { get; set; }
        public int Barrier18 { get; set; }
        public int Barrier19 { get; set; }
        public int Barrier20 { get; set; }

        public WeekDays DaysAvailable { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public TimeSpan BonusHiddenStartTime { get; set; }
        public TimeSpan BonusHiddenEndTime { get; set; }


        

        public Bonus() {
            
        }

        public Bonus(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                PlanName = dr["PlanName"].ToString();
                PlanDescription = dr["PlanDescription"].ToString();
                StepValue = float.Parse(dr["StepValue"].ToString());
                HalfStepValue = float.Parse(dr["HalfStepValue"].ToString());

                Barrier0 = int.Parse(dr["Barrier0"].ToString());
                Barrier1 = int.Parse(dr["Barrier1"].ToString());
                Barrier2 = int.Parse(dr["Barrier2"].ToString());
                Barrier3 = int.Parse(dr["Barrier3"].ToString());
                Barrier4 = int.Parse(dr["Barrier4"].ToString());
                Barrier5 = int.Parse(dr["Barrier5"].ToString());
                Barrier6 = int.Parse(dr["Barrier6"].ToString());
                Barrier7 = int.Parse(dr["Barrier7"].ToString());
                Barrier8 = int.Parse(dr["Barrier8"].ToString());
                Barrier9 = int.Parse(dr["Barrier9"].ToString());
                Barrier10 = int.Parse(dr["Barrier10"].ToString());
                Barrier11 = int.Parse(dr["Barrier11"].ToString());
                Barrier12 = int.Parse(dr["Barrier12"].ToString());
                Barrier13 = int.Parse(dr["Barrier13"].ToString());
                Barrier14 = int.Parse(dr["Barrier14"].ToString());
                Barrier15 = int.Parse(dr["Barrier15"].ToString());
                Barrier16 = int.Parse(dr["Barrier16"].ToString());
                Barrier17 = int.Parse(dr["Barrier17"].ToString());
                Barrier18 = int.Parse(dr["Barrier18"].ToString());
                Barrier19 = int.Parse(dr["Barrier19"].ToString());
                Barrier20 = int.Parse(dr["Barrier20"].ToString());

                DaysAvailable = (WeekDays)int.Parse(dr["DaysAvailable"].ToString());
                StartTime = TimeSpan.Parse(dr["StartTime"].ToString());
                EndTime = TimeSpan.Parse(dr["EndTime"].ToString());
                BonusHiddenStartTime = TimeSpan.Parse(dr["BonusHiddenStartTime"].ToString());
                BonusHiddenEndTime = TimeSpan.Parse(dr["BonusHiddenEndTime"].ToString());
                LoadVals();
            }
        }
        public Bonus(DataTable dt) {
            if (dt != null) {
                IID = dt.Rows[0]["IID"].ToString();
                PlanName = dt.Rows[0]["PlanName"].ToString();
                PlanDescription = dt.Rows[0]["PlanDescription"].ToString();
                StepValue = float.Parse(dt.Rows[0]["StepValue"].ToString());
                HalfStepValue = float.Parse(dt.Rows[0]["HalfStepValue"].ToString());

                Barrier0 = int.Parse(dt.Rows[0]["Barrier0"].ToString());
                Barrier1 = int.Parse(dt.Rows[0]["Barrier1"].ToString());
                Barrier2 = int.Parse(dt.Rows[0]["Barrier2"].ToString());
                Barrier3 = int.Parse(dt.Rows[0]["Barrier3"].ToString());
                Barrier4 = int.Parse(dt.Rows[0]["Barrier4"].ToString());
                Barrier5 = int.Parse(dt.Rows[0]["Barrier5"].ToString());
                Barrier6 = int.Parse(dt.Rows[0]["Barrier6"].ToString());
                Barrier7 = int.Parse(dt.Rows[0]["Barrier7"].ToString());
                Barrier8 = int.Parse(dt.Rows[0]["Barrier8"].ToString());
                Barrier9 = int.Parse(dt.Rows[0]["Barrier9"].ToString());
                Barrier10 = int.Parse(dt.Rows[0]["Barrier10"].ToString());
                Barrier11 = int.Parse(dt.Rows[0]["Barrier11"].ToString());
                Barrier12 = int.Parse(dt.Rows[0]["Barrier12"].ToString());
                Barrier13 = int.Parse(dt.Rows[0]["Barrier13"].ToString());
                Barrier14 = int.Parse(dt.Rows[0]["Barrier14"].ToString());
                Barrier15 = int.Parse(dt.Rows[0]["Barrier15"].ToString());
                Barrier16 = int.Parse(dt.Rows[0]["Barrier16"].ToString());
                Barrier17 = int.Parse(dt.Rows[0]["Barrier17"].ToString());
                Barrier18 = int.Parse(dt.Rows[0]["Barrier18"].ToString());
                Barrier19 = int.Parse(dt.Rows[0]["Barrier19"].ToString());
                Barrier20 = int.Parse(dt.Rows[0]["Barrier20"].ToString());

                DaysAvailable = (WeekDays)int.Parse(dt.Rows[0]["DaysAvailable"].ToString());
                StartTime = TimeSpan.Parse(dt.Rows[0]["StartTime"].ToString());
                EndTime = TimeSpan.Parse(dt.Rows[0]["EndTime"].ToString());
                try
                {
                    BonusHiddenStartTime = TimeSpan.Parse(dt.Rows[0]["BonusHiddenStartTime"].ToString());
                } catch
                {
                    BonusHiddenStartTime = StartTime;
                }
                try
                {
                    BonusHiddenEndTime = TimeSpan.Parse(dt.Rows[0]["BonusHiddenEndTime"].ToString());
                } catch
                {
                    BonusHiddenEndTime = EndTime;
                }


                LoadVals();
            }
        }

        private int[] vals;

        private void LoadVals() {
            if (vals == null)
                vals = new int[21];

            vals[0] = Barrier0;
            vals[1] = Barrier1;
            vals[2] = Barrier2;
            vals[3] = Barrier3;
            vals[4] = Barrier4;
            vals[5] = Barrier5;
            vals[6] = Barrier6;
            vals[7] = Barrier7;
            vals[8] = Barrier8;
            vals[9] = Barrier9;
            vals[10] = Barrier10;
            vals[11] = Barrier11;
            vals[12] = Barrier12;
            vals[13] = Barrier13;
            vals[14] = Barrier14;
            vals[15] = Barrier15;
            vals[16] = Barrier16;
            vals[17] = Barrier17;
            vals[18] = Barrier18;
            vals[19] = Barrier19;
            vals[20] = Barrier20;
        }

        public int GetPassedBarrierNumber(float ciro) {
            for (int i=1; i < vals.Length; i++) {
                if (vals[i] > ciro)
                    return i - 1;
            }
            return 20;
        }
        public int GetPassedBarrierValue(float ciro) {
            for (int i = 1; i < vals.Length; i++) {
                if (vals[i] > ciro)
                    return vals[i - 1];
            }
            return (int)ciro;
        }
        public int GetNextBarrierNumber(float ciro) {
            for (int i = 1; i < vals.Length; i++) {
                if (vals[i] > ciro)
                    return i;
            }
            return 20;
        }
        public int GetNextBarrierValue(float ciro) {
            for (int i = 1; i < vals.Length; i++) {
                if (vals[i] > ciro)
                    return vals[i];
            }
            return (int)ciro;
        }

        public BonusStatus GetBonusStatus(float ciro) {
            for (int i = 1; i < vals.Length; i++) {
                if (vals[i] == 0) {
                    //This is 1 after lastindex, return a special case 
                    return new BonusStatus(ciro, i - 1, vals[i - 1], i - 1, vals[i - 1]);
                }
                if (vals[i] > ciro) {
                    //i is the next barrier
                    return new BonusStatus(ciro, i - 1, vals[i - 1], i, vals[i]);
                }
            }
            //if you reach here and maximum is reached
            return new BonusStatus(ciro, 20, vals[20], 20, vals[20]);
           // return new BonusStatus(ciro, 0, 0, 0, 0);
        }

        public bool IsOverNight()
        {
            return StartTime > EndTime;
        }
        public bool IsInvisibleOverNight()
        {
            return BonusHiddenStartTime > BonusHiddenEndTime;
        }
        public bool WithinRange(TimeSpan ts)
        {
            if (IsOverNight())
            {
                TimeSpan Midnight = new TimeSpan(23, 59, 59);
                TimeSpan dayStart = new TimeSpan(0, 0, 0);
                return (ts >= StartTime && ts <= Midnight) || (ts >= dayStart && ts <= EndTime);
            } else
            {
                return ts >= StartTime && ts <= EndTime;
            }
        }
        public bool WithinInvisibleRange(TimeSpan ts)
        {
            if (IsInvisibleOverNight())
            {
                TimeSpan Midnight = new TimeSpan(23, 59, 59);
                TimeSpan dayStart = new TimeSpan(0, 0, 0);
                return (ts >= BonusHiddenStartTime && ts <= Midnight) || (ts >= dayStart && ts <= BonusHiddenEndTime);
            } else
            {
                return ts >= BonusHiddenStartTime && ts <= BonusHiddenEndTime;
            }
        }
    }

    public class BonusStatus {
        public float Ciro { get; set; }
        public int PreviousBarrierNumber { get; set; }
        public int PreviousBarrierValue { get; set; }
        public int NextBarrierNumber { get; set; }
        public int NextBarrrierValue { get; set; }
        public int Difference { get; set; }
        public int AchievedDifference { get; set; }
        public int TargetRequired { get; set; }

        public BonusStatus() {

        }
        public BonusStatus(float Ciro, int PreviousBarrierNumber, int PreviousBarrierValue, 
            int NextBarrierNumber, int NextBarrierValue) {
            this.Ciro = Ciro;
            this.PreviousBarrierNumber = PreviousBarrierNumber;
            this.PreviousBarrierValue = PreviousBarrierValue;
            this.NextBarrierNumber = NextBarrierNumber;
            this.NextBarrrierValue = NextBarrrierValue;

            Difference = NextBarrierValue - PreviousBarrierValue;
            AchievedDifference = (int)Ciro - PreviousBarrierValue;
            TargetRequired = Math.Max(0, NextBarrierValue - (int)Ciro);
        }
    }
}
