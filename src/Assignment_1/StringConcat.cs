
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class StringConcat
    {
        public void ConcatenateStrings(string str1, string str2)
        {
            string result = String.Concat(str1, str2);
            Console.WriteLine($"Concatenated string: {result}");
        }
    }
}
