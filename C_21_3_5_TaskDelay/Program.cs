﻿
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace C_21_3_5_TaskDelay
{
    class Simple
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            Console.WriteLine("Caller: Before call");
            ShowDelayAsync();
            Console.WriteLine("Caller: After call");
        }
        private async void ShowDelayAsync()
        {
            sw.Start();
            Console.WriteLine($"Before Delay: {sw.ElapsedMilliseconds}");
            await Task.Delay(1000);
            Console.WriteLine($"After Delay: {sw.ElapsedMilliseconds}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Simple sm = new Simple();
            sm.DoRun();
            Console.Read();   // 利用等待输入操作等待异步任务完成
        }
    }
}