using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSampleFactory
{
    public class RedCar : IAutoCarMake
    {
        public void MakeAutoCar()
        {
            Console.WriteLine("制造红色小轿车....");
        }
    }
}
