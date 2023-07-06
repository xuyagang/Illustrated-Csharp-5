using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    partial class Program
    {
        static void Main()
        {
            Console.WriteLine(a);

            Program g = new Program();
            g.MyValue = 4;

            SomeClass2 someclass2 = new SomeClass2();
            SomeClass someclass = (SomeClass)someclass2;
            someclass.Method();


        }



        void test()
        {
            Console.WriteLine(b);
        }

        public int MyValue
        {
            get;set;
        }

        private int num1 = 111;
        private int num2 = 222;
        private int num3 = 333;

        public int this [int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return num1;
                    case 1:
                        return num2;
                    case 2:
                        return num3;
                    default:
                        throw new IndexOutOfRangeException("index");
                }
            }
            set 
            {
                switch(index)
                {
                    case 0:
                        num1 = value;
                        break;
                    case 1:
                        num2 = value;
                        break;
                    case 2:
                        num3 = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("index");
                }
            }
        }
    }

    partial class Program
    {
        static int a = 5;
        string b = "b";
    }

    class SomeClass
    {
        public string Field = "SomeClass Field";
        public void Method()
        {
            Console.WriteLine();
        }
    }

    class SomeClass2 : SomeClass
    {
        new public string Field = "SomeClass2";
        new public void Method()
        {
            base.Method();
        }
    }

    
}