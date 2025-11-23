using System.Runtime.InteropServices;
using System.Globalization;


public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static readonly bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static TimeZoneInfo GetTimeZoneInfo(Location location)
    {
        return location switch
        {
            Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "Eastern Standard Time" : "America/New_York"),
            Location.London => TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "GMT Standard Time" : "Europe/London"),
            Location.Paris => TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "W. Europe Standard Time" : "Europe/Paris"),
            _ => throw new ArgumentOutOfRangeException(nameof(location), "Invalid location")
        };
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime localTime = DateTime.Parse(appointmentDateDescription);
        TimeZoneInfo timezone = GetTimeZoneInfo(location);

        return TimeZoneInfo.ConvertTimeToUtc(localTime, timezone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
            AlertLevel.Early => appointment.AddHours(-24),
            AlertLevel.Standard => appointment.AddMinutes(-105),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => throw new ArgumentOutOfRangeException(nameof(alertLevel), "Invalid alert level")
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo timezone = GetTimeZoneInfo(location);
        DateTime lastWeek = dt.AddDays(-7);

        return timezone.IsDaylightSavingTime(dt) != timezone.IsDaylightSavingTime(lastWeek);
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => throw new ArgumentOutOfRangeException(nameof(location), "Invalid location")
        };
        try
        {
            return DateTime.Parse(dtStr, culture);
        }
        catch (FormatException)
        {
            return new DateTime(1, 1, 1, 0, 0, 0);
        }
    }
}
