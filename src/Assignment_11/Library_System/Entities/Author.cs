using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System.Entities
{
    public class Author
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly? BirthDate { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
