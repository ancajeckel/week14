using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorAppTests;


namespace CalculatorAppUnitTests
{
    [TestFixture]
    public class CalculatorAppUnitTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            // se apeleaza cand se termina de rulat un test
        }

        [Test]
        public void AddTest()
        {
            //arrange
            var input1 = 2;
            var input2 = 3;
            var expected = 5;

            //act
            var actual = calc.Add(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(11.5, 4.5, ExpectedResult = 16)]
        [TestCase(-2, 3, ExpectedResult = 1)]
        [TestCase(2.45, 30000, ExpectedResult = 30002.45)]
        public decimal AddTestCase(decimal input1, decimal input2)
        {
            return calc.Add(input1, input2);
        }

        [TestCase(2, 3, ExpectedResult = -1)]
        [TestCase(11.5, 4.5, ExpectedResult = 7)]
        [TestCase(-2, 3, ExpectedResult = -5)]
        [TestCase(30000, 2.45, ExpectedResult = 29997.55)]
        public decimal SubtractTestCase(decimal input1, decimal input2)
        {
            return calc.Subtract(input1, input2);
        }

        [TestCase(2, 3, ExpectedResult = 6)]
        [TestCase(11.5, 4.5, ExpectedResult = 51.75)]
        [TestCase(-2, 3, ExpectedResult = -6)]
        [TestCase(0.01, 4, ExpectedResult = 0.04)]
        public decimal MultiplyTestCase(decimal input1, decimal input2)
        {
            return calc.Multiply(input1, input2);
        }

        [TestCase(6, 3, ExpectedResult = 2)]
        [TestCase(11.5, 5, ExpectedResult = 2.3)]
        [TestCase(-2, 4, ExpectedResult = -0.5)]
        [TestCase(1, 100, ExpectedResult = 0.01)]
        public decimal DivideTestCase(decimal input1, decimal input2)
        {
            return calc.Divide(input1, input2);
        }

        [Test]
        public void DivideTestDivideByZeroException()
        {
            decimal input1 = 5;
            decimal input2 = 0;
            Assert.Throws<DivideByZeroException>(() => calc.Divide(input1, input2));
        }
    }
}
