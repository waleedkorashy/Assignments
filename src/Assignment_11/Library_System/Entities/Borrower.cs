using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System.Entities
{
    public class Borrower
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly? MembershipDate { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
