using System;

namespace C_16_1_接口1
{
    class MyClass : IComparable    // 类接口实现
    {
        public int TheValue;
        public int CompareTo(object obj)   // 实现方法
        {
            MyClass mc = (MyClass)obj;
            if (this.TheValue < mc.TheValue) return -1;
            if (this.TheValue > mc.TheValue) return 1;
            return 0;
        }
    }
    internal class Program
    {
        static void PrintOut(string s, MyClass[] mc)
        {
            Console.Write(s);
            foreach (var m in mc)
                Console.Write($"{m.TheValue} ");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            var myInt = new[] { 20, 4, 16, 9, 2 };
            MyClass[] mcArr = new MyClass[5];   // 创建数组
            for (int i = 0; i < 5; i++)    // 初始化数组
            {
                mcArr[i] = new MyClass();
                mcArr[i].TheValue = myInt[i];
            }
            PrintOut("Initial Order:", mcArr);   // 输出初始数组
            Array.Sort(mcArr);
            PrintOut("Sorted Order:", mcArr);   // 输出初始数组
        }
    }
}