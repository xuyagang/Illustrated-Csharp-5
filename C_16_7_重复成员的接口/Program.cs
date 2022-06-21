using System;

namespace C_16_7_重复成员的接口
{
    interface IIfc1{void PrintOut(string s);}
    interface IIfc2 { void PrintOut(string t);}

    class MyClass : IIfc1, IIfc2
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Calling through: {s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintOut("Object");
        }
    }
}
