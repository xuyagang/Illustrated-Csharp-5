using System;

namespace C_18_10_1_协变
{
    //class Animal
    //{
    //    public int NumberOfLegs = 4;
    //}

    //class Dog : Animal
    //{ 
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal a1 = new Animal();
    //        Animal a2 = new Dog();

    //        Console.WriteLine($"Number of dog legs: {a2.NumberOfLegs}");
    //    }
    //}



    class Animal { public int Legs = 4;}   // 基类
    class Dog : Animal { }   // 派生类
    delegate T Factory<out T>();   // 委托
    class Program
    {
        static Dog MakeDog()   // 符合Factory委托的方法
        {
            return new Dog();
        }
        static void Main()
        {
            Factory<Dog> dogMaker = MakeDog;   // 创建委托对象
            Factory<Animal> animalMaker = dogMaker;   // 尝试赋值委托对象，会编译错误
        }
    }
}