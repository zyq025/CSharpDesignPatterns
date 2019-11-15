using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSingleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class SingletonThreadSafe
    {
        /// <summary>
        /// 提供一个锁对象
        /// </summary>
        private static object lockObj = new object();
        private static SingletonThreadSafe singleton;

        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private SingletonThreadSafe()
        {

        }

        /// <summary>
        /// 提供一个静态方法获取实例对象
        /// </summary>
        /// <returns></returns>
        public static SingletonThreadSafe GetSingleton()
        {
            //双重检查
            if (singleton == null)
            {
                lock (lockObj)
                {
                    if (singleton == null)
                    {
                        singleton = new SingletonThreadSafe();
                    }
                }
            }
            return singleton;
        }

        public void Show()
        {
            Console.WriteLine("Hello SingletonThreadSafe!!!");
        }
    }
}
