using System;

namespace ShippingManagement
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shipingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shipingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            // Check if order is already shipped
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            var shipment = new Shipment
            {
                ShippingCost = _shipingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1),
                EstimatedDeliveryDate = DateTime.Today.AddDays(4),
            };

            Console.WriteLine("Order Processed");
        }
    }
}
