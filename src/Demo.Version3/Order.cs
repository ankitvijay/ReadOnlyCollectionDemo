using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Demo.Helper;

namespace Demo.Version3
{
    public class OrderBase
    {
        private List<OrderItem> _orderItems;

        public OrderBase()
        {
            _orderItems = new List<OrderItem>();
        }

        public IReadOnlyCollection<OrderItem> OrderItems
        {
            get => _orderItems.ToImmutableList();
            private set => _orderItems = (List<OrderItem>)value;
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

    public class Order : OrderBase
    {
        public Order()
        {

        }

        public new IEnumerable<OrderItem> OrderItems => base.OrderItems.Cast<OrderItem>();
    }


}