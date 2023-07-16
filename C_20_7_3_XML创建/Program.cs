using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_20_7_3_XML创建
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument employees1 =
                new XDocument(                                  //xml文档
                    new XElement("Employees",                   //根元素
                        new XElement("Name", "Bob Smith"),      //元素
                        new XElement("Name", "Sally Jones")     //元素
                    )
                );

            employees1.Save("EmployeesFile.xml");   //保存到文件

            // 加载文档到变量
            XDocument employee2 = XDocument.Load("EmployeesFile.xml");
            Console.WriteLine(employee2);

            Console.ReadKey();

        }
    }
}
