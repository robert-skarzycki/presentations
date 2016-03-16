using NUnit.Framework;
using skarzycki.robert.unittests._01CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarzycki.robert.unittests._01CalcLibraryNUnit
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void SUM_should_add_two_numbers()
        {
            //Arrange
            var calculator = new Calculator();
            const int x = 1;
            const int y = 2;
            const int expected = 3;

            //Act
            var result = calculator.Sum(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
