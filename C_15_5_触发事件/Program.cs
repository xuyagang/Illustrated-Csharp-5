using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_15_5_触发事件
{
    delegate void Handler();   // 声明委托

    /// <summary>
    /// 发布者
    /// </summary>
    class Incrementer
    {
        public event Handler CountedADozen;   // 创建事件并发布（委托类型）
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                    CountedADozen();   // 每增加12个计数触发事件一次
        }
    }

    /// <summary>
    /// 订阅者
    /// </summary>
    class Dozens
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;   // 订阅事件
        }

        // 声明事件处理程序
        void IncrementDozensCount()
        {
            DozensCount++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();      // 实例化发布者
            Dozens dozensCounter = new Dozens(incrementer);   // 使用发布者实例为参数实例化订阅者 

            incrementer.DoCount();   // 在发布者的方法中会触发事件，会调用委托，委托会在初始化订阅者时配置
            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
        }
    }
}
