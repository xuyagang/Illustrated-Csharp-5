using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_20_6_5_使用委托参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            // 使用方法IsOdd初始化委托对象
            Func<int, bool> myDel = new Func<int, bool>(IsOdd);
            // 使用委托
            var countOdd = intArray.Count(myDel);
            Console.WriteLine(countOdd);
            Console.ReadKey();
        }

        // 委托对象使用的方法
        static bool IsOdd(int x)
        {
            return x % 2 == 1;   // 如果x是奇返回true;   
        }
    }
}
