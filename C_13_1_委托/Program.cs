using System;

namespace C_13_1_委托
{
    // 声明委托类型
    delegate void MyDel(int value);
    class Program
    {
        void PrintLow(int value)
        {
            Console.WriteLine("{0} - Low Value", value);
        }
        void PrintHigth(int value)
        {
            Console.WriteLine("{0} - High Value", value);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // 声明委托变量
            MyDel del;
            // 创建随机整数生成器对象，并得到0-99之间的随机数
            Random rand = new Random();
            int randomValue = rand.Next(99);
            // 创建一个包含PrintLow或PrintHigh的委托对象并将其赋值给del变量
            del = randomValue < 50
                      ? new MyDel(program.PrintLow)
                      : new MyDel(program.PrintHigth);
            // 执行委托
            del(randomValue);
        }
    }
}
