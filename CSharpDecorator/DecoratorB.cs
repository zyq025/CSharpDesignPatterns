using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDecorator
{
    public class DecoratorB : Decorator
    {
        public DecoratorB(Tank tank) : base(tank)
        {
        }

        public override void Run()
        {
            Console.WriteLine("增加水陆两栖功能");
            base.Run();
        }
    }
}
