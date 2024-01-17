using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_10_元组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
            //Console.WriteLine("Prime numbers less than 20: " +
            //                  "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}, {8}",
            //                  primes.Item1, primes.Item2, primes.Item3,
            //                  primes.Item4, primes.Item5, primes.Item6,
            //                  primes.Item7, primes.Rest.Item1);


            // 使用构造函数
            var test1 = new Tuple<double, double, double, double, double, double>(0.03, 0.00, 0.20, 0.34, 0.52, 0.63);
            // 使用Create方法
            var test2 = Tuple.Create(0.03, 0.00, 0.20, 0.34, 0.52, 0.63, 0.36, 0.02);

            // 使用名称引用元素
            GlobalTemp gt = new GlobalTemp();
            var tdVTuple = gt.TempDifferentceUsingValueTupleCtor();
            Console.WriteLine($"使用数据：{tdVTuple.d2000}");

            tdVTuple = gt.TempDifferentceUsingValueTuple();
            Console.WriteLine($"使用数据：{tdVTuple.d1980}");

        }
    }

    class GlobalTemp
    {
        public (double d1960, double d1970, double d1980, double d1990, double d2000, double d2010)
            TempDifferentceUsingValueTupleCtor()
        {
            // 试用构造函数,类型必须写，否则会报错
            return new ValueTuple<double, double, double, double, double, double>(0.03, 0.00, 0.20, 0.34, 0.52, 0.63);
        }

        public (double d1960, double d1970, double d1980, double d1990, double d2000, double d2010)
            TempDifferentceUsingValueTuple()
        {
            return (0.03, 0.00, 0.20, 0.34, 0.52, 0.63);
        }
    }
}
