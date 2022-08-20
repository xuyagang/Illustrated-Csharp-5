using System;
using System.IO;

namespace C_10_15_2_using示例
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (TextWriter tw = File.CreateText("Lincoln.txt"))
            //{
            //    tw.WriteLine("Four score and seven years ago.");
            //}
            //using (TextReader tr = File.OpenText("Lincoln.txt"))
            //{
            //    string InputString;
            //    while (null != (InputString = tr.ReadLine()))
            //        Console.WriteLine(InputString);
            //}



            //多个资源示例
            using (TextWriter tw1 = File.CreateText("Lincoln.txt"),
                              tw2 = File.CreateText("Franklin.txt"))
            {
                tw1.WriteLine("Four score and seven years ago,...");
                tw2.WriteLine("Early to bed; Early to rise ...");
            }

        }
    }
}
