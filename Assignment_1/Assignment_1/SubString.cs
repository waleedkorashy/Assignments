using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class SubString
    {
        public void ExtractSubString(string input, int startIndex, int length)
        {
            Console.WriteLine(input.Substring(startIndex, length));
        }
    }
}
