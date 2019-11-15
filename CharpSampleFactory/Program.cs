using System;

namespace CSharpSampleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            IAutoCarMake redCarMake = new CarFactory().MakeCar("red");
            IAutoCarMake blueCarMake = new CarFactory().MakeCar("blue");

            redCarMake.MakeAutoCar();
            blueCarMake.MakeAutoCar();

        }
    }
}
