using System;

namespace CSharpFactoryMethod
{
    internal class BMWCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("The BMWCar start-up speed is very quickly");
        }

        public override void StartUp()
        {
            Console.WriteLine("The BMWCar run is quitely fast and safe");
        }

        public override void Stop()
        {
            Console.WriteLine("The sloww stop time is 2 second");
        }
    }
}