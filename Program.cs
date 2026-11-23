using System;

namespace GeometryMethods
{
    class Program
    {
        // Reads a number from the user and keeps asking until it is valid
        static double ReadNumber(string prompt)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Enter a number: ");
            }
            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== AREA CALCULATOR ===");

            double radius = ReadNumber("Circle radius: ");
            Console.WriteLine($"Area of circle: {AreaCalculator.AreaOfCircle(radius):F2}");

            double triBase = ReadNumber("Triangle base: ");
            double triHeight = ReadNumber("Triangle height: ");
            Console.WriteLine($"Area of triangle: {AreaCalculator.AreaOfTriangle(triBase, triHeight):F2}");

            double sqLength = ReadNumber("Square length: ");
            Console.WriteLine($"Area of square: {AreaCalculator.AreaOfSquare(sqLength):F2}");

            double rectLength = ReadNumber("Rectangle length: ");
            double rectBreadth = ReadNumber("Rectangle breadth: ");
            Console.WriteLine($"Area of rectangle: {AreaCalculator.AreaOfRectangle(rectLength, rectBreadth):F2}");

            Console.WriteLine("\n=== QUADRATIC FORMULA ===");
            double a = ReadNumber("Enter a: ");
            double b = ReadNumber("Enter b: ");
            double c = ReadNumber("Enter c: ");

            try
            {
                var result = QuadraticSolver.Solve(a, b, c);

                if (result.HasRealRoots)
                {
                    Console.WriteLine($"x1 = {result.Root1:F2}");
                    Console.WriteLine($"x2 = {result.Root2:F2}");
                }
                else
                {
                    Console.WriteLine("No real roots (discriminant is negative).");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
