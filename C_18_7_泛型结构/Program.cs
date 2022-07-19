using System;

namespace C_18_7_泛型结构
{
    // 泛型结构
    struct PieceOfData<T>
    {
        public PieceOfData(T value){_data = value;}
        private T _data;
        public T Data
        {
            get{return _data;}
            set{ _data = value;}
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var intData = new PieceOfData<int>(10);
            var stringData = new PieceOfData<string>("Hello");

            Console.WriteLine(intData.Data);
            Console.WriteLine(stringData.Data);
        }
    }
}
