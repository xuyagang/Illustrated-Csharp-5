
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_2_字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hi there! this, is: a string.";
            char[] delimiters = { ' ', '!', ',', '.' };
            string[] words = s1.Split(delimiters);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
