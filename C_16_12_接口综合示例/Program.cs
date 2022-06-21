using System;

namespace C_16_12_接口综合示例
{
    interface ILiveBirth   // 声明接口
    {
        string BabyCalled();
    }
    class Animal { }      // 基类
    class Cat : Animal, ILiveBirth
    {public string BabyCalled() { return "Kitten"; }}

    class Dog : Animal, ILiveBirth
    { string ILiveBirth.BabyCalled() { return "Puppy"; } }

    class Bird : Animal
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalArray = new Animal[3];
            animalArray[0] = new Cat();
            animalArray[1] = new Bird();
            animalArray[2] = new Dog();

            foreach (Animal animal in animalArray)
            {
                ILiveBirth b = animal as ILiveBirth;
                if (b != null)
                    Console.WriteLine($"Baby is called: {b.BabyCalled()}");
                else
                    Console.WriteLine("NoName");
            }
        }
    }
}
