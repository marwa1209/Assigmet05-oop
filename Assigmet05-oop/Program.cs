
using Assigmet05_oop.First_Project;
using System.Drawing;

namespace Assigmet05_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(Points[0]);
            Console.WriteLine(Points[1]);
            #endregion
            if (Points[0]== Points[1])
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("ot equals");
            }

        }
    }
}
