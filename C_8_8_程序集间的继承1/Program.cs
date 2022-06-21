using System;
using C_8_8_程序集间的继承;

namespace C_8_8_程序集间的继承1
{
    class DerivedClass : MyBaseClass
    {
    }
    class Program
    {
        static void Main()
        {
            DerivedClass ds = new DerivedClass();
            ds.PrintMe();
        }
    }
}
