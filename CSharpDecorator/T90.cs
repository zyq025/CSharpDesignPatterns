using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class T90 : Tank
    {
        public override void Run()
        {
            Console.WriteLine("T90坦克平均每时运行40公里");
        }

        public override void Shot()
        {
            Console.WriteLine("T90坦克平均每秒射击10发子弹");
        }
    }
}
