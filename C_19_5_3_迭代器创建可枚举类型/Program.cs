using System;
using System.Collections.Generic;

namespace C_19_5_3_迭代器创建可枚举类型
{
    class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            // 获取可枚举类型
            IEnumerable<string> myEnumerable = BlackAndWhite();
            // 获取枚举器
            return myEnumerable.GetEnumerator();
        }
        public IEnumerable<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            // 使用类对象
            foreach (string shade in mc)
                Console.Write($"{shade}  ");

            // 使用类枚举器方法
            foreach (string shade in mc.BlackAndWhite())
                Console.Write($"{shade}  ");
        }
    }
}
