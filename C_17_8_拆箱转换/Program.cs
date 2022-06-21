using System;

namespace C_17_8_拆箱转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object oi = i;     // 对 i 装箱并把引用赋值给oi
            int j = (int) oi;   // 对 oi 拆箱并把值赋值给j

            Console.WriteLine($"i:{i}, oi:{oi}, j:{j}");
        }
    }
}
