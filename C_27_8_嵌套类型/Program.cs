using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_8_嵌套类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Incr(); mc.Incr(); mc.Incr();
            mc.Incr(); mc.Incr(); mc.Incr();
            Console.WriteLine($"Total:{mc.GetValue()}");
        }
    }

    class MyClass  // 封闭类
    {
        class MyCounter  // 嵌套类
        {
            public int Count { get; set; }
            public static MyCounter operator ++(MyCounter current)
            {
                current.Count++;
                return current;
            }
        }

        // 嵌套类类型的字段
        private MyCounter counter;
        // 构造函数
        public MyClass() { counter = new MyCounter(); }
        // 增量方法
        public int Incr() { return (counter++).Count; }
        // 获取计数
        public int GetValue() { return counter.Count; }
    }
}
