using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 3)
        {
            Console.WriteLine("The array must contain at least 3 elements.");
            return;
        }

        
        int[] nums = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);

        int max1 = nums[n - 1] * nums[n - 2] * nums[n - 3];

     
        int max2 = nums[0] * nums[1] * nums[n - 1];

        
        int maxProduct = Math.Max(max1, max2);


        Console.WriteLine("The maximum product of three numbers in the array is: " + maxProduct);
    }
}