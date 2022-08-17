using System;

namespace C_18_10_1_协变
{
<<<<<<< HEAD
    class Animal { public int Legs = 4; }   // 基类
    class Dog : Animal { }   // 派生类

    delegate T Factory<out T>();   // Factory委托

    internal class Program
    {
        static Dog MakeDog()   // 匹配Factory委托的方法
        {
            return new Dog();
        }

        static void Main(string[] args)
        {
            Factory<Dog> dogMaker = MakeDog;   // 创建委托对象
            Factory<Animal> animalMaker = dogMaker;   // 尝试赋值委托类型(派生类类型应该可以赋值给基类构造的委托)

            Console.WriteLine(animalMaker().Legs.ToString());
        }
    }
}
=======
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
>>>>>>> 5f48c034837d27efc5c9bcc32a6c71cc46756570
