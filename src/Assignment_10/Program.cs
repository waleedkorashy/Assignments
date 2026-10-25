using Part_1;
using System.Collections;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Assignment_10.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using File = System.IO.File;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 01 LINQ

            #region Restriction Operators
            Console.WriteLine("\n1-Restriction Operators");

            //1. Find all products that are out of stock.
            Console.WriteLine("All products that are out of stock.");

            var outOfStockProducts = ProductsList.Where(p => p.UnitsInStock == 0);
            foreach (var product in outOfStockProducts)
                Console.WriteLine(product);

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            Console.WriteLine("\nAll products that are in stock and cost more than 3.00 per unit.");


            var result = ProductsList.Where(p => p.UnitsInStock > 0
                                              && p.UnitPrice > 3);
            foreach (var product in result)
                Console.WriteLine(product);

            //3. Returns digits whose name is shorter than their value.
            Console.WriteLine("\ndigits whose name is shorter than their value.");

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var arrayResult = Arr.Where((name, index) => name.Length < index);

            foreach (var s in arrayResult)
                Console.WriteLine(s);
            #endregion

            #region Element Operators
            Console.WriteLine("\n2-Element Operators");

            //Get first Product out of Stock 
            Console.WriteLine("\nfirst Product out of Stock ");

            var firstOutOfStockProduct = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(firstOutOfStockProduct);

            //Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            Console.WriteLine("\nfirst product whose Price > 1000, unless there is no match, in which case null is returned.");

            var firstProductMoreThanThousand = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(firstOutOfStockProduct);


            //3. Retrieve the second number greater than 5 
            Console.WriteLine("\nThe second number greater than 5 ");

            int[] NumArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondNum = NumArr.Where(n => n > 5)
                                  .Skip(1)
                                  .FirstOrDefault();
            Console.WriteLine(secondNum);
            #endregion


            #region Aggregate Operators
            Console.WriteLine("\n3-Aggregate Operators");


            //1. Uses Count to get the number of odd numbers in the array
            int[] aggregateArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddArr = aggregateArr.Count(d => d % 2 != 0);
            Console.WriteLine(oddArr);


            //2. Return a list of customers and how many orders each has.
            var customerResult = ListGenerator.CustomersList
                                      .Select(c => new
                                      {
                                          c.CustomerName,
                                          OrderCount = c.Orders.Count()
                                      });
            Console.WriteLine(customerResult);

            //3.Return a list of categories and how many products each has(missed)
            var Categoryresult = ProductsList.GroupBy(p => p.Category)
                                             .Select(g => new
                                             {
                                                 Category = g.Key,
                                                 ProductCount = g.Count()
                                             });


            foreach (var item in Categoryresult)
                Console.WriteLine($"{item.Category}: {item.ProductCount} products");


            //4. Get the total of the numbers in an array
            int[] numsArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int Sum = numsArr.Sum();
            Console.WriteLine($"\nSum of the array :{Sum}");



            //5.Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            string[] dectionary = File.ReadAllLines
                ("C:\\Users\\Waleed\\source\\repos\\Assignments\\src\\Assignment_10\\Part-1\\dictionary_english.txt");

            int charsCount = 0;
            foreach (var word in dectionary)
                charsCount += word.Length;
            Console.WriteLine($"\nCharacters count in 'dictionary_english.txt' file is : {charsCount} ");

            //6. Get the length of the shortest word in dictionary_english.txt

            int shortestWord = dectionary.Min(w => w.Length);
            Console.WriteLine($"the length of the shortest word in dictionary_english.txt is :{shortestWord}");


            //7. Get the length of the longest word in dictionary_english.txt
            int longestWord = dectionary.Max(w => w.Length);
            Console.WriteLine($"the length of the longest word in dictionary_english.txt is :{shortestWord}");

            //8. Get the average length of the words in dictionary_english.txt 
            double avaregeWordLength = dectionary.Average(w => w.Length);
            Console.WriteLine($"the length of the longest word in dictionary_english.txt is :{shortestWord}");


            //9. Get the total units in stock for each product category. (missed)
            var unitsPerCategory = ProductsList.GroupBy(p => p.Category)
                                               .Select(g => new
                                               {
                                                   Category = g.Key,
                                                   TotalUnits = g.Sum(p => p.UnitsInStock)

                                               });

            foreach (var item in unitsPerCategory)
                Console.WriteLine($"{item.Category}: {item.TotalUnits}");

            //10. Get the cheapest price among each category's products  (missed)
            var cheapestPerCategory = ProductsList.GroupBy(p => p.Category)
                                                  .Select(g => new
                                                  {
                                                      Category = g.Key,
                                                      CheapestPrice = g.Min(p => p.UnitPrice)
                                                  });
            foreach (var item in cheapestPerCategory)
                Console.WriteLine($"{item.Category}: {item.CheapestPrice}");


            //11. Get the products with the cheapest price in each category (Use Let)   (missed)

            var cheapestPerCat = from p in ProductsList
                                 group p by p.Category into g
                                 let minPrice = g.Min(p => p.UnitPrice)
                                 select new
                                 {
                                     Category = g.Key,
                                     Products = g.Where(p => p.UnitPrice == minPrice)
                                 };
            foreach (var item in cheapestPerCat)
            {
                Console.WriteLine(item.Category);
                foreach (var p in item.Products)
                    Console.WriteLine($"{p.ProductName}: {p.UnitPrice}");
            }

            //12. Get the most expensive price among each category's products.    (missed)

            var mostExpensivePerCategory01 = ProductsList.GroupBy(p => p.Category)
                                                         .Select(g => new
                                                         {
                                                             Category = g.Key,
                                                             HighestPrice = g.Max(p => p.UnitPrice)
                                                         });
            foreach (var item in mostExpensivePerCategory01)
                Console.WriteLine($"{item.Category}: {item.HighestPrice}");

            //13. Get the products with the most expensive price in each category.  (missed)
            var mostExpensivePerCategory02 = ProductsList.GroupBy(p => p.Category)
                                                         .Select(g => new
                                                         {
                                                             Category = g.Key,
                                                             HighestPrice = g.Max(p => p.UnitPrice)
                                                         });
            foreach (var item in mostExpensivePerCategory02)
                Console.WriteLine($"{item.Category}: {item.HighestPrice}");


            //14. Get the average price of each category's products.   (missed)
            var averagePerCategory = ProductsList.GroupBy(p => p.Category)
                                                 .Select(g => new
                                                 {
                                                     Category = g.Key,
                                                     AveragePrice = g.Average(p => p.UnitPrice)
                                                 });
            foreach (var item in averagePerCategory)
                Console.WriteLine($"{item.Category}: {item.AveragePrice}");

            #endregion


            #region Ordering Operators

            //1.Sort a list of products by name
            var orderedProductsByName = ProductsList.OrderBy(p => p.ProductName);
            Console.WriteLine(orderedProductsByName);


            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array. (missed)

            string[] wordsArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sorted = wordsArr.OrderBy(w => w, new CaseInsensitiveComparer());

            foreach (var w in sorted)
                Console.WriteLine(w);

            //3. Sort a list of products by units in stock from highest to lowest.
            var productsByStock = ProductsList.OrderByDescending(p => p.UnitsInStock);


            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] digitsArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedArr01 = digitsArr.OrderBy(w => w.Length)
                                     .ThenBy(w => w);
            foreach (var word in sortedArr01)
                Console.WriteLine(word);

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array. (case-insensitive missed)
            var sortedArr02 = wordsArr.OrderBy(w => w.Length)
                                       .ThenBy(w => w, new CaseInsensitiveComparer());

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest
            var sortedProducts = ProductsList.OrderBy(p => p.Category)
                                             .ThenByDescending(p => p.UnitPrice);
            foreach (var product in sortedProducts)
                Console.WriteLine(product);

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //repeated question (Q5)


            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            List<string> secondLetterIsIList = digitsArr.Where(d => d.Length > 1
                                                                 && d[1] == 'i')
                                                        .Reverse()
                                                        .ToList();
            foreach (var d in secondLetterIsIList)
                Console.WriteLine(d);
            #endregion

            #region Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            var names = ProductsList.Select(p => p.ProductName);
            foreach (var name in names)
                Console.WriteLine(name);


            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var result01 = words.Select(w => new
            {
                Upper = w.ToUpper(),
                Lower = w.ToLower()
            });

            foreach (var word in result01)
                Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var result02 = ProductsList.Select(p => new
            {
                Name = p.ProductName,
                Quantity = p.UnitsInStock,
                Price = p.UnitPrice
            });

            foreach (var product in result02)
                Console.WriteLine(product);


            //4.Determine if the value of int in an array match their position in the array.
            var isInPosition = NumArr.Select((num, index) => new
            {
                Number = num,
                InPlace = num == index
            });

            Console.WriteLine("Number: In-place?");
            foreach (var item in isInPosition)
                Console.WriteLine($"{item.Number}: {item.InPlace}");



            #endregion Transformation Operators

            //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b })
                                .Where(p => p.a < p.b);
            Console.WriteLine("Pairs where a < b:");
            foreach (var p in pairs)
                Console.WriteLine($"{p.a} is less than {p.b}");


            //6. Select all orders where the order total is less than 500.00.
            var orders = CustomersList.SelectMany(c => c.Orders)
                                           .Where(o => o.Total < 500.00m);

            foreach (var o in orders)
                Console.WriteLine($"Order {o.OrderID}: {o.Total}");

            //7. Select all orders where the order was made in 1998 or later.
            var recentOrders = CustomersList.SelectMany(c => c.Orders)
                                            .Where(o => o.OrderDate.Year >= 1998);

            foreach (var o in recentOrders)
                Console.WriteLine($"Order {o.OrderID}: {o.OrderDate}");


            #endregion
            #region Assignment 02 LINQ


            #region  Set Operators

            //1. Find the unique Category names from Product List
            var uniqueCategories = ProductsList
                .Select(p => p.Category)
                .Distinct();

            foreach (var category in uniqueCategories)
                Console.WriteLine(category);


            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            var firstUniqueLetters = ProductsList.Select(p => p.ProductName[0])
                                                 .Union(CustomersList.Select(c => c.CustomerName[0]));
            foreach (var letter in firstUniqueLetters)
                Console.WriteLine(letter);


            //3. Create one sequence that contains the common first letter from both product and customer names.
            var firstCommonLetters = ProductsList.Select(p => p.ProductName[0])
                                                 .Intersect(CustomersList.Select(c => c.CustomerName[0]));
            foreach (var letter in firstCommonLetters)
                Console.WriteLine(letter);



            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var firstNotCustomerLetters = ProductsList.Select(p => p.ProductName[0])
                                                      .Except(CustomersList.Select(c => c.CustomerName[0]));
            foreach (var letter in firstNotCustomerLetters)
                Console.WriteLine(letter);

            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            var lastThree = ProductsList.Select(p => p.ProductName[^3..])
                                        .Concat(CustomersList.Select(c => c.CustomerName[^3..]));

            foreach (var letter in lastThree)
                Console.WriteLine(letter);
            #endregion

            #region Partitioning Operators

            //1. Get the first 3 orders from customers in Washington
            var orders01 = CustomersList.Where(c => c.Region == "WA")
                                        .SelectMany(c => c.Orders)
                                        .Take(3);

            foreach (var order in orders01)
                Console.WriteLine($"{order.OrderID}: {order.OrderDate} {order.Total}");

            //2. Get all but the first 2 orders from customers in Washington.
            var orders02 = CustomersList.Where(c => c.Region == "WA")
                                        .SelectMany(c => c.Orders)
                                        .Skip(2);

            foreach (var order in orders02)
                Console.WriteLine($"{order.OrderID}: {order.OrderDate} {order.Total}");

            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbersArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var nums01 = numbersArr.TakeWhile((p , index) => p >= index);
            
            foreach (var number in nums01)
                Console.WriteLine(number);


            //4.Get the elements of the array starting from the first element divisible by 3.
            var nums02 = numbersArr.SkipWhile(p => p % 3 != 0);

            foreach (var number in nums02)
                Console.WriteLine(number);


            //5. Get the elements of the array starting from the first element less than its position.
            var nums03 = numbersArr.SkipWhile((n, index) => n >= index);

            foreach (var number in nums03)
                Console.WriteLine(number);






            #endregion

            #region Quantifiers Operators

            //1. Use group by to partition a list of numbers by their remainder when divided by 5

            List<int> numbersList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var groups = numbersList.GroupBy(n => n % 5);

            foreach (var group in groups)
            {
                Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
                foreach (var n in group)
                    Console.WriteLine(n);
            }




            // 2.Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input
            var wordsGroups = dectionary.Where(p => !string.IsNullOrWhiteSpace(p))
                                        .GroupBy(p => p[0]);
            foreach (var group in wordsGroups)
            {
                Console.WriteLine($"words starts with {group.Key}");
                foreach (var n in group)
                    Console.WriteLine(n);
            }

            //3.	Consider this Array as an Input
            string[] wordsArr01 = { "from", "salt", "earn", " last", "near", "form" };
            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            var wordGroups = Arr.GroupBy(w => w, new AnagramComparer());

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Group:");
                foreach (var word in g)
                    Console.WriteLine($"  {word}");
            }







            #endregion


            #endregion

        }
    }
}
