using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace skarzycki.robert.unittests._01CalcLibraryVSTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void test1()
        {
            _01CalcLibrary.Calculator calculator = null; //new _01CalcLibrary.Calculator();
            var x = 10;
            var y = 11;
            var expected = x + y;
            
            // ---

            var result = calculator.Sum(x, y);
     
        }

        [TestMethod]
        public void test2()
        {
            var calculator = new _01CalcLibrary.Calculator();
            var x = -1;
            var y = 11;
            var expected = x + y;

            // ---

            var result = calculator.Sum(x, y);

            // ----

            Assert.AreEqual(expected, result);
        }
    }
}
