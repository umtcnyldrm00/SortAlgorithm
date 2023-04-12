using System;

class SelectionSort
{
    static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                    min_idx = j;
            }

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Array before sorting:");
        for (int i = 0; i < arr.Length; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        Sort(arr);

        Console.WriteLine("Array after sorting:");
        for (int i = 0; i < arr.Length; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}