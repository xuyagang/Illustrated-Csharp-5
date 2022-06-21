using System;

namespace C_16_1_接口
{
    // 声明接口
    interface IInfo
    {
        string GetName();
        string GetAge();
    }

    // 声明实现接口的类
    class CA : IInfo   // 将接口放到基类列表中
    {
        public string Name;
        public int Age;
        // 在类中实现两个接口方法
        public string GetName() { return Name; }
        public string GetAge() { return Age.ToString(); }
    }

    // 声明实现接口的类
    class CB : IInfo
    {
        public string First;
        public string Last;
        public double PersonsAge;
        // 在类中实现两个接口方法
        public string GetName() { return First + " " + Last; }
        public string GetAge() { return PersonsAge.ToString(); }
    }

    class Program
    {
        static void PrintInfo(IInfo item)   // 传入接口的引用
        {
            Console.WriteLine("Name:{0}, Age:{1}", item.GetName(), item.GetAge());
        }
        static void Main()
        {
            CA a = new CA() { Name = "John Doe", Age = 35 };
            CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };
            // 对象的引用能自动转换为它们实现的接口的引用
            PrintInfo(a);
            PrintInfo(b);
        }
        Array a;
    }
}