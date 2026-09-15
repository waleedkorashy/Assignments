using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Print
    {
        public void PrintNumber()
        {
            Console.WriteLine("Enter a number:");
            bool convertible = Int32.TryParse(Console.ReadLine(), out int num);
            if (convertible)
            {
                Console.WriteLine($"your number is :{num}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                PrintNumber();
            }
        }
    }
}
