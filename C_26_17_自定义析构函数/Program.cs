using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_17_自定义析构函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 调用域
            // 析构函数如何工作
            var student = GetStudentEnrollmentInfo(1);
            Console.WriteLine($"Student name: {student.name} Course: {student.course}");

            // 如果没有析构函数功能，只能通过没有描述性的Item1、Item2名称来访问ValueTuple
            Console.WriteLine($"Student name: {student.Item1} Course: {student.Item2}");

            (string name, string course) myValueTuple = ("Daniel", "Particle Physics");
            Console.WriteLine($"Student name: {myValueTuple.name} Course: {myValueTuple.course}");




            // 自定义类型析构函数测试
            (double latitude, string northSouth, double longtitude, string eastWest) =
                new GeoLocation(51.47, "NN", 0.21, "W");
            Console.WriteLine($"Location is {latitude}-{northSouth}, {longtitude}-{eastWest}");



            // 扩展方法实现析构函数示例
            (double latitude1, string northSouth1, double longtitude1, string eastWest1) =
                new GeoLocationWithoutDec(51.47, "NN", 0.21, "W");
            Console.WriteLine($"Location1 is {latitude1}-{northSouth1}, {longtitude1}-{eastWest1}");



        }

        // 示例 - 将 ValueTuple 析构成元素
        // 注意此处的函数类型
        public static (string name, string course) GetStudentEnrollmentInfo(int id)
        {
            // 取值
            return ("Connor", "ComputerScience");
        }
    }

    public static class Extensions
    {
        // 扩展析构方法
        public static void Deconstruct(this GeoLocationWithoutDec glWithoutDec,
            out double latitude, out string northSouth, out double longtitude, out string eastWest)
        {
            latitude = glWithoutDec.Latitude;
            northSouth = glWithoutDec.NorthSouth;
            longtitude = glWithoutDec.Longtitude;
            eastWest = glWithoutDec.EastWest;
        }
    }

    // 自定义类型使用析构
    public class GeoLocation
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public string NorthSouth { get; set; }
        public string EastWest { get; set; }

        public GeoLocation(double latitude, string northSouth, double longtitude, string eastWest)
        {
            Latitude = latitude;
            NorthSouth = northSouth;
            Longtitude = longtitude;
            EastWest = eastWest;
        }

        // 析构函数
        public void Deconstruct(out double latitude, out string northSouth, out double longtitude, out string eastWest)
        {
            latitude = Latitude;
            northSouth = NorthSouth;
            longtitude= Longtitude;
            eastWest = EastWest;
        }
    }

    public class GeoLocationWithoutDec
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public string NorthSouth { get; set; }
        public string EastWest { get; set; }

        public GeoLocationWithoutDec(double latitude, string northSouth, double longtitude, string eastWest)
        {
            Latitude = latitude;
            NorthSouth = northSouth;
            Longtitude = longtitude;
            EastWest = eastWest;
        }
    }
}
