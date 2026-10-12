using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    public sealed class LibraryConfiguration
    {
        
        public string LibraryName { get; set; } = "Alexandria Library";
        public int MaximumBorrowDays { get; set; } = 14;
        public decimal LateFeePerDay { get; set; } = 0.50m;
        private static LibraryConfiguration? _instance = null;

        private LibraryConfiguration() { }

        public static LibraryConfiguration GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LibraryConfiguration();
            }
            return _instance;
        }
    }
}