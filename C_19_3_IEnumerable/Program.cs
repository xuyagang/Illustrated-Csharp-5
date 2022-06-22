using System;
using System.Collections;

namespace C_19_3_IEnumerable
{
    class ColorEnumerator : IEnumerator   // 枚举器类是实现
    {
        string[] colors;
        int position = -1;

        public ColorEnumerator (string[] theColors)   // 构造函数,把传入的数组转为内部数组
        {
            colors = new string[theColors.Length];
            for (int i=0; i< theColors.Length; i++)
                colors[i] = theColors[i];
        }
        public object Current   // 实现Current
        {
            get
            {
                if (position == -1)
                    throw new InvalidOperationException();
                if (position >= colors.Length)
                    throw new InvalidOperationException();
                return colors[position];
            }
        }

        public bool MoveNext()   // 实现MoveNext
        {
            if (position < colors.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    class Spectrum : IEnumerable   // 可枚举类
    {
        string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
        public IEnumerator GetEnumerator()
        {
            // 返回对象的枚举器
            return new ColorEnumerator(Colors);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum spectrum = new Spectrum();
            foreach (string color in spectrum)
                Console.WriteLine(color);
        }
    }
}
