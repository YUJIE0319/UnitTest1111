using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1111
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator _calculator = new Calculator();

        [TestMethod]
        public void Add_positive_integer()
        {
            SumShouldBe(1, 2, 3);
        }

        private void SumShouldBe(int first, int second, int expected)
        {
            Assert.AreEqual(expected, _calculator.Add(first, second));
        }
    }

    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
