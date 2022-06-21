using System;

namespace C_16_10_访问显式接口成员
{
    interface IIfc1 { void PrintOut(string s); }
    class MyClass : IIfc1
    {
        void IIfc1.PrintOut(string s)   // 显式接口实现
        {
            Console.WriteLine($"{s}");
        }
        public void Method1()
        {
            //PrintOut("...");   // 编译错误
            //this.PrintOut("...")  // 编译错误
            ((IIfc1)this).PrintOut("...");   //正确调用
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Method1();

            IIfc1 ifc1 = (IIfc1)mc;
            ifc1.PrintOut("Interface1");

            ((IIfc1)mc).PrintOut("MyClass");
        }
    }
}
