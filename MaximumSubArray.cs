
using System;

namespace c__training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements to store in the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements in the array are: [" + string.Join(", ", numbers) + "]");

            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;

            for (int i = 0; i < size; i++)
            {
                int currentSum = 0;
                for (int j = i; j < size; j++)
                {
                    currentSum += numbers[j];// a=a+b

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        start = i;
                        end = j;
                    }
                }
            }

            Console.WriteLine($"Maximum subarray sum: {maxSum}");
            Console.Write("Maximum subarray: [");
            for (int i = start; i <= end; i++)
            {
                Console.Write(numbers[i]);
                if (i < end)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();
        }
    }
}

