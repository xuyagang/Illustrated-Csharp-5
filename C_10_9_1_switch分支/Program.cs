using System;

namespace C_10_9_1_switch分支
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                switch(i)   // 计算变量i
                {
                    case 2:   // 如果x=2
                        Console.WriteLine($"x is {i} -- In Case 2");
                        break;   // 结束switch语句

                    case 5:   // 如果x=5
                        Console.WriteLine($"x is {i} -- In Case 5");
                        break;   // 结束switch语句

                    default:   // 如果x既不等于2也不等于5
                        Console.WriteLine($"x is {i} -- In Default case");
                        break;   // 结束switch语句
                }
            }
        }
    }
}
