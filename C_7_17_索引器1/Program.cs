using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_17_索引器1
{
    class Class1
    {
        int Temp0;      //私有字段
        int Temp1;      //私有字段
        public int this [int index]     //索引
        {
            get
            {
                return(0==index)
                    ? Temp0
                    : Temp1;
            }
            set
            {
                if(0 ==index)
                    Temp0 = value;
                else
                    Temp1 = value;
            }
        }
    }
    class Example
    {
        static void Main()
        {
            Class1 a = new Class1();
            Console.WriteLine("Values -- T0:{0},T1:{1}", a[0], a[1]);
            a[0] = 15;
            a[1] = 20;
            Console.WriteLine($"Values -- T0:{a[0]},T1:{a[1]}");
        }
    }
}
