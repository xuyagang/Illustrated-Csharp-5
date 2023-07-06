using System;

namespace C_8_6_1_虚方法和覆写方法
{
    class MyBaseClass
    {
        virtual public void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public override void Print()
        {
            //base.Print();
            Console.WriteLine("This is the derived class");
        }
    }

    class Program
    {
        static void Main()
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            MyBaseClass myBaseClass = (MyBaseClass)myDerivedClass;

            myDerivedClass.Print();
            myBaseClass.Print();
        }
    }
}