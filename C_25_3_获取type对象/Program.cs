using System;
using System.Reflection;

namespace C_25_3_获取type对象
{
    class BaseClass
    {
        public int _BaseField = 0;
    }
    class DerivedClass : BaseClass
    {
        public int _DerivedField = 0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var bc = new BaseClass();
            var dc = new DerivedClass();

            BaseClass[] bca = new BaseClass[] {bc, dc};

            foreach (var v in bca)
            {
                Type t = v.GetType();
                Console.WriteLine($"Object type: {t.Name}");

                FieldInfo[] fi = t.GetFields();
                foreach(var f in fi)
                {
                    Console.WriteLine($"      Field: {f.Name}");
                }    
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");

            // 获取type的程序集
            Assembly assembly = bca.GetType().Assembly;
            // 程序集名称
            Console.WriteLine(assembly.FullName);
            // 获取程序集下的类型
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }

        }
    }
}
