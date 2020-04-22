using System.Collections.Generic;

// ReSharper disable UnusedMember.Local
namespace ReadOnlyCollectionDemo.Version1
{
    public class Order
    {
        private ICollection<OrderItem> _orderItems;
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public IReadOnlyCollection<OrderItem> OrderItems
        {
            get => (IReadOnlyCollection<OrderItem>)_orderItems;
            private set => _orderItems = (ICollection<OrderItem>)value;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }
    }
}
