using System;

namespace C_12_2_2_位标志示例
{
    // 带Flags枚举类型
    [Flags]
    enum CardDeckSettings : uint
    {
        SingleDeck = 0x01,
        LargePictures = 0x02,
        FancyNumbers = 0x04,
        Animation = 0x08
    }

    class MyClass
    {
        bool UseSingleDeck               = false,
             UseBigPics                  = false,
             UseFancyNumber              = false,
             UseAnimation                = false,
             UseAnimationAndFancyNumbers = false;
        public void SetOptions(CardDeckSettings ops)
        {
            UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
            UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
            UseFancyNumber = ops.HasFlag(CardDeckSettings.FancyNumbers);
            UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
            UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
