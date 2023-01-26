using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        //private double myConstant = 56.7;
        //public double Length4 { get; set; } = myConstant;

        private double myProperty { get; set; } = 67.8;
        public double Length5 { get; set; } = myProperty;
        static void Main()
        {
            Console.WriteLine(new  Program().Length4);
        }
    }
}