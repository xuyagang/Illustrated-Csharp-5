using System;

namespace C_18_8_泛型委托
{
    // 声明泛型委托
    delegate void MyDelegate<T>(T value);

    class Simple
    {
        //方法匹配委托
        static public void PrintString(string s)   
        {
            Console.WriteLine(s);
        }
        //方法匹配委托
        static public void PrintUpperString(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 创建委托的实例,括号内传入方法名
            var myDel = new MyDelegate<String>(Simple.PrintString);
            // 添加方法
            myDel += Simple.PrintUpperString;
            // 调用委托
            myDel("Hi There");
        }
    }
}
