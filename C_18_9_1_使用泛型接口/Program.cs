using System;

namespace C_18_9_1_使用泛型接口
{
    // 泛型接口
    interface IMyIfc<T>   
    {
        T ReturnIt(T inValue);
    }
    // 源于同一泛型接口的两个不同接口
    class Simple : IMyIfc<int>, IMyIfc<string>   // 非泛型类
    {
        public int ReturnIt(int inValue)   // 实现int类型接口
        {
            return inValue;
        }
        public string ReturnIt(string inValue)   // 实现string类型接口
        {
            return inValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Simple trivial = new Simple();

            Console.WriteLine(trivial.ReturnIt(5));
            Console.WriteLine(trivial.ReturnIt("Hi there"));
        }
    }
}