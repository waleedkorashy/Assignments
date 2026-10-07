using System;

namespace Assignment_4
{
    // Part 01 Q2 a separate class for the hiring date with day month and year
    internal class HireDate
    {
        // safe default values so the object is never empty
        private int _day = 1;
        private int _month = 1;
        private int _year = 2000;

        // Notes: properties instead of getters and setters
        // Notes: no runtime errors so a bad value is ignored and the old one stays
        public int Day
        {
            get { return _day; }
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                // a hire date can't be before 1900 or in the future
                if (value >= 1900 && value <= DateTime.Now.Year)
                    _year = value;
            }
        }

        // Notes: constructors
        // default one so we can still use new HireDate { Day = 1 }
        public HireDate() { }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // used by Employee ToString so the date prints nicely
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}