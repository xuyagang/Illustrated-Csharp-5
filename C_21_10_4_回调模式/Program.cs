using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace C_21_10_4_回调模式
{
    delegate long MyDel(int first, int second);

    class Program
    {
        // 声明异步方法
        static long Sum(int x, int y)
        {
            Console.WriteLine("                Inside Sum");
            Thread.Sleep(3000);
            return x + y;
        }
        // 回调方法,用户自定义的方法，用来处理异步方法的运算结果
        static void CallWhenDone(IAsyncResult iar)
        {
            Console.WriteLine("                Inside CallWhenDone");
            // 从参数IAsyncResult 对象中提取出委托的引用
            AsyncResult ar = (AsyncResult)iar;
            MyDel del = (MyDel)ar.AsyncDelegate;
            // 回调方法内调用EndInvoke
            long result = del.EndInvoke(iar);
            Console.WriteLine("                The result is:{0}", result);
        }

        static void Main(string[] args)
        {
            MyDel del = new MyDel(Sum);
            Console.WriteLine("Before BeginInvoke");
            // 开始异步调用
            IAsyncResult iar = del.BeginInvoke(3, 5, CallWhenDone, null);

            Console.WriteLine("Doing more work in Main.");
            Thread.Sleep(5000);
            Console.WriteLine("Done with Main.Exiting");
        }
    }
}
