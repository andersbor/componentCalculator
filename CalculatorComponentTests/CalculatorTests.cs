using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorComponent.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private static readonly double Delta = 0.000001;

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(9, Calculator.Add(4, 5));
            Assert.AreEqual(9.0, Calculator.Add(4.0, 5.0), Delta);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(2, Calculator.Subtract(7, 5));
            Assert.AreEqual(2.1, Calculator.Subtract(7.1, 5.0), Delta);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(10, Calculator.Multiply(2, 5));
            Assert.AreEqual(4.2, Calculator.Multiply(2.1, 2.0), Delta);
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(3, Calculator.Divide(7, 2));
            try
            {
                Calculator.Divide(7, 0);
                Assert.Fail();
            }
            catch (DivideByZeroException) { }

            Assert.AreEqual(3.5, Calculator.Divide(7.0, 2.0), Delta);
            Assert.AreEqual(double.PositiveInfinity, Calculator.Divide(4.0, 0.0));
        }
    }
}