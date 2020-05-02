﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Demo.Helper;
using Newtonsoft.Json;

namespace Demo.Version5
{
    public class Version5 : IVersion
    {
        public void Display()
        {
            var order = new Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.ToList().Count()}");

            Map();


            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new NonPublicPropertiesResolver()
            };

            var json = JsonConvert.SerializeObject(order);
            var orderDeserializer = JsonConvert.DeserializeObject<Order>(json);

            Console.WriteLine($"After serializing the Order: {orderDeserializer.OrderItems.ToList().Count}");
        }

        private static void Map()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new OrderProfile());
            }).CreateMapper();

            var order = new Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine("Mapping Order to OrderDto");
            var orderDto = mapper.Map<OrderDto>(order);

            Console.WriteLine("Mapping OrderDto back to Order");
            var orderMappedBack = mapper.Map<Order>(orderDto);
        }
    }
}
