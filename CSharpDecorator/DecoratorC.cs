using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class DecoratorC : Decorator
    {
        public DecoratorC(Tank tank) : base(tank)
        {
        }

        public override void Run()
        {
            Console.WriteLine("增加卫星定位功能");
            base.Run();
        }
    }
}
