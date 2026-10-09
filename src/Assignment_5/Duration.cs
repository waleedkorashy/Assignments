using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class Duration
    {
        #region Attributes
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Invalid value, Hours sat to 0");
                    _hours = default;
                }
                else
                {
                    _hours = value;
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Error: Invalid value for Minutes, Munites sat to 0");
                    _minutes = default;
                }
                else
                {
                    _minutes = value;
                }
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Error: Invalid value for Seconds, Seconds sat to 0");
                    _seconds = default;
                }
                else
                {
                    _seconds = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Duration() { }
        public Duration(int totalSeconds)
        {

            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        #endregion
        #region Methods
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is not Duration other)
                return false;

            return this.Hours == other.Hours
                && this.Minutes == other.Minutes
                && this.Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes:{Minutes:D2}, Seconds:{Seconds:D2}";
            }
            else if (Hours == 0 && Minutes == 0)
            {
                return $"Seconds:{Seconds:D2}";
            }
            return $"Hours:{Hours:D2}, Minutes:{Minutes:D2}, Seconds:{Seconds:D2}";
        }
        #endregion
        #region Operator overload
        //Implement All required Operators overloading to enable this Code:


        // D3=D1+D2
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours + d2.Hours) * 3600
                             + (d1.Minutes + d2.Minutes) * 60
                             + (d1.Seconds + d2.Seconds);

            return new Duration(totalSeconds);
        }

        //D3=D1 + 7800
        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + seconds; 

            return new Duration(totalSeconds);
        }

        // D3=666+D3
        public static Duration operator +(int seconds, Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + seconds;

            return new Duration(totalSeconds);
        }

        //D3= ++D1(Increase One Minute)
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + 60;

            return new Duration(totalSeconds);
        }

        //D3 = --D2(Decrease One Minute)
        public static Duration operator --(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) - 60;

            return new Duration(totalSeconds);
        }

        //D1= D1 -D2
        public static Duration operator -(Duration d1, Duration d2)
        {
            int d1Seconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int d2Seconds = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            int totalSeconds = Math.Abs(d1Seconds - d2Seconds);

            return new Duration(totalSeconds);
        }

        //If(D1>D2)
        public static bool operator >(Duration D1, Duration D2)
        {
            int D1_Seconds = (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds);
            int D2_Seconds = (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
            return D1_Seconds > D2_Seconds;
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            int D1_Seconds = (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds);
            int D2_Seconds = (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
            return D1_Seconds < D2_Seconds;
        }


        //If(D1<=D2)
        public static bool operator <=(Duration D1, Duration D2)
        {
            int D1_Seconds = (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds);
            int D2_Seconds = (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
            return D1_Seconds <= D2_Seconds;
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            int D1_Seconds = (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds);
            int D2_Seconds = (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
            return D1_Seconds >= D2_Seconds;
        }

        //If(D1) 
        //iam assuming that If(D1) checks the duration has values and not zeros 
        public static bool operator true(Duration d)
        {
            if (d is null) return false;
            return (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) != 0;
        }

        public static bool operator false(Duration d)
        {
            if (d is null) return true;
            return (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) == 0;
        }
        //DateTime Obj = (DateTime)D1
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, 0, 0, 0).AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }
        #endregion


    }
}
