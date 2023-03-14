using System;
using System.Data;
using System.Reflection.Metadata;

namespace TrianglesApp
{

    class TrianglesApp
    {
        static void Main(string[] args)
        {
            bool restart = true;
            while (restart)
            {

                try
                {

                    Console.Write("Enter coordinate x of dot A: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter coordinate y of dot A: ");
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter coordinate x of dot B: ");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter coordinate y of dot B: ");
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter coordinate x of dot C: ");
                    double x3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter coordinate y of dot C: ");
                    double y3 = Convert.ToDouble(Console.ReadLine());

                    double lenghtSideA = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
                    double lenghtSideB = Math.Round(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 2);
                    double lenghtSideC = Math.Round(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)), 2);

                    if (lenghtSideA <= 0 || lenghtSideB <= 0 || lenghtSideC <= 0)
                    {
                        throw new Exception("Triangle sides cannot be negative nor zero.");
                    }

                    double delta = 1.0;
                    bool triangleIsRight = Math.Abs(Math.Pow(lenghtSideC, 2) - (Math.Pow(lenghtSideA, 2) + Math.Pow(lenghtSideB, 2))) <= delta ||
                                           Math.Abs(Math.Pow(lenghtSideA, 2) - (Math.Pow(lenghtSideB, 2) + Math.Pow(lenghtSideC, 2))) <= delta ||
                                           Math.Abs(Math.Pow(lenghtSideB, 2) - (Math.Pow(lenghtSideC, 2) + Math.Pow(lenghtSideA, 2))) <= delta;

                    Console.WriteLine("Lenght of AB: {0}, Lenght of BC: {1}, Lenght of AC: {2}", lenghtSideA, lenghtSideB, lenghtSideC);

                    if (lenghtSideA == lenghtSideB && lenghtSideB == lenghtSideC)
                    {
                        Console.WriteLine("Triangle IS Equilateral.");
                    }
                    else
                    {
                        Console.WriteLine("Triangle is NOT Equilateral.");
                    }

                    if (lenghtSideA == lenghtSideB || lenghtSideB == lenghtSideC || lenghtSideC == lenghtSideA)
                    {
                        Console.WriteLine("Triangle IS isosceles.");
                    }
                    else
                    {
                        Console.WriteLine("Triangle is NOT isosceles.");
                    }

                    if (triangleIsRight)
                    {
                        Console.WriteLine("Triangle IS a right triangle.");
                    }
                    else
                    {
                        Console.WriteLine("Triangle is NOT a right triangle.");
                    }
                  ;

                    Console.WriteLine("Perimeter: {0}", CalculatePerimeter(lenghtSideA, lenghtSideB, lenghtSideC));

                    Console.WriteLine("Parity numbers in range from 0 to triangle perimeter: ");
                    for (int i = 0; i <= CalculatePerimeter(lenghtSideA, lenghtSideB, lenghtSideC); i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error ocurred: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to try again? (Y/N)");
                    string restartAnswer = Console.ReadLine().ToUpper();

                    if (restartAnswer == "N") { restart = false;}
                }
            }

            static double CalculatePerimeter(double lenghtSideA, double lenghtSideB, double lenghtSideC)
            {
                double perimeter = Math.Round(lenghtSideA + lenghtSideB + lenghtSideC, 2);
                return perimeter;
            }
        }

    }
}