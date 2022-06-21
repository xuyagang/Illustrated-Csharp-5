using System;

namespace C_8_11_2_抽象类
{
    abstract class Mybase           //抽象和非抽象成员的组合
    {
        public int SideLength = 50;                 //数据成员
        const int TriangleSideCount = 3;        //数据成员

        abstract public void PrintStuff(string s);        //抽象方法
        abstract public int MyInt { get; set; }             //抽象属性

        public int PerimeterLength()            //普通非抽象方法
        {
            return TriangleSideCount * SideLength;
        }
    }

    class MyClass : Mybase
    {
        public override void PrintStuff(string s)       //覆盖抽象方法
        {
            Console.WriteLine(s);
        }
        private int _myInt;
        public override int MyInt           //覆盖抽象属性
        {
            get { return _myInt; }
            set { _myInt = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            //创建继承类的实例
            MyClass mc = new MyClass();
            mc.PrintStuff("This is a string");
            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);
            //继承类可直接调用非抽象方法
            Console.WriteLine("Perimeter length:{0}", mc.PerimeterLength());
            double a = 0.5;
            Type t = mc.GetType();
            Console.WriteLine($"---{t}---test");
        }
    }
}
