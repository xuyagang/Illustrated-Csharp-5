using System;
using System.Collections.Generic;

namespace C_10_9_2_其他类型模式表达式
{
    public abstract class Shape { }   // 抽象类是设计为被继承的类
    public class Square : Shape
    {
        public double Side { get; set; }   // 属性
    }
    public class Circle :Shape
    {
        public double Radius { get; set; }
    }
    public class Triangle : Shape
    {
        public double Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Radius = 7 });   // 对象初始化语句，可初始化字段和属性
            shapes.Add(new Square() { Side = 5 });
            shapes.Add(new Triangle() { Height = 4 });
            var nullSquare = (Square)null;
            shapes.Add(nullSquare);

            foreach (var shape in shapes)
            {
                switch (shape)   // 此处有括号
                {
                    case Circle circle:
                        Console.WriteLine($"This shape is a circle of radius {circle.Radius}");
                        break;
                    case Square square when square.Side > 10:   // 仅仅匹配一部分Square
                        Console.WriteLine($"This shape is a large square of side {square.Side}");
                        break;
                    case Square square:
                        Console.WriteLine($"This shape is a square of side {square.Side}");
                        break;
                    case Triangle triangle:   // 等价于 if(shape is Triangle)
                        Console.WriteLine($"This shape is a triangle of height {triangle.Height}");
                        break;
                    //case Triangle triangle when triangle.Height > 5:
                    //    Console.WriteLine($"This shape is a triangle of height {triangle.Height}");
                    //    break;
                    case null:
                        Console.WriteLine($"This shape could be a Square, Circle or a Triangle");
                        break;
                    default:
                        throw new ArgumentException(message: "shape is not a recongnized shape", paramName: nameof(shape));
                }
            }
        }
    }
}
