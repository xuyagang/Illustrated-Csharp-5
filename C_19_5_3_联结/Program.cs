using System;
using System.Linq;

namespace C_19_5_3_联结
{
    class Program
    {
        public class Student            // 声明类
        {
            public int StID;
            public string LastName;
        }
        public class CourseStudent
        {
            public string CourseName;
            public int StID;
        }
        // 表1
        static Student[] students = new Student[]{
            new Student {StID = 1, LastName ="Carson"},
            new Student {StID = 2, LastName ="Klassen"},
            new Student{StID = 3, LastName ="Fleming"},
        };
        // 表2
        static CourseStudent[] studentsInCourses = new CourseStudent[]{
            new CourseStudent {CourseName ="Art", StID = 1},
            new CourseStudent {CourseName ="Art", StID = 2},
            new CourseStudent {CourseName ="History", StID = 1},
            new CourseStudent {CourseName ="History", StID = 3},
            new CourseStudent {CourseName ="Physics", StID = 3},
        };

        static void Main(string[] args)
        {
            // 选择历史课的学生姓
            var query = from s in students
                                join c in studentsInCourses on s.StID equals c.StID
                                where c.CourseName == "History"
                                select s.LastName;
            foreach (var q in query)
            {
                Console.WriteLine($"History - {q}");
            }
        }
    }
}
