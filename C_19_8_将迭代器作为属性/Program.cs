using System;
using System.Collections.Generic;

namespace C_19_8_将迭代器作为属性
{
    class Spectrum
    {
        bool _listFromUVtoIR;
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        public Spectrum(bool listFromUVtoIR)
        {
            _listFromUVtoIR = listFromUVtoIR;   // 初始化字段
        }
        public IEnumerator<string> GetEnumerator()
        {
            return _listFromUVtoIR
                   ? UVtoIR
                   : IRtoUV;
        }
        public IEnumerator<string> UVtoIR
        {
            get
            {
                for (int i = 0; i < colors.Length; i++)
                    yield return colors[i];
            }
        }
        public IEnumerator<string> IRtoUV
        {
            get
            {
                for (int i = colors.Length - 1; i >= 0; i--)
                    yield return colors[i];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum startUV = new Spectrum(true);
            Spectrum startIR = new Spectrum(false);

            foreach (string color in startUV)
                Console.Write($"{color}  ");
            Console.WriteLine();

            foreach(string color in startIR)
                Console.Write($"{color}  ");
            Console.WriteLine();
        }
    }
}
