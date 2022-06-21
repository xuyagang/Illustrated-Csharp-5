using System;

namespace C_16_11_接口继承
{
    interface IDataRetrieve { int GetData(); }
    interface IDataStore { void SetData(int x); }
    // 继承接口实现
    interface IDataIO : IDataStore, IDataRetrieve { }
    class MyData : IDataIO
    {
        int nPrivateData;
        public int GetData() { return nPrivateData; }
        public void SetData (int x) { nPrivateData = x; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();
            data.SetData(5);
            Console.WriteLine($"{data.GetData()}");
        }
    }
}