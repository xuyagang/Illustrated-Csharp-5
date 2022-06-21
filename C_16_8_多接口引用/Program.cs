using System;

namespace C_16_8_多接口引用
{
    interface IIfc1 { void PrintOut(string s); }
    interface IIfc2 { void PrintOut(string s); }
    class MyClass : IIfc1, IIfc2
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Calling through:{s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();   // 创建对象的引用
            IIfc1 ifc1 = (IIfc1)mc;   // 获取IIfc1的引用
            IIfc2 ifc2 = (IIfc2)mc;   // 获取IIfc2的引用
            mc.PrintOut("Object");
            ifc1.PrintOut("interface 1");
            ifc2.PrintOut("interface 2");
        }
    }
}
