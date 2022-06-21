using System;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            //格式化字符串
            Console.WriteLine("The value : {0:c}.", 500);
            Console.WriteLine("The value : {0}.\n", 500);

            //字符串插值
            int myInt = 500;
            Console.WriteLine($"The value : {myInt}.");
            Console.WriteLine($"The value : {myInt:c}.");

            int myInt1 = 500;
            Console.WriteLine("|{0,10}|", myInt1);
            Console.WriteLine($"|{myInt1,-10}|");

            int negInt = -10;
            Console.WriteLine($"number:{negInt:d}");
        }
    }
}