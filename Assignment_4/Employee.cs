using System;

namespace Assignment_4
{
    // Part 01 Q4 security privileges as an enum
    [Flags]
    internal enum SecLevels
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,

        // Part 01 Q6 the security officer has full permissions so he gets all of them
        SecurityOfficer = Guest | Developer | Secretary | DBA
    }

    // Part 01 Q1 the employee class
    internal class Employee
    {
        private Guid _id = Guid.NewGuid();
        private string _name = "Unknown";
        private SecLevels _securityLevel = SecLevels.Guest;
        private decimal _salary = 0;
        private HireDate _hireDate = new HireDate();
        private char _gender = 'M';

        public Guid ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value.Trim();
            }
        }

        public SecLevels SecurityLevel
        {
            get { return _securityLevel; }
            set { _securityLevel = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                // salary can't be negative
                if (value >= 0)
                    _salary = value;
            }
        }

        public HireDate HireDate
        {
            get { return _hireDate; }
            set
            {
                if (value != null)
                    _hireDate = value;
            }
        }

        // Part 01 Q3 gender can only be M or F
        public char Gender
        {
            get { return _gender; }
            set
            {
                char upper = char.ToUpper(value);

                // anything else is ignored instead of throwing an error
                if (upper == 'M' || upper == 'F')
                    _gender = upper;
            }
        }

        // Notes: constructors
        // default constructor uses all the default values above
        public Employee() { }

        // full constructor goes through the properties so every check still runs
        public Employee(string name, SecLevels securityLevel, decimal salary, HireDate hireDate, char gender)
        {
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        // Part 01 Q5 show the employee as a string with the salary as currency
        public override string ToString()
        {
            return $"ID:             {ID}\n" +
                   $"Name:           {Name}\n" +
                   $"Security level: {SecurityLevel}\n" +
                   $"Salary:         {String.Format("{0:C}", Salary)}\n" +
                   $"Hire Date:      {HireDate}\n" +
                   $"Gender:         {Gender}";
        }
    }
}