using System;

public static class DateTimeExtensions
{
    public static DateTime StartOfWeek(this DateTime dateTime, DayOfWeek startOfWeek)
    {
        int diff = (7 + (dateTime.DayOfWeek - startOfWeek)) % 7;
        return dateTime.AddDays(-1 * diff).Date;
    }
}