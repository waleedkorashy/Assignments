using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment_6
{
    public static class LibraryUtilities
    {
        public static decimal CalcLateFee(int overdueDays)
        {
            if (overdueDays <= 0) return 0.00m;
            return overdueDays * 0.50m;
        }
        public static string GenerateBookCode(string title, int year)
        {
            if (string.IsNullOrWhiteSpace(title)) return $"UNKNOWN-{year}";

            string[] words = title.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string initials = "";

            foreach (var word in words)
            {
                initials += char.ToUpper(word[0]);
            }

            return $"{initials}-{year}";
        }

      
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('=', 40));
        }
    }

}

