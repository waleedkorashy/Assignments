using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Magazine : LibraryItem
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Type : Magazine, ID : {ID}, Title : {Title}, Year : {Year}.");
        }
    }
}
