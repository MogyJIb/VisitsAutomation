

namespace VisitsAutomation.Models
{
   public class Schedule
    {
        public int Id { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public int Number { get; set; }
        public string Day { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Schedule))
                return false;

            if (this == obj)
                return true;

            Schedule s = (Schedule)obj;
            
            if(!GroupId.Equals(s.GroupId))
                return false;
            if(!Number.Equals(s.Number))
                return false;
            if(!Day.Equals(s.Day))
                return false;

            return true;
        }
    }
}
