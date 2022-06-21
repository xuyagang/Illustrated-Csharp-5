
using System;

namespace C_13_10_1_foreachTest
{
    class MyClass
    {
        public int MyField = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass[] mcArr = new MyClass[4];
            //for (int i=0; i<mcArr.Length; i++)
            //{
            //    mcArr[i] = new MyClass();
            //    mcArr[i].MyField = i;
            //}
            //foreach (MyClass i in mcArr)
            //{
            //    i.MyField += 10;
            //}
            //foreach (MyClass i in mcArr)
            //{
            //    Console.WriteLine("{0}",i.MyField);
            //}


            int total = 0;
            int[][] arr1 = new int[2][];
            arr1[0] = new int[] { 10, 11 };
            arr1[1] = new int[] { 12, 13, 14 };

            foreach (int[] array in arr1)
            {
                foreach (int i in array)
                {
                    total+= i;
                    Console.WriteLine("Item:{0},CurrentTotal:{1}", i, total);
                }
            }
        }
    }
}
