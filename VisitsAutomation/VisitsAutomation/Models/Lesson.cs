using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Lesson))
                return false;

            if (this == obj)
                return true;

            Lesson l = (Lesson)obj;

            if (!Name.Equals(l.Name))
                return false;
            if (!Type.Equals(l.Type))
                return false;

            return true;
        }
    }
}
