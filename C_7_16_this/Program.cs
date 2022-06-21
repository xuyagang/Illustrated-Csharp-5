using System;

namespace C_7_16_this
{
    class MyClass
    {
        int Var1 = 10;
        public int ReturnMaxSum(int Var1)
        {
            //        参数            字段
            return Var1  > this.Var1 
                                 ? Var1               //参数
                                 : this.Var1;        //字段
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            Console.WriteLine($"Max:{mc.ReturnMaxSum(3)}");
            Console.WriteLine($"Max:{mc.ReturnMaxSum(22)}");
        }
    }
}
