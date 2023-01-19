using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_21_10_3_轮询模式
{
    // 声明委托类型
    delegate long MyDel(int first, int second);   
    class Program
    {
        static long Sum(int x, int y)
        {
            Console.WriteLine("          Inside Sum");
            Thread.Sleep(100);

            return x + y;
        }
        static void Main(string[] args)
        {
            MyDel del = new MyDel(Sum);
            IAsyncResult iar = del.BeginInvoke(3, 5, null, null);   // 开始异步调用
            Console.WriteLine("After BeginInvoke");
            while (!iar.IsCompleted)
            {
                Console.WriteLine("Not Done");
                for (long i = 0; i < 10000000; i++)
                    ;
            }
            Console.WriteLine("Done");
            long result = del.EndInvoke(iar);   // 调用EndInvoke来获取接口并进行清理
            Console.WriteLine($"Result:{result}");
        }
    }
}
