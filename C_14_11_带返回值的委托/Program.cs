using System;

namespace C_14_11_带返回值的委托
{
    delegate int MyDel();   // 有返回值的委托
    class MyClass
    {
        int IntValue = 5;
        public int Add2() { IntValue += 2; return IntValue; }
        public int Add3() { IntValue += 3; return IntValue; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyDel mDel = mc.Add2;   // 创建并初始化委托
            mDel += mc.Add3;   // 增加方法
            mDel += mc.Add2;   // 增加方法
            Console.WriteLine("Value:{0}", mDel());
        }
    }
}
