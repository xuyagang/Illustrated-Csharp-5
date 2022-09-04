using System;

namespace C_25_6_1_Obsolete特性
{
    internal class Program
    {
        [Obsolete("Use method SuperPrintOut")]   // 将特性应用到方法
        static void PrintOut(string str)
        {
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            PrintOut("Start of Main");
        }
    }
}
