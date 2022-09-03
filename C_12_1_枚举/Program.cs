using System;

namespace C_12_1_枚举
{
    class Program
    {
        enum TrafficLight
        {
            绿,
            黄,
            红
        }


        static void Main(string[] args)
        {
            TrafficLight t1 = TrafficLight.绿;
            TrafficLight t2 = TrafficLight.黄;
            TrafficLight t3 = TrafficLight.红;

            Console.WriteLine($"{t1}, {(int)t1}");
            Console.WriteLine($"{t2}, {(int)t2}");
            Console.WriteLine($"{t3}, {(int)t3}");

            Console.WriteLine($"{TrafficLight.黄}");
        }
    }
}
