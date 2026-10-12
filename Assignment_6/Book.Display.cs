using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{

    internal partial class Book
    {        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Type : Book, ID : {ID}, Title : {Title}, Year : {Year}.");
        }

        public void PrintBookDetails()
        {
            Console.WriteLine("--- Book Details ---");
            DisplayInfo();
        }
    }
}
