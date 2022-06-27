using System;
using System.Collections.Generic;

namespace C_19_7_多个可枚举类型
{
    class Spectrum
    {
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
        
        public IEnumerable<string> UVtoIR()
        {
            for (int i=0; i< colors.Length; i++)
                yield return colors[i];
        }

        public IEnumerable<string> IRtoUV()
        {
            for (int i=colors.Length-1; i>=0; i--)
                yield return colors[i];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum spectrum = new Spectrum();

            foreach (string s in spectrum.UVtoIR())
                Console.Write($"{s}  ");
            Console.WriteLine();

            foreach (string s in spectrum.IRtoUV())
                Console.Write($"{s}  ");
            Console.WriteLine();
        }
    }
}
