using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFactoryMethod
{
    public class HongQiCarFactory : CarFactory
    {
        public override Car MakeCar()
        {
            return new HongQiCar();
        }
    }
}
