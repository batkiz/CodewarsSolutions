using System;

public class HumanTimeFormat
{
    public static string buildTime(int value, string unit)
    {
        if (value > 0)
        {
            return value + " " + unit + (value > 1 ? "s" : "") + ", ";
        }
        return "";
    }

    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
            return "now";

        var tmpSec = seconds;
        int MinSecs = 60;
        int HrSecs = MinSecs * 60;
        int DaySecs = HrSecs * 24;
        int YrSecs = DaySecs * 365;

        int years = tmpSec / YrSecs;
        tmpSec -= years * YrSecs;
        int days = tmpSec / DaySecs;
        tmpSec -= days * DaySecs;
        int hrs = tmpSec / HrSecs;
        tmpSec -= hrs * HrSecs;
        int mins = tmpSec / MinSecs;
        int secs = tmpSec - mins * MinSecs;

        string formattedStr = buildTime(years, "year")
                            + buildTime(days, "day")
                            + buildTime(hrs, "hour")
                            + buildTime(mins, "minute")
                            + buildTime(secs, "second");

        formattedStr = formattedStr.Substring(0, formattedStr.Length - 1);

        var idx = formattedStr.LastIndexOf(",");
        formattedStr = formattedStr.Substring(0, idx);

        idx = formattedStr.LastIndexOf(", ");
        if (idx > 0)
        {
            formattedStr = formattedStr.Substring(0, idx) + " and " + formattedStr.Substring(idx + 2);
        }
        return formattedStr;
    }
}

Console.WriteLine(HumanTimeFormat.formatDuration(12));