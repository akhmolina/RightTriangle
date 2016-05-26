using System;

namespace RightTriangleShape
{
    public static class ShapeCalculator
    {
        public static double CalculateRightTriangleShape (double a, double b, double c)
        {
            if (a <= 0) { throw new ArgumentException("The a side is less then zero", "a"); }
            if (b <= 0) { throw new ArgumentException("The b side is less then zero", "b"); }
            if (c <= 0) { throw new ArgumentException("The c side is less then zero", "c"); }

            double hip = Math.Max(a, b);
            double cath1 = Math.Min(a, b);
            double cath2;

            if (hip == Math.Max(c, hip))
            { cath2 = c; }
            else
            { cath2 = hip;  hip = c; }

            if ( Math.Pow(hip,2) != Math.Pow(cath1, 2) + Math.Pow(cath2, 2))
            { throw new Exception("Triangle is not right"); }

            return cath1 * cath2;
        }

    }
}
