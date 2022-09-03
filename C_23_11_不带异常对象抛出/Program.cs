using System;

namespace C_23_11_不带异常对象抛出
{
    class MyClass
    {
        public static void PrintArg(string arg)
        {
            try
            {
                try
                {
                    if (arg == null)
                    {
                        ArgumentNullException myEx = new ArgumentNullException("arg");
                        throw myEx;
                    }
                    Console.WriteLine(arg);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Inner Catch : {ex.Message}");
                    throw;   //重新抛出异常，没有附加参数
                }
            }
            catch   // 一般catch子句，捕获所有类型异常
            {
                Console.WriteLine("Outer Catch: Handing an Exception");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            MyClass.PrintArg(s);
        }
    }
}
