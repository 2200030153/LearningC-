using System;

namespace LearningCSharp
{
    public class ArrayOperations
    {
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Array elements:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }

        public static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        public static void SortArray(int[] array)
        {
            Array.Sort(array);
        }
    }
}
