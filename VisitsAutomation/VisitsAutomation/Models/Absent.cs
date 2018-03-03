using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
    public class Absent
    {
        public const string ABSENT =  "Absent";
        public const string PRESENT = "Present";
        public const string CAUSE = "Cause";

        public int Id { get; set; }
        public string Cause { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
