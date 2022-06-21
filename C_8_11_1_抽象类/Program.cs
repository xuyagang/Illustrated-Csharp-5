using System;

namespace C_8_11_1_抽象类
{
    abstract class AbClass          //抽象类
    {
        public void IdentifyBase()          //普通方法
        {
            Console.WriteLine("I am AbClass");         
        }

        abstract public void IdentifyDerived();          //抽象方法
    }
    class DerivedClass:AbClass
    {
        public override void IdentifyDerived()
        {
            Console.WriteLine("I am derived class");
        }
    }
    class Program
    {
        static void Main()
        {
            //AbClass a = new AbClass();                  //错误，抽象类不能实例化
            //a.IdentifyBase();

            DerivedClass b = new DerivedClass();    //实例化派生类
            b.IdentifyBase();                                      //调用继承方法
            b.IdentifyDerived();                                 //调用抽象方法
        }
    }
}
