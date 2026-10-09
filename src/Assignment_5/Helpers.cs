using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal static class Helpers
    {
        
        //3. Read from the User the Coordinates for 2 points P1, P2
        //(Check the input using try Pares, Parse, Convert).
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        public static Point3D ReadPoint3D()
        {
            Point3D P = new Point3D();
            P.X = ReadInt("Enter X value:");
            P.Y = ReadInt("Enter Y value:");
            P.Z = ReadInt("Enter Z value:");
            return P;
        }
    }
}
