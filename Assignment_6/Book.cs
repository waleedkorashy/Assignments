using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal partial class Book : LibraryItem, IComparable<Book>, ICloneable
    {
        public int PageCount { get; set; }

        public int CompareTo(Book? other)
        {
            if (other == null) return 0;
            if (Year == other.Year)
                return Title.CompareTo(other.Title);
            return Year.CompareTo(other.Year);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


        public static bool operator >(Book book1, Book book2)
        {
            if (book1 is null || book2 is null) return false;
            return book1.PageCount > book2.PageCount;
        }
        public static bool operator <(Book book1, Book book2)
        {
            if (book1 is null || book2 is null) return false;
            return book1.PageCount < book2.PageCount;
        }
        public static Book operator +(Book book1, Book book2)
        {
            if (book1 is null) throw new ArgumentNullException(nameof(book1));
            if (book2 is null) throw new ArgumentNullException(nameof(book2));

            return new Book
            {
                ID = -1,
                Title = $"{book1.Title} & {book2.Title} Bundle",
                Year = Math.Max(book1.Year, book2.Year),
                PageCount = book1.PageCount + book2.PageCount
            };
        }
    }
}
