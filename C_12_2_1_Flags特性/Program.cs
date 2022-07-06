using System;

namespace C_12_2_1_Flags特性
{
    internal class Program
    {
        enum Suits { Spade = 1, Clubs = 2, Diamonds = 4, Hearts = 8 }
        [Flags] enum SuitsFlags { Spade = 1, Clubs = 2, Diamonds = 4, Hearts = 8 }


        [Flags] enum test { Spade=0, Clubs=9, Diamonds=5, Hearts=0}

        static void Main(string[] args)
        {
            var str1 = (Suits.Spade | Suits.Diamonds).ToString();
            var str2 = (SuitsFlags.Spade | SuitsFlags.Hearts).ToString();
            var str3 = (test.Clubs | test.Hearts).ToString();

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
