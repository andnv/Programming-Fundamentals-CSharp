namespace _03._Longer_Line
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());

            double firstLine = CalculateLine(firstX1, firstY1, firstX2, firstY2);
            double secondLine = CalculateLine(secondX1, secondY1, secondX2, secondY2);

            if (firstLine >= secondLine)
            {
                ClosestToZero(firstX1, firstY1, firstX2, firstY2);
            }
            else
            {
                ClosestToZero(secondX1, secondY1, secondX2, secondY2);
            }
        }

        static void ClosestToZero(double x1, double y1, double x2, double y2)
        {

            if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        static double CalculateLine(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }
    }
}
