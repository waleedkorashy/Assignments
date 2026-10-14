using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
    //Make the constructor private.
    //Add a private static field to hold the single instance(starts as null).
    //Add a public static method GetLogger() that creates the instance
    //only on the first call and returns the same instance every time

    public class AppLogger
    {
        private static AppLogger instance;
        private AppLogger() { }

        public static AppLogger GetLogger()
        {
            if (instance == null) 
                return new AppLogger();
            else return instance;
        }
    }
}
