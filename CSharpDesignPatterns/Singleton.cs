using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSingleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        private static Singleton singleton;

        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// 提供一个静态方法获取实例对象
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            if(singleton==null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

        public void Show()
        {
            Console.WriteLine("Hello Singleton!!!");
        }
    }
}
