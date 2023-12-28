using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_20_局部函数1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var corvette = GetRemainingRange(.25, 24, "British");
            Console.WriteLine($"Remaining range is {corvette.distance} {corvette.units}");

            var prius = GetRemainingRange(.04, 12, "Metric");
            Console.WriteLine($"Remaining range is {prius.distance} {corvette.units}");
        }

        public static (double distance, string units) GetRemainingRange(double fuelConsumptionRate, double remainingFuel, string systemofUnits)
        {
            string units = string.Empty;
            switch(systemofUnits)
            {
                case "Metric":
                    units = "Kilometers";
                    break;
                case "British":
                    units = "Miles";
                    break;
            }
            // 注意这个局部函数没有参数
            double CalculateRemainingRange()
            {
                return remainingFuel / fuelConsumptionRate;
            }
            return (CalculateRemainingRange(), units);
        }
    }
}
