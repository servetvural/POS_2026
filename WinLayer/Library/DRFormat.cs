
namespace WinLayer;

public class DRFormat
{
    public DRFormat()
    {
    }

    #region ENCODING 
    public static string Encode(string str)
    {
        byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
        return Convert.ToBase64String(encbuff);
    }
    public static string Decode(string str)
    {
        byte[] decbuff = Convert.FromBase64String(str);
        return System.Text.Encoding.UTF8.GetString(decbuff);
    }
    #endregion

    #region DATETIME FORMATTING
    public static string GetFormattedSeconds(int seconds)
    {
        if (seconds > 0)
            return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, (seconds % 3600) / 60, seconds % 60);
        else
            return "00:00:00";
    }

    public static string GetFormattedSeconds(double seconds)
    {
        return GetFormattedSeconds((int)seconds);
    }

    public static string GetFormattedSeconds(string seconds)
    {
        int val = 0;
        try
        {
            val = int.Parse(seconds);
        } catch { }
        return GetFormattedSeconds(val);
    }

    public static string GetFormattedSeconds(TimeSpan diff)
    {
        return GetFormattedSeconds(diff.TotalSeconds);
    }

    public static string GetFormattedSeconds(DateTime FutureTime)
    {
        if (FutureTime > DateTime.Now)
        {
            return GetFormattedSeconds(FutureTime - DateTime.Now);
        } else
            return "00:00:00";
    }
    #endregion

    #region TEXT FORMATTING
    public static string Space(int count)
    {
        string str = "";
        for (int i = 0; i < count; i++)
            str += " ";
        return str;
    }
    #endregion
}
