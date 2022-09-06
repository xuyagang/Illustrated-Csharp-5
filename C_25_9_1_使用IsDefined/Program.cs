using System;

namespace C_25_9_1_使用IsDefined
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ReviewCommentAttribute: System.Attribute
    {
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public string ReviewID { get; set; }

        public ReviewCommentAttribute(string desc, string ver)
        {
            Description = desc;
            VersionNumber = ver;
        }
    }

    [ReviewComment("Check it out", "2.4")]
    class MyClass { }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();   // 创建类实例
            Type t = mc.GetType();   // 从实例中获取类型对象
            bool isDefined = t.IsDefined(typeof(ReviewCommentAttribute), false);
            if (isDefined)
            {
                Console.WriteLine($"ReviewComment is applied to type {t.Name}");
            }
        }
    }
}
