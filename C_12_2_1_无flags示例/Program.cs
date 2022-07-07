using System;

namespace C_12_2_1_无flags示例
{
    // uint 无符合整型
    [Flags]
    enum CardDeckSettings : uint
    {
        SingleDeck = 0x01,
        LargePicture = 0x02,
        FancyNumbers = 0x04,
        Animation = 0x08,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeckSettings ops;   // 创建标志字
            ops = CardDeckSettings.FancyNumbers;   // 设置一个标志
            Console.WriteLine(ops.ToString());

            // 设置两个标志值
            ops = CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
            Console.WriteLine(ops.ToString());
        }
    }
}
