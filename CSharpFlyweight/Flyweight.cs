using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFlyweight
{
    /// <summary>
    /// 抽象享元对象,提供具体享元类具有的方法
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsic_state);
    }
}
