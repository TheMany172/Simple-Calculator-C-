using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double convertInputToNumber(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Invalid inputExpected a numeric value.");
            return convertedNumber;
        }
    }
}