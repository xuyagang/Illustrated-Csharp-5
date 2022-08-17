using System;

namespace C_18_10_5_可变性
{
    class Animal { public int Legs = 4; }   // 基类
    class Dog : Animal { }   // 派生类

    internal class Program
    {
        delegate T Factory<out T>();   // 泛型委托，out关键字指定了类型参数的协变

        static Dog MakeDog() { return new Dog(); }

        static void Main(string[] args)
        {
            Factory<Animal> animalMaker1 = MakeDog;   // 隐式强制转换
            
            Factory<Dog> dogMaker = MakeDog;
            Factory<Animal> animalMaker2 = dogMaker;   // 需要out标识符

            Factory<Animal> animalMaker3 = new Factory<Dog>(MakeDog);   // 需要out标识符
        }
    }
}
