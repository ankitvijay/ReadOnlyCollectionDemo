using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Demo.Helper;

namespace Demo.Version3
{
    public class Order
    {
        private List<OrderItem> _orderItems;

        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public IReadOnlyCollection<OrderItem> OrderItems
        {
            get => _orderItems.ToImmutableList();
            private set => _orderItems = value.ToList();
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