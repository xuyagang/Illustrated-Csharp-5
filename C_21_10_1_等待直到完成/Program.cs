using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_21_10_1_等待直到完成
{
    delegate long MyDel(int first, int second);   // 声明委托类型
    class Program
    {
        // 声明异步方法
        static long Sum(int x, int y)
        {
            Console.WriteLine("           Inside Sum:");
            Thread.Sleep(5000);
            //throw new Exception("Test");
            return x + y;
        }

        static void Main(string[] args)
        {
            MyDel del = new MyDel(Sum);
            Console.WriteLine("Before BeginInvoke");
            // 开始异步调用
            IAsyncResult iar = del.BeginInvoke(3,5,null,null);
            Console.WriteLine("Doing stuff");
            // 等待结束并获取结果
            long result = del.EndInvoke(iar);
            Console.WriteLine($"After EndInvoke:{result}");
        }
    }
}
