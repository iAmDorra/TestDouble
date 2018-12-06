using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace TestDouble.Test.NSubstitute
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Should_throw_an_exception_when_Divide_by_zero()
        {
            bool accessAuthorized = true;
            IAuthorizer allowAccessAuthorizer = Substitute.For<IAuthorizer>();
            allowAccessAuthorizer.Authorize().Returns(accessAuthorized);
            Calculator calculator = new Calculator(allowAccessAuthorizer);
            int denominator = 0;
            int numerator = 3;
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                calculator.Divide(numerator, denominator);
            });
        }

        [TestMethod]
        public void Should_Divide_a_numerator_by_a_denominator_different_of_zero_when_authorization_is_accepted()
        {
            bool accessAuthorized = true;
            IAuthorizer allowAccessAuthorizer = Substitute.For<IAuthorizer>();
            allowAccessAuthorizer.Authorize().Returns(accessAuthorized);
            Calculator calculator = new Calculator(allowAccessAuthorizer);
            int numerator = 4;
            int denominator = 2;

            var result = calculator.Divide(numerator, denominator);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Should_throw_an_exception_when_unauthorized_Division()
        {
            const bool accessUnauthorized = false;
            IAuthorizer denyAccessAuthorizer = Substitute.For<IAuthorizer>();
            denyAccessAuthorizer.Authorize().Returns(accessUnauthorized);
            Calculator calculator = new Calculator(denyAccessAuthorizer);
            int numerator = 4;
            int denominator = 2;
            Assert.ThrowsException<UnauthorizedAccessException>(() =>
            {
                calculator.Divide(numerator, denominator);
            });
        }
    }
}
