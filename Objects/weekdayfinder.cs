using System.Collections.Generic;

namespace WeekdayFinder
{
  public class WeekdayFinder
  {
    private string[] _daysOfWeekNames = new string[] {"Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday"};
    public string GetDay(int day, int month, int year)
    {
      return _daysOfWeekNames[day % 7];
    }
  }
}
