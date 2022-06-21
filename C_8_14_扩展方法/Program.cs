using System;

namespace C_8_14_扩展方法
{
    sealed  class MyData
    {
        private double D1;                  //字段
        private double D2;
        private double D3;
        public MyData(double d1, double d2, double d3)          //构造函数
        { D1 = d1; D2 = d2; D3 = d3;}
        public double Sum()             //方法
        { return D1 + D2 + D3; }
    }
    static class ExtendData
    {
        public static double Average(this MyData md)
        {
            return md.Sum() / 3;
        }
    }

    class Program
    {
        static void Main()
        {
            MyData md = new MyData(3, 5, 4);
            Console.WriteLine("Average:{0}", md.Average());
            Console.WriteLine("\nAverage:{0}", ExtendData.Average(md));
        }
    }
}
