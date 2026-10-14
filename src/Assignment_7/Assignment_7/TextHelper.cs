using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Assignment_7
{
    //Q9. Create a static class TextHelper with these extension methods on string:

    public static class TextHelper
    {
        //1. IsShorterThan(this string value, int length) — returns true if value.Length is less than length;
        //otherwise false.
        public static bool IsShorterThan(this string value, int length)
            => value.Length < length;

        //2. Repeat(this string value, int times) — returns the string repeated times times.Example: "Ha".Repeat(3)
        //→ "HaHaHa".
        public static string Repeat(this string value, int times)
        {
            if (times <= 0) 
                return value;

            StringBuilder sb = new();
            for (int i = 0; i < times; i++)
            {
                sb.Append(value);
            }
            return sb.ToString();
        }


    }
}
