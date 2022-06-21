using System;

namespace C_14_3_3_捕获变量
{
    internal class Program
    {
        delegate void MyDel();
        static void Main(string[] args)
        {
            MyDel mDel;
            // x的作用域
            {
                int x = 5;
                // x被匿名方法捕获
                mDel = delegate {Console.WriteLine($"Value of x:{x}");};
            }

            // x离开了作用域，会导致编译错误
            Console.WriteLine($"Value of x:{x}");

                if (mDel != null)
                // 此处使用了x, 在匿名方法内部
                    mDel();
        }
    }
}
