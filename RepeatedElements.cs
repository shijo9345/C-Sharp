using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements of array to store:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the Values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int visited = int.Minvalue; 
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] != visited)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            Console.Write(arr[i] + " "); 
                            arr[j] = visited;
                            break; 
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
