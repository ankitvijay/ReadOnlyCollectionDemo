using System;
using System.Collections.Generic;
using Demo.Helper;

namespace Demo.Version1
{
    public class Version1 : IVersion
    {
        public void Display()
        {
            var order = new Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.Count}");

            var orderItem = new OrderItem(3, "Mouse");

            var orderItems = (ICollection<OrderItem>)order.OrderItems;
            orderItems.Add(orderItem);

            Console.WriteLine($"After Manipulating outside Order Domain: {order.OrderItems.Count}");
            
        }
    }
}