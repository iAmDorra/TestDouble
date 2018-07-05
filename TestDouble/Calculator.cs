using System;

namespace TestDouble
{
    public class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new InvalidOperationException("Can't divide by zero !");
            }

            double result = (double)numerator / (double)denominator;
            return result;
        }
    }
}
