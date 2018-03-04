using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Course { get; set; }
        public int Subgroup { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

       
    }
}
