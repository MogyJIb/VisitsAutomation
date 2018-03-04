using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitsAutomation.Utils;

namespace VisitsAutomation.Models
{
    public class DataContext
    {
        public const string GROUP = "group";
        public const string STUDENT  = "student";
        public const string ABSENT  = "absent";
        public const string SCHEDULE = "schedule";
        public const string LESSON  = "lesson";

        public  List<Group> Groups { get; set; }
        public  List<Student> Students { get; set; }
        public  List<Absent> Absents { get; set; }
        public  List<Schedule> Schedules { get; set; }
        public  List<Lesson> Lessons { get; set; }

        public DataContext()
        {

            var fileName = ConfigurationManager.AppSettings[GROUP];
            Groups = (List<Group>)XmlFileReader.Deserialize(fileName, typeof(List<Group>));

            fileName = ConfigurationManager.AppSettings[STUDENT];
            Students = (List<Student>)XmlFileReader.Deserialize(fileName, typeof(List<Student>));

            fileName = ConfigurationManager.AppSettings[ABSENT];
            Absents = (List<Absent>)XmlFileReader.Deserialize(fileName, typeof(List<Absent>));

            fileName = ConfigurationManager.AppSettings[SCHEDULE];
            Schedules = (List<Schedule>)XmlFileReader.Deserialize(fileName, typeof(List<Schedule>));

            fileName = ConfigurationManager.AppSettings[LESSON];
            Lessons = (List<Lesson>)XmlFileReader.Deserialize(fileName, typeof(List<Lesson>));
        }

        public void SaveChanges(string name)
        {
            var fileName = ConfigurationManager.AppSettings[name];
            switch (name)
            {
                case GROUP:                 
                    XmlFileWriter.Serialize(fileName, FileMode.Create,Groups);
                    break;
                case SCHEDULE:
                    XmlFileWriter.Serialize(fileName, FileMode.Create, Schedules);
                    break;
                case STUDENT:
                    XmlFileWriter.Serialize(fileName, FileMode.Create, Students);
                    break;
                case LESSON:
                    XmlFileWriter.Serialize(fileName, FileMode.Create, Lessons);
                    break;
                case ABSENT:
                    XmlFileWriter.Serialize(fileName, FileMode.Create, Absents);
                    break;
            }
        }
    }
}
