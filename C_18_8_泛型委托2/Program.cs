using System;

namespace C_18_8_泛型委托2
{
    public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);

    class Simple
    {
        // 方法匹配委托
        static public string PrintString(int p1, int p2)
        {
            int total = p1 + p2;
            return total.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建委托实例
            var myDel = new Func<int, int ,string>(Simple.PrintString);
            // 调用委托
            Console.WriteLine(myDel(11, 22));
        }

        int a = 2;
    }
}