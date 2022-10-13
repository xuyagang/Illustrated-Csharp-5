using System;
using System.Net;
using System.Diagnostics;



namespace C_21_1_非异步
{
    class MyDownloadString
    {
        //初始化新的 Stopwatch 实例，将运行时间属性设置为零，然后开始测量运行时间
        Stopwatch sw = Stopwatch.StartNew();

        public void DoRun()
        {
            const int LargeNumber = 6000000;
            sw.Stop();

            
        }

        private int CountCharacter(int id, String uriString)
        {
            WebClient wc1 = new WebClient();
            Console.WriteLine($"Start call {id}     :     {sw.Elapsed.TotalMilliseconds,4:No}");
            string result = wc1.DownloadString(new Uri(uriString));
            Console.WriteLine($" Call {id} completed:     {sw.Elapsed.TotalMilliseconds}");
            return result.Length;
        }
    }

    class Main1
    {
        static void Main()
        {
            MyDownloadString ds = new MyDownloadString();
            ds.DoRun();
        }
    }
}
