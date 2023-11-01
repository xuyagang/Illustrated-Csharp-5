using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_12_集合初始化语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer();
            var customer2 = new Customer();
            // 因为Subscription类没有Add方法，所以下面语句会失败
            var customers = new Subscriptions() { customer1, customer2 };
        }
    }

    public class Subscriptions : IEnumerable<Customer>
    {
        private List<Customer> _subscribers = new List<Customer>();
        public void Subscribe(Customer c)
        {
            _subscribers.Add(c);
        }
        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Customer
    {
    }
}
