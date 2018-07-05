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
            Calculator calculator = new Calculator();
            int numerator = 3;
            int denominator = 0;
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                calculator.Divide(numerator, denominator);
            });
        }
    }
}
