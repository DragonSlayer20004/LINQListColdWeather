using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{
    public class Weather
    {
        public DayOfWeek Day;
        public int HighTemp;
        public int LowTemp;

        public Weather(DayOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }
}
