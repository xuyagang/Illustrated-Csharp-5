
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_21_8_1_parallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 示例一：不能保证迭代的执行次序
            //Parallel.For(0, 15, i =>
            //Console.WriteLine($"The square of {i} is {i * i}"));


            //// 示例二：迭代并行执行，但结果是一个顺序排列的数组
            //const int maxValue = 11;
            //int[] squares = new int[maxValue];
            //Parallel.For(0, maxValue, x => squares[x] = x * x);

            //foreach(int x in squares)
            //{
            //    Console.WriteLine(x);
            //}


            // Parallel.ForEach
            string[] squares = new string[]
            {
                "We", "hold", "these", "truths", "to", "be", "self-evident"
            };
            Parallel.ForEach(squares, x => Console.WriteLine(
                String.Format($"\"{x}\" has {x.Length} letters")));


        }
    }
}