using System;

class NumberGuessing
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Random random = new Random();
        int targetNumber = random.Next(1, 101); // Random number between 1 and 100
        int attempts = 0;
        bool isCorrect = false;

        Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

        while (!isCorrect)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                attempts++;
                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
