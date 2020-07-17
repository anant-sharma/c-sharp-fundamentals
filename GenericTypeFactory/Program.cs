using System;

namespace GenericTypeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create Car Factory
            var carFactory = new VehicleFactory<Models.Car>();
            Models.Car car1 = carFactory.Create();
            Console.WriteLine("car1 tyrecount: " + car1.TyreCount);

            // Create Car Factory
            var truckFactory = new VehicleFactory<Models.Truck>();
            Models.Truck truck1 = truckFactory.Create();
            Console.WriteLine("truck1 tyrecount: " + truck1.TyreCount);
        }
    }
}
