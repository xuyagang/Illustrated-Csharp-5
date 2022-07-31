using System;

namespace C_18_9_泛型接口1
{
    // 泛型接口
    interface IMyIfc<T>
    {
        T ReturnIt(T inValue);
    }

    // 泛型类
    class Simple<S> : IMyIfc<S>
    {
        // 实现泛型接口
        public S ReturnIt(S inValue)
        {
            return inValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var trivInt = new Simple<int>();
            var trivString = new Simple<string>();

            Console.WriteLine(trivInt.ReturnIt(123));
            Console.WriteLine(trivString.ReturnIt("Hi there"));
        }
    }
}