using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class StringToInt
    {
        public void ConvertStringToInt(string input)
        {
            bool convertable = int.TryParse(input, out int result);
            if (convertable)
            {
                Console.WriteLine($"Converted number is: {result}");
            }
            else
            {
                Console.WriteLine("Error: The input string contains non-numeric characters and cannot be converted to an integer");
            }


        }
    }
}
