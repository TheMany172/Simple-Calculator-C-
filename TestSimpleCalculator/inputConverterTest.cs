using System;
using NUnit.Framework;
using SimpleCalculator;

namespace TestSimpleCalculator
{
    [TestFixture]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [Test]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.convertInputToNumber(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [Test]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            Assert.Throws<ArgumentException>(() => _inputConverter.convertInputToNumber(inputNumber));
        }
    }
}