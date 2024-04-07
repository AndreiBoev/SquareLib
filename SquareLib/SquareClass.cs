using System;

namespace SquareLib
{
    /// <summary>
    /// Class for calculating the square of various shapes.
    /// </summary>
    public class SquareClass
    {
        /// <summary>
        /// Calculating the square of a circle using the radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>The square of the circle.</returns>
        /// <exception cref="ArgumentException">If the radius is less than zero.</exception>
        public double CalculateCircle(double radius)
        {
            if(radius < 0)
                throw new ArgumentException("The radius must be greater than zero.");

            double res = Math.PI * Math.Pow(radius, 2);
            return res;
        }
        /// <summary>
        /// Сalculating the square of a triangle using the sides.
        /// </summary>
        /// <param name="a">The first side.</param>
        /// <param name="b">The second side.</param>
        /// <param name="c">The third side.</param>
        /// <returns>The square of the triangle.</returns>
        /// <exception cref="ArgumentException">If any side is less than or equal to zero.</exception>
        public double CalculateTriangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be greater than zero.");
            if ((a + b > c) && (a + c > b) && (b + c > a))
                throw new ArgumentException("There is no triangle with such sides.");
            double res;
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);
            if(sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
            {
                res = 0.5 * sides[0] * sides[1];
                return res;
            }

            double p = (a + b + c) / 2;
            res = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return res;
        }
        /// <summary>
        /// Calculating the square of a circle or triangle.
        /// </summary>
        /// <param name="sides">An array of shape parameters.</param>
        /// <returns>The square of the shape.</returns>
        /// <exception cref="ArgumentException">If there are more than 3 sides or some side is greater than zero.</exception>
        public double СalculateShape(double[] sides)
        {
            foreach(double side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("All sides must be greater than zero.");
            }

            if (sides.Length == 1) // circle
            {
                double radius = sides[0];
                return Math.PI * radius * radius;
            }
            else if (sides.Length == 3) // triangle
            {
                double a = sides[0];
                double b = sides[1];
                double c = sides[2];
                if ((a + b > c) && (a + c > b) && (b + c > a))
                    throw new ArgumentException("There is no triangle with such sides.");
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
            else
            {
                throw new ArgumentException("Unsupported shape.");
            }
        }
    }
}
