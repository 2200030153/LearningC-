using System;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock-Paper-Scissors!");
        string[] options = { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // User input
            Console.WriteLine("\nChoose: Rock, Paper, or Scissors");
            Console.Write("Your choice: ");
            string userChoice = Console.ReadLine()?.Trim();

            if (!Array.Exists(options, option => option.Equals(userChoice, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Invalid choice! Please try again.");
                continue;
            }

            // Computer's choice
            string computerChoice = options[random.Next(0, options.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            // Determine the winner
            if (userChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||
                     (userChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock") ||
                     (userChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            // Ask if the player wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine()?.Trim().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }
}
