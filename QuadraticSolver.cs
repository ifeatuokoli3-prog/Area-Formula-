using System;

namespace GeometryMethods
{
    // This class solves quadratic equations of the form ax² + bx + c = 0
    public static class QuadraticSolver
    {
        // Quadratic formula: x = (-b ± √(b² - 4ac)) / 2a
        // Returns whether real roots exist, and the two roots.
        public static (bool HasRealRoots, double Root1, double Root2) Solve(double a, double b, double c)
        {
            // 'a' cannot be 0, otherwise the equation is not quadratic
            if (a == 0)
            {
                throw new ArgumentException("'a' cannot be zero in a quadratic equation.");
            }

            // Discriminant = b² - 4ac
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            // A negative discriminant means there are no real roots
            if (discriminant < 0)
            {
                return (false, 0, 0);
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);

            return (true, root1, root2);
        }
    }
}
