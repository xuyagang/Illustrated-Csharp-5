using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_20_局部函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = GetDataFromDb();
            foreach(var item in data)
            {
                Console.WriteLine(ReplaceEmptyStringWithElipsis(item));
            }
            string ReplaceEmptyStringWithElipsis(string input) 
            {
                if (string.IsNullOrEmpty(input)) return "...";
                return input;
            }
        }
        private static List<string> GetDataFromDb()
        {
            throw new NotImplementedException();
        }
    }
}
