using System;

namespace C_14_13_匿名方法
{
    internal class Program
    {
        // 具名方法
        public static int Add20(int x)
        {
            return x + 20;
        }
        delegate int OtherDel(int InParam);
        static void Main(string[] args)
        {
            OtherDel del = Add20;
            Console.WriteLine("{0}", del(5));
            Console.WriteLine("{0}", del(6));
        }

        // 匿名方法
        delegate int OtherDel(int InParam);
        static void Main()
        {
            OtherDel del = delegate (int x) { return x + 20; };
            Console.WriteLine("{0}", del(5));
            Console.WriteLine("{0}", del(6));
        }
    }
}
