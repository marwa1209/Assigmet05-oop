using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmet05_oop.Third_Project
{
    internal class Duration
    {
        #region properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }
        #endregion
        #region Methods

        // ToString Override
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
        }

        // Equals Override
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration d = (Duration)obj; //unsafe casting
            return Hours.Equals(d.Hours)&& Minutes.Equals(d.Minutes)&&Seconds.Equals(d.Seconds);
        }

        // GetHashCode Override
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        #endregion
        #region operators overloadig
        // Addition of two Duration objects
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        // Addition of Duration and an integer representing seconds
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(seconds + d.Hours * 3600 + d.Minutes * 60 + d.Seconds);
        }
        // Increment (adds one minute)
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        // Decrement (subtracts one minute)
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        // Subtraction of two Duration objects
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }

        // Greater than operator
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        // Less than operator
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        // Less than or equal operator
        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        // greater than or equal operator
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        #endregion
    }
}
