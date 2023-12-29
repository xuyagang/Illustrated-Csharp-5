using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_22_表达式函数体成员
{
    internal class MyClass
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass("test");
        }

        string Var1;
        
        // 构造函数
        public MyClass(string var1) => this.Var1 = var1;

        // 析构函数
        ~MyClass() => Console.WriteLine("Unmanaged resources have been released");

        public string Area
        {
            get => Var1;
            set => Var1 = value;
        }
    }
}