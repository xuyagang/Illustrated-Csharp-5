using System;
using static C_7_10_属性3.Trivial;

namespace C_7_10_属性3
{
    class Trivial
    {
        public static int MyValue { get; set; }
        public void PrintValue()
        {Console.WriteLine("Value from inside: {0}", MyValue);}
    }
    class Program
    {
        static void Main()
        {
            //从类的外部范访问
            Console.WriteLine("Init Value:{0}", Trivial.MyValue);
            //从类的外部访问
            Trivial.MyValue = 123;
            Console.WriteLine("New Value:{0}", Trivial.MyValue);
            //类的外部访问，由于使用了using static,所以没有使用类名 
            MyValue = 20;
            Console.WriteLine("New Value:{0}", MyValue);
            Trivial tr = new Trivial();
            tr.PrintValue();
        }
    }
}
