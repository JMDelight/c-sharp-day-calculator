using System;
using System.Collections.Generic;

namespace WeekdayFinder
{
  public class WeekdayFinder
  {
    private string[] _daysOfWeekNames = new string[] {"Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday"};
    private int[] _DaysPassedBeforeThisMonth = new int[] {-1, 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334};
    public string GetDay(int day, int month, int year)
    {
      int yearDays = 365 * (year - 1);
      yearDays += year/4; //leap year
      int totalDays = yearDays;
      totalDays += _DaysPassedBeforeThisMonth[month];
      totalDays += day;
      string dayName = _daysOfWeekNames[totalDays % 7];
      Console.WriteLine(day + " " + month + " " + year);
      Console.WriteLine(dayName);
      return dayName;
    }
  }
}
