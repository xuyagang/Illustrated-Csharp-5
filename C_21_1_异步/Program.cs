using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace C_21_1_异步
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();
        
        public void DoRun()
        {
            const int LargeNumber = 6000000;
            sw.Start();

            // 声明并创建保存结果的对象
            Task<int> t1 = CountCharacterAsync(1, "https://cn.bing.com/");
            Task<int> t2 = CountCharacterAsync(2, "https://www.baidu.com/");

            CountToALargeNumber(1, LargeNumber); CountToALargeNumber(2, LargeNumber);
            CountToALargeNumber(3, LargeNumber); CountToALargeNumber(4, LargeNumber);

            // 获取结果
            Console.WriteLine($"Chars in https://cn.bing.com/      : {t1.Result}");
            Console.WriteLine($"Chars in https://www.baidu.com/    : {t2.Result}");

        }

        // 上下文关键字 async, Task<int>类型表示正在执行的工作，返回int
        private async Task<int> CountCharacterAsync(int id, string uriString)
        {
            WebClient wc1 = new WebClient();
            Console.WriteLine($"Start call {id}       :     {sw.Elapsed.TotalMilliseconds,4:N0}");
            // 上下文关键字
            string result = await wc1.DownloadStringTaskAsync(new Uri(uriString));
            Console.WriteLine($"Call {id} completed   :     {sw.Elapsed.TotalMilliseconds,4:N0}");
            return result.Length;
        }

        private void CountToALargeNumber(int id, int value)
        {
            for (long i = 0; i < value; i++) ;
            Console.WriteLine($"End counting {id}     :     {sw.Elapsed.TotalMilliseconds,4:N0}");
        }

        static void Main(string[] args)
        {
            MyDownloadString ds = new MyDownloadString();
            ds.DoRun();
        }
    }
}
