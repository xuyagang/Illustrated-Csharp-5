using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_4_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parseResultSummary;
            string stringFirst = "28";
            int intFirst;
            //                          输入字符串    输出变量
            bool success = int.TryParse(stringFirst, out intFirst);
            parseResultSummary = success 
                                ? "was successfully parsed"
                                : "was not successfully parsed";
            Console.WriteLine($"String {stringFirst} {parseResultSummary}");
            Console.WriteLine($"{intFirst}");


            string stringSecond = "vt750";
            int intSecond;
            success = int.TryParse(stringSecond, out intSecond);
            parseResultSummary = success
                                ? "was successfully parsed"
                                : "was not successfully parsed";
            Console.WriteLine($"String {stringSecond} {parseResultSummary}");
            Console.WriteLine($"{intSecond}");
        }
    }
}
