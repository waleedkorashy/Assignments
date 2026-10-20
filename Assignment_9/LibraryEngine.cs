using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{ 
    public class LibraryEngine
    {
        //a) Create a user-defined delegate with the same
        //signature as the methods that exist in the BookFunctions class.
        public delegate string BooksDelegate(Book B);
        public static void ProcessBooksUsingDelegate(List<Book> bList,BooksDelegate fptr)
        {
            foreach(Book B in bList)
            {
                Console.WriteLine(fptr(B));
            } 
        }
        //b) Use the proper built-in delegate. 
        public static void ProcessBooksUsingFunc(List<Book> bList, Func<Book, string> fptr)
        {
            foreach(Book B in bList)
            {
                Console.WriteLine(fptr(B));
            } 
        }




    }
}
