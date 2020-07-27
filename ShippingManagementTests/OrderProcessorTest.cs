using Xunit;
using ShippingManagement;
using System;

namespace ShippingManagementTests
{
    public class OrderProcessorTest
    {
        [Fact]
        public void Process_OrderIsAlreadyShipped_ExpectException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            Order order = new Order
            {
                IsShipped = true
            };

            Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
        }
    }

    public class FakeShippingCalculator: IShippingCalculator
    {
        public int CalculateShipping(Order order)
        {
            return 10;
        }
    }
}
