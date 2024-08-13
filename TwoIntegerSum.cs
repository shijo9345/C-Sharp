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
            bool val =true;

            for (int i = 0;i < n-1; i++)
            {
             
                for (int j = i+1;j < n; j++)
                {
                    if (size[i] + size[j] == target  )
                    {
                        val = false;
                        Console.WriteLine("[" + i+ "," + j +"]");
                    }
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
