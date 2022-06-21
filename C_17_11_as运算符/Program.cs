using System;

namespace C_17_11_as运算符
{
    class Employee : Person { }
    class Person
    {
        public string Name = "Anonymous";
        public int Age = 25;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            Person p;

            p = bill as Person;
            if (p != null)
            {
                Console.WriteLine($"Person Info : {p.Name}, {p.Age}");
            }
        }
    }
}
