using System;

namespace C_8_7_1_构造函数初始化
{
    class MyClass
    {
        readonly int firstVar;
        readonly double secondVar;

        public string UserName;
        public int UserIdNumber;

        //私有构造函数执行其他构造函数共用的初始化
        private MyClass()
        {
            firstVar = 20;
            secondVar = 30.5;
        }
        //使用构造函数初始化语句
        public MyClass(string firstName) : this()
        {
            UserName = firstName;
            UserIdNumber = -1;
        }
        //使用构造函数初始化语句
        public MyClass(int idNumber) : this()
        {
            UserName = "Anonymous";
            UserIdNumber = idNumber;
        }
    }
}
