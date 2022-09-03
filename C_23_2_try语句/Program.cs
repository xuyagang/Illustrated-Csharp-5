using System;

namespace C_23_2_try语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //try
            //{
            //    int y = 0;
            //    x /= y;
            //}
            //catch
            //{
            //    Console.WriteLine("Handing all exceptions - keep on running");
            //}



            int inVal = 5;
            try
            {
                if (inVal < 10)
                {
                    Console.Write("First Branch - ");
                    return;
                }
                else
                    Console.Write("Second Branch");
            }
            finally
            {
                Console.Write("In finally statement");
            }
        }
    }
}
