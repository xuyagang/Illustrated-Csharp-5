using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_5_3_空条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = null;
            int? studentCount = 5;

            if (students != null)   // 访问前进行检查
                studentCount = students.Length;   // 访问非空引用
            Console.WriteLine($"StudentCount:{studentCount}");

            // 对于引用变量，使用空条件运算符 ?. 方法其属性
            studentCount = students?.Length;
            Console.WriteLine($"StudentCount:{studentCount}");



            //int length = 3;
            //int strLength = length?.ToString();




        }
    }

    class Student { }
}
