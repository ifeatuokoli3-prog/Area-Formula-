using System;

namespace GeometryMethods
{
    // This class contains one method for each area formula.
    public static class AreaCalculator
    {
        // Area of a circle = π * r²
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Area of a triangle = ½ * base * height
        public static double AreaOfTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Area of a square = l²
        public static double AreaOfSquare(double length)
        {
            return length * length;
        }

        // Area of a rectangle = l * b
        public static double AreaOfRectangle(double length, double breadth)
        {
            return length * breadth;
        }
    }
}
