using System.Collections.Generic;
using Demo.Helper;
using Xunit;

namespace Demo.Version1.Tests
{
    public class OrderTests
    {
        [Fact]
        public void OrderItemsShouldNotBeManipulatedOutsideOrder()
        {
            var order = new Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Assert.True(order.OrderItems.Count == 2);

            var orderItem = new OrderItem(3, "Mouse");

            var orderItems = (ICollection<OrderItem>)order.OrderItems;
            orderItems.Add(orderItem);

            Assert.True(order.OrderItems.Count == 2);
        }
    }
}
