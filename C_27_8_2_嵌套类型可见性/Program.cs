using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_8_2_嵌套类型可见性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            sc.PrintMyMember();
        }
    }

    class SomeClass // 封闭类
    {
        int Field1 = 15, Field2 = 20;  // 封闭类字段
        MyNested mn = null;  // 嵌套类引用

        public void PrintMyMember()  // 调用嵌套类中的方法
        {
            mn.PrintOuterMember();
        }

        public SomeClass()  // 构造函数
        {
            // 传入对封闭类的引用
            mn = new MyNested(this);  // 创建嵌套类实例
        }

        class MyNested  //嵌套类
        {
            SomeClass sc = null;  // 封闭类引用
            public MyNested(SomeClass SC)
            {
                sc = SC;  // 存储封闭类引用
            }

            public void PrintOuterMember()
            {
                Console.WriteLine($"Field1: {sc.Field1}");  // 封闭字段
                Console.WriteLine($"Field1: {sc.Field2}");
            }
        }
    }
}
