using System;

namespace LearningCSharp
{
    class TestArrayOperations
    {
        static void Main(string[] args)
        {
            // Initialize an array of integers
            int[] numbers = { 5, 3, 1, 4, 2 };

            // Print the original array
            ArrayOperations.PrintArray(numbers);

            // Calculate and print the sum of the array elements
            int sum = ArrayOperations.SumArray(numbers);
            Console.WriteLine("Sum of array elements: " + sum);

            // Reverse and print the array
            ArrayOperations.ReverseArray(numbers);
            Console.WriteLine("Reversed array:");
            ArrayOperations.PrintArray(numbers);

            // Sort and print the array
            ArrayOperations.SortArray(numbers);
            Console.WriteLine("Sorted array:");
            ArrayOperations.PrintArray(numbers);
        }
    }
}
