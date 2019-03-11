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
    }
}
