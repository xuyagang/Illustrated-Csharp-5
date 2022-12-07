using System;
using System.Threading.Tasks;

namespace C_21_4_TaskYield
{
    static class DoStuff
    {
        public static async Task<int> FindSeriesSum(int i1)
        {
            int sum = 0;
            for(int i=0; i<i1; i++)
            {
                sum += i;
                if (i%1000 ==0)   
                {
                    await Task.Yield(); // 1000次执行一次
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
            CountBig(100000);
            CountBig(100000);
            CountBig(100000);
            CountBig(100000);
            Console.WriteLine("Test");
            Console.WriteLine($"Sum:{value.Result}");
        }
        /// <summary>
        /// 计数p次
        /// </summary>
        /// <param name="p"></param>
        private static void CountBig(int p)
        {
            for (int i = 0; i < p; i++)
                ;
        }
    }
}
