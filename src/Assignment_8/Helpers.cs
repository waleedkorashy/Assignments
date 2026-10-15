using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_8
{
    public static class Helpers
    {
        //3.You are given an ArrayList containing a sequence of elements.
        //Try to reverse the order of elements in the ArrayList
        //in-place(in the same ArrayList) without using the built-in Reverse.
        //Implement a function that takes the ArrayList as input and modifies
        //it to have the reversed order of elements.
        public static void ReverseArrList(ArrayList arrayList)
        {
            for (int i = 0, j = arrayList.Count - 1; i < j; i++, j--)
            {
                object temp = arrayList[i];
                arrayList[i] = arrayList[j];
                arrayList[j] = temp;
            }
        }




        //4.You are given a list of integers.Your task is to find and return
        //a new list containing only the even numbers from the given list.
        public static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> EvenNumbers = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                    EvenNumbers.Add(i);
            }
            return EvenNumbers;
        }



        //6.Given a string, find the first non-repeated character in it and return its index.
        //If there is no such character, return -1. Hint: you can use a dictionary
        public static int FirstNonRepeatedIndex(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
