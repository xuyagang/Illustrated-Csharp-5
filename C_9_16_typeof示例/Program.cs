using System;
using System.Diagnostics;
// 使用反射命名空间来全面利用检测类型信息的功能
using System.Reflection;


namespace C_9_16_typeof示例
{
    class SomeClass
    {
        public int Field1;
        public int Field2;

        public void Method1() { }
        public int Method2() { return 1; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(SomeClass);
            FieldInfo[] fi = t.GetFields();
            MethodInfo[] mi = t.GetMethods();

            foreach (FieldInfo f in fi)
                Console.WriteLine($"Field:{f.Name}");
            foreach (MethodInfo m in mi)
                Console.WriteLine($"Method:{m.Name}");

            SomeClass s = new SomeClass();
            Console.WriteLine($"\nType s:{s.GetType().Name}");
        }
    }
}
