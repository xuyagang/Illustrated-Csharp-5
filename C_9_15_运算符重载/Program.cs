using System;

namespace C_9_15_运算符重载
{
    class LimitedInt
    {
        const int MaxValue = 100;
        const int MinValue = 0;
        private int _TheValue = 0;

        public int TheValue
        {
            get { return _TheValue; }
            set
            {
                //value是属性的隐式值参，可以像普通变量一样使用，如赋值
                if (value < MinValue)
                    _TheValue = 0;
                else
                    _TheValue = value > MaxValue ? MaxValue : value;
            }
        }

        public static LimitedInt operator -(LimitedInt x)
        {
            // 该类中取负数等于0
            LimitedInt li = new LimitedInt();
            li.TheValue = 0;
            return li;
        }

        public static LimitedInt operator -(LimitedInt x, LimitedInt y)
        {
            // 声明一个用于返回值的类型
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue - y.TheValue;
            return li;
        }

        public static LimitedInt operator +(LimitedInt x, double y)
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue + (int)y;
            return li;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LimitedInt li1 = new LimitedInt();
            LimitedInt li2 = new LimitedInt();
            LimitedInt li3 = new LimitedInt();
            li1.TheValue = 10; li2.TheValue = 26;
            Console.WriteLine($"li1:{li1.TheValue}, li2:{li2.TheValue}");

            li3 = -li1;
            Console.WriteLine($"-{li1.TheValue} = {li3.TheValue}");

            li3 = li2 - li1;
            Console.WriteLine($"{li2.TheValue} - {li1.TheValue} = {li3.TheValue}");

            li3 = li1 - li2;
            Console.WriteLine($"{li1.TheValue} - {li2.TheValue} = {li3.TheValue}");
        }
    }
}
