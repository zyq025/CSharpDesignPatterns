using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFactoryMethod
{
    public class BMWCarFactory : CarFactory
    {
        public override Car MakeCar()
        {
            return new BMWCar();
        }
    }
}
