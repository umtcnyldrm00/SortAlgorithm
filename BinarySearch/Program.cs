using System;

class BinarySearch
{
    static int Search(int[] arr, int left, int right, int x)
    {
        if (right >= left)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] > x)
                return Search(arr, left, mid - 1, x);

            return Search(arr, mid + 1, right, x);
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;
        int x = 10;

        int result = Search(arr, 0, n - 1, x);

        if (result == -1)
            Console.WriteLine("Element not present in array");
        else
            Console.WriteLine("Element found at index " + result);
    }
}