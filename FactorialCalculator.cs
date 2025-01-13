using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Factorial Calculator!");

        while (true)
        {
            Console.Write("\nEnter a non-negative integer to calculate its factorial: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                continue;
            }

            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");

            Console.Write("\nDo you want to calculate another factorial? (yes/no): ");
            string response = Console.ReadLine()?.ToLower();
            if (response != "yes" && response != "y")
            {
                Console.WriteLine("Thank you for using the Factorial Calculator. Goodbye!");
                break;
            }
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * CalculateFactorial(n - 1);
    }
}
