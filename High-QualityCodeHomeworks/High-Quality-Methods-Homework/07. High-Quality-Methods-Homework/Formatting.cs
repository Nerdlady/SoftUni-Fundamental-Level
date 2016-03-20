namespace Methods
{
    using System;

    /// <summary>
    ///   The formatting class.
    /// </summary>
    public static class Formatting
    {
        /// <summary>
        ///   Print a digit as word.
        /// </summary>
        /// <param name="digit">Digit.</param>
        /// <returns>Digit as word.</returns>
        public static string PrintDigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return "Invalid number!";
        }

        /// <summary>
        ///   Formats a number according to the provided input string.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="format">The string.</param>
        /// <returns>Formatted string.</returns>
        public static string FormatNmber(object number, string format)
        {
            string formatString = format.ToLower();
            switch (formatString)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "r":
                    return string.Format("{0,8}", number);
            }

            throw new ArgumentException("Wrong format string");
        }
    }
}