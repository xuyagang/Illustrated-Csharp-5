using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_6
{
    class X
    {
        static public int A;                        //静态字段
        static public void PrintVal()           //静态方法
        {
            //静态方法访问静态字段
            Console.WriteLine("Value of A: {0}", A);
        }


    }
    class Program
    {
        static void Main()
        {
            X.A = 10;
            X.PrintVal();
        }
    }
}
