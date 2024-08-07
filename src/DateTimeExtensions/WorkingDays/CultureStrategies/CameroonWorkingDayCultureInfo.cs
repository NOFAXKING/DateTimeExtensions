using System;
using System.Collections.Generic;
using DateTimeExtensions;

public class CameroonWorkingDayCultureInfo : IWorkingDayCultureInfo
{
    public bool IsWorkingDay(DayOfWeek dayOfWeek)
    {
        // Cameroon working days are Monday to Friday
        return dayOfWeek >= DayOfWeek.Monday && dayOfWeek <= DayOfWeek.Friday;
    }

    public bool IsWorkingDay(DateTime date)
    {
        // Cameroon holidays
        var holidays = new List<DateTime>
        {
            new DateTime(date.Year, 1, 1), // New Year's Day
            new DateTime(date.Year, 5, 1), // Labour Day
            new DateTime(date.Year, 5, 20), // National Day
            new DateTime(date.Year, 8, 15), // Assumption of Mary
            new DateTime(date.Year, 12, 25), // Christmas Day
        };

        return !holidays.Contains(date.Date);
    }
}