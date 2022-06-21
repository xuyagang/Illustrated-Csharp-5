using System;

namespace C_17_9_2_用户自定义转换
{
    class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // 将Person转换为int
        public static implicit operator int(Person p)
        {
            return p.Age;
        }
        // 将int转换为Person
        public static implicit operator Person(int i)
        {
            return new Person("Nemo", i);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("bill", 25);

            // 把Person转换为int
            int age = bill;
            Console.WriteLine($"Person Info:{bill.Name}, {age}");

            // 把int转换为Person
            Person anon = 35;
            Console.WriteLine($"Person Info:{anon.Name}, {anon.Age}");
        }
    }
}
