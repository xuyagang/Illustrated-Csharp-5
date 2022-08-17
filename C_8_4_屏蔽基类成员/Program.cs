using System;

namespace C_8_4_使用基类的引用
{
    class MyBaseClass
    {
        public void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }
    class MyDerivedClass : MyBaseClass
    {
        new public void Print()
        {
            Console.WriteLine("This is the derived class.");
        }
    }
    class Program
    {
        static void Main()
        {
            //创建一个对象（派生类型对象引用）
            MyDerivedClass derived = new MyDerivedClass();
            //转换引用
            MyBaseClass mybc = derived;

            derived.Print();
            mybc.Print();
        }
    }
}
