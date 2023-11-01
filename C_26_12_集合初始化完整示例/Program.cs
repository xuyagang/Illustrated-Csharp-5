using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_26_12_集合初始化完整示例
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer("AAA");
            var customer2 = new Customer("BBB");

            // 集合初始化
            var customers = new Subscriptions { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }

    public static class SubscriptionExtensions
    {
        // 扩展方法
        public static void Add(this Subscriptions s, Customer c)
        {
            s.Subscribe(c);
        }
    }

    public class Subscriptions : IEnumerable<Customer>
    {
        private List<Customer> mSubscribers = new List<Customer>();

        public IEnumerator<Customer> GetEnumerator()
        {
            return mSubscribers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Subscribe(Customer c)
        {
            mSubscribers.Add(c);
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name) { Name = name; }
    }
}