using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_System.Entities
{
    public class Loan
    {
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int BorrowerId { get; set; }
        public Borrower? Borrower { get; set; }
        public DateOnly LoanDate { get; set; }
        public DateOnly ReturnDate { get; set; }
    }
}
