using System.Collections;
using static Assignment_8.Helpers;
namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Create a generic Range<T> class that represents a range
            //of values from a minimum value to a maximum value.The range
            //should support basic operations such as checking if a value is
            //within the range and determining the length of the range.

            var r = new Range<int>(5, 20);
            Console.WriteLine(r.Length());       
            Console.WriteLine(r.IsInRange(7));
            Console.WriteLine(r.IsInRange(33));


            //3.You are given an ArrayList containing a sequence of elements.
            //Try to reverse the order of elements in the ArrayList
            //in-place(in the same ArrayList) without using the built-in Reverse.
            //Implement a function that takes the ArrayList as input and modifies
            //it to have the reversed order of elements.
            var list = new ArrayList {1, 2, 3, 4, 5};
            ReverseArrList(list);
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine(string.Join(", ", list.Cast<object>()));


            //4.You are given a list of integers.Your task is to find and return
            //a new list containing only the even numbers from the given list.
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, -4, 0 };
            var result = GetEvenNumbers(nums);
            Console.WriteLine(string.Join(", ", result));




            //5.Implement a custom list called FixedSizeList<T> with a
            //predetermined capacity. This list should not allow more elements
            //than its capacity and should provide clear messages if one tries to
            //exceed it or access invalid indices.
            var list1 = new FixedSizeList<int>(2);
            list1.AddElement(10);
            list1.AddElement(20);
            Console.WriteLine(list1.GetElement(1));   
            list1.AddElement(30);






            //6.Given a string, find the first non-repeated character in it and return its index.
            //If there is no such character, return -1. Hint: you can use a dictionary
            Console.WriteLine(FirstNonRepeatedIndex("programming"));     
            Console.WriteLine(FirstNonRepeatedIndex("iloveprogramming"));
            Console.WriteLine(FirstNonRepeatedIndex("aabb"));
            Console.WriteLine(FirstNonRepeatedIndex(""));        
        }
    }
}
