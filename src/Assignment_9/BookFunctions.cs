using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment_9
{
    public class BookFunctions
    {
        public static string GetTitle(Book B) 
            => B.Title;

        public static string GetAuthors(Book B)
            => String.Join(',',B.Authors);

        public static string GetPrice(Book B)
            => B.Price.ToString();
    }
}
