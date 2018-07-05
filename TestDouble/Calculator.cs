using System;

namespace TestDouble
{
    public class Calculator
    {
        private IAuthorizer authorizer;

        public Calculator(IAuthorizer authorizer)
        {
            this.authorizer = authorizer;
        }

        public double Divide(int numerator, int denominator)
        {
            if(!authorizer.Authorize())
            {
                throw new UnauthorizedAccessException();
            }

            if (denominator == 0)
            {
                throw new InvalidOperationException("Can't divide by zero !");
            }

            double result = (double)numerator / (double)denominator;
            return result;
        }
    }
}
