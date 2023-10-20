using System;
using System.Collections.Generic;
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
            List<string> names = new List<string> { "aaa-", "bbb-", "ccc-", "ddd-" };
            Action<List<string>> action = ChangeStr;

            await Task.Run( () => action(names));

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


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

        private static void ChangeStr(List<string> strs)
        {
            for (int i = 0; i < strs.Count; i++)
            {
                strs[i] = strs[i].Replace("-", "00000");
            }
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
