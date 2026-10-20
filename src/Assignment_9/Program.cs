namespace Assignment_9
{
    using Microsoft.VisualBasic;
    using System.Drawing;
    using static Order;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Section 1

            #region Part 1 — User-Defined Delegate
            //a) Create a user-defined delegate with the same
            //signature as the methods that exist in the BookFunctions class.
            var booksUsingDelegate = new List<Book>();
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingDelegate, BookFunctions.GetTitle);
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingDelegate, BookFunctions.GetAuthors);

            //b) Use the proper built-in delegate.
            var booksUsingFunc = new List<Book>();
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingFunc, BookFunctions.GetTitle);
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingFunc, BookFunctions.GetAuthors);

            //c) Anonymous Method (GetISBN).
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingDelegate, delegate (Book B){return B.ISBN;});

            //d) Lambda Expression (GetPublicationDate).
            LibraryEngine.ProcessBooksUsingDelegate(booksUsingDelegate, 
                B => B.PublicationDate.ToString());

            #endregion

            #region Section 02: C# Delegates & Events — Assignment
            //Requirement
            //Call the method using different implementations:
            var order = new Order()
            {
                Id = 1,
                CustomerName = "Ahmed",
                Price = 10,
                Quantity = 3
            };
            //CalculateOrderPrice(order, CalculateTotal)
            CalculateOrderPrice(order, CalculateTotal);


            //CalculateOrderPrice(order, CalculateTotalWithDiscount)
            CalculateOrderPrice(order, CalculateTotalWithDiscount);
            #endregion

            #region Part 2 — Func<>
            //Replace one of your user-defined delegates with a built-in Func<>.
            //Use:
            //Func<Order, decimal>
            CalculateOrderPriceUsingFunc(order, CalculateTotal);

            //Create at least two different calculations using lambdas.
            CalculateOrderPriceUsingFunc(order, x => x.Price * x.Quantity);
            CalculateOrderPriceUsingFunc(order, x => x.Price * x.Quantity * 0.9m);

            //What problem does Func<> solve compared with creating a custom delegate?
            
            //Answer:
            //without Func I have to declare a new delegate type every time I want to pass a method around
            //just to describe its shape. Func is already built in
            //so I write Func<Order,decimal> and skip the declaration entirely
            #endregion
            #region Part 3 — Predicate<>

            //Create at least two different calculations using lambdas.
            bool validQuantity = ValidateOrder(order, o => o.Quantity > 0);
            bool validPrice = ValidateOrder(order, o => o.Price > 0);
            bool hasCustomer = ValidateOrder(order, o => !string.IsNullOrWhiteSpace(o.CustomerName));
            //Why is Predicate<Order> more expressive here than:
            //Func<Order, bool>
            //even though both can represent a function that returns bool?

            //Answer:
            //Predicate tells the reader straight away that this delegate is a rule that answers
            //true or false for one item. Func with bool only tells me the shape and I have to guess the purpose
            #endregion
            #region Part 4 — Action<>
            //Create at least three actions:
            //Print order information

            Action<Order> printOrder =
                order => Console.WriteLine($"Order {order.Id} processed");
            //Send a confirmation message
            Action<Order> confirmOdrer =
                order => Console.WriteLine($"Order {order.Id} confirmed");
            //Write an audit message
            Action<Order> auditMessage =
                order => Console.WriteLine($"Order {order.Id} processed, total {order.Price * order.Quantity:C}.");

            ProcessOrder(order, printOrder);
            ProcessOrder(order, confirmOdrer);
            ProcessOrder(order, auditMessage);
            #endregion
            #region Part 5 — Events

            //In the Program class, subscribe multiple handlers to the event.

            var orderService = new OrderService();

            // Subscribe multiple handlers
            orderService.OrderProcessed += printOrder;
            orderService.OrderProcessed += confirmOdrer;
            orderService.OrderProcessed += auditMessage;

            orderService.ProcessOrder(order);
            #endregion
            #region Part 6 — Event Subscription
            //Demonstrate both subscribing and unsubscribing:
            orderService.OrderProcessed += doneMsg => Console.WriteLine("Processing done");
            orderService.OrderProcessed += goodByeMsg => Console.WriteLine("See you in the next order");
            orderService.ProcessOrder(order);

            orderService.OrderProcessed -= doneMsg => Console.WriteLine("Processing done");
            orderService.ProcessOrder(order);

            #endregion
            #region Questions — Answer in Comments or a README

            // Q1
            // PriceCalculator is my own delegate
            // Func<Order, decimal> is the built in one with the same shape

            // Q2
            // Action<Order> returns nothing
            // Func<Order, decimal> returns a decimal

            // Q3
            // It answers a yes or no question about one item
            // It is made for tests and rules

            // Q4
            // A delegate holds a reference to a method
            // An event is a protected delegate
            // Outside code can only subscribe or unsubscribe from it

            // Q5
            // Only the owner class can raise it
            // This stops others from firing it by mistake

            // Q6
            // They all run in the order they were added
            // Each one gets the same arguments

            // Q7
            // OrderProcessed is the event
            // += means add to the list and not replace it
            // HandleOrderProcessed is the method that runs when it fires
            // No parentheses because I am passing it and not calling it

            // Q8
            // A plain Action<Order> can be invoked or wiped by anyone
            // An event only allows += and -= from outside
            // So subscribers stay safe
            #endregion

            #endregion
        }
    }
}
