using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ReadOnlyCollectionDemo.Version3
{
    public class Order
    {
        private IList<OrderItem> _orderItems;
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public IReadOnlyCollection<OrderItem> OrderItems
        {
            get => _orderItems.ToImmutableList();
            private set => _orderItems = value?.ToList() ?? new List<OrderItem>();
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
