using System.Threading.Channels;
using static Assignment_6.LibraryUtilities;
namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=============================Part 1 — Abstract Class==================================
            Console.WriteLine("----------------Part 1 — Abstract Class---------------");

            LibraryItem item = new Book()
            {
                ID = 1,
                Title = "Test",
                Year = 1999
            };
            item.DisplayInfo();


            //Answer these questions in comments or a separate README.md:

            //1.Why is LibraryItem abstract?
            //To apply polymorphism and enforce the derived classes to implement the abstract methods

            //2.Why can't we create:
            //new LibraryItem();
            //Because LibraryItem is abstract class and we cant create instances of an abstract classes  

            //3.What is the difference between the abstract DisplayInfo() method and the concrete PrintBasicInfo() method?
            //DisplayInfo() cant have an implementation in teh base class and the derived classe has to implement it (override)
            //while PrintBasicInfo() is a concrete method which can have default implementation in the base class'



            //-------------------------------------------------------------------------------
            //=============================Part 2 — IComparable<T>==================================
            Console.WriteLine("----------------Part 2 — IComparable<T>---------------");


            //Create several books
            //put them inside:List<Book>

            List<Book> books = new List<Book>
            {
                new Book { ID = 1, Title = "C# in Depth", Year = 2019 },
                new Book { ID = 2, Title = "Design Patterns", Year = 1994 },
                new Book { ID = 3,  Title = "The Pragmatic Programmer", Year = 1994 },
                new Book { ID = 4, Title = "Clean Code", Year = 2008 }
            };

            //Then sort them
            books.Sort();

            //Print the result
            Console.WriteLine("Sorted Books:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }

            //=============================Part 3 — ICloneable==================================
            Console.WriteLine("----------------Part 3 — ICloneable---------------");
            var originalBook = new Book() { ID = 1, Title = "Clean Code", Year = 2019 };
            var clonedBook = (Book)originalBook.Clone();
            clonedBook.Title = "Clean Code - Copy";

            originalBook.DisplayInfo();
            clonedBook.DisplayInfo();




            //Answer:
            //1.What is the difference between copying an object reference and cloning an object?
            //in copying an object refrence if you changed one value in one object it gets changed in the other one 
            //because its two refrence pointers points at the same object in the memory

            //2.What happens if you do:
            //Book clone = original;
            //it copies the refrence of the original object so both will be pointing at the same obj in memory

            //3.Why does ICloneable.Clone() return object ?
            //because it was created before generics 

            //4.Research and explain one limitation or criticism of ICloneable.
            //it does not specify whether it performs a "shallow copy" or a "deep copy" making its behavior completely 
            //ambiguous and unpredictable to developers.






            //---------------------------Part 4 — Static Class--------------------------
            Console.WriteLine("--------------------Part 4 — Static Class-------------------");

            PrintSeparator();
            Console.WriteLine($"Late Fee for 5 days: ${CalcLateFee(5)}");
            Console.WriteLine($"Generated Book Code: {GenerateBookCode("The Pragmatic Programmer", 1994)}");
            PrintSeparator();

            //---------------------------Part 5 — Sealed Class--------------------------

            //why we cant inherit LibraryCard ?
            //by making LibraryCard as sealed we explicitly tell the C# compiler that this class represents the final and complete version

            //1. What does sealed mean?
            //it prevents other classes from inheriting from it

            //2. Why might a developer intentionally prevent inheritance?
            //for security, to prevent broken behavior, and for slight performance gains

            //3. Can a sealed class inherit from another class?
            //yes it can have a parent class but cannot have child classes

            //4. Can a sealed class implement an interface?
            //yes it can implement interfaces normally



            //---------------------------Part 6 — Partial Class--------------------------

            //1. What does partial do?
            //it lets you split a single class definition across multiple source files

            //2. Does partial create two different Book classes?
            //no the compiler merges them into one single class during compilation

            //3. Does partial have any effect on the runtime type?
            //no at runtime it exists as a single standard unified type

            //4. Give one real-world situation where partial classes are useful.
            //keeping auto-generated database designer code separate from user-written logic



            //---------------------------Part 7 — Operator Overloading--------------------------

            //1. Why can operators be overloaded in C#?
            //because C# permits redefining standard operator syntax for custom types via static methods

            //2. What makes operator overloading useful?
            //it simplifies mathematical or logical expressions on custom objects using natural syntax

            //3. When can operator overloading make code harder to understand?
            //when an operator is forced to perform non-standard unpredictable, or hidden behaviors

            //4. Why should overloaded operators behave intuitively?
            //to match developer expectations and prevent logical errors caused by unexpected behavior


            //---------------------------Part 8 — Singleton Design Pattern--------------------------

            LibraryConfiguration config1 = LibraryConfiguration.GetInstance();
            LibraryConfiguration config2 = LibraryConfiguration.GetInstance();
            bool areIdentical = ReferenceEquals(config1, config2);

            Console.WriteLine($"Config 1 Library Name: {config1.LibraryName}");
            Console.WriteLine($"Config 2 Library Name: {config2.LibraryName}");
            Console.WriteLine($"Are config1 and config2 the exact same instance? {areIdentical}");

            //1. Why the constructor is private?
            //to hide it from external code completely blocking the use of "new LibraryConfiguration()"

            //2. Why the instance is static?
            //so it belongs directly to the class blueprint keeping a single shared object across the entire application runtime

            //3. Why the class is sealed?
            //to stop inheritance and preventing subclasses from altering or bypassing its unique instance logic

            //4. How your implementation guarantees a single instance?
            //it restricts creation to the GetInstance() method checking if the object is null before making a new one

            //5. How your implementation behaves when multiple threads access it simultaneously?
            //multiple threads entering simultaneously could cause a race condition accidentally creating multiple instances
        }
    }
}
