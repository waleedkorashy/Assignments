using Assignment_3;
using System;

namespace Assignment_4
{
    // ===================== ENUMS =====================

    // Enum&Struct Q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Enum&Struct Q2 and Q7

    struct PersonStruct
    {
        public string Name;
        public int Age;
    }


    // Enum & Struct Q3
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    // Enum&Struct Q4 [Flags] lets us combine enum values using |
    [Flags]
    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    // Enum&Struct Q5
    enum Colors 
    {
        Red,
        Green,
        Blue
    }

    // Enum&Struct Q6
    struct Point
    {
        public double X;
        public double Y;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Functions_Q1_ValueType();
            Functions_Q2_ReferenceType();
            Functions_Q3_SumAndSubtract();
            Functions_Q4_SumOfDigits();
            Functions_Q5_IsPrime();
            Functions_Q6_MinMaxArray();
            Functions_Q7_Factorial();
            Functions_Q8_ChangeChar();

            EnumStruct_Q1_WeekDays();
            EnumStruct_Q2_PersonArray();
            EnumStruct_Q3_Season();
            EnumStruct_Q4_Permissions();
            EnumStruct_Q5_Colors();
            EnumStruct_Q6_PointDistance();
            EnumStruct_Q7_OldestPerson();
        }

        //======================= FUNCTIONS ==========================

        // 1 Explain the difference between passing (Value type parameters) by
        // value and by reference then write a suitable c# example.

        // By value means the function gets a copy so the original stays the same
        // By reference means the function gets the original itself so it changes too
        private static void Functions_Q1_ValueType()
        {
            Console.WriteLine("----- Functions Q1: Value Type by Value vs Reference -----");

            // Passing by value
            int x = 5;
            Console.WriteLine($"Before ChangeValueByValue: {x}");
            ChangeValueByValue(x);
            Console.WriteLine($"After ChangeValueByValue: {x}");

            // Passing by reference
            int y = 5;
            Console.WriteLine($"Before ChangeValueByRef: {y}");
            ChangeValueByRef(ref y);
            Console.WriteLine($"After ChangeValueByRef: {y}");
            Console.WriteLine();
        }
        private static void ChangeValueByValue(int x)
        {
            x = 10;
        }
        private static void ChangeValueByRef(ref int x)
        {
            x = 10;
        }




        //-----------------------------------------------------------------------------
        // 2 Explain the difference between passing (Reference type parameters) by
        // value and by reference then write a suitable c# example

        // By value the function gets a copy of the reference not the object
        // so changing the object's data shows up outside
        // but giving it a new object only changes the local copy
        // By ref the original reference is used so a new object shows up outside too
        private static void Functions_Q2_ReferenceType()
        {
            Console.WriteLine("----- Functions Q2: Reference Type by Value vs Reference -----");

            // Passing by value
            PersonClass p1 = new PersonClass { Name = "Mohamed" };
            Console.WriteLine($"Before ChangePersonByValue: {p1.Name}");
            Console.WriteLine($"       HashCode: {p1.GetHashCode()}");
            ChangePersonByValue(p1);
            Console.WriteLine($"After ChangePersonByValue: {p1.Name}");
            Console.WriteLine($"       HashCode: {p1.GetHashCode()}");

            // Passing by reference
            PersonClass p2 = new PersonClass { Name = "Ahmed" };
            Console.WriteLine($"Before ChangePersonByRef: {p2.Name}");
            Console.WriteLine($"       HashCode: {p2.GetHashCode()}");

            ChangePersonByRef(ref p2);
            Console.WriteLine($"After ChangePersonByRef: {p2.Name}");
            Console.WriteLine($"       HashCode: {p2.GetHashCode()}");

            Console.WriteLine();
        }   
        private static void ChangePersonByValue(PersonClass p)
        {
            p = new PersonClass { Name = "New Person" };
        }
        private static void ChangePersonByRef(ref PersonClass p)
        {
            p = new PersonClass { Name = "Mohamed" };
        }





        //-----------------------------------------------------------------------------
        // 3 Write a c# Function that accepts 4 parameters from user and
        // returns the result of summation and subtracting of two numbers
        private static void Functions_Q3_SumAndSubtract()
        {
            Console.WriteLine("----- Functions Q3: Sum and Subtract -----");

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int sum = SumAndSubtract(a, b, c, d, true);
            int diff = SumAndSubtract(a, b, c, d, false);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {diff}");
            Console.WriteLine();
        }

        // bool flag decides add or subtract since the question wants both
        private static int SumAndSubtract(int a, int b, int c, int d, bool doSum)
        {
            if (doSum)
                return a + b;
            else
                return c - d;
        }

        // 4 Write a program in C# Sharp to create a function to calculate the
        // sum of the individual digits of a given number.
        // Output should be like:
        // Enter a number: 25
        // The sum of the digits of the number 25 is: 7
        private static void Functions_Q4_SumOfDigits()
        {
            Console.WriteLine("----- Functions Q4: Sum of Digits -----");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            Console.WriteLine();
        }

        private static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); // in case of a negative number

            while (number > 0)
            {
                sum = sum + number % 10; // get last digit and add it
                number = number / 10;    // remove last digit
            }

            return sum;
        }

        // 5 Create a function named "IsPrime" which receives an integer
        // number and returns true if it is prime or false if it is not
        private static void Functions_Q5_IsPrime()
        {
            Console.WriteLine("----- Functions Q5: IsPrime -----");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false; // found a divisor so it's not prime
            }

            return true;
        }

        // 6 Create a function named MinMaxArray to return the minimum and
        // maximum values stored in an array using reference parameters
        private static void Functions_Q6_MinMaxArray()
        {
            Console.WriteLine("----- Functions Q6: MinMaxArray -----");

            int[] numbers = { 12, 45, 3, 67, 21, 9 };
            int min, max;

            MinMaxArray(numbers, out min, out max);

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine();
        }

        // used out because we need to return two values
        private static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        // 7 Create an iterative (non recursive) function to calculate the
        // factorial of the number specified as parameter
        private static void Functions_Q7_Factorial()
        {
            Console.WriteLine("----- Functions Q7: Factorial -----");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long result = Factorial(number);
            Console.WriteLine($"The factorial of {number} is: {result}");
            Console.WriteLine();
        }

        private static long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        // 8 Create a function named "ChangeChar" to modify a letter in a
        // certain position (0 based) of a string replacing it with a
        // different letter
        private static void Functions_Q8_ChangeChar()
        {
            Console.WriteLine("----- Functions Q8: ChangeChar -----");

            string word = "Hello";
            Console.WriteLine($"Before: {word}");

            word = ChangeChar(word, 0, 'J');
            Console.WriteLine($"After: {word}");
            Console.WriteLine();
        }

        // strings can't be edited directly so I use a char array then make a new string
        private static string ChangeChar(string text, int position, char newChar)
        {
            char[] chars = text.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }

        // ===================== ENUM & STRUCT SECTION =====================

        // 1 Create an enum called "WeekDays" with the days of the week
        // (Monday to Sunday) as its members. Then write a C# program that
        // prints out all the days of the week using this enum.
        private static void EnumStruct_Q1_WeekDays()
        {
            Console.WriteLine("----- Enum&Struct Q1: WeekDays -----");

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();
        }

        // 2 Define a struct "Person" with properties "Name" and "Age".
        // Create an array of three "Person" objects and populate it with data.
        // Then write a C# program to display the details of all the persons
        // in the array.
        private static void EnumStruct_Q2_PersonArray()
        {
            Console.WriteLine("----- Enum&Struct Q2: Person Array -----");

            PersonStruct[] people = new PersonStruct[3];

            people[0].Name = "Ahmed";
            people[0].Age = 20;

            people[1].Name = "Sara";
            people[1].Age = 22;

            people[2].Name = "Omar";
            people[2].Age = 19;

            foreach (PersonStruct p in people)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
            Console.WriteLine();
        }

        // 3 Create an enum called "Season" with the four seasons (Spring
        // Summer Autumn Winter). Write a C# program that takes a season
        // name as input from the user and displays the corresponding month
        // range for that season.
        // Spring: March to May  Summer: June to August
        // Autumn: September to November  Winter: December to February
        private static void EnumStruct_Q3_Season()
        {
            Console.WriteLine("----- Enum&Struct Q3: Season -----");

            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();

            // turn the typed text into a Season value
            Season season = (Season)Enum.Parse(typeof(Season), input, true);

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
            }
            Console.WriteLine();
        }

        // 4 Assign the following Permissions (Read Write Delete Execute)
        // in a form of Enum. Create a variable from the previous Enum to Add
        // and Remove Permission from the variable and check if a specific
        // Permission exists inside the variable.
        private static void EnumStruct_Q4_Permissions()
        {
            Console.WriteLine("----- Enum&Struct Q4: Permissions -----");

            Permissions myPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Initial permissions: {myPermissions}");

            // Add a permission
            myPermissions = myPermissions | Permissions.Delete;
            Console.WriteLine($"After adding Delete: {myPermissions}");

            // Remove a permission
            myPermissions = myPermissions & ~Permissions.Write;
            Console.WriteLine($"After removing Write: {myPermissions}");

            // Check if a permission exists
            bool canExecute = myPermissions.HasFlag(Permissions.Execute);
            Console.WriteLine($"Has Execute permission? {canExecute}");

            bool canRead = myPermissions.HasFlag(Permissions.Read);
            Console.WriteLine($"Has Read permission? {canRead}");
            Console.WriteLine();
        }

        // 5 Create an enum called "Colors" with the basic colors
        // (Red Green Blue). Write a C# program that takes a color name
        // as input from the user and displays a message indicating whether
        // the input color is a primary color or not.
        private static void EnumStruct_Q5_Colors()
        {
            Console.WriteLine("----- Enum&Struct Q5: Colors -----");

            Console.Write("Enter a color name: ");
            string input = Console.ReadLine();

            // check if the text matches one of the Colors values
            bool isValidColor = Enum.TryParse<Colors>(input, true, out _);

            if (isValidColor)
                Console.WriteLine($"{input} is a primary color.");
            else
                Console.WriteLine($"{input} is not a primary color.");
            Console.WriteLine();
        }

        // 6 Create a struct called "Point" to represent a 2D point with
        // properties "X" and "Y". Write a C# program that takes two points
        // as input from the user and calculates the distance between them.
        private static void EnumStruct_Q6_PointDistance()
        {
            Console.WriteLine("----- Enum&Struct Q6: Point Distance -----");

            Point p1 = new Point();
            Console.Write("Enter X for point 1: ");
            p1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y for point 1: ");
            p1.Y = Convert.ToDouble(Console.ReadLine());

            Point p2 = new Point();
            Console.Write("Enter X for point 2: ");
            p2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y for point 2: ");
            p2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = GetDistance(p1, p2);
            Console.WriteLine($"The distance between the two points is: {distance:F2}");
            Console.WriteLine();
        }

        // Distance formula: sqrt((x2 minus x1)^2 + (y2 minus y1)^2)
        private static double GetDistance(Point a, Point b)
        {
            double dx = b.X - a.X;
            double dy = b.Y - a.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // 7 Create a struct called "Person" with properties "Name" and "Age".
        // Write a C# program that takes details of 3 persons as input from the
        // user and displays the name and age of the oldest person.
        private static void EnumStruct_Q7_OldestPerson()
        {
            Console.WriteLine("----- Enum&Struct Q7: Oldest Person -----");

            PersonStruct[] people = new PersonStruct[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                people[i].Name = Console.ReadLine();

                Console.Write($"Enter age of person {i + 1}: ");
                people[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            // assume the first one is oldest then check the others
            PersonStruct oldest = people[0];
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }

            Console.WriteLine($"The oldest person is {oldest.Name}, age {oldest.Age}");
            Console.WriteLine();
        }
    }
}