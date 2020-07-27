using System;

namespace ShippingManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());

            Order order = new Order
            {
                IsShipped = false
            };

            orderProcessor.Process(order);
        }
    }
}
