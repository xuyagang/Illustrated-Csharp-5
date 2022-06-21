using System;

namespace C_14_10_委托
{
    // 定义一个没有参数和返回值的委托
    delegate void PrintFunction();

    class Test
    {
        public void Print1()
        { Console.WriteLine("Print1---instance"); }
        public static void Print2()
        { Console.WriteLine("Print2---static"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();   // 创建一个测试类实例
            PrintFunction pf;   // 创建一个空委托

            pf = t.Print1;   // 初始化委托时只需要函数名

            // 给委托增加三个方法
            pf += Test.Print2;
            pf += t.Print1;
            pf += Test.Print2;
            // 现在委托有四个方法

            if (pf != null)   // 确认委托有方法
                pf();   // 调用委托
            else
                Console.WriteLine("Delegate is Empty");
        }
    }
}
