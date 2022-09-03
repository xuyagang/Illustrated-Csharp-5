using System;

namespace C_23_10_抛出异常
{
    internal class Program
    {
        class MyClass
        {
            public static void PrintArg(string arg)
            {
                try
                {
                    if (arg == null)
                    {
                        ArgumentNullException myEx = new ArgumentNullException("arg");
                        throw myEx;
                    }
                    Console.WriteLine($"Normal-{arg}");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Message:{ex.Message}");
                }
            }
        }

        static void Main(string[] args)
        {
            string s = null;
            MyClass.PrintArg(s);
            MyClass.PrintArg("Hi there");
        }
    }
}
