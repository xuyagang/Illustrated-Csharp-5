using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_3
{
    class Program
    {
        static void Main()
        {
            D d1 = new D();
            D d2 = new D();
            d1.Mem1 = 10;
            d2.Mem1 = 21;
            Console.WriteLine($"d1 = {d1.Mem1}, d2 = {d2.Mem1}");
        }
    }
    class D
    {
        public int Mem1;
    }
}
