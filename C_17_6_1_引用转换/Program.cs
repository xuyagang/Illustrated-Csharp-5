using System;

namespace C_17_6_1_引用转换
{
    class A { public int Field1; }
    class B : A { public int Field2; }
    class Program
    {
        static void Main(string[] args)
        {
            //B myVar1 = new B();
            //A myVar2 = (A) myVar1;     // 作为A类的引用返回myVar1的引用

            //Console.WriteLine($"{myVar2.Field1}");   // 正确
            //// Field2对于myVar2不可见
            ////Console.WriteLine($"{myVar2.Field2}");   // 编译错误

            A myVar1 = new A();
            B myVar2 = (B) myVar1;
        }
    }
}