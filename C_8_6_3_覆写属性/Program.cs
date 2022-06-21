using System;

namespace C_8_6_3_覆写属性
{
    class MybaseClass
    {
        private int _myInt = 5;
        virtual public int MyProperty
        {
            get { return _myInt; }
        }
    }
    class MyDerivedClass : MybaseClass
    {
        private int _myInt = 10;
        public override int MyProperty
        {
            get { return _myInt; }
        }
    }
    class Program
    {
        static void Main()
        {
            MyDerivedClass derived = new MyDerivedClass();
            MybaseClass mybc = (MybaseClass)derived;
            MybaseClass mb = new MybaseClass();

            Console.WriteLine(derived.MyProperty);
            Console.WriteLine(mybc.MyProperty);
            Console.WriteLine(mb.MyProperty);
        }
    }
}
