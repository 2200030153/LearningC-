using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Palindrome Checker!");

        while (true)
        {
            Console.Write("\nEnter a number to check if it's a palindrome: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }

            Console.Write("\nDo you want to check another number? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes" && response != "y")
            {
                Console.WriteLine("Thank you for using the Palindrome Checker. Goodbye!");
                break;
            }
        }
    }

    static bool IsPalindrome(string number)
    {
        int length = number.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (number[i] != number[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
