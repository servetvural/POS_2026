using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Bonus : BaseClass
{

    public string PlanName { get; set; } = null!;

    public string? PlanDescription { get; set; }

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

    public int DaysAvailable { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public double StepValue { get; set; }

    public double HalfStepValue { get; set; }

    public TimeOnly? BonusHiddenStartTime { get; set; }

    public TimeOnly? BonusHiddenEndTime { get; set; }
}
