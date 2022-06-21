using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_5_2
{
    class D
    {
        int Mem1;
        public static int Mem2;
    }
    class Program
    {
        static void Main()
        {
            D.Mem2 = 5;
            Console.WriteLine($"Mem2 = {D.Mem2}");
        }
    }
}
