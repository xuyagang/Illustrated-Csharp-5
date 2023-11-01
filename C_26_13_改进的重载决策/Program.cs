using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_13_改进的重载决策
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 之前因为二义性会报错
            // c#6.0 优先选择 Func<Task> function 而不是 Action
            Task.Run(DoThings);

            // Action
            Task.Run(Test);
        }
        static Task DoThings()
        {
            return Task.FromResult(0);
        }
        static void Test() { }
    }
}