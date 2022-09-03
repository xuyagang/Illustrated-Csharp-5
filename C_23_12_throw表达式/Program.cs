using System;

namespace C_23_12_throw表达式
{
    internal class Program
    {
        static string SecretCode { get { return "Roses are Red"; } }
        static void Main(string[] args)
        {
            bool safe = false;
            try
            {
                string secretCode = safe
                    ? SecretCode
                    : throw new Exception("Not safe to get code.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
