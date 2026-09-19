namespace Assignment_2
{
    internal class NumericOperations
    {

        #region Helpers methods to read an numbers from the console with validation

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        private double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static int[] ReadPoint(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string[] parts = (Console.ReadLine() ?? string.Empty).Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2
                    && int.TryParse(parts[0], out int x)
                    && int.TryParse(parts[1], out int y))
                {
                    return new[] { x, y };
                }

                Console.WriteLine("Invalid input. Enter two integers like: 3, 5");
            }
        }
        #endregion


        //1- Write a program that takes a number from the user then print yes if
        //that number can be divided by 3 and 4 otherwise print no.
        public void IsDivisible()
        {
            int number = ReadInt("Enter a number:");
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }





        //2- Write a program that allows the user to insert an integer then print
        //negative if it is negative number otherwise print positive.

        public void NumSignDetector()
        {
            int number = ReadInt("Enter an integer:");

            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }



        }

        //3- Write a program that takes 3 integers from the user
        //then prints the max element and the min element.
        public void FindMaxMin()
        {
            Console.WriteLine("Enter three integers separated by spaces:");
            string input = Console.ReadLine() ?? string.Empty;


            string[] parts = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3)
            {
                Console.WriteLine("Please enter exactly three integers separated by spaces.");
                FindMaxMin();
            }

            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter three valid integers separated by spaces.");
                    return;
                }
            }

            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Min: {numbers.Min()}");
        }

        //4- Write a program that allows the user to insert an integer number then
        //check If a number is even or odd.
        public void EvenOdd()
        {
            int number = ReadInt("Enter an integer:");


            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }


        //6- Write a program that allows the user to insert an integer then print
        //all numbers between 1 to that number.

        public void PrintNumbersUpTo()
        {
            int number = ReadInt("Enter an integer:");
            if (number < 1)
            {
                Console.WriteLine("Please enter a positive integer greater than or equal to 1.");
                PrintNumbersUpTo();
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }


        }


        //7- Write a program that allows the user to insert an integer then
        //print a multiplication table up to 12.

        public void MultiplicationTable()
        {
            int number = ReadInt("Enter an integer:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }



        }


        //8- Write a program that allows to user to insert number then print all
        //even numbers between 1 to this number

        public void PrintEvenNumbersUpTo()
        {
            int number = ReadInt("Enter an integer:");
            if (number < 2)
            {
                Console.WriteLine("Please enter a positive integer greater than or equal to 2.");
                PrintEvenNumbersUpTo();
            }
            else
            {
                for (int i = 2; i <= number; i += 2)
                {
                    Console.WriteLine(i);
                }
            }


        }



        //9- Write a program that takes two integers then prints the power.

        public void CalculatePower()
        {
            int baseNumber = ReadInt("Enter the base integer:");
            int exponent = ReadInt("Enter the exponent integer:");

            int result = (int)Math.Pow(baseNumber, exponent);
            Console.WriteLine($"Result: {result}");
        }

        //10- Write a program to enter marks of five subjects and calculate total,
        //average and percentage.


        public void CalculateMarks()
        {
            Console.WriteLine("Enter marks of five subjects separated by spaces:");
            string input = Console.ReadLine() ?? string.Empty;
            string[] parts = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 5)
            {
                Console.WriteLine("Please enter exactly five marks separated by spaces.");
                CalculateMarks();
                return;
            }
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(parts[i], out marks[i]))
                {
                    Console.WriteLine("Invalid input. Please enter five valid integers for marks.");
                    return;
                }
            }
            int total = marks.Sum();
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;
            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}%");
        }

        //-------------------------------------------------------------------------------

        //11- Write a program to input the month number and print the number of days
        //in that month.
        public void DaysInMonth()
        {
            int month = ReadInt("Enter the month number (1-12):");

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Please enter a valid month number between 1 and 12.");
                DaysInMonth();
            }
            else
            {
                int days = DateTime.DaysInMonth(DateTime.Now.Year, month);
                Console.WriteLine($"Number of days in month {month}: {days}");
            }

        }


        //12- Write a program to create a Simple Calculator.
        public void SimpleCalculator()
        {
            double firstNumber = ReadDouble("Enter first number:");
            double secondNumber = ReadDouble("Enter second number:");

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string operation = Console.ReadLine() ?? string.Empty;
            double result;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    return;
            }
            Console.WriteLine($"Result: {result}");
        }

        //15- Write a program in C# Sharp to find prime numbers within a range of
        //numbers.

        public void FindPrimeNumbersInRange()
        {
            int start = ReadInt("Input starting number of range:");
            int end = ReadInt("Input ending number of range:");

            if (start > end)
            {
                Console.WriteLine("Start must be less than or equal to end.");
                return;
            }

            bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            Console.WriteLine($"The prime numbers between {start} and {end} are:");
            bool found = false;
            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write($"{num} ");
                    found = true;
                }
            }

            Console.WriteLine(found ? "" : "No prime numbers found.");
        }

        // 16- . Write a program in C# Sharp to convert a decimal number into binary
        //without using an array.
        //Test Data :
        //Enter a number to convert : 25
        //Expected Output :
        //The Binary of 25 is 11001.
        public void decimalToBinary()
        {
            int number = ReadInt("Enter a decimal number to convert:");
            if (number < 0)
            {
                Console.WriteLine("Please enter a non-negative integer.");
                return;
            }
            string binary = string.Empty;
            if (number == 0)
            {
                binary = "0";
            }
            else
            {
                while (number > 0)
                {
                    binary = (number % 2).ToString() + binary;
                    number /= 2;
                }
            }
            Console.WriteLine($"The Binary of the entered number is {binary}.");
        }

        //17- Create a program that asks the user to input three points(x1, y1),
        //(x2, y2), and (x3, y3), and determines whether these points lie on a
        //single straight line.
        public void CheckCollinearity()
        {
            int[] p1 = ReadPoint("Enter the coordinates of the first point (x1, y1):");
            int[] p2 = ReadPoint("Enter the coordinates of the second point (x2, y2):");
            int[] p3 = ReadPoint("Enter the coordinates of the third point (x3, y3):");

            long left = (long)(p2[1] - p1[1]) * (p3[0] - p2[0]);
            long right = (long)(p3[1] - p2[1]) * (p2[0] - p1[0]);

            if (left == right)
                Console.WriteLine("The points lie on a single straight line.");
            else
                Console.WriteLine("The points do not lie on a single straight line.");
        }

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
        public void EfficiencyEvaluation()
        {
            int hours = ReadInt("Enter the time taken to complete the task (in hours):");
            switch (hours)
            {
                case < 2:
                    Console.WriteLine("Invalid input. Time taken cannot be less than 2 hours.");
                    break;
                case >= 2 and < 3:
                    Console.WriteLine("Highly efficient.");
                    break;
                case >= 3 and < 4:
                    Console.WriteLine("Increase your speed.");
                    break;
                case >= 4 and < 5:
                    Console.WriteLine("You will be provided with training to enhance your speed.");
                    break;
                case >= 5:
                    Console.WriteLine("You are required to leave the company.");
                    break;
            }
        }




        //19- Write a program that prints an identity matrix using for loop, in other 
        //words takes a value n from the user and shows the identity table of size n* n.

        public void PrintIdentityMatrix()
        {
            int n = ReadInt("Enter the size of the identity matrix (n):");
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }

        //20- Write a program in C# Sharp to find the sum of all elements of the array.
        public void SumOfArrayElements()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string InputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(InputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (arr.Length <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }
            int sum = arr.Sum();
            Console.WriteLine($"The sum of all elements in the array is: {sum}");
        }

        //21- Write a program in C# Sharp to merge two arrays of the same size
        //sorted in ascending order.

        public void MergeSortedArrays()
        {
            Console.WriteLine("Enter the elements of the first sorted array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string InputArr1 = Console.ReadLine() ?? string.Empty;
            int[] arr1 = Array.ConvertAll(InputArr1.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            Console.WriteLine("Enter the elements of the second sorted array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string InputArr2 = Console.ReadLine() ?? string.Empty;
            int[] arr2 = Array.ConvertAll(InputArr2.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Both arrays must be of the same size.");
                return;
            }
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, mergedArray, arr1.Length);
            Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);
            Array.Sort(mergedArray);
            Console.WriteLine("Merged and sorted array: " + string.Join(", ", mergedArray));
        }

        //22- Write a program in C# Sharp to count the frequency of each element of an array.

        public void CountFrequencyOfArrayElements()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string inputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(inputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (arr.Length == 0)
            {
                Console.WriteLine("Please enter at least one element.");
                return;
            }

            bool[] counted = new bool[arr.Length];

            Console.WriteLine("Frequency of each element:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (counted[i]) continue;

                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        counted[j] = true;
                    }
                }

                Console.WriteLine($"Element: {arr[i]}, Frequency: {count}");
            }
        }


        //23- Write a program in C# Sharp to find maximum and minimum element in an array

        public void FindMaxMinInArray()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string inputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(inputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            if (arr.Length == 0)
            {
                Console.WriteLine("Please enter at least one element.");
                return;
            }
            int max = arr.Max();
            int min = arr.Min();
            Console.WriteLine($"Maximum element in the array: {max}");
            Console.WriteLine($"Minimum element in the array: {min}");
        }


        //24- Write a program in C# Sharp to find the second largest element in an array.

        public void FindSecondLargestInArray()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string inputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(inputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (arr.Length < 2)
            {
                Console.WriteLine("Please enter at least two elements.");
                return;
            }

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int secondMax = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != max)
                {
                    if (found == false || arr[i] > secondMax)
                    {
                        secondMax = arr[i];
                        found = true;
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine("There is no second largest element in the array.");
            }
            else
            {
                Console.WriteLine($"The second largest element in the array is: {secondMax}");
            }
        }

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
        public void LongestDistanceBetweenEqualCells()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3");
            string inputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(inputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int maxDistance = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!firstOccurrence.ContainsKey(arr[i]))
                {
                    firstOccurrence[arr[i]] = i;
                }
                else
                {
                    int distance = i - firstOccurrence[arr[i]] - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
            }
            if (maxDistance == -1)
            {
                Console.WriteLine("No equal cells found.");
            }
            else
            {
                Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            }
        }


        //26- Given a list of space separated words, reverse the order of the words.
        //Input: this is a test Output: test a is this
        //Input: all your base Output: base your all
        //Input: Word Output: Word
        //Note :
        //Check the Split Function (Member in String Class) Output will be a Single
        //Console.WriteLine Statement
        public void ReverseWordsInString()
        {
            Console.WriteLine("Enter a list of space-separated words:");
            string input = Console.ReadLine() ?? string.Empty;
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            string reversed = string.Join(" ", words);
            Console.WriteLine($"Reversed order of words: {reversed}");
        }


        //27- Write a program to create two multidimensional arrays of same size.
        //Accept value from user and store them in first array. Now copy all the
        //elements of first array on second array and print second array.
        public void CopyMultidimensionalArray()
        {
            int rows = ReadInt("Enter the number of rows for the 2D array:");
            int cols = ReadInt("Enter the number of columns for the 2D array:");
            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];
            Console.WriteLine($"Enter {rows * cols} elements for the first array (row-wise):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    firstArray[i, j] = ReadInt($"Element at [{i},{j}]:");
                }
            }
            // Copying elements to second array
            Array.Copy(firstArray, secondArray, firstArray.Length);
            Console.WriteLine("Elements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //28- Write a Program to Print One Dimensional Array in Reverse Order
        public void PrintArrayInReverse()
        {
            Console.WriteLine("Enter the elements of the array separated by spaces or commas: \n Example: 1, 2, 3, 4, 5");
            string inputArr = Console.ReadLine() ?? string.Empty;
            int[] arr = Array.ConvertAll(inputArr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Array.Reverse(arr);
            Console.WriteLine("Array in reverse order: " + string.Join(", ", arr));


        }
    }
}
