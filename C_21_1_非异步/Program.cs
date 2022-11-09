using System;
using System.Net;
using System.Diagnostics;

namespace C_21_1_非异步
{
    class MyDownloadString
    {
        //初始化新的 Stopwatch 实例，将运行时间属性设置为零，然后开始测量运行时间
        // Stopwatch sw1 = Stopwatch.StartNew();   // 创建并开始计时
        Stopwatch sw = new Stopwatch();

        public void DoRun()
        {
            const int LargeNumber = 6000000;
            sw.Start();
            int t1 = CountCharacter(1, "https://cn.bing.com/");
            int t2 = CountCharacter(2, "https://www.baidu.com/");

            CountToALargeNumber(1, LargeNumber); CountToALargeNumber(2, LargeNumber);
            CountToALargeNumber(3, LargeNumber); CountToALargeNumber(4, LargeNumber);

            Console.WriteLine($"Chars in https://cn.bing.com/      : {t1}");
            Console.WriteLine($"Chars in https://www.baidu.com/    : {t2}");
        }

        private int CountCharacter(int id, String uriString)
        {
            WebClient wc1 = new WebClient();
            // 格式化数字字符串 {索引, 宽度对齐:格式精度}
            Console.WriteLine($"Start call {id}       :     {sw.Elapsed.TotalMilliseconds, 4:N0}");
            string result = wc1.DownloadString(new Uri(uriString));
            Console.WriteLine($"Call {id} completed   :     {sw.Elapsed.TotalMilliseconds, 4:N0}");
            return result.Length;
        }

        private void CountToALargeNumber(int id, int value)
        {
            for (long i = 0; i < value; i++) ;
            Console.WriteLine($"End counting {id}     :     {sw.Elapsed.TotalMilliseconds,4:N0}");
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
