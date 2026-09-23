using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class StringOperations
    {
        //5 - Write a program that takes character from the user then if it is
        //a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
        public void VowelOrConsonant()
        {
            Console.WriteLine("Enter a character:");
            string input = Console.ReadLine().ToLower() ?? string.Empty;
            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("Invalid input. Please enter a single alphabetic character.");
                VowelOrConsonant();
            }
            if ("aeiou".Contains(input))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }

        //13- Write a program to allow the user to enter a string and print the
        //REVERSE of it.

        public void ReverseString()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty.");
                ReverseString();
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine($"Reversed string: {reversedString}");
        }


        //14- Write a program to allow the user to enter int and print the REVERSED
        //of it.
        public void ReverseInteger()
        {
            Console.WriteLine("Enter an integer to reverse:");
            string input = Console.ReadLine() ?? string.Empty;
            bool Isconvertible = int.TryParse(input, out int number);
            if (!Isconvertible)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                ReverseInteger();
            }
            int reversedNumber = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            Console.WriteLine($"Reversed integer: {reversedNumber}");
        }






        

     
    }
}
