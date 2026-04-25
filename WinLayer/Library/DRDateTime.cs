
namespace WinLayer;
public class DRDateTime
{
    public DRDateTime()
    {
    }

    /// <summary>
    /// Returns MSSQL formatted datetime string, doesn't include (') quotes at the beginning and the end
    /// </summary>
    /// <param name="dt">DateTime object (this can be object, string or DateTime instance</param>
    /// <returns></returns>
    public static string DatetimeToMSSqlDatetime(object dt)
    {
        try
        {
            DateTime datetime = DateTime.Parse(dt.ToString());
            return datetime.Year + "/" + datetime.Month + "/" + datetime.Day + " " + datetime.Hour +
                ":" + datetime.Minute + ":" + datetime.Second;
        } catch
        {
            return "null";
        }
    }
    /// <summary>
    /// Returns MSSQL formatted datetime string, includes (') quotes at the beginning and the end
    /// </summary>
    /// <param name="dt">DateTime object (this can be object, string or DateTime instance</param>
    /// <returns></returns>
    public static string DatetimeToMSSqlDatetimeWithApostroph(object dt)
    {
        try
        {
            DateTime datetime = DateTime.Parse(dt.ToString());
            return "'" + datetime.Year + "/" + datetime.Month + "/" + datetime.Day + " " + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second + "'";
        } catch
        {
            return "null";
        }
    }

    public static string DatetimeToMSSql(object dt)
    {
        try
        {
            DateTime datetime = DateTime.Parse(dt.ToString());
            return "'" + datetime.Year + datetime.Month.ToString("D2") + datetime.Day.ToString("D2") + " " + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second + "'";
        } catch
        {
            return "null";
        }
    }


    /// <summary>
    /// Returns MSSQL formatted datetime string, doesn't include (') quotes at the beginning and the end
    /// </summary>
    /// <param name="datetime">Valid DateTime value</param>
    /// <returns></returns>
    public static string DatetimeToMSSqlDatetime(DateTime datetime)
    {
        return datetime.Year + "/" + datetime.Month + "/" + datetime.Day + " " + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
    }

    public static DateTime DateTimeToMidnight(DateTime dtime)
    {
        return new DateTime(dtime.Year, dtime.Month, dtime.Day, 23, 59, 59);
    }
    public static DateTime DateTimeToBegining(DateTime dtime)
    {
        return new DateTime(dtime.Year, dtime.Month, dtime.Day, 0, 0, 0);
    }
    public static DateTime GetFirstPastMondayFromDB()
    {
        DateTime today = DateTime.Now;
        int days = 0;
        switch (today.DayOfWeek)
        {
            case DayOfWeek.Monday:
                break;
            case DayOfWeek.Tuesday:
                days = (1 * 24);
                break;
            case DayOfWeek.Wednesday:
                days = (2 * 24);
                break;
            case DayOfWeek.Thursday:
                days = (3 * 24);
                break;
            case DayOfWeek.Friday:
                days = (4 * 24);
                break;
            case DayOfWeek.Saturday:
                days = (5 * 24);
                break;
            case DayOfWeek.Sunday:
                days = (6 * 24);
                break;
        }
        return today.Subtract(new TimeSpan(days, 0, 0));
    }
    
    public static DateTime GetLastDayOfThisMonth()
    {
        DateTime today = DateTime.Now;
        if (today.Month == 12)
        {
            //jump to next year
            DateTime FirstNextMonthDay = new DateTime(today.Year + 1, 1, 1, 0, 0, 0);
            return FirstNextMonthDay.Subtract(new TimeSpan(0, 0, 1));
        } else
        {
            DateTime FirstNextMonthDay = new DateTime(today.Year, today.Month + 1, 1, 0, 0, 0);
            return FirstNextMonthDay.Subtract(new TimeSpan(0, 0, 1));
        }
    }
    public static DateTime GetFirstDayOfLastMonth()
    {
        DateTime today = DateTime.Now;
        if (today.Month == 1)
        {
            return new DateTime(today.Year - 1, 12, 1, 0, 0, 0);
        } else
        {
            return new DateTime(today.Year, today.Month - 1, 1, 0, 0, 0);
        }
    }


    /// <summary>
    /// Gets total minutes from the beginning of the day to given datetime exp: 02:15 returns ==> 135 ==> (60+60 +15)
    /// </summary>
    /// <param name="dtime"></param>
    /// <returns></returns>
    public static int GetTimeEpsilon(DateTime dtime)
    {
        return (dtime.Hour * 60) + dtime.Minute;
    }
    /// <summary>
    /// Gets total minutes from the given hour and minutes exp: 2 hour 15 minutes, returns ==> 135 ==> (60+60 +15)
    /// </summary>
    /// <param name="dtime"></param>
    /// <returns></returns>
    public static int GetTimeEpsilonFromHourMinute(int Hour, int Minute)
    {
        return (Hour * 60) + Minute;
    }

    /// <summary>
    /// This function gives back the ResetDateTime for the Solva People counter based on the given 
    /// StartTime and Endtime. Normally this given StartTime = Session StartTime and EndTime= ReportTime or Now
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    public static DateTime GetRelatedResetDateTime(DateTime startTime, DateTime endTime, int PCResetHour, int PCResetMinute)
    {
        int StartEpsilon = GetTimeEpsilon(startTime);
        int EndEpsilon = GetTimeEpsilon(endTime);
        int ResetEpsilon = GetTimeEpsilonFromHourMinute(PCResetHour, PCResetMinute);


        if ((StartEpsilon <= ResetEpsilon) && (EndEpsilon <= ResetEpsilon))
        {
            //case: start is after 24:00 but before reset time 06:00 
            //      end is before or equal reset time e.g. 06:00
            return new DateTime(startTime.AddDays(-1).Year, startTime.AddDays(-1).Month, startTime.AddDays(-1).Day, PCResetHour, PCResetMinute, 0);
        } else
        {
            //case: the rest of it
            return new DateTime(startTime.Year, startTime.Month, startTime.Day, PCResetHour, PCResetMinute, 0);
        }

    }

    public static string GetTimeDisplayFromSeconds(int seconds, bool IncludeHours)
    {
        TimeSpan ts = new TimeSpan(0, 0, 0, seconds, 0);
        if (IncludeHours)
            return string.Format("{0:00}:{1:00}:{2:00}", ts.TotalHours, ts.Minutes, ts.Seconds);
        else
            return string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
    }


}
