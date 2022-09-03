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
        }
    }
}
