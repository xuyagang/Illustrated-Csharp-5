using System;
using System.Runtime.CompilerServices;

namespace C_25_6_3_调用者信息特性
{
    internal class Program
    {
        public static void MyTrace(string message,
                                   [CallerFilePath] string filename = "",
                                   [CallerLineNumber] int lineNumber = 0,
                                   [CallerMemberName] string callingMember = "")
        {
            Console.WriteLine($"File:       {filename}");
            Console.WriteLine($"Line:       {lineNumber}");
            Console.WriteLine($"Called From:{callingMember}");
            Console.WriteLine($"Message:{message}");
        }

        static void Main(string[] args)
        {
            MyTrace("Simple message");
        }
    }
}
