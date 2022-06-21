using System;
using System.Linq;

namespace C_19_6_1_查询运算符签名
{
    internal class Program
    {
        enum FaceCards
        {
            Jack = 5,
            Queen,
            King,
            Ace,
            NumberOfFaceCards = 19,
            SomeOtherValue,
            HighestFaceCard = Ace
        }
        static void Main()
        {
            //FaceCards a = FaceCards.Jack;
            //FaceCards b = FaceCards.Queen;
            //FaceCards c = FaceCards.King;
            //FaceCards d = FaceCards.Ace;
            //FaceCards e = FaceCards.NumberOfFaceCards;
            //FaceCards f = FaceCards.SomeOtherValue;
            //FaceCards g = FaceCards.HighestFaceCard;
            //Console.WriteLine($"{(int)a}-{(int)b}-{(int)c}-{(int)d}-{(int)e}-{(int)f}-{(int)g}");


            int[,,] intArr = new int[,,] {
                { {1,2 },{1,2  },{1,2  } },
                { {1,2 },{1,2  },{1,2  }},
                { {1,2 },{1,2  },{1,2  }},
                { {1,2 },{1,2  },{1,2  }}
            };


        }
    }
}
