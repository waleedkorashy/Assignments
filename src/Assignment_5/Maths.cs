using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal static class Maths
    {
        public static int Add(int x, int y) 
            => x + y;
        public static int Subtract(int x, int y)
            => x - y;
        public static int Multiply(int x, int y)
            => x * y;
        public static int Divide(int x, int y)
            => y == 0 ? 0 : x / y;

    }
}
