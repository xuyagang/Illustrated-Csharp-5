using System;

namespace C_9_7_递增递减
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y;
            y = x++;
            Console.WriteLine($"y:{y},x:{x}");

            x = 5;
            y = ++x;
            Console.WriteLine($"y:{y},x:{x}");

            x = 5;
            y = x--;
            Console.WriteLine($"y:{y},x:{x}");

            x = 5;
            y = --x;
            Console.WriteLine($"y:{y},x:{x}");
        }
    }
}