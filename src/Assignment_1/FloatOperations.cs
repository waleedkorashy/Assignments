using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class FloatOperations
    {
        public void FloatArithmeticOperations(float num1, float num2)
        {
            float sum = num1 + num2;
            float difference = num1 - num2;
            float product = num1 * num2;
            float devide = num1 / num2;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Devide: {devide}");
        }

    }
}
