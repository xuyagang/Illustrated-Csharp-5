using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_9
{
   class X
    {
        public const double PI = 3.1416;
    }
    class Program
    {
        static void Main()
        {
            //使用常量字段
            Console.WriteLine($"pi = {X.PI}");
        }
    }
}
