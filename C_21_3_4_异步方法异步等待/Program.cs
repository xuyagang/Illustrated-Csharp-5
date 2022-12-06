using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace C_21_3_4_异步方法异步等待
{
    class MyDownloadString
    { 
        public void Run()
        {
            Task<int> t = CountCharactersAsync("https://cn.bing.com/", "https://www.baidu.com/");
            Console.WriteLine("DoRun: Task {0} Finished", t.IsCompleted ? "" : "Not");
            Console.WriteLine("DoRun: Result = {0}", t.Result);
        }
        
        public async Task<int> CountCharactersAsync(string site1, string site2)
        {
            WebClient wc1 = new WebClient();
            WebClient wc2 = new WebClient();
            Task<string> t1 = wc1.DownloadStringTaskAsync(new Uri(site1));
            Task<string> t2 = wc2.DownloadStringTaskAsync(new Uri(site2));
            List<Task<string>> tasks = new List<Task<string>>();
            tasks.Add(t1);
            tasks.Add(t2);
            //await Task.WhenAll(tasks);
            await Task.WhenAny(tasks);   // 等待某个Task完成
            Console.WriteLine("CCA:T1{0} Finished", t1.IsCompleted ? "" : "Not");
            Console.WriteLine("CCA:T2{0} Finished", t2.IsCompleted ? "" : "Not");
            return t1.IsCompleted ? t1.Result.Length : t2.Result.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDownloadString ds = new MyDownloadString();
            ds.Run();   
        }
    }
}
