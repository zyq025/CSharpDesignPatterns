using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class DecoratorA : Decorator
    {
        public DecoratorA(Tank tank) : base(tank)
        {

        }

        public override void Shot()
        {
            Console.WriteLine("增加红外功能");
            base.Shot();
        }
    }
}
