using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
    public class DayList
    {
        private static string[] Days = new[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public static string Get(int i)
        {
            if (i >= 0 && i < Days.Length)
                return Days[i];
            else return Days[0];
        }
    }
}
