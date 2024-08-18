using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the target:");
            int k = int.Parse(Console.ReadLine());
            int[] arr = { 3, 4, 7, 2, -3, 1, 4, 2 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

    }
}
