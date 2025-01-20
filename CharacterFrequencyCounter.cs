using System;
using System.Collections.Generic;

class CharacterFrequencyCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to count the frequency of each character:");

        // Get the input string from the user
        string input = Console.ReadLine();

        // Call the function to count character frequencies
        Dictionary<char, int> frequency = CountCharacterFrequency(input);

        // Output the result
        Console.WriteLine("Character Frequencies:");
        foreach (var entry in frequency)
        {
            Console.WriteLine($"'{entry.Key}': {entry.Value}");
        }
    }

    // Function to count the frequency of each character in a string
    static Dictionary<char, int> CountCharacterFrequency(string input)
    {
        var frequency = new Dictionary<char, int>();

        foreach (var c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }

        return frequency;
    }
}
