using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Utils
{
    public class Comparator
    {
        public static bool Equal(DateTime one, DateTime two)
        {
            return one.Day == two.Day 
               && one.Month == two.Month
               && one.Year == two.Year;

        }
    }
}
