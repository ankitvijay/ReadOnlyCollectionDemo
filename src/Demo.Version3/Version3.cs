using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Helper;
using Newtonsoft.Json;

namespace Demo.Version3
{
    public class Version3 : IVersion
    {
        public void Display()
        {
            var order = new Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.ToList().Count()}");

            var orderItem = new OrderItem(3, "Mouse");
            try
            {
                var orderItems = (ICollection<OrderItem>) order.OrderItems;
                orderItems.Add(orderItem);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine($"After Manipulating outside Order Domain: {order.OrderItems.ToList().Count}");
            }


            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new NonPublicPropertiesResolver()
            };

            var json = JsonConvert.SerializeObject(order);
            var orderDeserializer = JsonConvert.DeserializeObject<Order>(json);
            
            Console.WriteLine($"After serializing the Order: {orderDeserializer.OrderItems.ToList().Count}");
        }
    }
}
