// GPT made this one in a few seconds

using System;
using System.Security.Cryptography;

namespace SimpleCalculator
{
    internal class Program2
    {
        // changed to Main2 so it doesn't conflict
        public static void Main2(string[] args)
     git    {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            while (true)
            {
                try
                {
                    // Input first number
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Input operator
                    Console.Write("Enter an operator (+, -, *, /): ");
                    char op = Console.ReadLine()[0];

                    // Input second number
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // Calculate result
                    double result = 0;

                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                                result = num1 / num2;
                            else
                                Console.WriteLine("Cannot divide by zero.");
                            break;
                        default:
                            Console.WriteLine("Invalid operator.");
                            continue;
                    }

                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter numeric values.");
                }

                // Prompt to continue or exit
                Console.Write("Do you want to perform another calculation? (y/n): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                    break;
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}