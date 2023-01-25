
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_15_6_标准事件的用法
{
    /// <summary>
    /// 发布者
    /// </summary>
    class Incrementer
    {
        // 使用系统定义的EventHandler委托，创建事件并发布
        public event EventHandler CountedADozen;
        // 发布者方法，会在其中触发事件
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                    CountedADozen(this, null);   // 触发事件时使用EventHandler的参数
        }
    }
    /// <summary>
    /// 订阅者
    /// </summary>
    class Dozens
    {
        public int DozensCount { get; private set; }
        /// <summary>
        /// 订阅者的构造函数，参数是发布者实例，通过其委托添加事件处理程序
        /// </summary>
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;
        }
        /// <summary>
        /// 事件处理程序的签名必须与委托的签名匹配
        /// </summary>
        void IncrementDozensCount(object source, EventArgs e)
        {
            DozensCount++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 实例化发布者
            Incrementer incrementer = new Incrementer();
            // 使用发布者实例为参数实例化订阅者，其构造函数会为发布者类的委托添加事件函数
            Dozens dozensCounter = new Dozens(incrementer);
            // 调用发布者的方法,其在特定条件会触发事件,会执行委托，然后其会执行它所持有的方法
            incrementer.DoCount();
            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
        }
    }
}
