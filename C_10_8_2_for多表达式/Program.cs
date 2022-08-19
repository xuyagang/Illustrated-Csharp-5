using System;

namespace C_10_8_2_for多表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxI = 5;
            for (int i = 0, j = 0; i < MaxI; i++, j+=10)
            {
                Console.WriteLine($"{i},{j}");
            }
        }
    }
}
