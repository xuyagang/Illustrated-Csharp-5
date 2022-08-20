using System;
using System.Threading;


namespace C_10_9_4_分支标签
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            switch(x)
            {
                case 5:
                    while (true)
                    {
                        Console.WriteLine("ok");
                        Thread.Sleep(2000);
                    }
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}