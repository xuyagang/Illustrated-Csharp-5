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

            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
