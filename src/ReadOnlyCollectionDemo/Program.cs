using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadOnlyCollectionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-------------- Version 1 ---------------------\n\n");
            Version1();

            Console.WriteLine("\n\n-------------- Version 2 ---------------------\n\n");
            Version2();

            Console.WriteLine("\n\n-------------- Version 3 ---------------------\n\n");
            Version3();

            Console.ReadLine();
        }

        private static void Version1()
        {
            var order = new Version1.Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.Count}");

            var orderItem = new OrderItem(3, "Mouse");

            var orderItems = (ICollection<OrderItem>) order.OrderItems;
            orderItems.Add(orderItem);

            Console.WriteLine($"After Manipulating outside Order Domain: {order.OrderItems.Count}");
        }

        private static void Version2()
        {
            var order = new Version2.Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.ToList().Count()}");

            var orderItem = new OrderItem(3, "Mouse");

            var orderItems = (ICollection<OrderItem>)order.OrderItems;
            orderItems.Add(orderItem);

            Console.WriteLine($"After Manipulating outside Order Domain: {order.OrderItems.ToList().Count}");
        }

        private static void Version3()
        {
            var order = new Version3.Order();
            order.AddOrderItem(new OrderItem(1, "Laptop"));
            order.AddOrderItem(new OrderItem(2, "Keyboard"));

            Console.WriteLine($"Before Manipulating outside Order Domain: {order.OrderItems.ToList().Count()}");

            var orderItem = new OrderItem(3, "Mouse");

            var orderItems = (ICollection<OrderItem>)order.OrderItems;
            orderItems.Add(orderItem);

            Console.WriteLine($"After Manipulating outside Order Domain: {order.OrderItems.ToList().Count}");
        }
    }
}

