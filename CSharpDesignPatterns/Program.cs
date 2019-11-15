using System;

namespace CSharpSingleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //单线程
            Singleton singleton = Singleton.GetSingleton();
            singleton.Show();

            //线程安全模式
            SingletonThreadSafe singleton1 = SingletonThreadSafe.GetSingleton();
            singleton1.Show();
        }
    }
}
