namespace GenericTypeFactory
{
    public class VehicleFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
