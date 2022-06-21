using System;

namespace C_7_12_静态构造函数
{
    class RandomNumberClass
    {
        //私有静态字段
        private static Random RandomKey; 
        //静态构造函数
        static RandomNumberClass()
        {
            RandomKey = new Random();
        }
        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
    class Program
    {
        static void Main()
        {
            RandomNumberClass a = new RandomNumberClass();
            RandomNumberClass b = new RandomNumberClass();
            Console.WriteLine("Next Random #:{0}", a.GetRandomNumber());
            Console.WriteLine("Next Random #:{0}", b.GetRandomNumber());
        }
    }
}
