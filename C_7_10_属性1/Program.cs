using System;

namespace C_7_10_属性1
{
    class RightTriangle
    {
        public double A = 3;
        public double B = 4;
        public double Hypotenuse
        {
            get { return Math.Sqrt(A * A + B * B); }
        }
    }
    class Program
    {
        static void Main()
        {
            RightTriangle c = new RightTriangle();
            Console.WriteLine("Hypotenuse:{0}", c.Hypotenuse);
        }
    }
}
