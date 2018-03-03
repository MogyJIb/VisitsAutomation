using System;
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
                    new Schedule{Id = 1, GroupId = 1, Date = new DateTime(2018,02,28), LessonId = 1, Number = 1},
                    new Schedule{Id = 2, GroupId = 1, Date = new DateTime(2018,02,28), LessonId = 2, Number = 2},
                    new Schedule{Id = 3, GroupId = 1, Date = new DateTime(2018,02,28), LessonId = 3, Number = 3},
                    new Schedule{Id = 4, GroupId = 1, Date = new DateTime(2018,02,28), LessonId = 4, Number = 4},

                    new Schedule{Id = 5, GroupId = 1, Date = new DateTime(2018,02,27), LessonId = 8, Number = 2},
                    new Schedule{Id = 6, GroupId = 1, Date = new DateTime(2018,02,27), LessonId = 9, Number = 3},
                    new Schedule{Id = 7, GroupId = 1, Date = new DateTime(2018,02,27), LessonId = 14, Number = 4},



                    new Schedule{Id = 8, GroupId = 2, Date = new DateTime(2018,02,28), LessonId = 5, Number = 1},
                    new Schedule{Id = 9, GroupId = 2, Date = new DateTime(2018,02,28), LessonId = 6, Number = 2},
                    new Schedule{Id = 10, GroupId = 2, Date = new DateTime(2018,02,28), LessonId = 9, Number = 3},

                    new Schedule{Id = 11, GroupId = 2, Date = new DateTime(2018,02,27), LessonId = 5, Number = 2},
                    new Schedule{Id = 12, GroupId = 2, Date = new DateTime(2018,02,27), LessonId = 4, Number = 3},
                    new Schedule{Id = 13, GroupId = 2, Date = new DateTime(2018,02,27), LessonId = 7, Number = 4},



                    new Schedule{Id = 14, GroupId = 3, Date = new DateTime(2018,02,28), LessonId = 1, Number = 3},
                    new Schedule{Id = 15, GroupId = 3, Date = new DateTime(2018,02,28), LessonId = 3, Number = 4},

                    new Schedule{Id = 16, GroupId = 3, Date = new DateTime(2018,02,27), LessonId = 2, Number = 2},
                    new Schedule{Id = 17, GroupId = 3, Date = new DateTime(2018,02,27), LessonId = 11, Number = 3},
                    new Schedule{Id = 18, GroupId = 3, Date = new DateTime(2018,02,27), LessonId = 10, Number = 4},



                    new Schedule{Id = 19, GroupId = 4, Date = new DateTime(2018,02,28), LessonId = 13, Number = 1},
                    new Schedule{Id = 20, GroupId = 4, Date = new DateTime(2018,02,28), LessonId = 12, Number = 2},

                    new Schedule{Id = 21, GroupId = 4, Date = new DateTime(2018,02,27), LessonId = 13, Number = 3},
                    new Schedule{Id = 22, GroupId = 4, Date = new DateTime(2018,02,27), LessonId = 5, Number = 4},
                    new Schedule{Id = 23, GroupId = 4, Date = new DateTime(2018,02,27), LessonId = 4, Number = 2},
                    new Schedule{Id = 24, GroupId = 4, Date = new DateTime(2018,02,27), LessonId = 8, Number = 3},
                    new Schedule{Id = 25, GroupId = 4, Date = new DateTime(2018,02,27), LessonId = 11, Number = 4},


                    
                    new Schedule{Id = 26, GroupId = 5, Date = new DateTime(2018,02,28), LessonId = 13, Number = 4},

                    new Schedule{Id = 27, GroupId = 5, Date = new DateTime(2018,02,27), LessonId = 1, Number = 2},
                    new Schedule{Id = 28, GroupId = 5, Date = new DateTime(2018,02,27), LessonId = 2, Number = 3},
                    new Schedule{Id = 29, GroupId = 5, Date = new DateTime(2018,02,27), LessonId = 6, Number = 4},



                    new Schedule{Id = 30, GroupId = 6, Date = new DateTime(2018,02,28), LessonId = 6, Number = 1},
                    new Schedule{Id = 31, GroupId = 6, Date = new DateTime(2018,02,28), LessonId = 6, Number = 4},
                    
                    new Schedule{Id = 32, GroupId = 6, Date = new DateTime(2018,02,27), LessonId = 14, Number = 3},
                    new Schedule{Id = 33, GroupId = 6, Date = new DateTime(2018,02,27), LessonId = 2, Number = 4},



                    new Schedule{Id = 34, GroupId = 7, Date = new DateTime(2018,02,28), LessonId = 3, Number = 1},
                    new Schedule{Id = 35, GroupId = 7, Date = new DateTime(2018,02,28), LessonId = 1, Number = 2},
                    new Schedule{Id = 36, GroupId = 7, Date = new DateTime(2018,02,28), LessonId = 10, Number = 3},
                    new Schedule{Id = 37, GroupId = 7, Date = new DateTime(2018,02,28), LessonId = 12, Number = 4},
                    
                    new Schedule{Id = 38, GroupId = 7, Date = new DateTime(2018,02,27), LessonId = 5, Number = 3},
                    new Schedule{Id = 39, GroupId = 7, Date = new DateTime(2018,02,27), LessonId = 3, Number = 4},



                    new Schedule{Id = 40, GroupId = 8, Date = new DateTime(2018,02,28), LessonId = 5, Number = 1},
                    new Schedule{Id = 41, GroupId = 8, Date = new DateTime(2018,02,28), LessonId = 5, Number = 2},
                    new Schedule{Id = 42, GroupId = 8, Date = new DateTime(2018,02,28), LessonId = 10, Number = 3},

                    new Schedule{Id = 43, GroupId = 8, Date = new DateTime(2018,02,27), LessonId = 9, Number = 4},
                    new Schedule{Id = 44, GroupId = 8, Date = new DateTime(2018,02,27), LessonId = 10, Number = 2},
                    new Schedule{Id = 45, GroupId = 8, Date = new DateTime(2018,02,27), LessonId = 9, Number = 3},
                    new Schedule{Id = 46, GroupId = 8, Date = new DateTime(2018,02,27), LessonId = 14, Number = 4},



                    new Schedule{Id = 47, GroupId = 9, Date = new DateTime(2018,02,28), LessonId = 13, Number = 1},
                    new Schedule{Id = 48, GroupId = 9, Date = new DateTime(2018,02,28), LessonId = 2, Number = 2},
                    new Schedule{Id = 49, GroupId = 9, Date = new DateTime(2018,02,28), LessonId = 4, Number = 4},
                    
                    new Schedule{Id = 50, GroupId = 9, Date = new DateTime(2018,02,27), LessonId = 2, Number = 4},

                });

            XmlFileWriter.Serialize(ConfigurationManager.AppSettings["absent"], fmCreate,
                new List<Absent>()
                {
                    new Absent{Id = 1, StudentId = 1, ScheduleId = 1, Cause = Absent.PRESENT},
                    new Absent{Id = 2, StudentId = 2, ScheduleId = 1, Cause = Absent.PRESENT},
                    new Absent{Id = 3, StudentId = 3, ScheduleId = 1, Cause = Absent.PRESENT},
                    new Absent{Id = 4, StudentId = 4, ScheduleId = 1, Cause = Absent.PRESENT},
                    new Absent{Id = 5, StudentId = 5, ScheduleId = 1, Cause = Absent.PRESENT},

                    new Absent{Id = 6, StudentId = 1, ScheduleId = 2, Cause = Absent.PRESENT},
                    new Absent{Id = 7, StudentId = 2, ScheduleId = 2, Cause = Absent.PRESENT},
                    new Absent{Id = 8, StudentId = 3, ScheduleId = 2, Cause = Absent.PRESENT},
                    new Absent{Id = 9, StudentId = 4, ScheduleId = 2, Cause = Absent.PRESENT},
                    new Absent{Id = 10, StudentId = 5, ScheduleId = 2, Cause = Absent.PRESENT},

                    new Absent{Id = 11, StudentId = 1, ScheduleId = 3, Cause = Absent.PRESENT},
                    new Absent{Id = 12, StudentId = 2, ScheduleId = 3, Cause = Absent.PRESENT},
                    new Absent{Id = 13, StudentId = 3, ScheduleId = 3, Cause = Absent.PRESENT},
                    new Absent{Id = 14, StudentId = 4, ScheduleId = 3, Cause = Absent.PRESENT},
                    new Absent{Id = 15, StudentId = 5, ScheduleId = 3, Cause = Absent.PRESENT},

                    new Absent{Id = 16, StudentId = 1, ScheduleId = 4, Cause = Absent.PRESENT},
                    new Absent{Id = 17, StudentId = 2, ScheduleId = 4, Cause = Absent.PRESENT},
                    new Absent{Id = 18, StudentId = 3, ScheduleId = 4, Cause = Absent.PRESENT},
                    new Absent{Id = 19, StudentId = 4, ScheduleId = 4, Cause = Absent.PRESENT},
                    new Absent{Id = 20, StudentId = 5, ScheduleId = 4, Cause = Absent.PRESENT},
                
                    new Absent{Id = 21, StudentId = 1, ScheduleId = 5, Cause = Absent.PRESENT},
                    new Absent{Id = 22, StudentId = 2, ScheduleId = 5, Cause = Absent.PRESENT},
                    new Absent{Id = 23, StudentId = 3, ScheduleId = 5, Cause = Absent.PRESENT},
                    new Absent{Id = 24, StudentId = 4, ScheduleId = 5, Cause = Absent.PRESENT},
                    new Absent{Id = 25, StudentId = 5, ScheduleId = 5, Cause = Absent.PRESENT},
                
                    new Absent{Id = 26, StudentId = 1, ScheduleId = 6, Cause = Absent.PRESENT},
                    new Absent{Id = 27, StudentId = 2, ScheduleId = 6, Cause = Absent.PRESENT},
                    new Absent{Id = 28, StudentId = 3, ScheduleId = 6, Cause = Absent.PRESENT},
                    new Absent{Id = 29, StudentId = 4, ScheduleId = 6, Cause = Absent.PRESENT},
                    new Absent{Id = 30, StudentId = 5, ScheduleId = 6, Cause = Absent.PRESENT},

                    new Absent{Id = 31, StudentId = 1, ScheduleId = 7, Cause = Absent.PRESENT},
                    new Absent{Id = 32, StudentId = 2, ScheduleId = 7, Cause = Absent.PRESENT},
                    new Absent{Id = 33, StudentId = 3, ScheduleId = 7, Cause = Absent.PRESENT},
                    new Absent{Id = 34, StudentId = 4, ScheduleId = 7, Cause = Absent.PRESENT},
                    new Absent{Id = 35, StudentId = 5, ScheduleId = 7, Cause = Absent.PRESENT},



                    new Absent{Id = 36, StudentId = 6, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 37, StudentId = 7, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 38, StudentId = 8, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 39, StudentId = 9, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 40, StudentId = 10, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 41, StudentId = 11, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 42, StudentId = 12, ScheduleId = 8, Cause = Absent.PRESENT},
                    new Absent{Id = 43, StudentId = 13, ScheduleId = 8, Cause = Absent.PRESENT},

                    new Absent{Id = 44, StudentId = 6, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 45, StudentId = 7, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 46, StudentId = 8, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 47, StudentId = 9, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 48, StudentId = 10, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 49, StudentId = 11, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 50, StudentId = 12, ScheduleId = 9, Cause = Absent.PRESENT},
                    new Absent{Id = 51, StudentId = 13, ScheduleId = 9, Cause = Absent.PRESENT},

                    new Absent{Id = 52, StudentId = 6, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 53, StudentId = 7, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 54, StudentId = 8, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 55, StudentId = 9, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 56, StudentId = 10, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 57, StudentId = 11, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 58, StudentId = 12, ScheduleId = 10, Cause = Absent.PRESENT},
                    new Absent{Id = 59, StudentId = 13, ScheduleId = 10, Cause = Absent.PRESENT},

                    new Absent{Id = 60, StudentId = 6, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 61, StudentId = 7, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 62, StudentId = 8, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 63, StudentId = 9, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 64, StudentId = 10, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 65, StudentId = 11, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 66, StudentId = 12, ScheduleId = 11, Cause = Absent.PRESENT},
                    new Absent{Id = 67, StudentId = 13, ScheduleId = 11, Cause = Absent.PRESENT},                    

                    new Absent{Id = 68, StudentId = 6, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 69, StudentId = 7, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 70, StudentId = 8, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 71, StudentId = 9, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 72, StudentId = 10, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 73, StudentId = 11, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 74, StudentId = 12, ScheduleId = 12, Cause = Absent.PRESENT},
                    new Absent{Id = 75, StudentId = 13, ScheduleId = 12, Cause = Absent.PRESENT},

                    new Absent{Id = 76, StudentId = 6, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 77, StudentId = 7, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 78, StudentId = 8, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 79, StudentId = 9, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 80, StudentId = 10, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 81, StudentId = 11, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 82, StudentId = 12, ScheduleId = 13, Cause = Absent.PRESENT},
                    new Absent{Id = 83, StudentId = 13, ScheduleId = 13, Cause = Absent.PRESENT},




                    new Absent{Id = 84, StudentId = 14, ScheduleId = 14, Cause = Absent.PRESENT},
                    new Absent{Id = 85, StudentId = 15, ScheduleId = 14, Cause = Absent.PRESENT},

                    new Absent{Id = 86, StudentId = 14, ScheduleId = 15, Cause = Absent.PRESENT},
                    new Absent{Id = 87, StudentId = 15, ScheduleId = 15, Cause = Absent.PRESENT},

                    new Absent{Id = 88, StudentId = 14, ScheduleId = 16, Cause = Absent.PRESENT},
                    new Absent{Id = 89, StudentId = 15, ScheduleId = 16, Cause = Absent.PRESENT},

                    new Absent{Id = 90, StudentId = 14, ScheduleId = 17, Cause = Absent.PRESENT},
                    new Absent{Id = 91, StudentId = 15, ScheduleId = 17, Cause = Absent.PRESENT},

                    new Absent{Id = 92, StudentId = 14, ScheduleId = 18, Cause = Absent.PRESENT},
                    new Absent{Id = 93, StudentId = 15, ScheduleId = 18, Cause = Absent.PRESENT},



                    new Absent{Id = 94, StudentId = 16, ScheduleId = 19, Cause = Absent.PRESENT},
                    new Absent{Id = 95, StudentId = 17, ScheduleId = 19, Cause = Absent.PRESENT},
                    new Absent{Id = 96, StudentId = 18, ScheduleId = 19, Cause = Absent.PRESENT},
                    new Absent{Id = 97, StudentId = 19, ScheduleId = 19, Cause = Absent.PRESENT},
                    new Absent{Id = 98, StudentId = 20, ScheduleId = 19, Cause = Absent.PRESENT},
                    new Absent{Id = 99, StudentId = 21, ScheduleId = 19, Cause = Absent.PRESENT},

                    new Absent{Id = 100, StudentId = 16, ScheduleId = 20, Cause = Absent.PRESENT},
                    new Absent{Id = 101, StudentId = 17, ScheduleId = 20, Cause = Absent.PRESENT},
                    new Absent{Id = 102, StudentId = 18, ScheduleId = 20, Cause = Absent.PRESENT},
                    new Absent{Id = 103, StudentId = 19, ScheduleId = 20, Cause = Absent.PRESENT},
                    new Absent{Id = 104, StudentId = 20, ScheduleId = 20, Cause = Absent.PRESENT},
                    new Absent{Id = 105, StudentId = 21, ScheduleId = 20, Cause = Absent.PRESENT},

                    new Absent{Id = 106, StudentId = 16, ScheduleId = 21, Cause = Absent.PRESENT},
                    new Absent{Id = 107, StudentId = 17, ScheduleId = 21, Cause = Absent.PRESENT},
                    new Absent{Id = 108, StudentId = 18, ScheduleId = 21, Cause = Absent.PRESENT},
                    new Absent{Id = 109, StudentId = 19, ScheduleId = 21, Cause = Absent.PRESENT},
                    new Absent{Id = 110, StudentId = 20, ScheduleId = 21, Cause = Absent.PRESENT},
                    new Absent{Id = 111, StudentId = 21, ScheduleId = 21, Cause = Absent.PRESENT},

                    new Absent{Id = 112, StudentId = 16, ScheduleId = 22, Cause = Absent.PRESENT},
                    new Absent{Id = 113, StudentId = 17, ScheduleId = 22, Cause = Absent.PRESENT},
                    new Absent{Id = 114, StudentId = 18, ScheduleId = 22, Cause = Absent.PRESENT},
                    new Absent{Id = 115, StudentId = 19, ScheduleId = 22, Cause = Absent.PRESENT},
                    new Absent{Id = 116, StudentId = 20, ScheduleId = 22, Cause = Absent.PRESENT},
                    new Absent{Id = 117, StudentId = 21, ScheduleId = 22, Cause = Absent.PRESENT},
                    
                    new Absent{Id = 118, StudentId = 16, ScheduleId = 23, Cause = Absent.PRESENT},
                    new Absent{Id = 119, StudentId = 17, ScheduleId = 23, Cause = Absent.PRESENT},
                    new Absent{Id = 120, StudentId = 18, ScheduleId = 23, Cause = Absent.PRESENT},
                    new Absent{Id = 121, StudentId = 19, ScheduleId = 23, Cause = Absent.PRESENT},
                    new Absent{Id = 122, StudentId = 20, ScheduleId = 23, Cause = Absent.PRESENT},
                    new Absent{Id = 123, StudentId = 21, ScheduleId = 23, Cause = Absent.PRESENT},

                    new Absent{Id = 124, StudentId = 16, ScheduleId = 24, Cause = Absent.PRESENT},
                    new Absent{Id = 125, StudentId = 17, ScheduleId = 24, Cause = Absent.PRESENT},
                    new Absent{Id = 126, StudentId = 18, ScheduleId = 24, Cause = Absent.PRESENT},
                    new Absent{Id = 127, StudentId = 19, ScheduleId = 24, Cause = Absent.PRESENT},
                    new Absent{Id = 128, StudentId = 20, ScheduleId = 24, Cause = Absent.PRESENT},
                    new Absent{Id = 129, StudentId = 21, ScheduleId = 24, Cause = Absent.PRESENT},

                    new Absent{Id = 130, StudentId = 16, ScheduleId = 25, Cause = Absent.PRESENT},
                    new Absent{Id = 131, StudentId = 17, ScheduleId = 25, Cause = Absent.PRESENT},
                    new Absent{Id = 132, StudentId = 18, ScheduleId = 25, Cause = Absent.PRESENT},
                    new Absent{Id = 133, StudentId = 19, ScheduleId = 25, Cause = Absent.PRESENT},
                    new Absent{Id = 134, StudentId = 20, ScheduleId = 25, Cause = Absent.PRESENT},
                    new Absent{Id = 135, StudentId = 21, ScheduleId = 25, Cause = Absent.PRESENT},




                    new Absent{Id = 136, StudentId = 22, ScheduleId = 26, Cause = Absent.PRESENT},
                    new Absent{Id = 137, StudentId = 23, ScheduleId = 26, Cause = Absent.PRESENT},
                    new Absent{Id = 138, StudentId = 24, ScheduleId = 26, Cause = Absent.PRESENT},
                    new Absent{Id = 139, StudentId = 25, ScheduleId = 26, Cause = Absent.PRESENT},

                    new Absent{Id = 140, StudentId = 22, ScheduleId = 27, Cause = Absent.PRESENT},
                    new Absent{Id = 141, StudentId = 23, ScheduleId = 27, Cause = Absent.PRESENT},
                    new Absent{Id = 142, StudentId = 24, ScheduleId = 27, Cause = Absent.PRESENT},
                    new Absent{Id = 143, StudentId = 25, ScheduleId = 27, Cause = Absent.PRESENT},

                    new Absent{Id = 144, StudentId = 22, ScheduleId = 28, Cause = Absent.PRESENT},
                    new Absent{Id = 145, StudentId = 23, ScheduleId = 28, Cause = Absent.PRESENT},
                    new Absent{Id = 146, StudentId = 24, ScheduleId = 28, Cause = Absent.PRESENT},
                    new Absent{Id = 147, StudentId = 25, ScheduleId = 28, Cause = Absent.PRESENT},

                    new Absent{Id = 148, StudentId = 22, ScheduleId = 29, Cause = Absent.PRESENT},
                    new Absent{Id = 149, StudentId = 23, ScheduleId = 29, Cause = Absent.PRESENT},
                    new Absent{Id = 150, StudentId = 24, ScheduleId = 29, Cause = Absent.PRESENT},
                    new Absent{Id = 151, StudentId = 25, ScheduleId = 29, Cause = Absent.PRESENT},




                    new Absent{Id = 152, StudentId = 26, ScheduleId = 30, Cause = Absent.PRESENT},
                    new Absent{Id = 153, StudentId = 27, ScheduleId = 30, Cause = Absent.PRESENT},
                    new Absent{Id = 154, StudentId = 28, ScheduleId = 30, Cause = Absent.PRESENT},
                    new Absent{Id = 155, StudentId = 29, ScheduleId = 30, Cause = Absent.PRESENT},
                    new Absent{Id = 156, StudentId = 30, ScheduleId = 30, Cause = Absent.PRESENT},

                    new Absent{Id = 157, StudentId = 26, ScheduleId = 31, Cause = Absent.PRESENT},
                    new Absent{Id = 158, StudentId = 27, ScheduleId = 31, Cause = Absent.PRESENT},
                    new Absent{Id = 159, StudentId = 28, ScheduleId = 31, Cause = Absent.PRESENT},
                    new Absent{Id = 160, StudentId = 29, ScheduleId = 31, Cause = Absent.PRESENT},
                    new Absent{Id = 161, StudentId = 30, ScheduleId = 31, Cause = Absent.PRESENT},

                    new Absent{Id = 162, StudentId = 26, ScheduleId = 32, Cause = Absent.PRESENT},
                    new Absent{Id = 163, StudentId = 27, ScheduleId = 32, Cause = Absent.PRESENT},
                    new Absent{Id = 164, StudentId = 28, ScheduleId = 32, Cause = Absent.PRESENT},
                    new Absent{Id = 165, StudentId = 29, ScheduleId = 32, Cause = Absent.PRESENT},
                    new Absent{Id = 166, StudentId = 30, ScheduleId = 32, Cause = Absent.PRESENT},

                    new Absent{Id = 167, StudentId = 26, ScheduleId = 33, Cause = Absent.PRESENT},
                    new Absent{Id = 168, StudentId = 27, ScheduleId = 33, Cause = Absent.PRESENT},
                    new Absent{Id = 169, StudentId = 28, ScheduleId = 33, Cause = Absent.PRESENT},
                    new Absent{Id = 170, StudentId = 29, ScheduleId = 33, Cause = Absent.PRESENT},
                    new Absent{Id = 171, StudentId = 30, ScheduleId = 33, Cause = Absent.PRESENT},





                    new Absent{Id = 172, StudentId = 31, ScheduleId = 34, Cause = Absent.PRESENT},
                    new Absent{Id = 173, StudentId = 32, ScheduleId = 34, Cause = Absent.PRESENT},
                    new Absent{Id = 174, StudentId = 33, ScheduleId = 34, Cause = Absent.PRESENT},
                    new Absent{Id = 175, StudentId = 34, ScheduleId = 34, Cause = Absent.PRESENT},
                    new Absent{Id = 176, StudentId = 35, ScheduleId = 34, Cause = Absent.PRESENT},

                    new Absent{Id = 177, StudentId = 31, ScheduleId = 35, Cause = Absent.PRESENT},
                    new Absent{Id = 178, StudentId = 32, ScheduleId = 35, Cause = Absent.PRESENT},
                    new Absent{Id = 179, StudentId = 33, ScheduleId = 35, Cause = Absent.PRESENT},
                    new Absent{Id = 180, StudentId = 34, ScheduleId = 35, Cause = Absent.PRESENT},
                    new Absent{Id = 181, StudentId = 35, ScheduleId = 35, Cause = Absent.PRESENT},

                    new Absent{Id = 182, StudentId = 31, ScheduleId = 36, Cause = Absent.PRESENT},
                    new Absent{Id = 183, StudentId = 32, ScheduleId = 36, Cause = Absent.PRESENT},
                    new Absent{Id = 184, StudentId = 33, ScheduleId = 36, Cause = Absent.PRESENT},
                    new Absent{Id = 185, StudentId = 34, ScheduleId = 36, Cause = Absent.PRESENT},
                    new Absent{Id = 186, StudentId = 35, ScheduleId = 36, Cause = Absent.PRESENT},

                    new Absent{Id = 187, StudentId = 31, ScheduleId = 37, Cause = Absent.PRESENT},
                    new Absent{Id = 188, StudentId = 32, ScheduleId = 37, Cause = Absent.PRESENT},
                    new Absent{Id = 189, StudentId = 33, ScheduleId = 37, Cause = Absent.PRESENT},
                    new Absent{Id = 190, StudentId = 34, ScheduleId = 37, Cause = Absent.PRESENT},
                    new Absent{Id = 191, StudentId = 35, ScheduleId = 37, Cause = Absent.PRESENT},

                    new Absent{Id = 192, StudentId = 31, ScheduleId = 38, Cause = Absent.PRESENT},
                    new Absent{Id = 193, StudentId = 32, ScheduleId = 38, Cause = Absent.PRESENT},
                    new Absent{Id = 194, StudentId = 33, ScheduleId = 38, Cause = Absent.PRESENT},
                    new Absent{Id = 195, StudentId = 34, ScheduleId = 38, Cause = Absent.PRESENT},
                    new Absent{Id = 196, StudentId = 35, ScheduleId = 38, Cause = Absent.PRESENT},

                    new Absent{Id = 197, StudentId = 31, ScheduleId = 39, Cause = Absent.PRESENT},
                    new Absent{Id = 198, StudentId = 32, ScheduleId = 39, Cause = Absent.PRESENT},
                    new Absent{Id = 199, StudentId = 33, ScheduleId = 39, Cause = Absent.PRESENT},
                    new Absent{Id = 200, StudentId = 34, ScheduleId = 39, Cause = Absent.PRESENT},
                    new Absent{Id = 201, StudentId = 35, ScheduleId = 39, Cause = Absent.PRESENT},





                    new Absent{Id = 202, StudentId = 36, ScheduleId = 40, Cause = Absent.PRESENT},
                    new Absent{Id = 203, StudentId = 37, ScheduleId = 40, Cause = Absent.PRESENT},
                    new Absent{Id = 204, StudentId = 38, ScheduleId = 40, Cause = Absent.PRESENT},
                    new Absent{Id = 205, StudentId = 39, ScheduleId = 40, Cause = Absent.PRESENT},
                    new Absent{Id = 206, StudentId = 40, ScheduleId = 40, Cause = Absent.PRESENT},

                    new Absent{Id = 207, StudentId = 36, ScheduleId = 41, Cause = Absent.PRESENT},
                    new Absent{Id = 208, StudentId = 37, ScheduleId = 41, Cause = Absent.PRESENT},
                    new Absent{Id = 209, StudentId = 38, ScheduleId = 41, Cause = Absent.PRESENT},
                    new Absent{Id = 210, StudentId = 39, ScheduleId = 41, Cause = Absent.PRESENT},
                    new Absent{Id = 211, StudentId = 40, ScheduleId = 41, Cause = Absent.PRESENT},

                    new Absent{Id = 212, StudentId = 36, ScheduleId = 42, Cause = Absent.PRESENT},
                    new Absent{Id = 213, StudentId = 37, ScheduleId = 42, Cause = Absent.PRESENT},
                    new Absent{Id = 214, StudentId = 38, ScheduleId = 42, Cause = Absent.PRESENT},
                    new Absent{Id = 215, StudentId = 39, ScheduleId = 42, Cause = Absent.PRESENT},
                    new Absent{Id = 216, StudentId = 40, ScheduleId = 42, Cause = Absent.PRESENT},

                    new Absent{Id = 217, StudentId = 36, ScheduleId = 43, Cause = Absent.PRESENT},
                    new Absent{Id = 218, StudentId = 37, ScheduleId = 43, Cause = Absent.PRESENT},
                    new Absent{Id = 219, StudentId = 38, ScheduleId = 43, Cause = Absent.PRESENT},
                    new Absent{Id = 220, StudentId = 39, ScheduleId = 43, Cause = Absent.PRESENT},
                    new Absent{Id = 221, StudentId = 40, ScheduleId = 43, Cause = Absent.PRESENT},

                    new Absent{Id = 222, StudentId = 36, ScheduleId = 44, Cause = Absent.PRESENT},
                    new Absent{Id = 223, StudentId = 37, ScheduleId = 44, Cause = Absent.PRESENT},
                    new Absent{Id = 224, StudentId = 38, ScheduleId = 44, Cause = Absent.PRESENT},
                    new Absent{Id = 225, StudentId = 39, ScheduleId = 44, Cause = Absent.PRESENT},
                    new Absent{Id = 226, StudentId = 40, ScheduleId = 44, Cause = Absent.PRESENT},
                
                    new Absent{Id = 227, StudentId = 36, ScheduleId = 45, Cause = Absent.PRESENT},
                    new Absent{Id = 228, StudentId = 37, ScheduleId = 45, Cause = Absent.PRESENT},
                    new Absent{Id = 229, StudentId = 38, ScheduleId = 45, Cause = Absent.PRESENT},
                    new Absent{Id = 230, StudentId = 39, ScheduleId = 45, Cause = Absent.PRESENT},
                    new Absent{Id = 231, StudentId = 40, ScheduleId = 45, Cause = Absent.PRESENT},

                    new Absent{Id = 232, StudentId = 36, ScheduleId = 46, Cause = Absent.PRESENT},
                    new Absent{Id = 233, StudentId = 37, ScheduleId = 46, Cause = Absent.PRESENT},
                    new Absent{Id = 234, StudentId = 38, ScheduleId = 46, Cause = Absent.PRESENT},
                    new Absent{Id = 235, StudentId = 39, ScheduleId = 46, Cause = Absent.PRESENT},
                    new Absent{Id = 236, StudentId = 40, ScheduleId = 46, Cause = Absent.PRESENT},




                    new Absent{Id = 237, StudentId = 41, ScheduleId = 47, Cause = Absent.PRESENT},
                    new Absent{Id = 238, StudentId = 42, ScheduleId = 47, Cause = Absent.PRESENT},
                    new Absent{Id = 239, StudentId = 43, ScheduleId = 47, Cause = Absent.PRESENT},
                    new Absent{Id = 240, StudentId = 44, ScheduleId = 47, Cause = Absent.PRESENT},
                    new Absent{Id = 241, StudentId = 45, ScheduleId = 47, Cause = Absent.PRESENT},

                    new Absent{Id = 242, StudentId = 41, ScheduleId = 48, Cause = Absent.PRESENT},
                    new Absent{Id = 243, StudentId = 42, ScheduleId = 48, Cause = Absent.PRESENT},
                    new Absent{Id = 244, StudentId = 43, ScheduleId = 48, Cause = Absent.PRESENT},
                    new Absent{Id = 245, StudentId = 44, ScheduleId = 48, Cause = Absent.PRESENT},
                    new Absent{Id = 246, StudentId = 45, ScheduleId = 48, Cause = Absent.PRESENT},

                    new Absent{Id = 247, StudentId = 41, ScheduleId = 49, Cause = Absent.PRESENT},
                    new Absent{Id = 248, StudentId = 42, ScheduleId = 49, Cause = Absent.PRESENT},
                    new Absent{Id = 249, StudentId = 43, ScheduleId = 49, Cause = Absent.PRESENT},
                    new Absent{Id = 250, StudentId = 44, ScheduleId = 49, Cause = Absent.PRESENT},
                    new Absent{Id = 251, StudentId = 45, ScheduleId = 49, Cause = Absent.PRESENT},

                    new Absent{Id = 252, StudentId = 41, ScheduleId = 50, Cause = Absent.PRESENT},
                    new Absent{Id = 253, StudentId = 42, ScheduleId = 50, Cause = Absent.PRESENT},
                    new Absent{Id = 254, StudentId = 43, ScheduleId = 50, Cause = Absent.PRESENT},
                    new Absent{Id = 255, StudentId = 44, ScheduleId = 50, Cause = Absent.PRESENT},
                    new Absent{Id = 256, StudentId = 45, ScheduleId = 50, Cause = Absent.PRESENT},
                });
        }
    }
}
