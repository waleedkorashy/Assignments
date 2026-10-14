using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
    //Q11.Create a class FineCalculator with these methods:
    public class FineCalculator
    {
        //int Add(int a, int b)
        public int Add(int a, int b)
                => a + b;

        //int Subtract(int a, int b)
        public int Subtract(int a, int b)
                => a - b;

        //int Multiply(int a, int b)
        public int Multiply(int a, int b)
            => a * b;

        //int Divide(int a, int b) — must throw DivideByZeroException when b == 0       
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

    }
}
