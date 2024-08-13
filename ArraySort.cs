using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Project4

{
    internal class Prg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements:");
            int n = int.Parse(Console.ReadLine());
            int[] size = new int[n];
            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < n; i++)
            {
                size[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", size));
            Console.ReadLine();

            for (int i = 0; i < n - 1; i++)
            {
            
                for (int j = i+1; j < n; j++)
                {
                    if (size[i] > size[j])
                    {
                        int temp = size[i];
                        size[i] = size[j ];
                        size[j] = temp;
                    }
                }

            }
            foreach (int x in size)
            {
                Console.Write(x +", ");
            }
           
            Console.ReadLine();
        }
    }
}