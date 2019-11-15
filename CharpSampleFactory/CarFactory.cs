using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSampleFactory
{
    public class CarFactory
    {
        public IAutoCarMake MakeCar(string strType)
        {
            IAutoCarMake car = null;
            switch (strType)
            {
                case "red":
                    car = new RedCar();
                    break;
                case "blue":
                    car = new BlueCar();
                    break;
                default:
                    car = null;
                    break;
            }
            return car;
        }
    }
}
