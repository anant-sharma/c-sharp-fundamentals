namespace ShippingManagement
{
    public interface IShippingCalculator
    {
        int CalculateShipping(Order order);
    }

    class ShippingCalculator : IShippingCalculator
    {
        public int CalculateShipping(Order order)
        {
            return 10;
        }
    }
}
