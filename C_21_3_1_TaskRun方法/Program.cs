using System;
using System.Threading.Tasks;

namespace C_21_3_1_TaskRun方法
{
    static class MyClass
    {
        /// <summary>
        /// 使用Task.Run方法运行四种不同的委托类型所表示的方法
        /// </summary>
        /// <returns></returns>
        public static async Task DoWorkAsync()
        {
            //await指定异步执行任务 
            //                       Action  
            await Task.Run(() => Console.WriteLine(5.ToString()));
            //                               TResult Func()
            Console.WriteLine((await Task.Run(() => 6)).ToString());
            //                               Task Func()
            await Task.Run(() => Task.Run(() => Console.WriteLine(7.ToString())));
            //                          Task<TResult> Func()
            int value = await Task.Run(() => Task.Run(() => 8));
            Console.WriteLine(value.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = MyClass.DoWorkAsync();
            t.Wait(); // 等待 Task 完成执行过程
            Console.WriteLine("Press Enter Key To Exit");
        }
    }
}
