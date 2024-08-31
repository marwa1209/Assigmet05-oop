
using Assigmet05_oop.First_Project;
using Assigmet05_oop.Second_Project;
using Assigmet05_oop.Third_Project;
using System.Drawing;
using System.Reflection;

namespace Assigmet05_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            _3dPoint[] Points =
    {
                        new _3dPoint(),
                        new _3dPoint()
                    };

            #region Read Poits From a array

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Coordinates for P{i + 1} ");
                Console.Write("Enter X:");
                Points[i].X = int.Parse(Console.ReadLine());
                Console.Write("Enter Y:");
                Points[i].Y = Convert.ToInt32(Console.ReadLine());
                int z;
                do
                {
                    Console.Write("Enter Z:");

                } while (!int.TryParse(Console.ReadLine(), out z));
                Points[i].Z = z;

            }

            #endregion
            if (Points[0] == Points[1])
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("ot equals");
            }
            for (int i = 0; i < Points.Length; i++)
            {
                Console.WriteLine(Points[i]);
            }
            Array.Sort(Points);

            Console.WriteLine("Sorted Points:");
            foreach (var point in Points)
            {
                Console.WriteLine(point.ToString());
            }
            _3dPoint P1 = ReadPoint("P1");
            _3dPoint P2 = ReadPoint("P2");
            _3dPoint P3 = (_3dPoint)P1.Clone();
            Console.WriteLine($"Cloned Point: {P3.ToString()}");
            #endregion
            #region Q2

            // Add method
            int sum = Maths.Add(10, 5);
            Console.WriteLine($"Add: 10 + 5 = {sum}");

            //  Subtract method
            int difference = Maths.Subtract(10, 5);
            Console.WriteLine($"Subtract: 10 - 5 = {difference}");

            //   Multiply method
            int product = Maths.Multiply(10, 5);
            Console.WriteLine($"Multiply: 10 * 5 = {product}");

            // Divide method

            int quotient = Maths.Divide(10, 5);
            Console.WriteLine($"Divide: 10 / 5 = {quotient}");
            #endregion

            #region Q3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Console.WriteLine("*******operators overloadig*********");
            //operators overloadig
            //●	D3=D1+D2
            Console.Write("D1 + D2 = ");
            Duration D03 = D1 + D2;
            Console.WriteLine(D03.ToString());
            //●	D3=D1 + 7800
            Console.Write("D1 + 7800 = ");
            Duration D003 = D1 + 7800;
            Console.WriteLine(D003.ToString());
            //●	D3 = 666 + D3
            Console.Write("666 + D2 = ");
            Duration D0003 = 666 + D2;
            Console.WriteLine(D0003.ToString());
            //●	D3= ++D1 (Increase One Minute)
            Console.Write("++D1 = ");
            Duration D4 = ++D1;
            Console.WriteLine(D4.ToString());
            //●	D3= --D1 (Decrease  One Minute)
            Console.Write("--D2 = ");
            Duration D04 = --D1;
            Console.WriteLine(D04.ToString());
            //●	D5= D1 -D2
            Console.Write("D1 -D2 = ");
            Duration D5 = D1 - D2;
            Console.WriteLine(D5.ToString());
            //●	If (D1>D2)
            Console.Write("If (D1>D2)?=>");
            Console.WriteLine(D1 > D2);
            //●	If (D1<=D2)
            Console.Write("If (D1<=D2)?=>");
            Console.WriteLine(D1 <= D2);
            #endregion
        }

        #region Q1Methods
        static _3dPoint ReadPoint(string pointName)
        {
            int x, y, z;
            Console.WriteLine($"Enter the coordinates for {pointName}:");

            x = ReadCoordinate("X");
            y = ReadCoordinate("Y");
            z = ReadCoordinate("Z");

            return new _3dPoint(x, y, z);
        }
        static int ReadCoordinate(string coordinateName)
        {
            int coordinate;
            bool isValid;

            do
            {
                Console.Write($"{coordinateName}: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out coordinate);
                if (!isValid)
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            } while (!isValid);

            return coordinate;
        }
        #endregion
    }
}
