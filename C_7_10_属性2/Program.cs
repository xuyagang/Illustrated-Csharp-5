using System;

namespace C_7_10_属性2
{
    class C1
    {
        //没有声明后备字段
        public int MyValue         //分配内存
        {
            //访问器的方法体被声明为分号
            set; get;
        }
        class Program
        {
            static void Main()
            {
                C1 c = new C1();
                Console.WriteLine("MyValue:{0}", c.MyValue);

                c.MyValue = 10;
                Console.WriteLine("MyValue:{0}", c.MyValue);
            }
        }
    }
}
