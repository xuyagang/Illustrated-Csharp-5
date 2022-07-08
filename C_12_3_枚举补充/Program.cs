using System;

namespace C_12_3_枚举补充
{
    enum TrafficLight
    {
        Green,
        Yellow,
        Red,
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Second member of TrafficLight is {0}\n",
                               Enum.GetName(typeof(TrafficLight), 1));

            Console.WriteLine(Enum.GetName(typeof(TrafficLight), 5) == null);
            Console.WriteLine();

            foreach (var name in Enum.GetNames(typeof(TrafficLight)))
                Console.WriteLine(name);
        }
    }
}
