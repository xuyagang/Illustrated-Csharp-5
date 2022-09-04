using System;
using System.Diagnostics;


namespace C_25_6_4_DebuggerStepThrouth特性
{
    internal class Program
    {
        int x = 1;
        int X
        {
            get { return x; }
            [DebuggerStepThrough]
            set
            {
                x = x * 2;
                x += value;
            }
        }
        public int Y { get; set; }
        [DebuggerStepThrough]
        void IncrementFields()
        {
            x++; Y++;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.IncrementFields();
            p.X = 5;
            Console.WriteLine($"X = {p.x}, Y = {p.Y}");
        }
    }
}
