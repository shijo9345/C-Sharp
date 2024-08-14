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
            Console.WriteLine("Enter the Array elements to store:");
            int n = int.Parse(Console.ReadLine());
            int[] size = new int[n];
            for (int i = 0; i < n; i++)
            {
                size[i] = int.Parse(Console.ReadLine());
            }
            bool targets = true;
            var seenTriplets = new HashSet<string>();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (size[i] + size[j] + size[k] == 0)
                        {
                            int[] triplet = { size[i], size[j], size[k] };
                            Array.Sort(triplet);
                            // Convert triplet to a string for HashSet
                            string tripletKey = $"{triplet[0]},{triplet[1]},{triplet[2]}";

                            // Check if the triplet is already seen
                            if (!seenTriplets.Contains(tripletKey))
                            {
                                Console.WriteLine($"[{triplet[0]},{triplet[1]},{triplet[2]}]");

                                // Add the triplet to the HashSet
                                seenTriplets.Add(tripletKey);
                                targets = false;
                            }
                        }
                    }
                }
            }
            if (targets == true)
            {
                Console.WriteLine("Invalid Target");
            }
            Console.ReadLine();
        }
    }
}
