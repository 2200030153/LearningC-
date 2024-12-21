using System;

class QuickSortExample
{
    static void Main(string[] args)
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original array:");
        PrintArray(array);

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; 
        int i = low - 1; 

        for (int j = low; j < high; j++)
        {
            
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        
        Swap(array, i + 1, high);

        return i + 1;
    }

    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
