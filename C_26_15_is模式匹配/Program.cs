﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_15_is模式匹配
{
    public interface IOne
    {
        int SampleIntProperty { get; set; }
    }
    public interface ITwo
    {
        int SampleIntProperty2 { get; set; }
    }

    public class BaseClass
    { 
        public string SampleStringProperty { get; set; }
    }
    public class DerivedClass : BaseClass, IOne, ITwo
    {
        public int SampleIntProperty { get; set; }
        public int SampleIntProperty2 { get; set; }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            if (dc is DerivedClass)
            { 
                Console.WriteLine("Derived Class found"); 
            }

            if (dc is BaseClass)
            { Console.WriteLine("Base Class found"); }

            if (dc is IOne)
            { Console.WriteLine("Interface One found"); }

            if (dc is ITwo)
            { Console.WriteLine("Interface Tow found"); }
        }
    }
}
