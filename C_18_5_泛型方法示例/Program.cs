using System;

namespace C_18_5_泛型方法示例
{
    class Simple   // 非泛型类
    {
        static public void ReverseAndPrint<T>(T[] arr)   // 泛型方法
        {
            Array.Reverse(arr);
            foreach (T item in arr)   // 使用参数类型T
                Console.Write($"{item.ToString()}, ");
            Console.WriteLine("");
        }
    }
    public class Program
    {
        static void Main()
        {
            // 创建各种类型的数组
            var intArray = new int[] { 3, 5, 7, 9, 11 };
            var stringArray = new string[] { "first", "Second", "Third" };
            var doubleArray = new double[] { 3.567, 7.891, 2.345 };

            Simple.ReverseAndPrint<int>(intArray);   // 标准调用
            Simple.ReverseAndPrint(intArray);        // 推断类型调用

            Simple.ReverseAndPrint<string>(stringArray);
            Simple.ReverseAndPrint(stringArray);

            Simple.ReverseAndPrint<double>(doubleArray);
            Simple.ReverseAndPrint(doubleArray);
        }
    }
}
