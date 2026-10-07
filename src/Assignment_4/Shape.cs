using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class Shape
    {
        //. Create a class Shape with two auto-properties Width and Height (of type double)
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor that initializes them
        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //method Area() that returns Width
        public double CalcArea()
        {
            return Height * Width;
        }

        //Override ToString() to return "(Width = ..., Height = ...)".
        public override string ToString()
        {
            return $"Width = {Width}, Height = {Height}";
        }
    }
}
