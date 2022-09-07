using System;

namespace C_25_9_2_使用GetCustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MyAttributeAttribute: Attribute
    {
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public string ReviewerID { get; set; }

        public MyAttributeAttribute(string desc, string ver)
        {
            Description = desc;
            VersionNumber = ver;
        }
    }
    
    [MyAttribute("Check it out", "2.5")]
    class MyClass
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            object[] AttArr = t.GetCustomAttributes(false);   // 获取应用到MyClass上的特性的数组

            foreach (object a in AttArr)
            {
                MyAttributeAttribute attr = a as MyAttributeAttribute;
                if (attr != null)
                {
                    Console.WriteLine("Description   :{0}", attr.Description);
                    Console.WriteLine("VersionNumber :{0}", attr.VersionNumber);
                    Console.WriteLine("Reviewer Id   :{0}", attr.ReviewerID);
                }
            }
        }
    }
}
