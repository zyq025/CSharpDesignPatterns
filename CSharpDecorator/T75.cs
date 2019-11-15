using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class T75 : Tank
    {
        public override void Run()
        {
            Console.WriteLine("T75坦克平均每时运行35公里");
        }

        public override void Shot()
        {
            Console.WriteLine("T75坦克平均每秒射击10发子弹");
        }
    }
}
