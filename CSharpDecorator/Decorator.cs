using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    /// <summary>
    /// 这是装饰类，不是为了实现，而是为了接口继承
    /// </summary>
    public class Decorator : Tank
    {
        /// <summary>
        /// Has a 对象组合
        /// </summary>
        private Tank tank;

        public Decorator(Tank tank)
        {
            this.tank = tank;
        }

        public override void Run()
        {
            tank.Run();
        }

        public override void Shot()
        {
            tank.Shot();
        }
    }
}
