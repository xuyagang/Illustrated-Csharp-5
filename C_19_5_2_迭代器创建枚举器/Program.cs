using System;
using System.Collections.Generic;


namespace C_19_5_2_迭代器创建枚举器
{
    class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite();   // 返回枚举器
        }
        public IEnumerator<string> BlackAndWhite()   // 迭代器
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
            foreach (string shade in mc)
            {
                Console.WriteLine(shade);
            }
        }
    }
}