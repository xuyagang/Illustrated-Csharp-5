using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_15_6_1_扩展EventArgs来传递参数
{
    /// <summary>
    /// 自定义类，派生自 EventArgs
    /// </summary>
    public class IncrementerEventArgs : EventArgs
    {
        // 存储一个整数
        public int IterationCount { get; set; }
    }

    /// <summary>
    /// 发布者
    /// </summary>
    class Incrementer
    {
        // 使用自定义类的泛型委托
        public event EventHandler<IncrementerEventArgs> CountedADozen;

        public void DoCount()
        {
            // 自定义类对象
            IncrementerEventArgs args = new IncrementerEventArgs();
            for (int i = 1; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                {
                    // 更新自定义类中的数据
                    args.IterationCount = i;
                    // 调用委托，在触发事件时传递数据,数据参数是EventArgs派生类实例，实际数据是其属性
                    CountedADozen(this, args);
                }
        }
    }

    /// <summary>
    /// 订阅者
    /// </summary>
    class Dozens
    {
        public int DozensCount { get; private set; }
        // 订阅者的构造函数，参数是发布者实例，通过其委托添加事件处理程序
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;
        }
        // 事件处理程序的签名必须与委托的签名匹配
        void IncrementDozensCount(object source, IncrementerEventArgs e)
        {
            // source 是 命名空间.发布者类
            Console.WriteLine($"Incremented at iteration:{e.IterationCount} in {source.ToString()}");
            DozensCount++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化发布者
            Incrementer incrementer = new Incrementer();
            // 使用发布者实例为参数实例化订阅者，其构造函数会为发布者类的委托添加事件函数
            Dozens dozensCounter = new Dozens(incrementer);
            // 调用发布者的方法,其在特定条件会触发事件,会执行委托，然后其会执行它所持有的方法
            incrementer.DoCount();

            Console.WriteLine($"Number of dozens = {dozensCounter.DozensCount}");
        }
    }
}
