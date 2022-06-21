
using System;

namespace C_13_8_4_交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 带有二维数组的交错数组
            int[][,] Arr;
            // 实例化带有3个二维数组的交错数组
            Arr = new int[3][,];

            Arr[0] = new int[,] {{10  , 20 },
                                          {100 , 200}};
            Arr[1] = new int[,] {{30,  40,  50 },
                                           {300, 400, 500}};
            Arr[2] = new int[,] {{60, 70, 80, 90 },
                                           {600,700,800,900}};

            // 获取Arr维度0的长度（最外层的长度）
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                // 获取Arr[i]维度0的长度（最外层的长度）
                for (int j = 0; j < Arr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < Arr[i].GetLength(1); k++)
                    {
                        Console.WriteLine($"[{i}][{j},{k}] = {Arr[i][j,k]}");
                    }
                }
            }
        }
    }
}
