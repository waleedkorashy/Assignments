using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    public abstract class LibraryItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public abstract void DisplayInfo();
        public void PrintBasicInfo()
        {
            Console.WriteLine($"ID : {ID}, Title : {Title}, Year : {Year}.");
        }
    }

}
