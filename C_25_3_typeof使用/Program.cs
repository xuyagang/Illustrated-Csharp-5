using System;
using System.Reflection;

namespace C_25_3_typeof使用
{
    class BaseClass
    {
        public int BaseField;
    }
    class DerivedClass: BaseClass
    {
        public int DerivedField;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type tbc = typeof(DerivedClass);   // 获取类型
            Console.WriteLine($"Object type: {tbc.Name}");
            FieldInfo[] fi = tbc.GetFields();
            foreach (var f in fi)
            {
                Console.WriteLine($"      Field: {f.Name}");
            }

        }
    }
}
