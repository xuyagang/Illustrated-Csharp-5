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
    /// 定义事件，并在自身方法中触发事件（调用自己的委托）
    /// </summary>
    class Incrementer
    {
        public event Handler CountedADozen;   // 创建事件并发布（委托类型）
        /// <summary>
        /// 发布者方法
        /// </summary>
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                    CountedADozen();   // 每增加12个计数，触发事件一次
        }
    }

    /// <summary>
    /// 订阅者
    /// 定义事件处理程序（可以在外部类中）
    /// 注册事件，向传入的发布者类的委托添加事件函数
    /// </summary>
    class Dozens
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            // 注册在事件成员被触发时要调用的回调方法
            incrementer.CountedADozen += IncrementDozensCount;   
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
            // 使用发布者实例为参数实例化订阅者，并为发布者类的委托添加事件函数
            Dozens dozensCounter = new Dozens(incrementer);   
            // 在发布者的方法中会触发事件，会调用委托，委托会在初始化订阅者时配置
            incrementer.DoCount();   
            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
        }
    }
}
