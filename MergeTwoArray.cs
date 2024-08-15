using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 3, 5, 7 };
        int[] array2 = { 2, 4, 6, 8 };

        // Call the Merge function
        int[] mergedArray = MergeSortedArrays(array1, array2);

        // Print the merged array
        Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
        Console.Readline();
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int[] mergedArray = new int[2 * n];

        int i = 0; // Pointer for arr1
        int j = 0; // Pointer for arr2
        int k = 0; // Pointer for mergedArray

        // Use a single loop to merge both arrays
        for (k = 0; k < 2 * n; k++)
        {
            if (i < n && (j >= n || arr1[i] <= arr2[j]))
            {
                mergedArray[k] = arr1[i++];
            }
            else
            {
                mergedArray[k] = arr2[j++];
            }
        }

        return mergedArray;
    }
}
