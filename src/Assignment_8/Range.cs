using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Assignment_8
{
    //1.Create a generic class named Range<T> where T represents the type of values.
    internal class Range<T> where T : IComparable<T> , INumber<T>
    {
        public T Min { get; }
        public T Max { get; }

        //2.Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max.");

            Min = min;
            Max = max;
        }

        //3.Implement a method IsInRange(T value) that returns true if the given value is within the range; otherwise, false.
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;

        }

        //4.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        public T Length()
        {
            return Max - Min;
        }
    }
}
