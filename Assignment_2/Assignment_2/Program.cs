namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NumericOperations n = new NumericOperations();
            StringOperations s = new StringOperations();
            ////1- Write a program that takes a number from the user then print yes if
            ////that number can be divided by 3 and 4 otherwise print no.

            n.IsDivisible();

            ////----------------------------------------------------------------------------

            ////2- Write a program that allows the user to insert an integer then print
            ////negative if it is negative number otherwise print positive.

            n.NumSignDetector();

            //----------------------------------------------------------------------------

            //3- Write a program that takes 3 integers from the
            //user then prints the max element and the min element.

            n.FindMaxMin();


            //4- Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            n.EvenOdd();

            //----------------------------------------------------------------------------


            //5 - Write a program that takes character from the user then if it is a
            //vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            s.VowelOrConsonant();


            //----------------------------------------------------------------------------


            //6- Write a program that allows the user to insert an integer then print
            //all numbers between 1 to that number.

            n.PrintNumbersUpTo();

            //----------------------------------------------------------------------------

            //7- Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.

            n.MultiplicationTable();

            //----------------------------------------------------------------------------

            //8- Write a program that allows to user to insert number then print all
            //even numbers between 1 to this number

            n.PrintEvenNumbersUpTo();

            //----------------------------------------------------------------------------


            //9- Write a program that takes two integers then prints the power.

            n.CalculatePower();

            //----------------------------------------------------------------------------

            //10- Write a program to enter marks of five subjects and calculate total,
            //average and percentage.

            n.CalculateMarks();

            //----------------------------------------------------------------------------

            //11- Write a program to input the month number and print the number of days
            //in that month.

            n.DaysInMonth();

            //----------------------------------------------------------------------------

            //12- Write a program to create a Simple Calculator.

            n.SimpleCalculator();

            //----------------------------------------------------------------------------

            //13- Write a program to allow the user to enter a string and print the
            //REVERSE of it.

            s.ReverseString();

            //----------------------------------------------------------------------------

            //14- Write a program to allow the user to enter int and print the REVERSED
            //of it.

            s.ReverseInteger();

            //----------------------------------------------------------------------------

            //15- Write a program in C# Sharp to find prime numbers within a range of
            //numbers.

            n.FindPrimeNumbersInRange();

            //----------------------------------------------------------------------------

            // 16- . Write a program in C# Sharp to convert a decimal number into binary
            //without using an array.

            n.decimalToBinary();

            //----------------------------------------------------------------------------

            //17- Create a program that asks the user to input three points(x1, y1),
            //(x2, y2), and (x3, y3), and determines whether these points lie on a
            //single straight line.

            n.CheckCollinearity();

            //----------------------------------------------------------------------------

            //18- Within a company, the efficiency of workers is evaluated based on the
            //duration required to complete a specific task.A worker's efficiency level
            //is determined as follows:
            //- If the worker completes the job within 2 to 3 hours, they are considered
            //highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their
            //speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to
            //enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the
            //company.
            //To calculate the efficiency of a worker, the time taken for the task is
            //obtained via user input from the keyboard

            n.EfficiencyEvaluation();


            //----------------------------------------------------------------------------

            //19- Write a program that prints an identity matrix using for loop, in other 
            //words takes a value n from the user and shows the identity table of size n* n.

            n.PrintIdentityMatrix();

            //----------------------------------------------------------------------------

            //20- Write a program in C# Sharp to find the sum of all elements of the array.

            n.SumOfArrayElements();

            //----------------------------------------------------------------------------

            //21- Write a program in C# Sharp to merge two arrays of the same size
            //sorted in ascending order.

            n.MergeSortedArrays();

            //----------------------------------------------------------------------------

            //22- Write a program in C# Sharp to count the frequency of each element of
            //an array.

            n.CountFrequencyOfArrayElements();

            //----------------------------------------------------------------------------

            //23- Write a program in C# Sharp to find maximum and minimum element in an array

            n.FindMaxMinInArray();

            //----------------------------------------------------------------------------

            //24- Write a program in C# Sharp to find the second largest element in an array.

            n.FindSecondLargestInArray();


            //----------------------------------------------------------------------------


            //25-. Consider an Array of Integer values with size N, having values as
            //in this Example
            //7 0 0 0 5 6 7 5 0 7 5 3
            //write a program find the longest distance between Two equal cells.In this example.The
            //distance is measured by the number Of cells- for example, the distance between the first and
            //the fourth cell is 2 (cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.
            //Note:
            //- Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.

            n.LongestDistanceBetweenEqualCells();



            //----------------------------------------------------------------------------

            //26- Given a list of space separated words, reverse the order of the words.
            //Input: this is a test Output: test a is this
            //Input: all your base Output: base your all
            //Input: Word Output: Word
            //Note :
            //Check the Split Function (Member in String Class) Output will be a Single
            //Console.WriteLine Statement

            n.ReverseWordsInString();

            //----------------------------------------------------------------------------


            //27- Write a program to create two multidimensional arrays of same size.
            //Accept value from user and store them in first array. Now copy all the
            //elements of first array on second array and print second array.

            n.CopyMultidimensionalArray();


            //----------------------------------------------------------------------------

            //28- Write a Program to Print One Dimensional Array in Reverse Order

            n.PrintArrayInReverse();


        }
    }
}
