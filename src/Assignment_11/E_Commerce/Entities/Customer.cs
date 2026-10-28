using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11_E_Commerce.Entities
{
    public class Customer
    {
        public int? Id { get; set; }
        public string Name { get; set; } =  string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}

