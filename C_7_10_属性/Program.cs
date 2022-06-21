using System;

namespace C_7_10_属性
{
    class C1
    {
        private int theRealValue = 10;          //后备字段
        public int MyValue                           //属性：不分配内存
        {
            set { theRealValue = value; }
            get { return theRealValue; }
        }
    }
    class Program
    {
        static void Main()
        {
            C1 c = new C1();
            Console.WriteLine("MyValue:{0}", c.MyValue);
            c.MyValue = 111;
            Console.WriteLine("MyValue:{0}", c.MyValue);

        }
    }
}
