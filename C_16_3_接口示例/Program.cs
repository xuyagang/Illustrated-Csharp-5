using System;

namespace C_16_3_接口示例
{
    interface IIfc1   // 声明接口
    {
        //  接口成员不允许有访问修饰符
        void PrintOut(string s);  // 方法有名称参数和返回类型
    }
    class MyClass : IIfc1   // 声明类
    {
        public void PrintOut(string s)   // 实现方法
        {
            Console.WriteLine($"Calling throuth: {s}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            mc.PrintOut("Object");
        }
    }
}
