using System;

namespace C_16_9_派生成员实现接口
{
    interface IIfc1 { void PrintOut(string s); }
    // 声明基类
    class MyBaseClass
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Calling through: {s}");
        }
    }
    // 声明类
    class Derived : MyBaseClass 
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.PrintOut("object");
        }
    }
}
