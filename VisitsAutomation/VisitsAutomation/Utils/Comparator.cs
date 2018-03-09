using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Utils
{
   public  class Comparator
    {
        public static bool Equals(DateTime one, DateTime two)
        {
            return one.Year == two.Year && one.Month == two.Month && one.Day == two.Day;
        }
    }
}
