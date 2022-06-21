using System;

namespace C_20_2_匿名类型
{
    class Other
    {
        static public string Name = "Mary Jones";
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var student = new { Name = "Mary Jones", Age = 19, Major = "History" };
        //    Console.WriteLine($"{student.Name}, Age {student.Age}, Major {student.Major}");
        //}

        static void Main()
        {
            string Major = "History";
            // 投影初始化语句
            var student = new { Age = 18, Other.Name, Major };
            Console.WriteLine($"{student.Name}, Age {student.Age}, Major: {Major}");
        }
    }
}