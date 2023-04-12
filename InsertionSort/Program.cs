using System;

class InsertionSort
{
    static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
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
