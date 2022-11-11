using System;

namespace C_26_7_空条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = null;

            //int studentCount = students.Length;
            //Student first = students[0];

            int? studentCount = students?.Length;
            Student first = students?[0];

        }
    }

    class Student
    {

    }
}
