using System;

namespace C_8_2_继承
{
    class SomeClass                             //基类
    {
        public string Field1 = "base class field";
        public void Method1(string value)
        {
            Console.WriteLine($"base class method1: {value}");
        }
    }
    class OtherClass: SomeClass           //派生类
    {
        public string Field2 = "derived class field";
        public void Method2(string value)
        {
            Console.WriteLine($"Derived class method2:{value}");
        }
    }
    class Program
    {
        static void Main()
        {
            OtherClass oc = new OtherClass();
            oc.Method1(oc.Field1);                      //以基类字段为参数的基类方法
            oc.Method1(oc.Field2);                      //派生类字段为参数的基类方法
            oc.Method2(oc.Field1);                      //以基类字段为参数的派生方法
            oc.Method2(oc.Field2);                      //派生类字段为参数的派生方法
        }
    }
}
