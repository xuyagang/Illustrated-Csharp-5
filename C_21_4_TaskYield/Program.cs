using System;
using System.Threading.Tasks;

namespace C_21_4_TaskYield
{
    static class DoStuff
    {
        /// <summary>
        /// 异步方法，程序没执行某个循环1000次就移交一次控制权
        /// </summary>
        public static async Task<int> FindSeriesSum(int i1)
        {
            Console.WriteLine("FindSeriesSum");
            int sum = 0;
            for(int i=0; i<i1; i++)
            {
                sum += i;
                if (i%1000 ==0)   
                {
                    await Task.Yield();
                    Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
                }
            }
            return sum;
        }
        public static async Task<int> FindSeriesSum2(int i1)
        {
            Console.WriteLine("FindSeriesSum2");
            int sum = 0;
            for (int i = 0; i < i1; i++)
            {
                sum += i;
                if (i % 2000 == 0)
                {
                    await Task.Yield();
                }
            }
            return sum;
        }

        public static int FindSeriesSum3(int i1)
        {
            int sum = 0;
            for (int i = 0; i < i1; i++)
            {
                sum += i;
                if (i % 2000 == 0)
                {
                }
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task<int> value = DoStuff.FindSeriesSum(1000000);
            //Task<int> value2 = DoStuff.FindSeriesSum2(1000000);
            //int value3 = DoStuff.FindSeriesSum3(1000000);
            
            Console.WriteLine("Test");
            //Console.WriteLine($"Sum:{value.Result} - {value2.Result}");
            Console.WriteLine($"Sum:{value.Result}");

            CountBig(100000);
            CountBig(100000);
            CountBig(100000);
            CountBig(100000);
        }
        /// <summary>
        /// 计数p次
        /// </summary>
        /// <param name="p"></param>
        private static void CountBig(int p)
        {
            for (int i = 0; i < p; i++)
                ;
            Console.WriteLine("CountBig");
        }
    }
}
