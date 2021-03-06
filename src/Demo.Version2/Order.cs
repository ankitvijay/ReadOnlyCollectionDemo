﻿using System.Collections.Generic;
using Demo.Helper;

namespace Demo.Version2
{
    public class OrderBase
    {
        private ICollection<OrderItem> _orderItems;

        public OrderBase()
        {
            _orderItems = new List<OrderItem>();
        }

        public virtual IReadOnlyCollection<OrderItem> OrderItems
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

    public class Order : OrderBase
    {
        public Order()
        {
        }

        public new IEnumerable<OrderItem> OrderItems => base.OrderItems;
    }

    
}