using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_27_9_1_标准dispose模式
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }
    }

    class MyClass : IDisposable
    {
        // 释放状体
        bool disposed = false;

        // 公共Dispose方法
        public void Dispose()
        {
            Dispose(true);
            // 阻止终结器
            GC.SuppressFinalize(this);
        }

        // 析构函数(终结器)
        ~MyClass()
        {
            Dispose(false);
        }

        // 分解释放
        protected virtual void Dispose(bool disposing)
        {
            if (disposed == false)
            {
                if (disposing == true)
                {
                    // 释放 托管资源
                    // ...
                }

                // 释放 非托管资源
                // ...

                disposed = true;
            }
        }
    }
}