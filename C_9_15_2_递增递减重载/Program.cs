using System;
using static System.Console;

namespace C_9_15_2_递增递减重载
{
    // 当MyType是类时，返回对象的后置递增值已经增加了
    // 当MyType是结构，返回对象的后置递增是预期的样子
    public class MyType
    {
        public int X;
        public MyType(int x)   //构造函数
        {
            X = x;
        }
        public static MyType operator ++(MyType m)
        {
            m.X++;
            return m;
        }
    }

    class Program
    {
        static void Show(string message, MyType tv)
        {
            WriteLine($"{message} {tv.X}");
        }
        static void Main(string[] args)
        {
            MyType tv = new MyType(10);
            WriteLine("Pre-increment");
            Show("Before", tv);
            Show("Retured", ++tv);
            Show("After", tv);
            WriteLine();

            tv = new MyType(10);
            WriteLine("Post-increment");
            Show("Before", tv);
            Show("Retured", tv++);
            Show("After", tv);
            WriteLine();
        }
    }
}
