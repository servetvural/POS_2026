
using POSLayer.Library;
namespace POSLayer.Models;

public partial class Bonus : BaseClass
{

    public string? ShopIID { get; set; }
    public Shop? Shop { get; set; }

    public string PlanName { get; set; } = string.Empty;

    public string PlanDescription { get; set; } = string.Empty;

    public double StepValue { get; set; }

    public double HalfStepValue { get; set; }

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

    public int Barrier11 { get; set; }

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


    private int[] vals;

    private void LoadVals()
    {
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

    public int GetPassedBarrierNumber(double ciro)
    {
        for (int i = 1; i < vals.Length; i++)
        {
            if (vals[i] > ciro)
                return i - 1;
        }
        return 20;
    }
    public int GetPassedBarrierValue(double ciro)
    {
        for (int i = 1; i < vals.Length; i++)
        {
            if (vals[i] > ciro)
                return vals[i - 1];
        }
        return (int)ciro;
    }
    public int GetNextBarrierNumber(double ciro)
    {
        for (int i = 1; i < vals.Length; i++)
        {
            if (vals[i] > ciro)
                return i;
        }
        return 20;
    }
    public int GetNextBarrierValue(double ciro)
    {
        for (int i = 1; i < vals.Length; i++)
        {
            if (vals[i] > ciro)
                return vals[i];
        }
        return (int)ciro;
    }

    public BonusStatus GetBonusStatus(double ciro)
    {
        for (int i = 1; i < vals.Length; i++)
        {
            if (vals[i] == 0)
            {
                //This is 1 after lastindex, return a special case 
                return new BonusStatus(ciro, i - 1, vals[i - 1], i - 1, vals[i - 1]);
            }
            if (vals[i] > ciro)
            {
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


public class BonusStatus
{
    public double Ciro { get; set; }
    public int PreviousBarrierNumber { get; set; }
    public int PreviousBarrierValue { get; set; }
    public int NextBarrierNumber { get; set; }
    public int NextBarrrierValue { get; set; }
    public int Difference { get; set; }
    public int AchievedDifference { get; set; }
    public int TargetRequired { get; set; }

    public BonusStatus()
    {

    }
    public BonusStatus(double Ciro, int PreviousBarrierNumber, int PreviousBarrierValue,
        int NextBarrierNumber, int NextBarrierValue)
    {
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