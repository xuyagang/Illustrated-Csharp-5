using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace C_21_3_3_同步等待任务1
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();

        // 定义异步方法，包括三个部分：await之前的，await-异步执行任务，
        private async Task<int> CountCharactersAsync(int id, string site)
        {
            WebClient wc = new WebClient();
            string result = await wc.DownloadStringTaskAsync(new Uri(site));
            Console.WriteLine("Test");
            Console.WriteLine($"Call {id} completed: {sw.Elapsed.TotalMilliseconds,4:N0}");
            return result.Length;
        }

        public void DoRun()
        {
            sw.Start();
            Task<int> t1 = CountCharactersAsync(1, "https://cn.bing.com/");
            Task<int> t2 = CountCharactersAsync(2, "https://www.baidu.com/");

            // 全部注释掉为完全异步的方式,DoRun内的代码不等待Task

            //Task.WaitAll(t1, t2);   // 所有Task完成后才继续后续代码
            Task.WaitAny(t1, t2);   // 任意一个Task完成后就继续后续代码

            Console.WriteLine("Task 1:{0}Finished", t1.IsCompleted ? "" : "Not");
            Console.WriteLine("Task 2:{0}Finished", t2.IsCompleted ? "" : "Not");
            Console.Read();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDownloadString ds = new MyDownloadString();
            ds.DoRun();
        }
    }
}
