using System;

class SimpleCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Calculator!");

        while (true)
        {
            Console.WriteLine("\nEnter the first number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Choose an operation (+, -, *, /):");
            string operation = Console.ReadLine();

            double result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter one of +, -, *, /.");
                    break;
            }

            Console.WriteLine("\nDo you want to perform another calculation? (yes/no):");
            string continueResponse = Console.ReadLine().ToLower();
            if (continueResponse != "yes" && continueResponse != "y")
            {
                Console.WriteLine("Thank you for using the calculator. Goodbye!");
                break;
            }
        }
    }
}
