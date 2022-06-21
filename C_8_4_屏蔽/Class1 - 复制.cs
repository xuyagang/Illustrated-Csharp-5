using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_8_4_屏蔽
{
    class SomeClass     //基类
    {
        public string Field1 = "SomeClass Field1";
        public void Method1(string value)
        {Console.WriteLine("SomeClass.Method1:{0}", value);}
    }
    class OtherClass : SomeClass        //派生类
    {
        //屏蔽基类成员
        new public string Field1 = "OtherClass Field1";
        //屏蔽基类成员
        new public void Method1(string value)
        { Console.WriteLine("OtherClass.Method1:{0}", value); }
    }
    class Program
    {
        static void Main()
        {
            OtherClass os = new OtherClass();
            os.Method1(os.Field1);
        }
    }
}
