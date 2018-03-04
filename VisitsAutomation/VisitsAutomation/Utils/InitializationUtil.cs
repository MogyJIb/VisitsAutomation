
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using VisitsAutomation.Models;

namespace VisitsAutomation.Utils
{
    class InitializationUtil
    {
        public static void Init()
        {
            FileMode fmCreate = FileMode.Create;

            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["group"], fmCreate,
                new List<Group>()
                {
                    new Group{Id = 1, Name = "IP-21", DepartmentName = "Informatics", FacultyName = "FAIS"},
                    new Group{Id = 2, Name = "IP-31", DepartmentName = "Informatics", FacultyName = "FAIS"},
                    new Group{Id = 3, Name = "EN-41", DepartmentName = "Theoretical Foundations of Electrical Engineering", FacultyName = "EF"},
                    new Group{Id = 4, Name = "IT-12", DepartmentName = "Information Technology", FacultyName = "FAIS"},
                    new Group{Id = 5, Name = "IT-31", DepartmentName = "Information Technology", FacultyName = "FAIS"},
                    new Group{Id = 6, Name = "ET-11", DepartmentName = "Theoretical Foundations of Electrical Engineering", FacultyName = "EF"},
                new Group{Id = 7, Name = "ET-32", DepartmentName = "Theoretical Foundations of Electrical Engineering", FacultyName = "EF"},
                new Group{Id = 8, Name = "IS-22", DepartmentName = "Industrial Electronics", FacultyName = "FAIS"},
                new Group{Id = 9, Name = "E-31", DepartmentName = "Economics", FacultyName = "HEF"}
                });

      
            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["student"], fmCreate,
                new List<Student>()
                {
                    new Student{Id = 1, GroupId = 1, Course = 2, FullName = "Eustace David", Subgroup = 2},
                    new Student{Id = 2, GroupId = 1, Course = 2, FullName = "Oliver Thomas", Subgroup = 1},
                    new Student{Id = 3, GroupId = 1, Course = 2, FullName = "Peter Anthony", Subgroup = 2},
                    new Student{Id = 4, GroupId = 1, Course = 2, FullName = "Lester Piers", Subgroup = 2},
                    new Student{Id = 5, GroupId = 1, Course = 2, FullName = "Jordan Fane", Subgroup = 1},
                    
                    new Student{Id = 6, GroupId = 2, Course = 3, FullName = "Macon Charlson", Subgroup = 2},
                    new Student{Id = 7, GroupId = 2, Course = 3, FullName = "Lorna Evans", Subgroup = 1},
                    new Student{Id = 8, GroupId = 2, Course = 3, FullName = "Benjamin Aldridge", Subgroup = 2},
                    new Student{Id = 9, GroupId = 2, Course = 3, FullName = "Cornelia Alsopp", Subgroup = 2},
                    new Student{Id = 10, GroupId = 2, Course = 3, FullName = "Tristan Enderson", Subgroup = 1},
                    new Student{Id = 11, GroupId = 2, Course = 3, FullName = "Debbie Goldman", Subgroup = 2},
                    new Student{Id = 12, GroupId = 2, Course = 3, FullName = "Gavin Williams", Subgroup = 1},
                    new Student{Id = 13, GroupId = 2, Course = 3, FullName = "Lally Birch", Subgroup = 2},

                    new Student{Id = 14, GroupId = 3, Course = 4, FullName = "David Hamphrey", Subgroup = 2},
                    new Student{Id = 15, GroupId = 3, Course = 4, FullName = "Jenny Barnes", Subgroup = 1},

                    new Student{Id = 16, GroupId = 4, Course = 1, FullName = "Thomas Goodman", Subgroup = 2},
                    new Student{Id = 17, GroupId = 4, Course = 1, FullName = "Jacob Dutton", Subgroup = 1},
                    new Student{Id = 18, GroupId = 4, Course = 1, FullName = "Marsha Blare", Subgroup = 2},
                    new Student{Id = 19, GroupId = 4, Course = 1, FullName = "Lewis Haig", Subgroup = 2},
                    new Student{Id = 20, GroupId = 4, Course = 1, FullName = "Amy Gustman", Subgroup = 1},
                    new Student{Id = 21, GroupId = 4, Course = 1, FullName = "Anthony Conors", Subgroup = 2},

                    new Student{Id = 22, GroupId = 5, Course = 3, FullName = "Katie Bargeman", Subgroup = 1},
                    new Student{Id = 23, GroupId = 5, Course = 3, FullName = "Sondra Flannagan", Subgroup = 2},
                    new Student{Id = 24, GroupId = 5, Course = 3, FullName = "Erika Matveenko", Subgroup = 2},
                    new Student{Id = 25, GroupId = 5, Course = 3, FullName = "Lally Galbraith", Subgroup = 1},

                    new Student{Id = 26, GroupId = 6, Course = 1, FullName = "Tiffany Brickman", Subgroup = 2},
                    new Student{Id = 27, GroupId = 6, Course = 1, FullName = "Jeremiah Donovan", Subgroup = 1},
                    new Student{Id = 28, GroupId = 6, Course = 1, FullName = "Bridget Bradberry", Subgroup = 2},
                    new Student{Id = 29, GroupId = 6, Course = 1, FullName = "Angel Bradberry", Subgroup = 2},
                    new Student{Id = 30, GroupId = 6, Course = 1, FullName = "Annabelle Fraser", Subgroup = 1},

                    new Student{Id = 31, GroupId = 7, Course = 3, FullName = "Alex Dutton", Subgroup = 2},
                    new Student{Id = 32, GroupId = 7, Course = 3, FullName = "Lucy Attwood", Subgroup = 1},
                    new Student{Id = 33, GroupId = 7, Course = 3, FullName = "Blak Phillips", Subgroup = 2},
                    new Student{Id = 34, GroupId = 7, Course = 3, FullName = "Nathan Parker", Subgroup = 2},
                    new Student{Id = 35, GroupId = 7, Course = 3, FullName = "Sondra Dutton", Subgroup = 1},

                    new Student{Id = 36, GroupId = 8, Course = 2, FullName = "Gabriel White", Subgroup = 2},
                    new Student{Id = 38, GroupId = 8, Course = 2, FullName = "Johanna Gilson", Subgroup = 1},
                    new Student{Id = 38, GroupId = 8, Course = 2, FullName = "Dominique Young", Subgroup = 2},
                    new Student{Id = 39, GroupId = 8, Course = 2, FullName = "Clover Nelson", Subgroup = 2},
                    new Student{Id = 40, GroupId = 8, Course = 2, FullName = "Jacob Francis", Subgroup = 1},

                    new Student{Id = 41, GroupId = 9, Course = 3, FullName = "Sherry Hardman", Subgroup = 2},
                    new Student{Id = 42, GroupId = 9, Course = 3, FullName = "Ryan Freeman", Subgroup = 1},
                    new Student{Id = 43, GroupId = 9, Course = 3, FullName = "Angel Miller", Subgroup = 2},
                    new Student{Id = 44, GroupId = 9, Course = 3, FullName = "Imogen Davis", Subgroup = 2},
                    new Student{Id = 45, GroupId = 9, Course = 3, FullName = "Tiffany Jackson", Subgroup = 1},
                });

            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["lesson"], fmCreate,
                new List<Lesson>()
                {
                    new Lesson{Id = 1, Name = "Mathematics",  Type = "practice"},
                    new Lesson{Id = 2, Name = "Mathematics",  Type = "lecture"},
                    new Lesson{Id = 3, Name = "Physics",  Type = "practice"},
                    new Lesson{Id = 4, Name = "Web",  Type = "lecture"},
                    new Lesson{Id = 5, Name = "Programming",  Type = "laboratory"},
                    new Lesson{Id = 6, Name = "English",  Type = "practice"},
                    new Lesson{Id = 7, Name = "BoAP",   Type = "lecture"},
                    new Lesson{Id = 8, Name = "BGCh",  Type = "practice"},
                    new Lesson{Id = 9, Name = "BGCh",  Type = "lecture"},
                    new Lesson{Id = 10, Name = "Economics",  Type = "practice"},
                    new Lesson{Id = 11, Name = "History",  Type = "lecture"},
                    new Lesson{Id = 12, Name = "TTD",  Type = "laboratory"},
                    new Lesson{Id = 13, Name = "Programming",  Type = "lecture"},
                    new Lesson{Id = 14, Name = "Physical Culture",  Type = "practice"}
                });

            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["schedule"], fmCreate,
                new List<Schedule>()
                {
                    new Schedule{Id = 1, GroupId = 1, Day = DayOfWeek.Monday, LessonId = 1, Number = 1},
                    new Schedule{Id = 2, GroupId = 1, Day = DayOfWeek.Monday, LessonId = 2, Number = 2},
                    new Schedule{Id = 3, GroupId = 1, Day = DayOfWeek.Monday, LessonId = 3, Number = 3},
                    new Schedule{Id = 4, GroupId = 1, Day = DayOfWeek.Monday, LessonId = 4, Number = 4},

                    new Schedule{Id = 5, GroupId = 1, Day = DayOfWeek.Tuesday, LessonId = 8, Number = 2},
                    new Schedule{Id = 6, GroupId = 1, Day = DayOfWeek.Tuesday, LessonId = 9, Number = 3},
                    new Schedule{Id = 7, GroupId = 1, Day = DayOfWeek.Tuesday, LessonId = 14, Number = 4},

                    new Schedule{Id = 8, GroupId = 1, Day = DayOfWeek.Wednesday, LessonId = 5, Number = 1},
                    new Schedule{Id = 9, GroupId = 1, Day = DayOfWeek.Wednesday, LessonId = 6, Number = 2},
                    new Schedule{Id = 10, GroupId = 1, Day = DayOfWeek.Wednesday, LessonId = 9, Number = 3},

                    new Schedule{Id = 11, GroupId = 1, Day = DayOfWeek.Thursday, LessonId = 5, Number = 2},
                    new Schedule{Id = 12, GroupId = 1, Day = DayOfWeek.Thursday, LessonId = 4, Number = 3},
                    new Schedule{Id = 13, GroupId = 1, Day = DayOfWeek.Thursday, LessonId = 7, Number = 4},

                    new Schedule{Id = 14, GroupId = 1, Day = DayOfWeek.Friday, LessonId = 1, Number = 3},
                    new Schedule{Id = 15, GroupId = 1, Day = DayOfWeek.Friday, LessonId = 3, Number = 4},




                    new Schedule{Id = 16, GroupId = 2, Day = DayOfWeek.Monday, LessonId = 2, Number = 2},
                    new Schedule{Id = 17, GroupId = 2, Day = DayOfWeek.Monday, LessonId = 11, Number = 3},
                    new Schedule{Id = 18, GroupId = 2, Day = DayOfWeek.Monday, LessonId = 10, Number = 4},
                    
                    new Schedule{Id = 19, GroupId = 2, Day = DayOfWeek.Tuesday, LessonId = 13, Number = 1},
                    new Schedule{Id = 20, GroupId = 2, Day = DayOfWeek.Tuesday, LessonId = 12, Number = 2},

                    new Schedule{Id = 21, GroupId = 2, Day = DayOfWeek.Wednesday, LessonId = 13, Number = 3},
                    new Schedule{Id = 22, GroupId = 2, Day = DayOfWeek.Wednesday, LessonId = 5, Number = 4},
                    new Schedule{Id = 23, GroupId = 2, Day = DayOfWeek.Wednesday, LessonId = 4, Number = 2},
                    new Schedule{Id = 24, GroupId = 2, Day = DayOfWeek.Wednesday, LessonId = 8, Number = 3},
                    new Schedule{Id = 25, GroupId = 2, Day = DayOfWeek.Wednesday, LessonId = 11, Number = 4},
                    
                    new Schedule{Id = 26, GroupId = 2, Day = DayOfWeek.Thursday, LessonId = 13, Number = 4},

                    new Schedule{Id = 27, GroupId = 2, Day = DayOfWeek.Friday, LessonId = 1, Number = 2},
                    new Schedule{Id = 28, GroupId = 2, Day = DayOfWeek.Friday, LessonId = 2, Number = 3},
                    new Schedule{Id = 29, GroupId = 2, Day = DayOfWeek.Friday, LessonId = 6, Number = 4},




                    new Schedule{Id = 30, GroupId = 3, Day = DayOfWeek.Monday, LessonId = 6, Number = 1},
                    new Schedule{Id = 31, GroupId = 3, Day = DayOfWeek.Monday, LessonId = 6, Number = 4},

                    new Schedule{Id = 32, GroupId = 3, Day = DayOfWeek.Tuesday, LessonId = 14, Number = 3},
                    new Schedule{Id = 33, GroupId = 3, Day = DayOfWeek.Tuesday, LessonId = 2, Number = 4},
                    
                    new Schedule{Id = 34, GroupId = 3, Day = DayOfWeek.Wednesday, LessonId = 3, Number = 1},
                    new Schedule{Id = 35, GroupId = 3, Day = DayOfWeek.Wednesday, LessonId = 1, Number = 2},
                    new Schedule{Id = 36, GroupId = 3, Day = DayOfWeek.Wednesday, LessonId = 10, Number = 3},
                    new Schedule{Id = 37, GroupId = 3, Day = DayOfWeek.Wednesday, LessonId = 12, Number = 4},

                    new Schedule{Id = 38, GroupId = 3, Day = DayOfWeek.Thursday, LessonId = 5, Number = 3},
                    new Schedule{Id = 39, GroupId = 3, Day = DayOfWeek.Thursday, LessonId = 3, Number = 4},
                    
                    new Schedule{Id = 40, GroupId = 3, Day = DayOfWeek.Friday, LessonId = 5, Number = 1},
                    new Schedule{Id = 41, GroupId = 3, Day = DayOfWeek.Friday, LessonId = 5, Number = 2},
                    new Schedule{Id = 42, GroupId = 3, Day = DayOfWeek.Friday, LessonId = 10, Number = 3},




                    new Schedule{Id = 43, GroupId = 4, Day = DayOfWeek.Monday, LessonId = 9, Number = 4},
                    new Schedule{Id = 44, GroupId = 4, Day = DayOfWeek.Monday, LessonId = 10, Number = 2},
                    new Schedule{Id = 45, GroupId = 4, Day = DayOfWeek.Monday, LessonId = 9, Number = 3},
                    new Schedule{Id = 46, GroupId = 4, Day = DayOfWeek.Monday, LessonId = 14, Number = 4},
                    
                    new Schedule{Id = 47, GroupId = 4, Day = DayOfWeek.Tuesday, LessonId = 13, Number = 1},
                    new Schedule{Id = 48, GroupId = 4, Day = DayOfWeek.Tuesday, LessonId = 2, Number = 2},
                    new Schedule{Id = 49, GroupId = 4, Day = DayOfWeek.Tuesday, LessonId = 4, Number = 4},

                    new Schedule{Id = 50, GroupId = 4, Day = DayOfWeek.Wednesday, LessonId = 2, Number = 4},

                    new Schedule{Id = 51, GroupId = 4, Day = DayOfWeek.Thursday, LessonId = 5, Number = 3},
                    new Schedule{Id = 52, GroupId = 4, Day = DayOfWeek.Thursday, LessonId = 3, Number = 4},

                    new Schedule{Id = 53, GroupId = 4, Day = DayOfWeek.Friday, LessonId = 5, Number = 1},
                    new Schedule{Id = 54, GroupId = 4, Day = DayOfWeek.Friday, LessonId = 5, Number = 2},
                    new Schedule{Id = 55, GroupId = 4, Day = DayOfWeek.Friday, LessonId = 10, Number = 3},



                    new Schedule{Id = 55, GroupId = 5, Day = DayOfWeek.Monday, LessonId = 1, Number = 1},
                    new Schedule{Id = 56, GroupId = 5, Day = DayOfWeek.Monday, LessonId = 2, Number = 2},
                    new Schedule{Id = 57, GroupId = 5, Day = DayOfWeek.Monday, LessonId = 3, Number = 3},
                    new Schedule{Id = 58, GroupId = 5, Day = DayOfWeek.Monday, LessonId = 4, Number = 4},

                    new Schedule{Id = 59, GroupId = 5, Day = DayOfWeek.Tuesday, LessonId = 8, Number = 2},
                    new Schedule{Id = 60, GroupId = 5, Day = DayOfWeek.Tuesday, LessonId = 9, Number = 3},
                    new Schedule{Id = 61, GroupId = 5, Day = DayOfWeek.Tuesday, LessonId = 14, Number = 4},

                    new Schedule{Id = 62, GroupId = 5, Day = DayOfWeek.Wednesday, LessonId = 5, Number = 1},
                    new Schedule{Id = 63, GroupId = 5, Day = DayOfWeek.Wednesday, LessonId = 6, Number = 2},
                    new Schedule{Id = 64, GroupId = 5, Day = DayOfWeek.Wednesday, LessonId = 9, Number = 3},

                    new Schedule{Id = 65, GroupId = 5, Day = DayOfWeek.Thursday, LessonId = 5, Number = 2},
                    new Schedule{Id = 66, GroupId = 5, Day = DayOfWeek.Thursday, LessonId = 4, Number = 3},
                    new Schedule{Id = 67, GroupId = 5, Day = DayOfWeek.Thursday, LessonId = 7, Number = 4},

                    new Schedule{Id = 68, GroupId = 5, Day = DayOfWeek.Friday, LessonId = 1, Number = 3},
                    new Schedule{Id = 69, GroupId = 5, Day = DayOfWeek.Friday, LessonId = 3, Number = 4},




                    new Schedule{Id = 70, GroupId = 6, Day = DayOfWeek.Monday, LessonId = 2, Number = 2},
                    new Schedule{Id = 71, GroupId = 6, Day = DayOfWeek.Monday, LessonId = 11, Number = 3},
                    new Schedule{Id = 72, GroupId = 6, Day = DayOfWeek.Monday, LessonId = 10, Number = 4},

                    new Schedule{Id = 73, GroupId = 6, Day = DayOfWeek.Tuesday, LessonId = 13, Number = 1},
                    new Schedule{Id = 74, GroupId = 6, Day = DayOfWeek.Tuesday, LessonId = 12, Number = 2},

                    new Schedule{Id = 75, GroupId = 6, Day = DayOfWeek.Wednesday, LessonId = 13, Number = 3},
                    new Schedule{Id = 76, GroupId = 6, Day = DayOfWeek.Wednesday, LessonId = 5, Number = 4},
                    new Schedule{Id = 77, GroupId = 6, Day = DayOfWeek.Wednesday, LessonId = 4, Number = 2},
                    new Schedule{Id = 78, GroupId = 6, Day = DayOfWeek.Wednesday, LessonId = 8, Number = 3},
                    new Schedule{Id = 79, GroupId = 6, Day = DayOfWeek.Wednesday, LessonId = 11, Number = 4},

                    new Schedule{Id = 80, GroupId = 6, Day = DayOfWeek.Thursday, LessonId = 13, Number = 4},

                    new Schedule{Id = 81, GroupId = 6, Day = DayOfWeek.Friday, LessonId = 1, Number = 2},
                    new Schedule{Id = 82, GroupId = 6, Day = DayOfWeek.Friday, LessonId = 2, Number = 3},
                    new Schedule{Id = 83, GroupId = 6, Day = DayOfWeek.Friday, LessonId = 6, Number = 4},




                    new Schedule{Id = 84, GroupId = 7, Day = DayOfWeek.Monday, LessonId = 6, Number = 1},
                    new Schedule{Id = 85, GroupId = 7, Day = DayOfWeek.Monday, LessonId = 6, Number = 4},

                    new Schedule{Id = 86, GroupId = 7, Day = DayOfWeek.Tuesday, LessonId = 14, Number = 3},
                    new Schedule{Id = 87, GroupId = 7, Day = DayOfWeek.Tuesday, LessonId = 2, Number = 4},

                    new Schedule{Id = 88, GroupId = 7, Day = DayOfWeek.Wednesday, LessonId = 3, Number = 1},
                    new Schedule{Id = 89, GroupId = 7, Day = DayOfWeek.Wednesday, LessonId = 1, Number = 2},
                    new Schedule{Id = 90, GroupId = 7, Day = DayOfWeek.Wednesday, LessonId = 10, Number = 3},
                    new Schedule{Id = 91, GroupId = 7, Day = DayOfWeek.Wednesday, LessonId = 12, Number = 4},

                    new Schedule{Id = 92, GroupId = 7, Day = DayOfWeek.Thursday, LessonId = 5, Number = 3},
                    new Schedule{Id = 93, GroupId = 7, Day = DayOfWeek.Thursday, LessonId = 3, Number = 4},

                    new Schedule{Id = 94, GroupId = 7, Day = DayOfWeek.Friday, LessonId = 5, Number = 1},
                    new Schedule{Id = 95, GroupId = 7, Day = DayOfWeek.Friday, LessonId = 5, Number = 2},
                    new Schedule{Id = 96, GroupId = 7, Day = DayOfWeek.Friday, LessonId = 10, Number = 3},




                    new Schedule{Id = 97, GroupId = 8, Day = DayOfWeek.Monday, LessonId = 9, Number = 4},
                    new Schedule{Id = 98, GroupId = 8, Day = DayOfWeek.Monday, LessonId = 10, Number = 2},
                    new Schedule{Id = 99, GroupId = 8, Day = DayOfWeek.Monday, LessonId = 9, Number = 3},
                    new Schedule{Id = 100, GroupId = 8, Day = DayOfWeek.Monday, LessonId = 14, Number = 4},

                    new Schedule{Id = 101, GroupId = 8, Day = DayOfWeek.Tuesday, LessonId = 13, Number = 1},
                    new Schedule{Id = 102, GroupId = 8, Day = DayOfWeek.Tuesday, LessonId = 2, Number = 2},
                    new Schedule{Id = 103, GroupId = 8, Day = DayOfWeek.Tuesday, LessonId = 4, Number = 4},

                    new Schedule{Id = 104, GroupId = 8, Day = DayOfWeek.Wednesday, LessonId = 2, Number = 4},

                    new Schedule{Id = 105, GroupId = 8, Day = DayOfWeek.Thursday, LessonId = 5, Number = 3},
                    new Schedule{Id = 106, GroupId = 8, Day = DayOfWeek.Thursday, LessonId = 3, Number = 4},

                    new Schedule{Id = 107, GroupId = 8, Day = DayOfWeek.Friday, LessonId = 5, Number = 1},
                    new Schedule{Id = 108, GroupId = 8, Day = DayOfWeek.Friday, LessonId = 5, Number = 2},
                    new Schedule{Id = 109, GroupId = 8, Day = DayOfWeek.Friday, LessonId = 10, Number = 3},


                    new Schedule{Id = 110, GroupId = 9, Day = DayOfWeek.Monday, LessonId = 2, Number = 2},
                    new Schedule{Id = 111, GroupId = 9, Day = DayOfWeek.Monday, LessonId = 11, Number = 3},
                    new Schedule{Id = 112, GroupId = 9, Day = DayOfWeek.Monday, LessonId = 10, Number = 4},

                    new Schedule{Id = 113, GroupId = 9, Day = DayOfWeek.Tuesday, LessonId = 13, Number = 1},
                    new Schedule{Id = 114, GroupId = 9, Day = DayOfWeek.Tuesday, LessonId = 12, Number = 2},

                    new Schedule{Id = 115, GroupId = 9, Day = DayOfWeek.Wednesday, LessonId = 13, Number = 3},
                    new Schedule{Id = 116, GroupId = 9, Day = DayOfWeek.Wednesday, LessonId = 5, Number = 4},
                    new Schedule{Id = 117, GroupId = 9, Day = DayOfWeek.Wednesday, LessonId = 4, Number = 2},
                    new Schedule{Id = 118, GroupId = 9, Day = DayOfWeek.Wednesday, LessonId = 8, Number = 3},
                    new Schedule{Id = 119, GroupId = 9, Day = DayOfWeek.Wednesday, LessonId = 11, Number = 4},

                    new Schedule{Id = 120, GroupId = 9, Day = DayOfWeek.Thursday, LessonId = 13, Number = 4},

                    new Schedule{Id = 121, GroupId = 9, Day = DayOfWeek.Friday, LessonId = 1, Number = 2},
                    new Schedule{Id = 122, GroupId = 9, Day = DayOfWeek.Friday, LessonId = 2, Number = 3},
                    new Schedule{Id = 123, GroupId = 9, Day = DayOfWeek.Friday, LessonId = 6, Number = 4},
                });

            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["absent"], fmCreate,
                new List<Absent>()
                {
                    
                });
        }
    }
}
