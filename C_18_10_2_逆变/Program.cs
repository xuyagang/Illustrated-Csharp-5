using System;

namespace C_18_10_2_逆变
{
    // 动物类
    class Animal { public int NumberOfLegs = 4; }
    // 狗子类
    class Dog : Animal { }

    class Program
    {
        delegate void Action1<in T>(T a);   // 委托
        static void ActOnAnimal(Animal a) { Console.WriteLine(a.NumberOfLegs.ToString()); }

        static void Main(string[] args)
        {
            Action1<Animal> act1 = ActOnAnimal;   // 委托1:期待传入基类类型参数
            Action1<Dog> dog1 = act1;   // 把委托1赋值给委托2(期待传入更高程度的派生类型)
            dog1(new Dog());   // 调用委托
            //act1(new Dog());
        }
    }
}
