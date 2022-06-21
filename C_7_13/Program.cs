using System;

namespace C_7_13
{
    public class Point
    {
        public int X = 1;
        public int Y = 2;
    }
    class Program
    {
        static void Main()
        {
            //pt1调用构造函数设置两个字段的值为1、2
            Point pt1 = new Point();
            //pt2构造函数设置字段为1、2，初始化语句把他们修改为5、6
            Point pt2 = new Point { X = 5, Y = 6 };

            Console.WriteLine("Pt1:{0}---{1}", pt1.X, pt1.Y);
            Console.WriteLine("Pt2:{0}---{1}", pt2.X, pt2.Y);
        }
    }
}
