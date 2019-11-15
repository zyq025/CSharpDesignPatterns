using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class T50 : Tank
    {
        public override void Run()
        {
            Console.WriteLine("T50坦克平均每小时运行30公里");
        }

        public override void Shot()
        {
            Console.WriteLine("T50坦克平均每秒射击5发子弹");
        }
    }
}
