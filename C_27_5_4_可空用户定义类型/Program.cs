using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_5_4_可空用户定义类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 结构变量和可空类型变量
            MyStruct mSStruct = new MyStruct(6, 11);
            MyStruct? mSNull = new MyStruct(5, 10);

            // 结构和可空类型的访问
            Console.WriteLine($"{mSStruct.X} - {mSStruct.Y}");
            Console.WriteLine($"{mSNull.Value.X} - {mSNull.Value.Y}");
        }
    }

    struct MyStruct
    {
        public int X;
        public int Y;
        public MyStruct(int x, int y) { X = x; Y = y; }
    }
}
