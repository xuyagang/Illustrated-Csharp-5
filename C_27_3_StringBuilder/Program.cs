using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_3_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hi there.");
            Console.WriteLine(sb.ToString());
            sb.Replace("Hi", "Hello");
            Console.WriteLine(sb.ToString());
        }
    }
}
