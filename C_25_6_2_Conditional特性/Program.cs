﻿//#define DoTrace
using System;
using System.Diagnostics;

namespace C_25_6_2_Conditional特性
{
    internal class Program
    {
        [Conditional("DoTrace")]
        static void TraceMessage(string str)
        {
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            TraceMessage("Start of Main");
            Console.WriteLine("Doing work in Main");
            TraceMessage("End of Main");
        }
    }
}
