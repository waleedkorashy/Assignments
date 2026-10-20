using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment_9
{
    public class Order
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        //Create a user-defined delegate
        public delegate decimal PriceCalculator(Order order);

        //Create at least two methods that match this delegate:
        public static decimal CalculateTotal(Order order)
            =>  order.Quantity * order.Price ; 
        public static decimal CalculateTotalWithDiscount(Order order)
            =>  order.Quantity * (order.Price - (order.Price * 0.1m));

        public static decimal CalculateOrderPrice(Order order, PriceCalculator priceCalculator) 
            => priceCalculator(order);

        //Replace one of your user-defined delegates with a built-in Func<>.
        public static decimal CalculateOrderPriceUsingFunc(Order order, Func<Order, decimal> priceCalculator) 
            => priceCalculator(order);

        //Create a method:
        //ValidateOrder(Order order, Predicate<Order> validationRule)
        public static bool ValidateOrder(Order order, Predicate<Order> validationRule)
            => validationRule(order);

        //Create a method:
        //ProcessOrder(Order order, Action<Order> action)
        public static void ProcessOrder(Order order, Action<Order> action)
            => action(order);



    }
}
