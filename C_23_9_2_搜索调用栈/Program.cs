using System;

namespace C_23_9_2_搜索调用栈
{
    class MyClass
    {
        public void A()
        {
            try
            { B(); }
            catch (System.NullReferenceException)
            { Console.WriteLine("catch clause in A()"); }
            finally
            { Console.WriteLine("finally clause in A()"); }
        }

        void B()
        {
            int x = 10, y = 0;
            try
            {
                x /= y;
            }
            catch (System.IndexOutOfRangeException)
            {Console.WriteLine("catch clause in B()");}
            finally
            {Console.WriteLine("finally clause in B()"); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            try
            {mc.A();}
            catch (DivideByZeroException e)
            {Console.WriteLine("catch clause in Main()");}
            finally
            { Console.WriteLine("finally clause in Main()"); }
            Console.WriteLine("After try statement in Main.");
            Console.WriteLine("              ---Keep running");
        }
    }
}
