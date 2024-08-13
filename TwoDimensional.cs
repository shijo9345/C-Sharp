using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Jan", "Feb", "Mar" };
            int[,] array = new int[3,3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Sales for SalesMan - {i+1}");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Enter Sales for {months [j]}:");
                    array[i,j]= int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($" SalesMan - {i + 1} \t");
                int total = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} \t ");
                    total += array[i, j];
                }
                Console.WriteLine( total);
            }
            Console.ReadLine();
        }
    }
}
