using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
    public class DayOfWeek
    {
        public const string Monday = "Monday",
            Tuesday = "Tuesday",
            Wednesday = "Wednesday",
            Thursday = "Thursday",
            Friday = "Friday",
            Saturday = "Saturday",
            Sunday = "Sunday";


        private static string[] Days = new[]
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        public static string Get(int i)
        {
            if (i >= 0 && i < Days.Length)
                return Days[i];
            else return Days[0];
        }

        public static int IndexOf(string day)
        {
            return Days.ToList().IndexOf(day);
        }
    }
}
