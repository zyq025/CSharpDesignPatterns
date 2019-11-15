using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSampleFactory
{
    public class BlueCar : IAutoCarMake
    {
        public void MakeAutoCar()
        {
            Console.WriteLine("制造蓝色轿车");
        }
    }
}
