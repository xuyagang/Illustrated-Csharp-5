using System;

namespace C_17_10_is运算符
{
    class Employee : Person { }
    class Person
    {
        public String Name = "Anonymous";
        public int Age = 25;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            // 检测bill是否能转换为Person类型
            if (bill is Person)
            {
                Person p = bill;
                Console.WriteLine($"Person Info : {p.Name}, {p.Age}");
            }
        }
    }
}