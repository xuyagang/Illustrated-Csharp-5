using System;

namespace C_16_10_显式接口成员
{
    interface IIfc1 { void PrintOut(string s); }
    interface IIfc2 { void PrintOut(string s); }
    class MyClass : IIfc1, IIfc2
    {
        void IIfc1.PrintOut(string s)   // 显式接口成员实现
        {
            Console.WriteLine($"IIfc1: {s}");
        }
        void IIfc2.PrintOut(string s)   // 显式接口成员实现
        {
            Console.WriteLine($"IIfc2: {s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();   // 创建类对象

            IIfc1 ifc1 = (IIfc1) mc;
            ifc1.PrintOut("interface 1");

            IIfc2 ifc2 = (IIfc2)mc;
            ifc2.PrintOut("interface 2");
        }
    }
}