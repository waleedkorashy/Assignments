using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library_System.Entities
{
    public class Book
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? ISBN { get; set; }
        public int? AuthorId { get; set; }

        public Author? Author { get; set; } = null;
        public ICollection<Loan>? Loans { get; set; }

    }
}
