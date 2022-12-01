using System;
using System.Threading.Tasks;

namespace C_21_3_2_await和异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = BadAsync();
            t.Wait();   //等待 Task 完成执行过程
            Console.WriteLine($"Task status   : {t.Status}");   //获取此任务的当前阶段(枚举值)
            Console.WriteLine($"Task IsFaulted: {t.IsFaulted}");   //获取 Task 是否由于未经处理异常的原因而完成
        }

        // 异步方法的返回类似是void、Task、Task<T> 三种之一
        // Task异步操作，多用于检查异步方法状态
        static async Task BadAsync()
        {
            try
            {
                await Task.Run(() => { throw new Exception(); });
            }
            catch
            {
                Console.WriteLine("Exception is BadAsync");
            }
        }
    }
}
