using System;

namespace C_8_5_基类访问
{
    class SomeClass         //基类
    {
        public string Field1 = "Field1 --- In the base class";
    }
    class OtherClass : SomeClass        //派生类
    {
        //屏蔽基类字段
        new public string Field1 = "Field1 --- In the derived class";
        public void PrintField1()
        {
            Console.WriteLine(Field1);              //访问派生类
            Console.WriteLine(base.Field1);      //访问基类
        }
    }
    class Program
    {
        static void Main()
        {
            OtherClass oc = new OtherClass();
            oc.PrintField1();
        }
    }
}