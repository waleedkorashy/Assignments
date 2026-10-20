using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    public class OrderService
    {
        //Inside an OrderService class, create an event:
        //public event Action<Order> OrderProcessed;
        public event Action<Order>? OrderProcessed;

        //Create a method:
        //public void ProcessOrder(Order order)
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing order {order.Id} ...");
            OrderProcessed?.Invoke(order);
        }

    }
}
