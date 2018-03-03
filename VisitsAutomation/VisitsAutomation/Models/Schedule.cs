using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitsAutomation.Models
{
   public class Schedule
    {
        public int Id { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public int Number { get; set; }
        public DateTime Date { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
