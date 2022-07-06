using System;



namespace C_18_6_扩展方法和泛型类
{
    // 定义一个Print扩展方法，扩展叫作Holder<T>的泛型类
    static class ExtendHolder
    {
        // 声明泛型方法 + 扩展方法结合,方法名后需要加类型参数列表，形参类型前需要加this
        public static void Print<T>(this Holder<T> h)
        {
            T[] vals = h.GetValues();
            Console.WriteLine($"{vals[0]},\t{vals[1]},\t{vals[2]}");
        }
    }

    class Holder<T>
    {
        T[] Vals = new T[3];
        public Holder(T v0, T v1, T v2)
        {Vals[0] = v0; Vals[1] = v1; Vals[2] = v2; }

        // 返回数组
        public T[] GetValues() { return Vals; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var intHolder = new Holder<int>(3, 5, 7);
            var stringHolder = new Holder<string>("A1", "A2", "A3");

            intHolder.Print();
            stringHolder.Print();
        }
    }
}
