using System;

namespace TrianglesApp
{

    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Side A: {0}, Side B: {1}, Side C: {2}", lenghtSideA, lenghtSideB, lenghtSideC);
            Console.ReadLine();
        }

    }
}