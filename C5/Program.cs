using System;

namespace C5
{
    /*
    class DaysTemp
    {
        public int high = 75;
        public int low = 45;
    }
    class Program
    {
        static void Main()
        {
            DaysTemp temp = new DaysTemp();
            temp.high = 85;
            temp.low = 60;
            Console.WriteLine("High:", temp.high);
            Console.WriteLine($"Low:{temp.low}");
        }
    }
    */

    /*
    //示例
    class DaysTemp                            //声明类
    {
        public int High, Low;                 //声明实例字段
        public int Average()                  //声明实例方法
        {
            return (High + Low) / 2;
        }
    }

    class Program
    {
        static void Main()
        {
            //创建两个DaysTemp的实例
            DaysTemp t1 = new DaysTemp();
            DaysTemp t2 = new DaysTemp();
            //给字段赋值
            t1.High = 76;       t1.Low = 57;
            t2.High = 75;       t2.Low = 53;
            //读取字段值，调用实例的方法
            Console.WriteLine("t1: {0}, {1}, {2}", 
                                                t1.High, t1.Low, t1.Average());
            Console.WriteLine("t2: {0}, {1}, {2}",
                                                t2.High, t2.Low, t2.Average());
        }
    }
    */
    class MyClass
    {
        void PrintDateTime()                            //声明方法
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine($"{ dt }");
        }
        static void Main()                                  //声明方法
        {
            MyClass mc = new MyClass();
            mc.PrintDateTime();                         //调用方法
        }
    }



}
