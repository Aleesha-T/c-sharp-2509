using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CsharpAssignmentsPart8
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WithValidInputs_ReturnsCorrectSum()
        {
            int result = _calculator.Add(3, 8);
            ClassicAssert.AreEqual(11, result);
        }
        //Test for addition.
        [Test]
        public void Divide_WithValidInputs_ReturnsCorrectQuotient()
        {
            int result = _calculator.Divide(6, 3);
            ClassicAssert.AreEqual(2, result);
        }
        //Test for division.
        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(3, 0));
        }
        //Test for division by zero.
    }
}
