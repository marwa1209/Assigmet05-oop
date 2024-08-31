using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmet05_oop.Second_Project
{
    internal class Maths
    {
        // Add method
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Subtract method
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiply method
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divide method
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
