using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Demo.Helper;

namespace Demo.Version6
{
    public class Order
    {
        public HashSet<OrderItem> _orderItems;

        public Order()
        {
            _orderItems = new HashSet<OrderItem>();
        }

        public ImmutableHashSet<OrderItem> OrderItems
        {
            get => _orderItems.ToImmutableHashSet();
            private set => _orderItems = value.ToHashSet();
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
