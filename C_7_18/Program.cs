using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_7_18
{
   class Person
    {
        //不同访问级别的访问器
        public string Name { get; private set; }
        public Person(string name) {Name = name; }
    }
    class Program
    {
        static void Main()
        {
            Person p = new Person("Capt. Ernest Evans");
            // p.Name 此时不可访问
            Console.WriteLine($"Person's name is{p.Name}");
        }
    }
}
