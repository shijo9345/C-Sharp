using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array elements to Store:");
            int n = int.Parse(Console.ReadLine());
            int[] size = new int[n];
            for (int i = 0; i < n; i++)
            {
                size[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Target:");
            int target = int.Parse(Console.ReadLine());
            bool val = true;

            int start = 0;
            int end = n - 1;
            for (int i = start; i < end; i++)
            {
                int sum = size[start] + size[end];
                if (sum == target)
                {
                    Console.WriteLine(start + "," + end);
                    break;
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            if (val == true)
            {
                Console.WriteLine("Invalid Target");
            }
            Console.ReadLine();
        }
    }
}
