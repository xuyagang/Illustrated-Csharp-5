using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_20_6_6_使用Lambda表达式参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lambda
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            var countOdd = intArray.Count(x => x % 2 == 1);
            Console.WriteLine(countOdd);
            Console.ReadKey();
            #endregion

            #region 匿名方法
            int[] intArray2 = { 1, 2, 3, 4, };
            // 匿名方法
            Func<int, bool> myDel = delegate(int x) { return x % 2 == 1; };
            var countOddd = intArray2.Count(myDel);
            Console.WriteLine(countOddd);
            Console.ReadKey();
            #endregion
        }
    }
}