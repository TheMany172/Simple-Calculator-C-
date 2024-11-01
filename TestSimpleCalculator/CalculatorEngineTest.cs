using System;
using NUnit.Framework;
using SimpleCalculator;

namespace TestSimpleCalculator
{
    [TestFixture]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        
        [Test]
        public void addsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate(number, "+", number2);
            int expectedResult = 3;
            
            Assert.AreEqual(expectedResult, result);
        }
        
    }
}