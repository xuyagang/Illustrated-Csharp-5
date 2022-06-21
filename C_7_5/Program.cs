using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_5
{
    class D
    {
        int           Mem1;
        static int Mem2;
        //设置两个数据成员的值
        public void SetVars(int v1, int v2)
        { Mem1 = v1; Mem2 = v2; }
        //显示两个数据成员的值
        public void Display(string str)
        {Console.WriteLine("{0}: Mem1 = {1}, Mem2 = {2}", str, Mem1, Mem2);}
    }
    class Program
    {
        static void Main()
        {
            //创建两个实例
            D d1 = new D(), d2 = new D();
            d1.SetVars(2, 4);
            d1.Display("d1");
            d2.SetVars(12, 34);
            d2.Display("d2");
            d1.Display("d1");
        }
    }
}
