using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{

    public enum DayOfWeek
    {
        Sun, Mon, Tues, Wed, Thurs, Fri, Sat
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> daysForcasted = new List<Weather>();
            daysForcasted.Add(new Weather(DayOfWeek.Tues, 36, 28));
            daysForcasted.Add(new Weather(DayOfWeek.Wed, 34, 29));
            daysForcasted.Add(new Weather(DayOfWeek.Thurs, 36, 26));
            daysForcasted.Add(new Weather(DayOfWeek.Fri, 37, 28));
            daysForcasted.Add(new Weather(DayOfWeek.Sat, 42, 33));

            var coldDays = from forecast in daysForcasted where forecast.HighTemp < 40 select forecast;

            foreach(var coldDay in coldDays)
            {
                Console.WriteLine("Cold weather on {0}",coldDay.Day);
            }
        }
    }
}
