using System;

namespace C_7_11_构造函数
{
    class Class1
    {
        int Id;
        string Name;
        public Class1() { Id = 26; Name = "Nemo"; }             //构造函数1
        public Class1(int val) { Id = val; Name = "Nemo"; }   //构造函数2
        public Class1(string name) { Name = name; }           //构造函数3
        public void SoundOff()
        {
            Console.WriteLine($"Name:{Name}, ID:{Id}");
        }
    }
    class Program
    {
        static void Main()
        {
            Class1 a = new Class1(),              //调用构造函数1
                       b = new Class1(7),           //调用构造函数2
                       c = new Class1("Bill");      //调用构造函数3
            a.SoundOff();
            b.SoundOff();
            c.SoundOff();
        }
    }
}
