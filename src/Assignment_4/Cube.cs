using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    //Q2.Create a class Cube that inherits from Shape
    internal class Cube : Shape
    {
        private double Depth; //Add a new property Depth initialized through the constructor 

        public Cube(double width, double height, double depth) : base(width, height)
        {
            Depth = depth;
        }

        //Hide the Area() method using the new keyword so it returns base.Area() * Depth.
        public new double CalcArea()
        {
            return base.CalcArea() * Depth;
        }

        //Add a Print() method that prints all three dimensions.
        public override string ToString() 
        {
            return base.ToString() + $" Depth = {Depth}";
        }
    }
}
