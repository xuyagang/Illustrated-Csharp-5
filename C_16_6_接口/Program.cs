using System;

namespace C_16_6_接口
{
    // 声明接口
    interface IDataRetrive { int GetData(); }
    interface IDataStore { void SetData(int x); }
    class MyData : IDataRetrive, IDataStore
    {
        int Mem1;
        public int GetData() { return Mem1; }
        public void SetData(int x) { Mem1 = x; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();
            data.SetData(5);
            Console.WriteLine($"Value = {data.GetData()}");
        }
    }
}
