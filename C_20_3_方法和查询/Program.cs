using System;
using System.Linq;

namespace C_20_3_方法和查询
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 28, 31, 17, 16, 48 };
            //using System.Linq;
            var numsQuery = from n in numbers                                   // 查询语法
                                         where n < 20
                                         select n;
            //where参数使用了lambda表达式
            var numsMethod = numbers.Where(n => n < 20);              // 方法语法

            int numsCount = (from n in numbers                                   // 两种形式的组合
                                         where n < 20
                                         select n).Count();

            foreach (var x in numsQuery)
                Console.Write($"{x}, ");
            Console.WriteLine();

            foreach (var x in numsMethod)
                Console.Write($"{x}, ");
            Console.WriteLine();

            Console.WriteLine(numsCount);
        }
    }
}
