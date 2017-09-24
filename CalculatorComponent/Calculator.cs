using System;

namespace CalculatorComponent
{
    public class Calculator
    {
       /// <summary>
       /// Adds to integers
       /// </summary>
       /// <param name="a">first number</param>
       /// <param name="b">second number</param>
       /// <returns>The sum of the two numbers</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides two integers
        /// </summary>
        /// <param name="a">Numerator</param>
        /// <param name="b">Denominator</param>
        /// <returns>numerator / denomerator</returns>
        /// <exception cref="DivideByZeroException">if denominator is 0</exception>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides two doubles
        /// </summary>
        /// <param name="a">Numerator</param>
        /// <param name="b">Denominator</param>
        /// <returns>numerator / denomerator</br>
        /// Double.Infinity if denumerator is 0.0
        /// </returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}