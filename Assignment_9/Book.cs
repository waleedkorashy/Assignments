using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    //1.	Considering the Code Below, Write Down the Body of all listed methods, properties, and the constructor:
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, 
            DateTime _PublicationDate, decimal _Price)

        { 
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
            => $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, PublicationDate: {PublicationDate}, Price: {Price}";
    }
}
