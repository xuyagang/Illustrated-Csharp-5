using System;

namespace C6_21_可选参数
{
    class MyClass
    {
        double GetCylinderVolume(double radius = 3.0, double height = 4.0)
        {
            return 3.1415 * radius * radius * height;
        }
        static void Main()
        {
            MyClass mc = new MyClass();
            double volume;
            volume = mc.GetCylinderVolume(3.0, 4.0);            //位置参数
            Console.WriteLine("volume = " + volume);
            volume = mc.GetCylinderVolume(radius:5.0);            //height默认值
            Console.WriteLine("volume = " + volume);
            volume = mc.GetCylinderVolume(height:7.0);            //radius默认值
            Console.WriteLine("volume = " + volume);
            volume = mc.GetCylinderVolume();            //两个默认值
            Console.WriteLine("volume = " + volume);

        }
    }
}
