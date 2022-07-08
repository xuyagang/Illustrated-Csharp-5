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
        // 声明多个字段
        bool UseSingleDeck               = false,
             UseBigPics                  = false,
             UseFancyNumber              = false,
             UseAnimation                = false,
             UseAnimationAndFancyNumbers = false;
        // 通过传入的标志字判断是否含有位标志，对字段进行赋值
        public void SetOptions(CardDeckSettings ops)
        {
            UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
            UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
            UseFancyNumber = ops.HasFlag(CardDeckSettings.FancyNumbers);
            UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
            UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);   // true
        }
        public void PrintOptions()
        {
            Console.WriteLine("Option Settings:");
            Console.WriteLine("Use Single Deck - {0}", UseSingleDeck);
            Console.WriteLine("Use Large Pictures - {0}", UseBigPics);
            Console.WriteLine("Use Fancy Numbers - {0}", UseFancyNumber);
            Console.WriteLine("Show Animation - {0}", UseAnimation);
            Console.WriteLine("Show Animation and FancyNumbers - {0}", UseAnimationAndFancyNumbers);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建标志字，并对位标志进行设置
            CardDeckSettings ops = CardDeckSettings.SingleDeck
                                 | CardDeckSettings.FancyNumbers
                                 | CardDeckSettings.Animation;
            MyClass mc = new MyClass();
            mc.SetOptions(ops);
            mc.PrintOptions();
        }
    }
}