using System;

namespace C_13_14_Ref返回和局部变量
{
    internal class Program
    {
        // ref返回关键字1
        public static ref int PointerToHighestPositive(int[] numbers)
        {
            int highest = 0;
            int indexOfHighest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > highest)
                {
                    indexOfHighest = i;
                    highest = numbers[indexOfHighest];
                }
            }
            // ref返回关键字2
            return ref numbers[indexOfHighest];
        }
        static void Main()
        {
            int[] scores = { 5, 80 };
            Console.WriteLine($"Before:{scores[0]},{scores[1]}");
            // ref 局部变量
            ref int locationOfHigher = ref PointerToHighestPositive(scores);
            // 改变最大值的值
            locationOfHigher = 0;
            Console.WriteLine($"After:{scores[0]},{scores[1]}");
        }
    }
}