using System;

namespace C_17_7_1_装箱是创建副本
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建并初始化值类型
            int i = 10;
            // 创建并初始化引用类型
            object oi = i;

            Console.WriteLine($"i:{i}, oi:{oi}");

            i = 11;
            oi = 15;

            Console.WriteLine($"i:{i}, oi:{oi}");

        }
    }
}
