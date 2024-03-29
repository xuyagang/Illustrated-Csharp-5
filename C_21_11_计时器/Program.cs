﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_21_11_计时器
{
    class Program
    {
        // 调用次数
        int TimesCalled = 0;
        // 回调函数，打印调用次数信息
        void Display(object state)
        {
            Console.WriteLine($"{(string)state} {++TimesCalled}");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            // Timer提供以指定的时间间隔对线程池线程执行方法的机制
            //                                                   2秒后第一次调用   每秒重复一次
            Timer myTimer = new Timer(p.Display, "Processing timer event", 2000, 1000);
            Console.WriteLine("Timer started");
            Console.ReadLine();
        }
    }
}
