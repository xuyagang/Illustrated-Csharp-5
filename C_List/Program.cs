using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_List
{
    class Program
    {
        static void Main()
        {
            ////默认容量的list
            //List<Int16> list = new List<Int16>();
            ////传入容量，capacity = 5
            //List<string> names = new List<string>(5);
            ////传入初始元素集合
            //string[] animals = { "Cow", "Camel", "Elephant" };
            //List<string> animalsList = new List<string>(animals);
            //foreach (string i in animals)
            //    Console.WriteLine($"{i}");



            ////动态数组列表无大小限制
            //List<int> numberList = new List<int>();
            //numberList.Add(13);
            //numberList.Add(32);
            //numberList.Add(11);
            //foreach (int i in numberList)
            //    Console.WriteLine($"{i}");
            ////字符串列表
            //List<string> authors = new List<string>(2);
            //authors.Add("Mahesh Chand");
            //authors.Add("Chris Love");
            //authors.Add("Chris Love");
            //authors.Add("Allen O'neill");
            //authors.Add("Adam Xu");
            //foreach (string i in authors)
            //    Console.WriteLine(i);
            ////将集合添加到列表中
            //string[] animals2 = { "Cow", "Camel", "Elephant" };
            //List<string> animalList2 = new List<string>();
            //animalList2.AddRange(animals2);
            //foreach(string a in animalList2)
            //    Console.WriteLine(a);


            ////属性
            //ArrayList authorsArray = new ArrayList();
            //authorsArray.Add("Mahesh Chand");
            //authorsArray.Add("Praveen Kumar");
            //authorsArray.Add("Raj Kumar");
            //authorsArray.Add("Dinesh Beniwal");
            //authorsArray.Add("David McCarter");
            //Console.WriteLine("Count: " + authorsArray.Count);
            //Console.WriteLine("Capacity: " + authorsArray.Capacity);


            ////增删改查
            ////插入元素
            //authorsArray.Insert(3, "Test");
            ////移除元素 - 移除元素
            //authorsArray.Remove("Test");
            ////移除元素 - 按索引移除
            //authorsArray.Remove(3);
            ////移除元素 - 按范围移除,从指定起始位置删除指定项
            //authorsArray.RemoveRange(3, 2);
            ////移除所有元素
            //authorsArray.Clear();
            ////使用 IndeOf 函数查找元素，没有查找到元素则返回-1
            //int idx = authorsArray.IndexOf("Null");
            //Console.WriteLine($"{idx}");
            ////可以指定在列表中开始查找的位置
            //Console.WriteLine(authors.IndexOf("Naveen Sharma", 2));
            ////LastlndexOf 返回某个值的最后一个匹配项的从零开始的索引
            //Console.WriteLine(authors.LastIndexOf("Chris Love"));

            //排序一个列表
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Mahesh Chand");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            Console.WriteLine("Original List items");
            Console.WriteLine("===============");
            // Print original order
            foreach (string a in authors)
                Console.WriteLine(a);
            // Sort list items
            authors.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted List items");
            Console.WriteLine("===============");
            // Print sorted items
            foreach (string a in authors)
                Console.WriteLine(a);

            //reverse list items
            authors.Reverse();
            Console.WriteLine();
            Console.WriteLine("Reversed List items");
            Console.WriteLine("===============");
            foreach(string a in authors)
                Console.WriteLine(a);

            //二分查找：BinarySearch,查找一个排序的列表，返回匹配索引
            int bs = authors.BinarySearch("Mahesh Chand");
            Console.WriteLine($"{bs}");

            List<string> listOne = new List<string>();
            listOne.Add("One");
            listOne.Add("Two");
            listOne.Add("Three");
            listOne.Add("Four");
            listOne.Add("Five");
            List<string> listTwo = new List<string>();
            listTwo.Add("A");
            listTwo.Add("B");
            listTwo.Add("C");
            listOne.AddRange(listTwo);
            foreach (string item in listOne)
                Console.WriteLine(item);
        }
    }
}
