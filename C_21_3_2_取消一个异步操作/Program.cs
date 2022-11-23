using System;
using System.Threading;
using System.Threading.Tasks;

namespace C_21_3_2_取消一个异步操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            MyClass mc = new MyClass();
            Task t = mc.RunAsync(token);

            t.Wait();
            Console.WriteLine($"Was Cancelled:{token.IsCancellationRequested}");

        }
    }

    class MyClass
    {
        // 返回类型为Task的异步方法
        public async Task RunAsync(CancellationToken ct)
        {
            if(ct.IsCancellationRequested)
                return;
            // Task是awaitable类型对象，run需要传入一个委托参数
            await Task.Run(() => CycleMethod(ct), ct);
        }

        void CycleMethod( CancellationToken ct)
        {
            Console.WriteLine("Start CycleMethod");
            const int max = 5;
            for (int i = 0; i < max; i++)
            {
                if (ct.IsCancellationRequested)   // 监控令牌
                    return ;
                Thread.Sleep(1000);
                Console.WriteLine($"{i + i} of {max} iterations completed");
            }
        }
    }
}
