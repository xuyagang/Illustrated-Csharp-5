using System;

namespace C_17_9_4_多步用户自定义转换
{
    class Employee : Person { }
    class Person
    {
        public string Name;
        public int Age;
        // 将Person转换为int
        public static implicit operator int (Person p)
        {
            return p.Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            bill.Name = "William";
            bill.Age = 25;
            // 把Employee 转换为 float
            float fVar = bill;
            Console.WriteLine($"Person Info: {bill.Name}, {fVar}");
        }
    }
}