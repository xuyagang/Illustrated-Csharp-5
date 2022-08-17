using System;

namespace C_18_10_4_接口的协变与逆变
{
    class Animal { public string Name; }
    class Dog : Animal { }

    // out 是协变关键字
    interface IMyIfc<out T>   // 泛型接口，接口中使用了 out 协变标识符
    {
        T GetFirst();
    }

    class SimpleReturn<T> : IMyIfc<T>
    {
        public T[] items = new T[2];   // 两个元素的数组，数组一旦创建，大小固定，不支持动态扩展
        public T GetFirst()
        {
            return items[0];
        }
    }
    class Program
    {
        static void DoSomething(IMyIfc<Animal> returner)   // 该方法接受由Animal类型构建的泛型接口作为参数
        {
            Console.WriteLine(returner.GetFirst().Name);
        }

        static void Main(string[] args)
        {
            SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog>();   // 使用Dog创建泛型类SimpleReturn的构造实例
            dogReturner.items[0] = new Dog() { Name = "Avonlea" };   // 初始化了实例的一个item值
            IMyIfc<Animal> animalReturner = dogReturner;   // 把泛型类的实例dogReturner赋值给栈上的一个变量，采用Animal类型构建
            DoSomething(dogReturner);   // 使用实现接口的构造协变类调用DoSomething方法
        }
    }
}
