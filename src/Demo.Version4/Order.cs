using System.Collections.Generic;
using Demo.Helper;

namespace Demo.Version4
{
    public class Order
    {
        private HashSet<OrderItem> _orderItems;

        public Order()
        {
            _orderItems = new HashSet<OrderItem>();
        }

        public HashSet<OrderItem> OrderItems
        {
            get => _orderItems;
            private set => _orderItems = value;
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