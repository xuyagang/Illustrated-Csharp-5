using System;

namespace C_9_4_自定义强制转换
{
    class LimitedInt
    {
        const int MaxValue = 100;
        const int MinValue = 0;
        //      必须的                 目标类型    源数据  
        public static explicit operator int(LimitedInt li)   // 类型转换
        {
            return li.TheValue;
        }
        //      必须的                    目标类型   源数据  
        public static explicit operator LimitedInt(int x)   // 类型转换
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = x;
            return li;
        }

        private int _theValue = 0;
        public int TheValue   // 属性
        {
            get { return _theValue; }
            set
            {
                if (value < MinValue)
                    _theValue = 0;
                else
                    _theValue = value > MaxValue ? MaxValue : value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LimitedInt li = (LimitedInt)500;    // 将500转换为LimitedInt
            int value = (int)li;         // 将LimitedInt转换为int
            Console.WriteLine($"li:{li.TheValue}, value:{value}");
        }
    }
}