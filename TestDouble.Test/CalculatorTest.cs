using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDouble.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Should_throw_an_exception_when_Divide_by_zero()
        {
            IAuthorizer authorizer = new AcceptingAuthorizer();
            Calculator calculator = new Calculator(authorizer);
            int numerator = 3;
            int denominator = 0;
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                calculator.Divide(numerator, denominator);
            });
        }

        [TestMethod]
        public void Should_Divide_a_numerator_by_a_denominator_different_of_zero_when_authorization_is_accepted()
        {
            IAuthorizer authorizer = new AcceptingAuthorizer();
            Calculator calculator = new Calculator(authorizer);
            int numerator = 4;
            int denominator = 2;

            var result = calculator.Divide(numerator, denominator);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Should_throw_an_exception_when_unauthorized_Division()
        {
            IAuthorizer authorizer = new RefusingAuthorizer();
            Calculator calculator = new Calculator(authorizer);
            int numerator = 3;
            int denominator = 0;
            Assert.ThrowsException<UnauthorizedAccessException>(() =>
            {
                calculator.Divide(numerator, denominator);
            });
        }
    }
}
