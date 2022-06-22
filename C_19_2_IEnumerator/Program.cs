using System;
using System.Collections;

namespace C_19_2_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 11, 12, 13 };   // 创建数组
            IEnumerator ie = arr1.GetEnumerator();   // 获取并存储枚举器
            while (ie.MoveNext())
            {
                int item = (int)ie.Current;   // 获取当前项
                Console.WriteLine($"Item value: {item}");
            }
            ie.Reset();
        }
    }
}