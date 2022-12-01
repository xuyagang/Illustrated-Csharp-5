using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace C_21_3_3_同步等待任务1
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();

        private async Task<int> CountCharactersAsync(int id, string site)
        {
            WebClient wc = new WebClient();
            string result = await wc.DownloadStringTaskAsync(new Uri(site));
            Console.WriteLine($"Call {id} completed: {sw.Elapsed.TotalMilliseconds,4:N0}");
            return result.Length;
        }

        public void DoRun()
        {
            sw.Start();
            Task<int> t1 = CountCharactersAsync(1, "https://cn.bing.com/");
            Task<int> t2 = CountCharactersAsync(2, "https://www.baidu.com/");

            //Task.WaitAll(t1, t2);
            //Task.WaitAny(t1, t2);

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
