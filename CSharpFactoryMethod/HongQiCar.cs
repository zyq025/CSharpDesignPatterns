using System;

namespace CSharpFactoryMethod
{
    internal class HongQiCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Test HongQiCar start-up speed");
        }

        public override void StartUp()
        {
            Console.WriteLine("The HongQiCar run is very quickly!");
        }

        public override void Stop()
        {
            Console.WriteLine("The slow stop time is 3 second");
        }
    }
}