using System.Text;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Write a program that allows the user to enter a number then print it.
            Print P = new Print();
            P.PrintNumber();


            //-----------------------------------------------------------------------------------------

            //2-Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //what will happen : it will throw an exception if the string contains non-numeric characters and we try to convert it to an integer using int.TryParse
            StringToInt S = new StringToInt();
            S.ConvertStringToInt("j");
            Console.WriteLine("------------------------");
            S.ConvertStringToInt("18");



            //-----------------------------------------------------------------------------------------

            //3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            FloatOperations F = new FloatOperations();
            F.FloatArithmeticOperations(5.5f, 2.25f);


            //-----------------------------------------------------------------------------------------

            //4-Write C# program that Extract a substring from a given string.
            SubString S1 = new SubString();
            S1.ExtractSubString("Hello, World!", 7, 5);




            //-----------------------------------------------------------------------------------------


            //5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 10;
            int y = x;
            x = 20;
            //what will happen: x value got assigned to y then modified x value to 20




            //-----------------------------------------------------------------------------------------

            //6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 10;
            Console.WriteLine("initial coordinates values of p1 and p2:");
            Console.WriteLine($"Point p1 coordinates: ({p1.x}, {p1.y})");
            Point p2 = p1;
            p2.x = 10;
            p2.y = 20;
            Console.WriteLine($"Point p2 coordinates: ({p2.x}, {p2.y})");
            //modifying the object through p2 will also modify the object referenced by p1 since both p1 and p2 refer to the same object in memory.
            p2.x = 15;
            p2.y = 25;
            Console.WriteLine("modifying the object through p2:");
            Console.WriteLine($"Point p1 coordinates: ({p1.x}, {p1.y})");
            Console.WriteLine($"Point p2 coordinates: ({p2.x}, {p2.y})");


            //-----------------------------------------------------------------------------------------

            //7-	Write C# program that take two string variables and print them as one variable 
            StringConcat S2 = new StringConcat();
            S2.ConcatenateStrings("Hello, ", "World!");






            //-------------------Questions-------------------





            //8 - Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //ANSWER 
            // b)	A value 1 will be assigned to d.
            // because 30 is nnot less than 20 so it should return false but ! operator converted it to
            // true then Convert.ToInt32 will convert true to 1 and assign it to d.


            //-----------------------------------------------------------------------------------------

            //9 - Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            //ANSWER 
            //d)	6 1
            //because 13 / 2 = 6.5 but integer ignores the decimal part and 13 % 2 = 1

            //-----------------------------------------------------------------------------------------

            //10 - What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //     if (!(num <= 0))
            //         Console.WriteLine(++num + z++ + " " + ++z);
            //     else
            //         Console.WriteLine(--num + z-- + " " + --z);

            //ANSWER 
            //d)	7 7
            //because the condition !(num <= 0) is true so first block will be executed
            //and in the cw statement ++num will be 2 and z++ will be 5 then ++z will be 7 so the output will be 7 7


        }
    }
}
