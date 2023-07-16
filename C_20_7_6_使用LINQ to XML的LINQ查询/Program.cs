using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_20_7_6_使用LINQ_to_XML的LINQ查询
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 创建xml
            XDocument xd = new XDocument(
                new XElement("MyElements",
                    new XElement("first",
                        new XAttribute("color", "red"),
                        new XAttribute("size", "small")),
                    new XElement("second",
                        new XAttribute("color", "red"),
                        new XAttribute("size", "small")),
                    new XElement("third",
                        new XAttribute("color", "red"),
                        new XAttribute("size", "small"))));

            Console.WriteLine(xd);
            xd.Save("simple.xml");
            #endregion


            #region 读取并查询
            //加载文档
            XDocument xd = XDocument.Load("simple.xml");
            //获取根元素
            XElement rt = xd.Element("MyElements");
            //查询
            var xyz = from e in rt.Elements()
                      where e.Name.ToString().Length == 5
                      select e;

            foreach (XElement x in xyz)
                Console.WriteLine(x.Name.ToString());
            #endregion
        }
    }
}