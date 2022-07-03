using System;

namespace C_18_3_4_泛型_栈
{
    class MyStack<T>
    {
        T[] StackArray;
        int stackPointer = 0;

        public void Push(T x)
        {
            if (!IsStackFull)
                StackArray[stackPointer++] = x;
        }
        public T Pop()
        {
            return (!IsStackEmpty)
                   ? StackArray[--stackPointer]
                   : StackArray[0];
        }

        const int MaxStack = 10;
        bool IsStackFull { get { return stackPointer >= MaxStack; } }
        bool IsStackEmpty { get { return stackPointer <= 0; } }

        public MyStack()
        {
            StackArray = new T[MaxStack];
        }
        public void Print()
        {
            for (int i=stackPointer-1; i>=0; i--)
                Console.WriteLine($"Value:{StackArray[i]}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> StackInt = new MyStack<int>();
            MyStack<string> StackString = new MyStack<string>();

            StackInt.Push(3);
            StackInt.Push(5);
            StackInt.Push(7);
            StackInt.Push(9);
            StackInt.Print();

            StackString.Push("This is fun");
            StackString.Push("Hi there");
            StackString.Print();
        }
    }
}
