using System;
using System.Security.Cryptography;

namespace SimpleCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.convertInputToNumber(Console.ReadLine());
                string operation = Console.ReadLine();
                double secondNumber = inputConverter.convertInputToNumber(Console.ReadLine());

                double result = calculatorEngine.Calculate(firstNumber, operation, secondNumber);

                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                // We realistically would want to log this message
                Console.WriteLine(ex.Message);
            }
        }
    }
}