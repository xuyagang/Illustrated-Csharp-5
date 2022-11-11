using System;
using System.Threading.Tasks;

namespace C_21_3_1_异步方法控制流
{
    internal class Program
    {
        public int Get10()   // 与Func<int> 兼容
        {
            return 10;
        }

        public async Task DoWorkAsync()
        {
            Func<int> ten = new Func<int>(Get10);
            int a = await Task.Run(ten);
            int b = await Task.Run(new Func<int>(Get10));
            int c = await Task.Run(() => { return 10; });
            Console.WriteLine($"{a} {b} {c}");
        }

        static void Main(string[] args)
        {
            Task t = (new Program()).DoWorkAsync();
            t.Wait();
        }
    }
}
