using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_15_6_2_移除事件处理程序
{
    /// <summary>
    /// 发布者，创建并发布事件，可通过方法调用事件委托
    /// </summary>
    class Publisher
    {
        // 事件的委托，创建并发布事件
        public event EventHandler SimpleEvent;
        public void RaiseTheEvent() { SimpleEvent(this, null); }
    }

    /// <summary>
    /// 订阅者
    /// 一般会包含事件处理程序，必须具有与事件的委托相同的签名和返回类型
    /// </summary>
    class Subscriber
    {
        public void MethodA(object o, EventArgs e) { Console.WriteLine("AAA"); }
        public void MethodB(object o, EventArgs e) { Console.WriteLine("BBB"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher  p = new Publisher();
            Subscriber s = new Subscriber();

            p.SimpleEvent += s.MethodA;
            p.SimpleEvent += s.MethodB;
            p.RaiseTheEvent();

            Console.WriteLine("\r\nRemove MethodA");
            p.SimpleEvent -= s.MethodA;
            p.RaiseTheEvent();
        }
    }
}
