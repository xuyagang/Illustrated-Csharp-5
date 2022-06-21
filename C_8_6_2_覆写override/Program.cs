using System;

namespace C_8_6_2_覆写override
{
    class MyBaseClass                                                               //基类
    {
        virtual public void Print()
        { Console.WriteLine("This is the base class."); }
    }
    class MyDerivedClass : MyBaseClass                                  //派生类
    {
        override public void Print()
        { Console.WriteLine("This is the derived class."); }
    }
    class SecondDerived : MyDerivedClass                            //最高派生类
    {
        //情况一：使用override声明Print
        //public override void Print()
        //情况二：使用new声明Print
        new public void Print()
        { Console.WriteLine("This is the second derived class."); }
    }
    class Program
    {
        static void Main()
        {
            SecondDerived derived = new SecondDerived();
            MyBaseClass mybc = (MyBaseClass)derived;

            derived.Print();
            mybc.Print();
        }
    }
}
