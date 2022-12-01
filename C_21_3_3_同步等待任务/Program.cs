using System;
using System.Net;
using System.Threading.Tasks;

namespace C_21_3_3_同步等待任务
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDownloadString.DoRun();
        }
    }

    static class MyDownloadString
    {
        // 异步方法
        private static async Task<int> CountCharactersAsync(string site)
        {
            // await用于异步方法内部，指明要异步执行的任务
            string result = await new WebClient().DownloadStringTaskAsync(new Uri(site));
            return result.Length;
        }

        // 调用异步方法
        public static void DoRun()
        {
            Task<int> t = CountCharactersAsync("https://cn.bing.com/");
            t.Wait();
            Console.WriteLine($"The Task has finished, returning value {t.Result}");
        }
    }
}
