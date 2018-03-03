using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string FacultyName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Group))
                return false;

            if (this == obj)
                return true;

            Group g = (Group) obj;

            if (!Name.Equals(g.Name))
                return false;
            if (!DepartmentName.Equals(g.DepartmentName))
                return false;
            if (!FacultyName.Equals(g.FacultyName))
                return false;

            return true;
        }
    }
}
