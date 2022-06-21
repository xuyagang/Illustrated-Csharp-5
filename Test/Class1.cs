using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    struct Simple
    {
        public int X;
        public int Y;
    }
    class Program
    {
         struct Simple
        {
            public int x = 0;   // 编译错误
            public int y = 10;   // 编译错误
            public int prop1 { get; set; } = 5;    // 编译错误
        }
    }
}