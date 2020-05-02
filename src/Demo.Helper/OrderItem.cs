// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local
namespace Demo.Helper
{
    public class OrderItem
    {
        public OrderItem(int orderId, string orderName)
        {
            OrderId = orderId;
            OrderName = orderName;
        }

        public int OrderId { get; private set; }

        
        public string OrderName { get; private set; }
    }
}
