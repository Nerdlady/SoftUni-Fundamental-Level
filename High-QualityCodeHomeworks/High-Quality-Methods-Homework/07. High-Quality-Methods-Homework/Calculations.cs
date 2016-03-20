namespace Methods
{
    using System;

    /// <summary>
    ///   The calculations class.
    /// </summary>
    public static class Calculations
    {
        /// <summary>
        ///   Calculate area of triangle.
        /// </summary>
        /// <param name="a">Side a of the triangle. </param>
        /// <param name="b">Side b of the triangle.</param>
        /// <param name="c">Side c of the triangle.</param>
        /// <returns>Triangle area.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Sides should be positive number.</exception>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive number.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        ///   Find max number in array.
        /// </summary>
        /// <param name="elements">The array of numbers.</param>
        /// <returns>Max number.</returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Array cannot be empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        /// <summary>
        ///   Calculates the distance between two ponts.
        /// </summary>
        /// <param name="x1">The x coordinate of the first point.</param>
        /// <param name="y1">The y coordinate of the first point.</param>
        /// <param name="x2">The x coordinate of the second point.</param>
        /// <param name="y2">The y coordinate of the second point.</param>
        /// <returns>Distance.</returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        ///   Checks if the line crossing the two given points is vertical.
        /// </summary>
        /// <param name="x1"> The x coordinate of the first point. </param>
        /// <param name="x2"> The x coordinate of the second point. </param>
        /// <returns> True or false. </returns>
        public static bool IsVerticalLine(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }

        /// <summary>
        ///   Checks if the line crossing the two given points is horizontal.
        /// </summary>
        /// <param name="x1"> The x coordinate of the first point. </param>
        /// <param name="x2"> The x coordinate of the second point. </param>
        /// <returns> True or false. </returns>
        public static bool IsHorizontalLine(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }
    }
}